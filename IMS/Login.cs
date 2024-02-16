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
    public partial class LoginForm : Form
    {
        private string responseMessage;

        public LoginForm()
        {
           
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True");
        

       

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void txtLoginName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }
        //Login 
        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
               
                string query = "SELECT * FROM Login WHERE username = '" + txtLoginName.Text + "' AND password = '" + txtLoginPassword.Text + "'";
                // Execute the query and process the result
                using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-F70OSGES\SQLEXPRESS;Initial Catalog=ConnectionDb;Integrated Security=True"))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    SqlCommand command = new SqlCommand(query, connection);
                    
                    // Execute the query and process the result
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Login successful
                        MessageBox.Show("Login successful");

                        // Redirect to the dashboard
                        DashboardForm dashboardForm = new DashboardForm();
                        dashboardForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid username or password");
                    }

                    reader.Close();
                }
            }
            catch
            {

            }

        }
        // Validate Sign-In
        private void validateResponseMessage()
        {
            if (responseMessage == "Successful Login" || responseMessage.Equals("Successful Login"))
            {
                this.Hide();
                DashboardForm dashboard = new DashboardForm();
                dashboard.Closed += (s, args) => this.Close();
                dashboard.Show();
            }
            else
            {

            }
        }
        //Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLoginName.Text = "";
            txtLoginPassword.Text = "";
        }
    }

}

