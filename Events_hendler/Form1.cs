using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Events_hendler
{
    public partial class Form1 : Form
    {
        public MySqlConnection connection;
        private string server = "localhost";
        private string database = "event_hendler";
        private string uid = "root";
        private string password = "";

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        public void InitializeDatabase()
        {
            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void passUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users WHERE username=@username AND password=@password";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@username", userName.Text);
                cmd.Parameters.AddWithValue("@password", passUser.Text);

                connection.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string retrievedUserRole = reader["role"].ToString();
                        string nama = reader["nama"].ToString();
                        if (retrievedUserRole == "admin")
                        {
                            MessageBox.Show("Login successful!");
                            this.Hide();

                            adminForm MainFrom = new adminForm();
                            MainFrom.Show();
                        }
                        else if(retrievedUserRole == "user")
                        {
                            MessageBox.Show("Login successful!");
                            this.Hide();

                            halamanUtama mainFrom = new halamanUtama(nama);
                            mainFrom.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials. Please try again.");
                    }
                }
                connection.Close();
            }
        }
    }
}
