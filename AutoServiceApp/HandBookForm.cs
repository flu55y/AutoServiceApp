using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServiceApp
{
    public partial class HandBookForm : Form
    {
        public HandBookForm()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Owner = this;
            employeeForm.ShowDialog();
        }

        private void btnSpareparts_Click(object sender, EventArgs e)
        {
            SparepartForm sparepartForm = new SparepartForm();
            sparepartForm.Owner = this;
            sparepartForm.ShowDialog();
        }

        private void btnTypeOfWork_Click(object sender, EventArgs e)
        {
            TypeOfWorkForm typeOfWorkForm = new TypeOfWorkForm();
            typeOfWorkForm.Owner = this;
            typeOfWorkForm.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
