using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganStienus
{
    public partial class Pengaturan_KelolaAkun_Pass : Form
    {
        private const string selectQuery = "select username from logincr where username=@uname";
        private const string updateQuery = "update logincr set password=@pswd where username=@uname";
        public MainMenu main { get; set; }
        public string currentAdmin { get; set; }
        MySqlConnection conn, conn2;
        MySqlCommand cmd, cmd2;
        MySqlDataReader reader;
        private string pswd;
        private string tempA;
        private string tempB;
        private string uname;

        private void btNext_Click(object sender, EventArgs e)
        {
            resetPass();
        }
        private void resetPass()
        {
            if (tbNewPass.Text != tbNewPassRepeat.Text)
            {
                MessageBox.Show("Password baru tidak cocok");
            }
            else
            {
                pswd = passwordHashing(tbNewPass.Text);
                conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlConnectionString"].ConnectionString);
                cmd = new MySqlCommand(selectQuery, conn);
                cmd.Parameters.AddWithValue("@uname", tbUname.Text);
                conn.Open();
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tempA = reader["username"].ToString();
                    }
                    conn.Close();
                    uname = tbUname.Text;
                    if (tempA == uname)
                    {
                        //change password
                        conn2 = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlConnectionString"].ConnectionString);
                        cmd2 = new MySqlCommand(updateQuery, conn2);
                        cmd2.Parameters.AddWithValue("@pswd", pswd);
                        cmd2.Parameters.AddWithValue("@uname", uname);
                        conn2.Open();
                        cmd2.ExecuteNonQuery();
                        conn2.Close();
                        MessageBox.Show("Password telah diganti");
                        backClick();
                    }
                    else
                    {
                        //password doesnt match
                        MessageBox.Show("Username tidak terdaftar");
                    }
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

        private void btBack_Click(object sender, EventArgs e)
        {
            backClick();
        }

        private void backClick()
        {
            main.changePanelBack();
            main.formlevel = 1;
            this.Dispose();
        }
        public void deployData()
        {
            tbUname.Text = currentAdmin;
        }

        private void tbNewPassRepeat_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                resetPass();
            }
        }

        private string pswdh;
        public Pengaturan_KelolaAkun_Pass()
        {
            InitializeComponent();
        }
    }
}
