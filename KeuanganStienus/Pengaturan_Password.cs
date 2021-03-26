using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Configuration;

namespace KeuanganStienus
{
    public partial class Pengaturan_Password : Form
    {
        private const string selectQuery = "select * from logincr where username='master'";
        MySqlConnection conn;
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
            pwd = passwordHashing(tbPassword.Text);                 //hash password
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);             //buat SqlConnection
            cmd = new MySqlCommand(selectQuery, conn);                //buat SqlCommand
            conn.Open();                                    
            using(reader = cmd.ExecuteReader())                     //membaca tabel menggunakan reader dengan command dari SqlCommand
            {
                while(reader.Read())
                {
                    temp = reader["password"].ToString();           //membaca password
                }
                conn.Close();
                if(pwd==temp)
                {
                    switch(opsi)
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

        private string passwordHashing(string pass)
        {
            SHA256Managed MyHash = new SHA256Managed();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] hash = MyHash.ComputeHash(data);
            string hashstr = System.Text.Encoding.ASCII.GetString(hash);
            return hashstr;
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
