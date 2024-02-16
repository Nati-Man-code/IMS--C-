using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }
        //To display multiple forms in C#, you can create instances of the forms you want to display and call the Show() method on each instance. 
        private void btncustomercliked_Click(object sender, EventArgs e)
        {
            CustomersForm customersForm = new CustomersForm();
            customersForm.Show();
        }

        private void btnEmployeebtnclicked_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
        }

        private void btnsupplierclicked_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.Show();
        }

        private void btnProductclicked_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void btnOrderClicked_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        //private void btnstockclicked_Click(object sender, EventArgs e)
        //{
        //    StockForm stockForm = new StockForm();
        //    stockForm.Show();
        //}

        private void btnReportClicked_Click(object sender, EventArgs e)
        {
            //ReportForm reportForm = new ReportForm();
            //reportForm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
