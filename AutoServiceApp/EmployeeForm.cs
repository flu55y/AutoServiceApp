using AutoServiceApp.Model.Entities;
using AutoServiceApp.Model.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class EmployeeForm : Form
    {
        private readonly EmployeeRepository employeeRep = new EmployeeRepository();
        private int employeeId = -1;
        public EmployeeForm()
        {
            InitializeComponent();
            dtgrdEmployee.AutoGenerateColumns = false;
            LoadData();
        }
        private void LoadData()
        {
            var employeesList = employeeRep.GetEmployees();
            var employees = (from s in employeesList
                             select new
                          {
                              EmployeeId = s.EmployeeId,
                              Fio = s.FIO,
                              Speciality = s.Speciality.Name
                          }).ToList();
            dtgrdEmployee.DataSource = employees;

            var specialities = employeeRep.GetSpecialities();
            cmbxSpeciality.DataSource = specialities;
        }
        private void ClearInputs()
        {
            txtbxFIO.Text = string.Empty;
            employeeId = -1;
        }

        private void btnSpeciality_Click(object sender, EventArgs e)
        {
            SpecialityForm specialityForm = new SpecialityForm();
            specialityForm.Owner = this;
            specialityForm.ShowDialog();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fio = txtbxFIO.Text;
            Speciality selectedSpeciality = cmbxSpeciality.SelectedItem as Speciality;
            if (string.IsNullOrEmpty(fio))
            {
                MessageBox.Show("Необходимо ввести ФИО", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(selectedSpeciality == null)
            {
                MessageBox.Show("Необходимо выбрать специальность", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Employee employee = new Employee
            {
                EmployeeId = employeeId,
                FIO = fio,
                SpecialityId = selectedSpeciality.SpecialityId
            };
            if (IsValidate(employee))
            {
                employeeRep.AddEmployee(employee);
                ClearInputs();
                LoadData();
            }
        }

        private void dtgrdEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                employeeId = (int)dtgrdEmployee.Rows[e.RowIndex].Cells[0].Value;
                string fio = (string)dtgrdEmployee.Rows[e.RowIndex].Cells[1].Value;
                string speciality = (string)dtgrdEmployee.Rows[e.RowIndex].Cells[2].Value;

                txtbxFIO.Text = fio;
                cmbxSpeciality.SelectedIndex = cmbxSpeciality.FindStringExact(speciality);
            }
        }

        private bool IsValidate(Employee employee)
        {
            var results = new List<ValidationResult>();
            StringBuilder stringError = new StringBuilder();
            var contextEmployee = new ValidationContext(employee);
            if (!Validator.TryValidateObject(employee, contextEmployee, results, true))
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
