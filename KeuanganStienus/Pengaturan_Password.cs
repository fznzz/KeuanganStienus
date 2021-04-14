using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganStienus
{
    public partial class Pengaturan_Password : Form
    {
        private const string selectQuery = "select * from logincr where username='master'";
        MySqlCommand cmd;
        MySqlDataReader reader;
        string temp, pwd;
        public MainMenu main { get; set; }
        public Pengaturan pengaturan { get; set; }
        public string opsi { get; set; }
        public Pengaturan_Password()
        {
            InitializeComponent();
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            passwordChecker();                                      //panggil fungsi passwordChecker
        }
        private void passwordChecker()
        {
            if (opsi == "hapus")
            {
                pengaturan.bukaHapusAkun();
                this.Dispose();
            }
            else
            {
                pwd = hash.passwordHashing(tbPassword.Text);
                var (sshClient, localPort) = ssh.ConnectSsh();
                using (sshClient)
                {
                    MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                    using (var connection = new MySqlConnection(csb.ConnectionString))
                    {
                        cmd = new MySqlCommand(selectQuery, connection);                //buat SqlCommand
                        connection.Open();
                        using (reader = cmd.ExecuteReader())                     //membaca tabel menggunakan reader dengan command dari SqlCommand
                        {
                            while (reader.Read())
                            {
                                temp = reader["password"].ToString();           //membaca password
                            }
                            connection.Close();
                            if (pwd == temp)
                            {
                                switch (opsi)
                                {
                                    case "tambah":                              //buka pengaturan tambah akun

                                        pengaturan.bukaTambahAkun();
                                        this.Dispose();
                                        break;
                                    case "hapus":                               //buka pengaturan hapus akun
                                        pengaturan.bukaHapusAkun();
                                        this.Dispose();
                                        break;
                                    case "perubahan":
                                        pengaturan.bukaPerubahan();
                                        this.Dispose();
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Maaf, password yang anda masukkan salah");
                            }
                        }
                    }
                }
            }
        }
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                passwordChecker();
            }
        }
    }
}
