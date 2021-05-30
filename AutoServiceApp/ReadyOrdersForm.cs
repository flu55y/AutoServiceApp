using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class ReadyOrdersForm : Form
    {
        public ReadyOrdersForm()
        {
            InitializeComponent();

            //зеленый цвет для строк
            ordersDataGridView.DefaultCellStyle.BackColor = Color.LightGreen;
            ordersDataGridView.AutoGenerateColumns = false;
            LoadData();
        }

        private void LoadData()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                try
                {
                    //подключаемся к бд
                    connection.Open();

                    //создаем адаптер со строкой для поиска всех готовых заказов
                    var adapterOrders = new SqlDataAdapter("Select * from Orders where Status='Готов'", connection);

                    //создаем таблицу для заказов
                    var dataTable = new DataTable();

                    //через адаптер заполняем таблицу
                    adapterOrders.Fill(dataTable);


                    //создаем адаптер со строкой для поиска всех роботников
                    var adapterEmployees = new SqlDataAdapter("Select * from Employees", connection);

                    //создаем таблицу для роботников
                    var employeesTable = new DataTable();

                    //через адаптер заполняем таблицу
                    adapterEmployees.Fill(employeesTable);

                    //создаем коллекцию для строк роботников
                    var employees = new List<object[]>();

                    //добавляем в коллекцию все строки
                    foreach (DataRow row in employeesTable.Rows)
                    {
                        employees.Add(row.ItemArray);
                    }

                    //временная таблица
                    var tempDataTable = new DataTable();

                    //переносим схему таблицы заказов во временную таблицу
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        var tempColumn = new DataColumn(col.ColumnName, col.DataType);
                        tempDataTable.Columns.Add(tempColumn);
                    }

                    //указываем тип данных для столбца "сотрудник"
                    tempDataTable.Columns[1].DataType = typeof(String);


                    //заполняем временную таблицу
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var tempRow = tempDataTable.NewRow();

                        var items = row.ItemArray;

                        //получаем ID сотрудника
                        var employeeId = row[1];

                        //находим его
                        var employee = employees.First(e => e[0].ToString().Equals(employeeId.ToString()));

                        //заполняем соответствующий столбец именем сотрудника
                        items[1] = employee[2];

                        tempRow.ItemArray = items;

                        //добавляем заполненную строку во временную таблицу
                        tempDataTable.Rows.Add(tempRow);
                    }

                    //назначаем временную таблицу в DataSource нашего ordersDataGridView
                    ordersDataGridView.DataSource = tempDataTable.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Обработка нажатия на кнопку просмотр
        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    int orderId = (int)ordersDataGridView.Rows[e.RowIndex].Cells[0].Value;
                    OrderServiceForm orderServiceForm = new OrderServiceForm(orderId);
                    orderServiceForm.Owner = this;
                    orderServiceForm.ShowDialog();
                    LoadData();
                }
            }
        }
    }
}
