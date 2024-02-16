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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        DataTable EmployeeDatatable = new DataTable();


        //To Load Employee Data

        private void loadEmployeeDataFromDB()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True"))
            {
                String query = "SELECT * FROM Employee";
                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        adapter.Fill(EmployeeDatatable);
                        dataGridEmployee.DataSource = EmployeeDatatable;
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
            if (txtEmployeeCode.Text != "" && txtEmployeeFirstName.Text != "" && txtEmployeeLastName.Text != "" && txtEmployeeDateOfBirth.Text != "" && txtEmployeeEmail.Text != "" && txtemployeeGender.Text != "" && txtEmployeeAddress.Text != "" && txtEmployeePhone.Text !="")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            if (validCustomer())
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True"))
                {
                    String query = "INSERT INTO Employee(Code, Name,  Date of birth, Email,Password, Gender, Address,Status, Phone No) VALUES(@Code, @FirstName, @LastName, @DateOfBirth, @Email, @Gender, @Address, @Phone)";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@Code", txtEmployeeCode.Text);
                            sqlCommand.Parameters.AddWithValue("@FirstName", txtEmployeeFirstName.Text);
                            sqlCommand.Parameters.AddWithValue("@LastName", txtEmployeeLastName.Text);
                            sqlCommand.Parameters.AddWithValue("@DateOfBirth", txtEmployeeDateOfBirth.Text);
                            sqlCommand.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text);
                            sqlCommand.Parameters.AddWithValue("@Gender", txtemployeeGender.Text);
                            sqlCommand.Parameters.AddWithValue("@Address", txtEmployeeAddress.Text);
                            sqlCommand.Parameters.AddWithValue("@Phone", txtEmployeePhone.Text);
                            sqlCommand.ExecuteNonQuery();
                            txtEmployeeCode.Text= txtEmployeeFirstName.Text=txtEmployeeLastName.Text=txtEmployeeDateOfBirth.Text=txtEmployeeEmail.Text=txtemployeeGender.Text=txtEmployeeAddress.Text=txtEmployeePhone.Text="";

                            EmployeeDatatable.Clear();
                            loadEmployeeDataFromDB();
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

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (validCustomer())
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True"))
                {
                    String query = "UPDATE Employee SET Code=@Code,  FirstName=@FirstName, LastName=@LastName, Phone=@Phone,DateOfBirth=@DateOfBirth,  Email=@Email, Gender=@Gender Address=@Address, Phone=@Phone WHERE EmployeeCode=@EmployeeCode";
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            sqlCommand.CommandType = CommandType.Text;
                            sqlCommand.Parameters.AddWithValue("@FirstName", txtEmployeeCode.Text);
                            sqlCommand.Parameters.AddWithValue("@FirstName", txtEmployeeFirstName.Text);
                            sqlCommand.Parameters.AddWithValue("@LastName", txtEmployeeLastName.Text);
                            sqlCommand.Parameters.AddWithValue("@DateOfBirth", txtEmployeeDateOfBirth.Text);
                            sqlCommand.Parameters.AddWithValue("@Email", txtEmployeeEmail.Text);
                            sqlCommand.Parameters.AddWithValue("@Gender", txtemployeeGender.Text);
                            sqlCommand.Parameters.AddWithValue("@Address", txtEmployeeAddress.Text);
                            sqlCommand.Parameters.AddWithValue("@Phone", txtEmployeePhone.Text);
                            sqlCommand.ExecuteNonQuery();
                            EmployeeDatatable.Clear();
                            loadEmployeeDataFromDB();
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

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (validCustomer())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this customer?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True"))
                    {
                        String query = "DELETE FROM Employee WHERE EmployeeCode=@EmployeeCode";
                        using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                        {
                            try
                            {
                                connection.Open();
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Parameters.AddWithValue("@EmployeeCode", int.Parse(txtEmployeeCode.Text));
                                sqlCommand.ExecuteNonQuery();
                                EmployeeDatatable.Clear();
                                loadEmployeeDataFromDB();
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

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeDatatable.DefaultView.RowFilter = string.Format("FirstName LIKE '%{0}%'", comboBox1.Text);
        }

        private void dataGridEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridEmployee.SelectedRows.Count == 1)
            {
                txtEmployeeCode.Text = dataGridEmployee.SelectedCells[0].Value.ToString();
                txtEmployeeFirstName.Text = dataGridEmployee.SelectedCells[1].Value.ToString();
                txtEmployeeLastName.Text = dataGridEmployee.SelectedCells[2].Value.ToString();
                txtEmployeeDateOfBirth.Text = dataGridEmployee.SelectedCells[3].Value.ToString();
                txtEmployeeEmail.Text = dataGridEmployee.SelectedCells[4].Value.ToString();
                txtemployeeGender.Text = dataGridEmployee.SelectedCells[5].Value.ToString();
                txtEmployeeAddress.Text = dataGridEmployee.SelectedCells[6].Value.ToString();
                txtEmployeePhone.Text = dataGridEmployee.SelectedCells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
                    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
