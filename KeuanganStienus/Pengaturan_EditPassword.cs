using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace KeuanganStienus
{
    public partial class Pengaturan_EditPassword : Form
    {
        private const string selectQuery = "select * from logincr where username=@uname";
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
        private string pswdh;

        public Pengaturan_EditPassword()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            backClick();
        }

        private void backClick()
        {
            main.changePanelBack();
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
                editPass();
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            editPass();
        }
        private void editPass()
        {
            if (tbNewPass.Text != tbNewPassRepeat.Text)
            {
                MessageBox.Show("Password baru tidak cocok");
            }
            else
            {
                pswd = passwordHashing(tbNewPass.Text);
                conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
                cmd = new MySqlCommand(selectQuery, conn);
                cmd.Parameters.AddWithValue("@uname", tbUname.Text);
                conn.Open();
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tempA = reader["username"].ToString();
                        tempB = reader["password"].ToString();
                    }
                    conn.Close();
                    uname = tbUname.Text;
                    pswdh = passwordHashing(tbOldPass.Text);
                    if (tempA == uname && tempB == pswdh)
                    {
                        //change password
                        conn2 = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
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
                        MessageBox.Show("Password lama salah");
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
    }
}
