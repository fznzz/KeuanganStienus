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
        MySqlCommand cmd, cmd2;
        MySqlDataReader reader;
        private string pswd,tempA,tempB,uname,pswdh;
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
                pswd = hash.passwordHashing(tbNewPass.Text);
                var (sshClient, localPort) = ssh.ConnectSsh();
                using (sshClient)
                {
                    MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                    using (var connection = new MySqlConnection(csb.ConnectionString))
                    {
                        cmd = new MySqlCommand(selectQuery, connection);
                        cmd.Parameters.AddWithValue("@uname", tbUname.Text);
                        connection.Open();
                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tempA = reader["username"].ToString();
                                tempB = reader["password"].ToString();
                            }
                            connection.Close();
                            uname = tbUname.Text;
                            pswdh = hash.passwordHashing(tbOldPass.Text);
                            if (tempA == uname && tempB == pswdh)
                            {
                                //change password
                                cmd2 = new MySqlCommand(updateQuery, connection);
                                cmd2.Parameters.AddWithValue("@pswd", pswd);
                                cmd2.Parameters.AddWithValue("@uname", uname);
                                connection.Open();
                                cmd2.ExecuteNonQuery();
                                connection.Close();
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
            }
        }
    }
}
