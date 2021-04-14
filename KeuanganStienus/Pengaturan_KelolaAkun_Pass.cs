using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace KeuanganStienus
{
    public partial class Pengaturan_KelolaAkun_Pass : Form
    {
        private const string selectQuery = "select username from logincr where username=@uname";
        private const string updateQuery = "update logincr set password=@pswd where username=@uname";
        public MainMenu main { get; set; }
        public string currentAdmin { get; set; }
        MySqlCommand cmd, cmd2;
        MySqlDataReader reader;
        private string pswd;
        private string temp;
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
                var (sshClient, localPort) = ssh.ConnectSsh();
                using (sshClient)
                {
                    MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);

                    using (var connection = new MySqlConnection(csb.ConnectionString))
                    {
                        pswd = passwordHashing(tbNewPass.Text);
                        cmd = new MySqlCommand(selectQuery, connection);
                        cmd.Parameters.AddWithValue("@uname", tbUname.Text);
                        connection.Open();
                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                temp = reader["username"].ToString();
                            }
                            connection.Close();
                            uname = tbUname.Text;
                            if (temp == uname)
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
                                MessageBox.Show("Username tidak terdaftar");
                            }
                        }
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
        public Pengaturan_KelolaAkun_Pass()
        {
            InitializeComponent();
        }
    }
}
