using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Events_hendler
{
    public partial class halamanUtama : Form
    {
        public MySqlConnection connect;
        private string server = "localhost";
        private string database = "event_hendler";
        private string uid = "root";
        private string password = "";
        public string alasanText;
        private string namaUser;
        private string event1Name;
        private string event2Name;
        private string event3Name;
        private string event4Name;
        private string event5Name;
        private string event6Name;

        public halamanUtama(string nama)
        {
            InitializeComponent();
            InitializeDatabase();
            namaUser = nama.ToString();
            namaPeserta.Text = namaUser;
            getEventName();
        }

        private void getEventName()
        {
            List<string> allUserNames = GetUserNames();
            List<string> dateEvent = GetEventDate();

            // Mengakses nama pengguna dalam List
            if (allUserNames.Count > 0)
            {
                string nama1 = allUserNames[0];
                string nama2 = allUserNames.Count > 1 ? allUserNames[1] : string.Empty;
                string nama3 = allUserNames.Count > 2 ? allUserNames[2] : string.Empty;
                string nama4 = allUserNames.Count > 3 ? allUserNames[3] : string.Empty;
                string nama5 = allUserNames.Count > 4 ? allUserNames[4] : string.Empty;
                string nama6 = allUserNames.Count > 5 ? allUserNames[5] : string.Empty;

                event1Name = nama1;
                event2Name = nama2;
                event3Name = nama3;
                event4Name = nama4;
                event5Name = nama5;
                event6Name = nama6;

                label2.Text = nama1;
                label3.Text = nama2;
                label4.Text = nama3;
                label5.Text = nama4;
                label19.Text = nama5;
            }
            else if(dateEvent.Count > 0)
            {
                string date1 = dateEvent[0];
                string date2 = dateEvent.Count > 1 ? dateEvent[1] : string.Empty;
                string date3 = dateEvent.Count > 2 ? dateEvent[2] : string.Empty;
                string date4 = dateEvent.Count > 3 ? dateEvent[3] : string.Empty;
                string date5 = dateEvent.Count > 4 ? dateEvent[4] : string.Empty;
                label3.Text = date1;

                if(label2.Text == event1Name && calenderEvent.TodayDate.ToString() == date1)
                {
                    this.label6.ForeColor = Color.Green;
                    this.hadirBtn.BackColor = Color.Green;
                    this.izinBtn.BackColor = Color.PaleGreen;
                    this.namaPeserta.Text = namaUser;
                    this.pesertaEvent2.Text = "";
                }
                else if(label3.Text == event2Name && calenderEvent.TodayDate.ToString() == date2)
                {
                    this.label7.ForeColor = Color.Green;
                    this.hadirBtn2.BackColor = Color.Green;
                    this.izinBtn2.BackColor = Color.PaleGreen;
                    this.pesertaEvent2.Text = namaUser;
                    this.namaPeserta.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tidak ada nama pengguna yang ditemukan.");
            }
        }

        private List<string> GetUserNames()
        {
            List<string> userNames = new List<string>();
            string query = "SELECT * FROM events";

            // Pastikan koneksi sudah terbuka
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }

            using (MySqlCommand cmd = new MySqlCommand(query, connect))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Mengakses semua nama pengguna
                        string nama = reader.GetString(0); // Ubah angka indeks kolom sesuai dengan struktur tabel Anda
                        userNames.Add(nama);
                    }
                }
            }
            return userNames;
        }

        private List<string> GetEventDate()
        {
            List<string> dateEvent = new List<string>();
            string query = "SELECT * FROM events";

            // Pastikan koneksi sudah terbuka
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }

            using (MySqlCommand cmd = new MySqlCommand(query, connect))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string date = reader.GetString(1);
                        dateEvent.Add(date);
                    }
                }
            }
            return dateEvent;
        }

        private void InitializeDatabase()
        {
            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connect = new MySqlConnection(connectionString);
        }

        private void namaPeserta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void absen()
        {
            string namaPesertaValue = namaPeserta.Text;
            string rolePesertaValue = rolePeserta.Text;

            // Validasi jika TextBox kosong atau tidak
            if (string.IsNullOrWhiteSpace(namaPesertaValue) || string.IsNullOrWhiteSpace(rolePesertaValue))
            {
                MessageBox.Show("Mohon isi semua kolom.");
                return;
            }

            // Gunakan parameterized query untuk mencegah SQL Injection
            string queryString = "INSERT INTO absen_event1 VALUES (@nama, @role, 'hadir')";

            using (MySqlCommand command = new MySqlCommand(queryString, connect))
            {
                command.Parameters.AddWithValue("@nama", namaPesertaValue);
                command.Parameters.AddWithValue("@role", rolePesertaValue);
                if(connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void absen2()
        {
            string namaPesertaValue = namaPeserta.Text;
            string rolePesertaValue = rolePeserta.Text;

            // Validasi jika TextBox kosong atau tidak
            if (string.IsNullOrWhiteSpace(namaPesertaValue) || string.IsNullOrWhiteSpace(rolePesertaValue))
            {
                MessageBox.Show("Mohon isi semua kolom.");
                return;
            }

            // Gunakan parameterized query untuk mencegah SQL Injection
            string queryString = "INSERT INTO absen_event2 VALUES (@nama, @role, 'hadir')";

            using (MySqlCommand command = new MySqlCommand(queryString, connect))
            {
                command.Parameters.AddWithValue("@nama", namaPesertaValue);
                command.Parameters.AddWithValue("@role", rolePesertaValue);

                connect.Open();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void hadirBtn_Click(object sender, EventArgs e)
        {
            absen();
        }

        private void izinBtn_Click(object sender, EventArgs e)
        {
            string namaPesertaValue = namaPeserta.Text;
            string rolePesertaValue = rolePeserta.Text;
            this.Hide();

            alasanForm form2 = new alasanForm(namaPesertaValue);
            form2.Show();

            string queryString = "INSERT INTO absen_event1 VALUES (@nama, @role, 'izin')";
            using (MySqlCommand command = new MySqlCommand(queryString, connect))
            {
                command.Parameters.AddWithValue("@nama", namaPesertaValue);
                command.Parameters.AddWithValue("@role", rolePesertaValue);
                if(connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void hadirBtn2_Click(object sender, EventArgs e)
        {
            absen2();
        }

        private void izinBtn2_Click(object sender, EventArgs e)
        {
            string namaPesertaValue = namaPeserta.Text;
            string rolePesertaValue = rolePeserta.Text;
            this.Hide();

            alasanForm form2 = new alasanForm(namaPesertaValue);
            form2.Show();

            string queryString = "INSERT INTO absen_event2 VALUES (@nama, @role, 'izin')";
            using (MySqlCommand command = new MySqlCommand(queryString, connect))
            {
                command.Parameters.AddWithValue("@nama", namaPesertaValue);
                command.Parameters.AddWithValue("@role", rolePesertaValue);

                connect.Open();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void calenderEvent_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
