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
using System.Xml.Linq;

namespace IMS
{
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();

            // Validate input on form closing
            FormClosing += (sender, e) =>
            {
                if (ValidSupplier())
                {
                    e.Cancel = false;
                }
                else
                {
                    MessageBox.Show("Please correct the input errors before closing the form.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            };
        }
        // Validate Customer
        private Boolean ValidSupplier()
        {
            if (!string.IsNullOrWhiteSpace(txtSupFullName.Text) && !string.IsNullOrWhiteSpace(txtSuppPhoneNo.Text) && !string.IsNullOrWhiteSpace( txtSupFullName.Text) && !string.IsNullOrWhiteSpace(txtSuppEmail.Text) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {

        }
        //Add Supplier
        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            if (ValidSupplier())
            {
                String query = "INSERT INTO Supplier(ID, FirstName, LastName, Phone, Email, City, Address, Balance) VALUES(@FirstName, @LastName, @Phone, @Email, @City, @Address, @Balance)";
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True"))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO Suppliers (ID, Email, FullName, Product, address, PhoneNo) VALUES (@ID, @FullName,  @Email, @address, @PhoneNo)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        try
                        {
                            connection.Open();
                            cmd.Parameters.AddWithValue("@ID", txtSuppID.Text);
                            cmd.Parameters.AddWithValue("@Email", txtSuppEmail.Text);
                            cmd.Parameters.AddWithValue("@FullName", txtSupFullName.Text);
                            cmd.Parameters.AddWithValue("@Product", txtSuppProduct.Text);
                            cmd.Parameters.AddWithValue("@address", txtSuppAddress.Text);
                            cmd.Parameters.AddWithValue("@PhoneNo", txtSuppPhoneNo.Text);
                            cmd.ExecuteNonQuery();
                            //customersDataTable.Clear();
                            //loadCustomerDataFromDB();
                            MessageBox.Show("Successfully Added New Supplier");
                        }
                        catch
                        {
                            MessageBox.Show("ERROR while creating Supplier");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }

            }
        }
        //Update Supplier
        private void btnUpdateSupp_Click(object sender, EventArgs e)
        {
            if (ValidSupplier())
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True"))
                {
                    String query = "UPDATE Supplier SET ID=@ID,  FullName=@FullName, Product=@Product, Address=@Address, PhoneNo=@PhoneNo";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@ID", txtSuppID.Text);
                            sqlCommand.Parameters.AddWithValue("@FullName", txtSupFullName.Text);
                            sqlCommand.Parameters.AddWithValue("@Product", txtSuppProduct.Text);
                            sqlCommand.Parameters.AddWithValue("@Address", txtSuppAddress.Text);
                            sqlCommand.Parameters.AddWithValue("@PhoneNo", txtSuppPhoneNo.Text);
                            sqlCommand.ExecuteNonQuery();
                            //customersDataTable.Clear();
                            //loadCustomerDataFromDB();
                            MessageBox.Show("Successfully Updated Supplier");
                        }
                        catch
                        {
                            MessageBox.Show("ERROR while updating Supplier");
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

        private void btnSearchSupp_Click(object sender, EventArgs e)
        {

        }
        //Delete Supplier
        private void btnDeleteSupp_Click(object sender, EventArgs e)
        {
            if (ValidSupplier())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Employee?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True"))
                    {
                        String query = "DELETE FROM Employee WHERE EmployeeID=@EmployeeID";
                        using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Parameters.AddWithValue("@EmployeeID", int.Parse(txtSuppID.Text));
                                sqlCommand.ExecuteNonQuery();
                                //customersDataTable.Clear();
                                //loadCustomerDataFromDB();
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

        private void dataGridViewSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewSupplier.SelectedRows.Count == 1)
            {
                txtSuppID.Text = dataGridViewSupplier.SelectedCells[0].Value.ToString();
                txtSuppEmail.Text = dataGridViewSupplier.SelectedCells[1].Value.ToString();
                txtSupFullName.Text = dataGridViewSupplier.SelectedCells[2].Value.ToString();
                txtSuppProduct.Text = dataGridViewSupplier.SelectedCells[3].Value.ToString();
                txtSuppAddress.Text = dataGridViewSupplier.SelectedCells[4].Value.ToString();
                txtSuppPhoneNo.Text = dataGridViewSupplier.SelectedCells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void txtSupFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSuppEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
