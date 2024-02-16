using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            // Initialize DataGridView
            //adapter = new SqlDataAdapter("SELECT * FROM product" );
            //dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //dataGridViewProduct.DataSource = dataTable;
        }
        //Load 
        private void Product_Load(object sender, EventArgs e)
        {
            BindData();
        }
        //datagridview section
        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count == 1)
            {
                dataGridViewProduct.CurrentRow.Selected = true;
                txtProductID.Text = dataGridViewProduct.SelectedCells[0].Value.ToString();
                txtProductName.Text = dataGridViewProduct.SelectedCells[1].Value.ToString();
                txtProductQuantity.Text = dataGridViewProduct.SelectedCells[2].Value.ToString();
                txtProductPrice.Text = dataGridViewProduct.SelectedCells[3].Value.ToString();
                txtProductCategory.Text = dataGridViewProduct.SelectedCells[4].Value.ToString();
                txtProductSupplier.Text = dataGridViewProduct.SelectedCells[5].Value.ToString();
                txtProductAddress.Text = dataGridViewProduct.SelectedCells[6].Value.ToString();
                txtProductPhoneNo.Text = dataGridViewProduct.SelectedCells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-F70OSGES\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True");

        //Add Section
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("Add into Product values ('"+txtProductID.Text+"' , '"+txtProductName.Text   +"' , '"+txtProductQuantity.Text+"' , '"+txtProductPrice.Text+"' '"+txtProductSupplier.Text+" '"+txtProductAddress.Text+"' '"+txtProductPhoneNo.Text+"'' getdata()" , conn);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfuly Inserted");
            conn.Close();
            BindData();

        }
        //For Bind
        void BindData()
        {
            SqlCommand command = new SqlCommand("select * From Product " );
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridViewProduct.DataSource = dt;
        }
        //Update Section
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            
            string query = "UPDATE Product SET Name = @Name, Quantity = @Quantity, Price = @Price, Supplier = @Supplier, Address = @Address, PhoneNo = @PhoneNo WHERE ID = @ID";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Name", txtProductName.Text);
                command.Parameters.AddWithValue("@Quantity", txtProductQuantity.Text);
                command.Parameters.AddWithValue("@Price", txtProductPrice.Text);
                command.Parameters.AddWithValue("@Supplier", txtProductSupplier.Text);
                command.Parameters.AddWithValue("@Address", txtProductAddress.Text);
                command.Parameters.AddWithValue("@PhoneNo", txtProductPhoneNo.Text);
                command.Parameters.AddWithValue("@ID", txtProductID.Text);

                command.ExecuteNonQuery();
            }

            MessageBox.Show("Successfuly Updated");
            conn.Close();
            BindData();
        }
        //Delete Part
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text != "")
            {
                if(MessageBox.Show("Are You shure to delete?" ,"delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("Delete Product Where ID = '"+txtProductID+"' ");
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfuly Deleted");
                    conn.Close();
                    BindData();
                }
               
            }
            else
            {
                MessageBox.Show("Fill Product Id");
            }
        }
        //Search 
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * From Product where  ID = '"+txtProductID+"'");
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridViewProduct.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("select Name , Quantity, Price, Category, Supplier, Address, Phone No");
            SqlDataReader srd = command.ExecuteReader();
            while(srd.Read())
            {
                txtProductName.Text = srd.GetValue(0).ToString();
                txtProductPrice.Text = srd.GetValue(2).ToString();
                txtProductCategory.Text = srd.GetValue(3).ToString();
                txtProductSupplier.Text = srd.GetValue(4).ToString();
                txtProductAddress.Text = srd.GetValue(5).ToString();
                txtProductPhoneNo.Text = srd.GetValue(6).ToString();

            }
            conn.Close();
        }
    }
}
