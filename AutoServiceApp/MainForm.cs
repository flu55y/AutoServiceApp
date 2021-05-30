using AutoServiceApp.Model.Entities;
using AutoServiceApp.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Drawing;

namespace AutoServiceApp
{
    public partial class MainForm : Form
    {
        private readonly OwnerRepository ownerRep = new OwnerRepository();
        private readonly CarRepository carRep = new CarRepository();
        private int selectedOwnerId = -1;

        private Timer loadOwnersTimer = new Timer();

        private const int TIME_TO_UPDATE = 15;//sec

        public MainForm()
        {
            InitializeComponent();
            dtgrdClients.AutoGenerateColumns = false;
            OrdersDataGridView.AutoGenerateColumns = false;

            LoadData();
            //StartOwnerTimer();
        }

        private void StartOwnerTimer()
        {
            loadOwnersTimer.Interval = TIME_TO_UPDATE * 1000;
            loadOwnersTimer.Tick += LoadOwnersTimer_Tick;
            loadOwnersTimer.Start();
        }

        private void LoadOwnersTimer_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(string searchStr = null)
        {
            var ownersList = ownerRep.GetOwners();


            var owners = (from s in ownersList
                          select new
                          {
                              OwnerId = s.OwnerId,
                              CarNumber = s.CarNumber,
                              FIO = s.Owner.FIO,
                              Phone = s.Owner.Phone,
                              DriverLicense = s.Owner.DriverLicense,
                              CarMark = s.Mark,
                          }).OrderByDescending(o=>o.OwnerId).ToList();

            dtgrdClients.DataSource = owners;
            ////////////////////////////////

            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                try
                {
                    connection.Open();

                    var adapter = new SqlDataAdapter("Select * from Orders where Status='Создан'", connection);
                    var dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    OrdersDataGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void ClearInputs()
        {
            txtbxFIO.Text = string.Empty;
            txtbxPhone.Text = string.Empty;
            txtbxDriverLicense.Text = string.Empty;
            txtbxCarNumber.Text = string.Empty;
            txtbxCarMark.Text = string.Empty;
            selectedOwnerId = -1;
            txtbxCarNumber.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fio = txtbxFIO.Text;
            string phone = txtbxPhone.Text;
            string driverLicense = txtbxDriverLicense.Text;
            string carMark = txtbxCarMark.Text;
            string carNumber = txtbxCarNumber.Text;
            if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(driverLicense)
                || string.IsNullOrEmpty(carMark) || string.IsNullOrEmpty(carNumber))
            {
                MessageBox.Show("Не все данные введены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            Owner owner = new Owner
            {
                OwnerId = selectedOwnerId,
                FIO = fio,
                Phone = phone,
                DriverLicense = driverLicense
            };
            Car car = new Car
            {
                CarNumber = carNumber,
                Mark = carMark,
            };
            if (IsValidate(owner, car))
            {
                int ownerId = ownerRep.AddOwner(owner);
                car.OwnerId = ownerId;
                carRep.AddCar(car);
                ClearInputs();
                LoadData();
            }
        }

        private bool IsValidate(Owner owner, Car car)
        {
            var results = new List<ValidationResult>();         
            StringBuilder stringError = new StringBuilder();
            var contextOwner = new ValidationContext(owner);
            if (!Validator.TryValidateObject(owner, contextOwner, results, true))
            {
                foreach (var error in results)
                {
                    stringError.Append(error.ErrorMessage + Environment.NewLine);
                }
            }
            var contextCar = new ValidationContext(car);
            if (!Validator.TryValidateObject(car, contextCar, results, true))
            {               
                foreach (var error in results)
                {
                    stringError.Append(error.ErrorMessage + Environment.NewLine);
                }
               
            }
            if (stringError.Length > 0)
            {
                MessageBox.Show(stringError.ToString(), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Owner = this;
            searchForm.ShowDialog();
            LoadData();
        }

        private void dtgrdClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    string carNumber = (string)dtgrdClients.Rows[e.RowIndex].Cells[5].Value;
                    OrderForm orderForm = new OrderForm(carNumber);
                    orderForm.Owner = this;
                    orderForm.ShowDialog();
                }
            }
        }

        private void OrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    int orderId = (int)OrdersDataGridView.Rows[e.RowIndex].Cells[0].Value;
                    OrderServiceForm orderServiceForm = new OrderServiceForm(orderId);
                    orderServiceForm.Owner = this;
                    orderServiceForm.ShowDialog();
                    LoadData();
                }
            }
        }


        private void dtgrdClients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex != 6)
            {
                int id = (int)dtgrdClients.Rows[e.RowIndex].Cells[0].Value;
                string fio = (string)dtgrdClients.Rows[e.RowIndex].Cells[1].Value;

                ownerNameLabel.Text = "ФИО клиента: " + fio;
                ownerIdLabel.Text = "Id клиента: " + id;
                EditButton.Enabled = true;
            }
        }

        private void readyOrdersBtn_Click(object sender, EventArgs e)
        {
            ReadyOrdersForm readyOrdersForm = new ReadyOrdersForm();
            readyOrdersForm.Owner = this;
            readyOrdersForm.ShowDialog();
            LoadData();
        }

        private void handBookBtn_Click(object sender, EventArgs e)
        {
            HandBookForm handBookForm = new HandBookForm();
            handBookForm.Owner = this;
            handBookForm.ShowDialog();
            LoadData();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditOwnerForm editOwnerForm = new EditOwnerForm(Int32.Parse(ownerIdLabel.Text.Split(' ').Last()));
            editOwnerForm.Owner = this;
            editOwnerForm.ShowDialog();
            LoadData();
        }
    }
}
