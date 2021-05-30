using AutoServiceApp.Model.Entities;
using AutoServiceApp.Model.Repositories;
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
    public partial class OrderServiceForm : Form
    {
        private int orderId;
        private readonly TypeOfWorkRepository typeOfWorkRep = new TypeOfWorkRepository();
        private readonly SparepartRepository sparepartRep = new SparepartRepository();
        private readonly EmployeeRepository employeeRep = new EmployeeRepository();
        private readonly OrderRepository orderRep = new OrderRepository();

        private List<TypeOfWork> listTypeOfWorks = new List<TypeOfWork>();
        private List<Sparepart> listSpareparts = new List<Sparepart>();
        public OrderServiceForm(int orderId)
        {
            InitializeComponent();
            dtgrdTypeOfWork.AutoGenerateColumns = false;
            dtgrdSparepart.AutoGenerateColumns = false;
            this.orderId = orderId;
            lblOrderNumber.Text = $"№ Заказа: {orderId}";
            LoadData();
        }

        private void LoadData()
        {
            var employees = employeeRep.GetEmployees();
            cmbxEmployee.DataSource = employees;

            var typeOfWorks = typeOfWorkRep.GetTypeOfWorks();
            cmbxTypeOfWork.DataSource = typeOfWorks;

            var spareparts = sparepartRep.GetSpareparts();
            cmbbxSpareparts.DataSource = spareparts;

            var order = orderRep.GetOrder(orderId);

            if(order.Employee != null)
            {
                cmbxEmployee.DataSource = new List<Employee> { order.Employee };
                cmbxEmployee.Enabled = false;
                btnComplete.Enabled = false;
                btnAddSparepart.Enabled = false;
                btnAddTypeOfWork.Enabled = false;
                foreach (var typeOfWork in order.OrderTypeOfWorks)
                {
                    listTypeOfWorks.Add(typeOfWork.TypeOfWork);
                    dtgrdTypeOfWork.DataSource = listTypeOfWorks;
                    dtgrdTypeOfWork.Enabled = false;
                }
                foreach (var sparepart in order.OrderSpareparts)
                {
                    listSpareparts.Add(sparepart.Sparepart);
                    dtgrdSparepart.DataSource = listSpareparts;
                    dtgrdSparepart.Enabled = false;
                }
            }
        }

        private void btnAddTypeOfWork_Click(object sender, EventArgs e)
        {
            var selectedTypeOfWork = cmbxTypeOfWork.SelectedItem as TypeOfWork;
            if(selectedTypeOfWork != null)
            {
                var typeOfWork = listTypeOfWorks.FirstOrDefault(x => x.TypeOfWorkId == selectedTypeOfWork.TypeOfWorkId);
                if(typeOfWork != null)
                {
                    MessageBox.Show("Данный тип работы уже добавлен", "Предпреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                listTypeOfWorks.Add(selectedTypeOfWork);
                dtgrdTypeOfWork.DataSource = null;
                dtgrdTypeOfWork.DataSource = listTypeOfWorks;
            }
        }

        private void dtgrdTypeOfWork_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 5)
                {
                    int typeOfWorkId = (int)dtgrdTypeOfWork.Rows[e.RowIndex].Cells[0].Value;
                    var typeOfWork = listTypeOfWorks.FirstOrDefault(x => x.TypeOfWorkId == typeOfWorkId);
                    if(typeOfWork != null)
                    {
                        listTypeOfWorks.Remove(typeOfWork);
                        dtgrdTypeOfWork.DataSource = null;
                        dtgrdTypeOfWork.DataSource = listTypeOfWorks;
                    }
                }
            }
        }

        private void dtgrdSparepart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 4)
                {
                    int sparepartId = (int)dtgrdSparepart.Rows[e.RowIndex].Cells[0].Value;
                    var sparepart = listSpareparts.FirstOrDefault(x => x.SparepartId == sparepartId);
                    if (sparepart != null)
                    {
                        listSpareparts.Remove(sparepart);
                        dtgrdSparepart.DataSource = null;
                        dtgrdSparepart.DataSource = listSpareparts;
                    }
                }
            }
        }

        private void btnAddSparepart_Click(object sender, EventArgs e)
        {
            var selectedSparepart = cmbbxSpareparts.SelectedItem as Sparepart;
            if(selectedSparepart != null)
            {
                var sparepart = listSpareparts.FirstOrDefault(x => x.SparepartId == selectedSparepart.SparepartId);
                if(sparepart != null)
                {
                    MessageBox.Show("Данная запчасть уже добавлена", "Предпреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                listSpareparts.Add(selectedSparepart);
                dtgrdSparepart.DataSource = null;
                dtgrdSparepart.DataSource = listSpareparts;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            var selectedEmployee = cmbxEmployee.SelectedItem as Employee;
            if(selectedEmployee == null)
            {
                MessageBox.Show("Не выбран сотрудник", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(listTypeOfWorks.Count == 0)
            {
                MessageBox.Show("Не выбран вид работы", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            orderRep.CompleteOrder(orderId, selectedEmployee.EmployeeId, listTypeOfWorks, listSpareparts);
            Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
