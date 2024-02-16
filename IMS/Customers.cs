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
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
            loadCustomerDataFromDB();
        }
        //create connection
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True");
        DataTable customersDataTable = new DataTable("Customer");

        //To Load customer Data

        private void loadCustomerDataFromDB()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True"))
            {
                String query = "SELECT * FROM customers";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = sqlCommand;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        dataGridCustomers.DataSource = dt;
                        

                
                    }
                    catch
                    {
                        MessageBox.Show("ERROR while loading users from database");
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }

        // Validate Customer
        private Boolean validCustomer()
        {
            if (!string.IsNullOrWhiteSpace(txtCustomersFirstName.Text) && !string.IsNullOrWhiteSpace(txtCustomersPhone.Text) && !string.IsNullOrWhiteSpace(txtCustomersLastName.Text) && !string.IsNullOrWhiteSpace(txtCustomersEmail.Text) && !string.IsNullOrWhiteSpace(txtCustomersCity.Text) && !string.IsNullOrWhiteSpace(txtCustomersAddress.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Customercs_Load(object sender, EventArgs e)
        {

        }
        //Add a New Customer
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            if (validCustomer())
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True"))
                {
                    String query = "INSERT INTO Customers (CustomerID, CustomerFirstName, CustomerLastName, CustomerPhone, CustomerEmail, CustomerCity, CustomerAddress) VALUES(@ID,@FirstName, @LastName, @Phone, @Email, @City, @Address)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@ID", txtCustomersID.Text);
                            sqlCommand.Parameters.AddWithValue("@FirstName", txtCustomersFirstName.Text);
                            sqlCommand.Parameters.AddWithValue("@LastName", txtCustomersLastName.Text);
                            sqlCommand.Parameters.AddWithValue("@Phone", txtCustomersPhone.Text);
                            sqlCommand.Parameters.AddWithValue("@Email", txtCustomersEmail.Text);
                            sqlCommand.Parameters.AddWithValue("@City", txtCustomersCity.Text);
                            sqlCommand.Parameters.AddWithValue("@Address", txtCustomersAddress.Text);
                            sqlCommand.ExecuteNonQuery();
                            txtCustomersAddress.Text= txtCustomersCity.Text=txtCustomersEmail.Text=txtCustomersPhone.Text=txtCustomersLastName.Text=txtCustomersFirstName.Text=txtCustomersID.Text="";

                            customersDataTable.Clear();
                            loadCustomerDataFromDB();
                            MessageBox.Show("Successfully Added New Customer");
                        }
                        catch
                        {
                            MessageBox.Show("ERROR while creating customer");
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid fields");
            }
        }
        //Update a new customer
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (validCustomer())
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True"))
                {
                    String query = "UPDATE Customers SET  CustomerFirstName = @CustomerFirstName,CustomerLastName=@CustomerLastName,CustomerPhone=@CustomerPhone,CustomerEmail=@CustomerEmail,CustomerCity=@CustomerCity ,CustomerAddress=@CustomerAddress WHERE CustomerID=@CustomerID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@CustomerID", txtCustomersID.Text);
                            sqlCommand.Parameters.AddWithValue("@CustomerFirstName", txtCustomersFirstName.Text);
                            sqlCommand.Parameters.AddWithValue("@CustomerLastName", txtCustomersLastName.Text);
                            sqlCommand.Parameters.AddWithValue("@CustomerPhone", txtCustomersPhone.Text);
                            sqlCommand.Parameters.AddWithValue("@CustomerEmail", txtCustomersEmail.Text);
                            sqlCommand.Parameters.AddWithValue("@CustomerCity", txtCustomersCity.Text);
                            sqlCommand.Parameters.AddWithValue("@CustomerAddress", txtCustomersAddress.Text);
                            sqlCommand.ExecuteNonQuery();
                            txtCustomersAddress.Text = txtCustomersCity.Text=txtCustomersEmail.Text=txtCustomersPhone.Text=txtCustomersLastName.Text=txtCustomersFirstName.Text=txtCustomersID.Text="";

                            customersDataTable.Clear();
                            loadCustomerDataFromDB();
                            MessageBox.Show("Successfully Updated Customer");
                        }
                        catch
                        {
                            MessageBox.Show("ERROR while updating customer");
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid fields");
            }
        }
        //Delete button
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (validCustomer())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True"))
                    {
                        String query = "DELETE FROM Customers WHERE CustomerID=@CustomerID";
                        using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Parameters.AddWithValue("@CustomerID", int.Parse(txtCustomersID.Text));
                                sqlCommand.ExecuteNonQuery();
                                customersDataTable.Clear();
                                txtCustomersAddress.Text = txtCustomersCity.Text=txtCustomersEmail.Text=txtCustomersPhone.Text=txtCustomersLastName.Text=txtCustomersFirstName.Text=txtCustomersID.Text="";

                                loadCustomerDataFromDB();
                                MessageBox.Show("Successfully Deleted Customer");
                            }
                            catch
                            {
                                MessageBox.Show("ERROR while deleting");

                            }
                            finally
                            {
                                connection.Close();
                            }

                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        

        private void dataGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            int index;
            index = (int)e.RowIndex;
            
            DataGridViewRow selectedRow = dataGridCustomers.Rows[index];
        
  
                txtCustomersID.Text = selectedRow.Cells[0].Value.ToString();
                txtCustomersFirstName.Text = selectedRow.Cells[1].Value.ToString();
                txtCustomersLastName.Text =selectedRow.Cells[2].Value.ToString();
                txtCustomersPhone.Text = selectedRow.Cells[3].Value.ToString();
                txtCustomersEmail.Text =selectedRow.Cells[4].Value.ToString();
                txtCustomersCity.Text = selectedRow.Cells[5].Value.ToString();
                txtCustomersAddress.Text = selectedRow.Cells[6].Value.ToString();
           
        }
        //Search Btn
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        ////private void btnSearchCustomer_Click(object sender, EventArgs e)
        ////{
        ////    if (validCustomer())
        ////    {


        ////            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True"))
        ////            {
        ////                String query = "SELECT FROM customers WHERE CustomerID=@CustomerID";
        ////                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
        ////                {
        ////                    try
        ////                    {
        ////                    connection.Open();
        ////                    sqlCommand.Parameters.AddWithValue("@ID", txtCustomersID.Text);
        ////                    sqlCommand.Parameters.AddWithValue("@FirstName", txtCustomersFirstName.Text);
        ////                    sqlCommand.Parameters.AddWithValue("@LastName", txtCustomersLastName.Text);
        ////                    sqlCommand.Parameters.AddWithValue("@Phone", txtCustomersPhone.Text);
        ////                    sqlCommand.Parameters.AddWithValue("@Email", txtCustomersEmail.Text);
        ////                    sqlCommand.Parameters.AddWithValue("@City", txtCustomersCity.Text);
        ////                    sqlCommand.Parameters.AddWithValue("@Address", txtCustomersAddress.Text);
        ////                    SqlDataAdapter da = new SqlDataAdapter();
        ////                    da.SelectCommand = sqlCommand;
        ////                    DataTable dt = new DataTable();
        ////                    dt.Clear();
        ////                    da.Fill(dt);
        ////                    dataGridCustomers.DataSource = dt;
        ////                }
        ////                    catch
        ////                    {
        ////                        MessageBox.Show("ERROR while Searching");

        ////                    }
        ////                    finally
        ////                    {
        ////                        connection.Close();
        ////                    }

        ////                }
        ////            }




        ////    }
        ////}

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (validCustomer())
            {


                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True;Trust Server Certificate=True"))
                {
                    String query = "SELECT FROM customers WHERE CustomerID=@CustomerID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.Parameters.AddWithValue("@ID", txtCustomersID.Text);
                            sqlCommand.Parameters.AddWithValue("@FirstName", txtCustomersFirstName.Text);
                            sqlCommand.Parameters.AddWithValue("@LastName", txtCustomersLastName.Text);
                            sqlCommand.Parameters.AddWithValue("@Phone", txtCustomersPhone.Text);
                            sqlCommand.Parameters.AddWithValue("@Email", txtCustomersEmail.Text);
                            sqlCommand.Parameters.AddWithValue("@City", txtCustomersCity.Text);
                            sqlCommand.Parameters.AddWithValue("@Address", txtCustomersAddress.Text);
                            SqlDataAdapter da = new SqlDataAdapter();
                            da.SelectCommand = sqlCommand;
                            DataTable dt = new DataTable();
                            dt.Clear();
                            da.Fill(dt);
                            dataGridCustomers.DataSource = dt;
                        }
                        catch
                        {
                            MessageBox.Show("ERROR while searching for products");
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }




            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
