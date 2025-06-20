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
using System.Configuration;

namespace Hospital_Management
{
    public partial class FormHospitalManagementSystem : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HospitalManagementSystem"].ConnectionString;
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        
        public FormHospitalManagementSystem()
        {
            InitializeComponent();
        }
        private void FormHospitalManagementSystem_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cnn.Close();

        }

        private void labelDatabaseConfiguration_Click(object sender, EventArgs e)
        {


        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string query = "SELECT COUNT(*) FROM tbUsers WHERE Username=@username AND PasswordHash=@password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = (int)command.ExecuteScalar();

                        Console.WriteLine(count);

                        if (count > 0)
                        {
                            //MessageBox.Show("Login successful!");
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }

    }
}

