using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace Events_hendler
{
    public partial class alasanForm : Form
    {
        private string namaPeserta;
        public MySqlConnection connect;
        private string server = "localhost";
        private string database = "event_hendler";
        private string uid = "root";
        private string password = "";

        public alasanForm(string nama)
        {
            InitializeComponent();
            InitializeDatabase();
            namaPeserta = nama.ToString();
        }

        private void InitializeDatabase()
        {
            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connect = new MySqlConnection(connectionString);
        }

        private void kirimBtn_Click(object sender, EventArgs e)
        {
            if(this.alasanText.Text == null)
            {
                MessageBox.Show("Please fill the reason form first");
            }
            else
            {
                string namaNew = namaPeserta.ToString();
                string alasan = this.alasanText.Text;

                halamanUtama newOne = new halamanUtama(namaNew);
                newOne.Show();

                string query = $"insert into alasan values ('{namaNew}', '{alasan}')";
                using(MySqlCommand cmd = new MySqlCommand(query, connect))
                {
                    connect.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Alasan berhasil dikirim");
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
        }
    }
}
