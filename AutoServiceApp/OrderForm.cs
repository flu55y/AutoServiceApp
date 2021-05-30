using AutoServiceApp.Model.Entities;
using AutoServiceApp.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class OrderForm : Form
    {
        private readonly OrderRepository orderRep = new OrderRepository();
        private string carNumber;

        private Timer loadOwnersTimer = new Timer();

        private const int TIME_TO_UPDATE = 15;//sec

        public OrderForm(string carNumber)
        {
            InitializeComponent();
            dtgrdOrders.AutoGenerateColumns = false;
            this.carNumber = carNumber;
            lblCarNumber.Text = $"Номер автомобиля: {carNumber}";
            LoadData();
            StartOwnerTimer();
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

        private void LoadData()
        {
            var orders = orderRep.GetOrders().Where(x => x.CarNumber == carNumber).ToList();
            dtgrdOrders.DataSource = orders;
        }
        private void ClearInputs()
        {
            txtbxReason.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string reason = txtbxReason.Text;
            DateTime dt = dttmpckDate.Value;
            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Необходимо ввести причину", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Order order = new Order
            {
                CarNumber = carNumber,
                Reason = reason,
                Date = dt,
                Status = "Создан"
            };
            if (IsValidate(order))
            {
                orderRep.AddOrder(order);
                ClearInputs();
                LoadData();
            }
        }

        private void dtgrdOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    int orderId = (int)dtgrdOrders.Rows[e.RowIndex].Cells[0].Value;
                    OrderServiceForm orderServiceForm = new OrderServiceForm(orderId);
                    orderServiceForm.Owner = this;
                    orderServiceForm.ShowDialog();
                    LoadData();
                }
            }
        }

        private void dtgrdOrders_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow dgvr in dtgrdOrders.Rows)
            {               
                if ((string)dgvr.Cells[3].Value == "Готов")
                {                  
                    dgvr.DefaultCellStyle.BackColor = Color.LightGreen;
                    dgvr.Cells[4].Value = "Просмотреть";
                }
                else
                {
                    dgvr.Cells[4].Value = "Оформить";
                }
            }
        }
        private bool IsValidate(Order order)
        {
            var results = new List<ValidationResult>();
            StringBuilder stringError = new StringBuilder();
            var contextOrder = new ValidationContext(order);
            if (!Validator.TryValidateObject(order, contextOrder, results, true))
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
