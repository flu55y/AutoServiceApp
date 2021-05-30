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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            dtgrdClients.AutoGenerateColumns = false;
            ordersDataGridView.AutoGenerateColumns = false;
        }

        private void searchClientsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
                {
                    //подключаемся к бд
                    connection.Open();

                    var adapter = new SqlDataAdapter("Select * from Owners", connection);
                    var dataTable = new DataTable();

                    //заполянем таблицу всеми клиентами
                    adapter.Fill(dataTable);

                    string sortString, filterString;

                    //сортировка
                    sortString = "FIO DESC";

                    //строка фильтрации
                    filterString = GetClientFilterString();

                    //выбираем клиентов в соответствии с заданными фильтром и сортировкой
                    DataRow[] rows = dataTable.Select(filterString, sortString);

                    //временная таблица
                    var tempDataTable = new DataTable();

                    //перенос схемы таблицы клиентов во временную таблицу
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        var tempColumn = new DataColumn(col.ColumnName, col.DataType);
                        tempDataTable.Columns.Add(tempColumn);
                    }

                    //заполняем временную таблицу
                    foreach (var row in rows)
                    {
                        var tempRow = tempDataTable.NewRow();

                        tempRow.ItemArray = row.ItemArray;

                        tempDataTable.Rows.Add(tempRow);
                    }

                    //проверка на количество клиентов
                    if (tempDataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Не найдено");
                        dtgrdClients.DataSource = null;
                    }
                    else
                    {
                        dtgrdClients.DataSource = tempDataTable.DefaultView;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetClientFilterString()
        {
            string filterString = String.Empty;

            //словарь для частей строки фильтра
            var clientData = new Dictionary<string, string>();

            //в зависимости от выбраннных textbox в форме добавляем в словарь необходимые данные
            if (clientsPhoneCheck.Checked)
            {
                clientData.Add("Phone", clientsPhoneTextBox.Text);
            }

            if (clientsDriverLicenseCheck.Checked)
            {
                clientData.Add("DriverLicense", clientsDriverLicenseTextBox.Text);
            }

            if (clientsFIOCheck.Checked)
            {
                clientData.Add("FIO", clientsFIOTextBox.Text);
            }

            //формируем строку фильтра
            foreach (var item in clientData)
            {
                if (clientData.Last().Equals(item))
                {
                    filterString += $"{item.Key} LIKE '%{item.Value}%'";
                    break;
                }
                else
                {
                    filterString += $"{item.Key}='{item.Value}'";
                    filterString += " AND ";
                }
            }

            return filterString;
        }


        //тоже самое что и с клиентами
        private void searchOrdersBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
                {
                    connection.Open();

                    var adapter = new SqlDataAdapter("Select * from Orders", connection);
                    var dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    string sortString, filterString;

                    sortString = "OrderId";
                    filterString = GetOrderFilterString();

                    DataRow[] rows = dataTable.Select(filterString, sortString);



                    var adapterEmployees = new SqlDataAdapter("Select * from Employees", connection);

                    var employeesTable = new DataTable();

                    adapterEmployees.Fill(employeesTable);

                    var employees = new List<object[]>();

                    foreach (DataRow row in employeesTable.Rows)
                    {
                        employees.Add(row.ItemArray);
                    }


                    var tempDataTable = new DataTable();

                    foreach (DataColumn col in dataTable.Columns)
                    {
                        var tempColumn = new DataColumn(col.ColumnName, col.DataType);
                        tempDataTable.Columns.Add(tempColumn);
                    }

                    tempDataTable.Columns[1].DataType = typeof(string);


                    foreach (var row in rows)
                    {
                        var tempRow = tempDataTable.NewRow();

                        var items = row.ItemArray;

                        var employeeId = row[1].ToString();


                        if (!employeeId.Equals(""))
                        {
                            var employee = employees.First(em => em[0].ToString().Equals(employeeId));

                            if (employee != null)
                            {
                                items[1] = employee[2];
                            }
                            else
                            {
                                items[1] = "Работника нет";
                            }
                        }
                        else
                        {
                            items[1] = "Работника нет";
                        }


                        tempRow.ItemArray = items;

                        tempDataTable.Rows.Add(tempRow);
                    }

                    if (tempDataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Не найдено");
                        ordersDataGridView.DataSource = null;
                    }
                    else
                    {
                    ordersDataGridView.DataSource = tempDataTable.DefaultView;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ChangeCellsColor();
        }

        private string GetOrderFilterString()
        {
            string filterString = String.Empty;

            var clientData = new Dictionary<string, string>();

            if (ordersIdCheck.Checked)
            {
                clientData.Add("OrderId", ordersIdTextBox.Text);
            }

            if (ordersCarNumberCheck.Checked)
            {
                clientData.Add("CarNumber", ordersCarNumberTextBox.Text);
            }

            foreach (var item in clientData)
            {
                if (!item.Key.Contains("Like"))
                {
                    filterString += $"{item.Key}='{item.Value}'";
                }
                else
                {
                    filterString += $"{item.Key} {item.Value}";
                }

                if (clientData.Last().Equals(item))
                {
                    break;
                }

                filterString += " AND ";
            }

            return filterString;
        }


        //Меняем цвет строки если заказ готов
        private void ChangeCellsColor()
        {
            foreach (DataGridViewRow dgvr in ordersDataGridView.Rows)
            {
                if ((string)dgvr.Cells[4].Value == "Готов")
                {
                    dgvr.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }



        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void clientsFIOCheck_CheckedChanged(object sender, EventArgs e)
        {
            clientsFIOTextBox.Enabled = clientsFIOCheck.Checked;
        }

        private void clientsPhoneCheck_CheckedChanged(object sender, EventArgs e)
        {
            clientsPhoneTextBox.Enabled = clientsPhoneCheck.Checked;
        }

        private void clientsDriverLicenseCheck_CheckedChanged(object sender, EventArgs e)
        {
            clientsDriverLicenseTextBox.Enabled = clientsDriverLicenseCheck.Checked;
        }



        private void ordersIdCheck_CheckedChanged(object sender, EventArgs e)
        {
            ordersIdTextBox.Enabled = ordersIdCheck.Checked;
        }

        private void ordersCarNumberCheck_CheckedChanged(object sender, EventArgs e)
        {
            ordersCarNumberTextBox.Enabled = ordersCarNumberCheck.Checked;
        }       

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
                }
            }
        }
    }
}
