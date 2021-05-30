using AutoServiceApp.Model.Entities;
using AutoServiceApp.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class TypeOfWorkForm : Form
    {
        private readonly TypeOfWorkRepository typeOfWorkRep = new TypeOfWorkRepository();
        private int typeOfWorkId = -1;
        public TypeOfWorkForm()
        {
            InitializeComponent();
            dtgrdTypeOfWork.AutoGenerateColumns = false;
            LoadData();
        }

        private void LoadData()
        {
            var typeOfWorks = typeOfWorkRep.GetTypeOfWorks();
            dtgrdTypeOfWork.DataSource = typeOfWorks;
        }
        private void ResetInputs()
        {
            txtbxName.Text = string.Empty;
            txtbxPrice.Text = string.Empty;
            txtbxDeadline.Text = string.Empty;
            txtbxGurantee.Text = string.Empty;
            typeOfWorkId = -1;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            string name = txtbxName.Text;
            string priceStr = txtbxPrice.Text;
            string deadline = txtbxDeadline.Text;
            string gurantee = txtbxGurantee.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceStr) || 
                string.IsNullOrEmpty(deadline) || string.IsNullOrEmpty(gurantee))
            {
                MessageBox.Show("Не все поля заполнены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(priceStr, out decimal price))
            {
                MessageBox.Show("Стоимость должна быть числом", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TypeOfWork typeOfWork = new TypeOfWork
            {
                TypeOfWorkId = typeOfWorkId,
                Name = name,
                Price = price,
                Deadline = deadline,
                Gurantee = gurantee
            };
            if (IsValidate(typeOfWork))
            {
                typeOfWorkRep.AddTypeOfWork(typeOfWork);
                ResetInputs();
                LoadData();
            }
        }

        private void dtgrdTypeOfWork_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                typeOfWorkId = (int)dtgrdTypeOfWork.Rows[e.RowIndex].Cells[0].Value;
                string name = (string)dtgrdTypeOfWork.Rows[e.RowIndex].Cells[1].Value;
                decimal cost = (decimal)dtgrdTypeOfWork.Rows[e.RowIndex].Cells[2].Value;
                string deadline = (string)dtgrdTypeOfWork.Rows[e.RowIndex].Cells[3].Value;
                string gurantee = (string)dtgrdTypeOfWork.Rows[e.RowIndex].Cells[4].Value;

                txtbxName.Text = name;
                txtbxPrice.Text = cost.ToString();
                txtbxDeadline.Text = deadline;
                txtbxGurantee.Text = gurantee;
            }
        }

        private bool IsValidate(TypeOfWork typeOfWork)
        {
            var results = new List<ValidationResult>();
            StringBuilder stringError = new StringBuilder();
            var contextTypeOfWork = new ValidationContext(typeOfWork);
            if (!Validator.TryValidateObject(typeOfWork, contextTypeOfWork, results, true))
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
