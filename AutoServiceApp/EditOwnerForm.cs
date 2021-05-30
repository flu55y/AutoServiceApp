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
using AutoServiceApp.Model.Repositories;

namespace AutoServiceApp
{
    public partial class EditOwnerForm : Form
    {
        private readonly OwnerRepository ownerRep = new OwnerRepository();
        private int ownerId;
        private string carNumber;

        public EditOwnerForm(int ownerId)
        {
            InitializeComponent();

            //id клиента для редактированя
            this.ownerId = ownerId;
            LoadData();
        }

        private void LoadData()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                //подключаемся к бд
                connection.Open();

                //создаем адаптер и получаем клиента
                var adapterOwner = new SqlDataAdapter($"Select * from Owners where OwnerId='{ownerId}'", connection);
                var dataTable = new DataTable();

                adapterOwner.Fill(dataTable);

                //создаем адаптер и получаем его машину
                var adapterCar = new SqlDataAdapter($"Select * from Cars where OwnerId='{ownerId}'", connection);
                var carTable = new DataTable();

                adapterCar.Fill(carTable);

                //получаем номер машины
                carNumber = carTable.Rows[0].ItemArray[0].ToString();

                //заполняем поля данными
                txtbxFIO.Text = dataTable.Rows[0].ItemArray[1].ToString();
                txtbxPhone.Text = dataTable.Rows[0].ItemArray[2].ToString();
                txtbxDriverLicense.Text = dataTable.Rows[0].ItemArray[3].ToString();
                txtbxCarMark.Text = carTable.Rows[0].ItemArray[2].ToString();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                //подключаемся к бд и создаем строку запроса апдейта для клиента
                connection.Open();
                string commandOwnerStr = "UPDATE [Owners] " +
                    "SET FIO=@FIO, Phone=@Phone, DriverLicense=@DriverLicense " +
                    "WHERE OwnerId=@OwnerId";

                SqlCommand commandOwner = new SqlCommand(commandOwnerStr, connection);

                //создаем набор параметров для запроса
                commandOwner.Parameters.AddWithValue("@FIO", txtbxFIO.Text);
                commandOwner.Parameters.AddWithValue("@Phone", txtbxPhone.Text);
                commandOwner.Parameters.AddWithValue("@DriverLicense", txtbxDriverLicense.Text);
                commandOwner.Parameters.AddWithValue("@OwnerId", ownerId);

                //выполняем запрос
                commandOwner.ExecuteNonQuery();

                //также меняем марку машины для номера клиента
                string commandCarStr = "UPDATE [Cars] " +
                    "SET Mark=@Mark " +
                    "WHERE CarNumber=@CarNumber";

                SqlCommand commandCar = new SqlCommand(commandCarStr, connection);
                commandCar.Parameters.AddWithValue("@Mark", txtbxCarMark.Text);
                commandCar.Parameters.AddWithValue("@CarNumber", carNumber);

                commandCar.ExecuteNonQuery();

                this.Close();
            }
        }
    }
}
