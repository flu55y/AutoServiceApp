using AutoServiceApp.Model.Entities;
using AutoServiceApp.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class SparepartForm : Form
    {
        private readonly SparepartRepository sparepartRep = new SparepartRepository();
        private int sparepartId = -1;
        public SparepartForm()
        {
            InitializeComponent();
            dtgrdSparepart.AutoGenerateColumns = false;

            LoadData();
        }

        private void LoadData()
        {
            var spareparts = sparepartRep.GetSpareparts();
            dtgrdSparepart.DataSource = spareparts;
        }

        private void ResetInputs()
        {
            txtbxName.Text = string.Empty;
            txtbxPrice.Text = string.Empty;
            txtbxGurantee.Text = string.Empty;
            sparepartId = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtbxName.Text;
            string priceStr = txtbxPrice.Text;
            string gurantee = txtbxGurantee.Text;
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(priceStr) || string.IsNullOrEmpty(gurantee))
            {
                MessageBox.Show("Не все поля заполнены", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!decimal.TryParse(priceStr, out decimal price))
            {
                MessageBox.Show("Стоимость должна быть числом", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Sparepart sparepart = new Sparepart
            {
                SparepartId = sparepartId,
                Name = name,
                Price = price,
                Guarantee = gurantee
            };
            if (IsValidate(sparepart))
            {
                sparepartRep.AddSparepart(sparepart);
                ResetInputs();
                LoadData();
            }
        }

        private void dtgrdSparepart_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                sparepartId = (int)dtgrdSparepart.Rows[e.RowIndex].Cells[0].Value;
                string name = (string)dtgrdSparepart.Rows[e.RowIndex].Cells[1].Value;
                decimal cost = (decimal)dtgrdSparepart.Rows[e.RowIndex].Cells[2].Value;
                string gurantee = (string)dtgrdSparepart.Rows[e.RowIndex].Cells[3].Value;

                txtbxName.Text = name;
                txtbxPrice.Text = cost.ToString();
                txtbxGurantee.Text = gurantee;
            }
        }
        private bool IsValidate(Sparepart sparepart)
        {
            var results = new List<ValidationResult>();
            StringBuilder stringError = new StringBuilder();
            var contextSparepart = new ValidationContext(sparepart);
            if (!Validator.TryValidateObject(sparepart, contextSparepart, results, true))
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
