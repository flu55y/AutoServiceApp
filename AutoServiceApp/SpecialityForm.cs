using AutoServiceApp.Model.Entities;
using AutoServiceApp.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class SpecialityForm : Form
    {
        private readonly EmployeeRepository employeeRep = new EmployeeRepository();
        private int specialityId = -1;
        public SpecialityForm()
        {
            InitializeComponent();
            dtgrdSpeciality.AutoGenerateColumns = false;
            LoadData();
        }

        private void LoadData()
        {
            var specialities = employeeRep.GetSpecialities();
            dtgrdSpeciality.DataSource = specialities;
        }
        private void ResetInputs()
        {
            txtbxName.Text = string.Empty;
            specialityId = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtbxName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Необходимо ввести специальность", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Speciality speciality = new Speciality
            {
                SpecialityId = specialityId,
                Name = name
            };
            if (IsValidate(speciality))
            {
                employeeRep.AddSpeciality(speciality);
                ResetInputs();
                LoadData();
            }
        }

        private void dtgrdSpeciality_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                specialityId = (int)dtgrdSpeciality.Rows[e.RowIndex].Cells[0].Value;
                string name = (string)dtgrdSpeciality.Rows[e.RowIndex].Cells[1].Value;

                txtbxName.Text = name;
            }
        }

        private bool IsValidate(Speciality speciality)
        {
            var results = new List<ValidationResult>();
            StringBuilder stringError = new StringBuilder();
            var contextSpeciality = new ValidationContext(speciality);
            if (!Validator.TryValidateObject(speciality, contextSpeciality, results, true))
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
