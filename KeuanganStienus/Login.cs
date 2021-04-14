using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace KeuanganStienus
{
    public partial class Form1 : Form
    {
        string uname, pswd, pswdh;
        string tempA, tempB;
        public Form1()
        {
            InitializeComponent();
        }
        private void tbUname_KeyDown(object sender, KeyEventArgs e)
        {
            //QoL: enter, keys to move pointer
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
            if (e.KeyCode == Keys.Up)
            {
                this.SelectNextControl((Control)sender, false, true, true, true);
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            //QoL: enter, keys to move pointer
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                loginClick();
            }
            if (e.KeyCode == Keys.Up)
            {
                this.SelectNextControl((Control)sender, false, true, true, true);
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void loginClick()
        {
            uname = tbUname.Text;
            pswd = tbPass.Text;
            pswdh = hash.passwordHashing(pswd);
            var (sshClient, localPort) = ssh.ConnectSsh();
            using (sshClient)
            {
                MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                using (var connection = new MySqlConnection(csb.ConnectionString))
                {
                    string getcred = "Select * from logincr where username=@uname";
                    MySqlCommand oCmd = new MySqlCommand(getcred, connection);
                    oCmd.Parameters.AddWithValue("@uname", uname);
                    connection.Open();
                    using (MySqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            tempA = oReader["username"].ToString();
                            tempB = oReader["password"].ToString();
                        }
                        connection.Close();
                        if (tempB == pswdh && tempA == uname)
                        {
                            callMain();
                        }
                        else
                        {
                            MessageBox.Show("Username and password doesn't match or is not exist");
                        }
                    }
                }
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            if(tbUname.Text== "pQ$wQ4_S")
            {
                uname = "First Time Login";
                loginClick();
            }
            else
            {
                loginClick();
            }
        }
        private void callMain()
        {
            var frm = new MainMenu();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.currentadmin = uname;
            frm.deployInitData();
            this.Hide();
            tbUname.Clear();
            tbPass.Clear();
            frm.ShowDialog();
            this.Show();
        }
    }
}
