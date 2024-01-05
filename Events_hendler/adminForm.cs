using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_hendler
{
    public partial class adminForm : Form
    {
        public MySqlConnection connection;
        private string server = "localhost";
        private string database = "event_hendler";
        private string uid = "root";
        private string password = "";

        public adminForm()
        {
            InitializeComponent();
            InitializeDatabase();
            eventNameAdd.Visible = false;
            eventDateAdd.Visible = false;
            AddBtn.Visible = false;
            if (this.dateTime.Value == new DateTime(2024, 01, 05))
            {
                this.event1.Text = "Event 1";
            }
            else if (dateTime.Value == new DateTime(2024, 02, 10))
            {
                event1.Text = "Event 2";
            }
            else if (dateTime.Value == new DateTime(2024, 02, 12))
            {
                event1.Text = "Event 3";
            }
            else if (dateTime.Value == new DateTime(2024, 02, 19))
            {
                event1.Text = "Event 4";
            }
            else if (dateTime.Value == new DateTime(2024, 02, 28))
            {
                event1.Text = "Event 5";
            }
            else if (dateTime.Value == new DateTime(2024, 03, 17))
            {
                event1.Text = "Event 6";
            }
        }

        private void InitializeDatabase()
        {
            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        private void showUser()
        {
            string query = "SELECT COUNT(*) FROM users";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {

                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                connection.Close();

                this.userCount.Text = $"{userCount}";
            }
        }

        private void userDetails()
        {
            string query = "select * from users";
            using(MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                connection.Open();
                using(MySqlDataReader column = cmd.ExecuteReader())
                {
                    while (column.Read())
                    {
                        string nama = column["nama"]?.ToString();
                    }

                }
            }
        }

        private void userCount_Click(object sender, EventArgs e)
        {
            showUser();
            userDetails();
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.eventList.Items.Clear();
            string query = "select * from alasan";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader column = cmd.ExecuteReader())
                {
                    while (column.Read())
                    {
                        string nama = column["nama"]?.ToString();
                        string alasan = column["alasan"]?.ToString();
                        string itemToShow = $"{nama}: {alasan}";

                        eventList.Items.Add(itemToShow);
                    }

                }
            }
        }

        private void event1_Click(object sender, EventArgs e)
        {
            showEvent1();
        }

        private void showEvent1()
        {
            string query = "SELECT * FROM absen_event1";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                if(connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string peserta = reader["nama"]?.ToString();
                        string keterangan = reader["keterangan"]?.ToString();
                        if (peserta == null || keterangan == null)
                        {
                            absenList.Items.Add("Null");
                            keteranganAbsen.Items.Add("Null");
                        }
                        else
                        {
                            absenList.Items.Add(peserta);
                            keteranganAbsen.Items.Add(keterangan);
                        }
                    }
                }
            }
        }

        private void showEvent2()
        {
            string query = "SELECT * FROM absen_event2";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                if(connection.State != ConnectionState.Open)
                {
                    connection.Open();

                }
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string peserta = reader["nama"]?.ToString();
                        string keterangan = reader["keterangan"]?.ToString();
                        if(peserta == null  || keterangan == null)
                        {
                            absenList.Items.Add("Null");
                            keteranganAbsen.Items.Add("Null");
                        }
                        else
                        {
                            absenList.Items.Add(peserta);
                            keteranganAbsen.Items.Add(keterangan);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eventNameAdd.Visible = true;
            eventDateAdd.Visible = true;
            AddBtn.Visible = true;
            AddBtn.Text = "Add";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(this.AddBtn.Text == "Add")
            {
                string namaEvent = eventNameAdd.Text;
                string dateEvent = eventDateAdd.Text;
                string query = $"INSERT INTO events values('{namaEvent}','{dateEvent}')";
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if(connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("Event berhasil ditambahkan");
                }
            }
            else if(this.AddBtn.Text == "Delete")
            {
                string namaEvent = eventNameAdd.Text;
                string dateEvent = eventDateAdd.Text;
                string query = $"DELETE FROM events WHERE event_name = '{namaEvent}'";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("Event berhasil dihapus");
                }
            }
        }

        private void ShowEventsList_Click(object sender, EventArgs e)
        {
            this.eventList.Items.Clear();
            string query = "select * from events";
            List<string> events = GetUserNames();

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                if(connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string namaEvent = reader["event_name"].ToString();
                        string dateEvent = reader["event_date"].ToString();
                        string showAll = $"{namaEvent} {dateEvent}";
                        this.eventList.Items.Add(showAll);
                    }
                }
            }
        }

        private List<string> GetUserNames()
        {
            List<string> eventName = new List<string>();
            List<string> eventDate = new List<string>();
            string query = "SELECT * FROM events";

            // Pastikan koneksi sudah terbuka
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Mengakses semua nama pengguna
                        string nama = reader.GetString(0); // Ubah angka indeks kolom sesuai dengan struktur tabel Anda
                        string date = reader.GetString(1);
                        eventName.Add(nama);
                        eventDate.Add(date);
                        return eventDate;
                    }
                }
            }

            return eventName;
        }

        private void event2_Click(object sender, EventArgs e)
        {
            showEvent2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            eventNameAdd.Visible = true;
            eventDateAdd.Visible = true;
            AddBtn.Visible = true;
            this.AddBtn.Text = "Delete";
        }
    }
}
