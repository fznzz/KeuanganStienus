using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;


namespace KeuanganStienus
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        SqlConnection sqlconn;
        string uname, pswd, pswdh;
        string tempA, tempB;
        public Form1()
        {
            InitializeComponent();
        }

        public void initSqlConn()
        {
            
        }

        private void tbUname_KeyDown(object sender, KeyEventArgs e)
        {
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

        public string passwordHashing(string pass)
        {
            SHA256Managed MyHash = new SHA256Managed();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] hash = MyHash.ComputeHash(data);
            string hashstr = System.Text.Encoding.ASCII.GetString(hash);
            return hashstr;
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            createClick();
        }

        private void loginClick()
        {
            uname = tbUname.Text;
            pswd = tbPass.Text;
            pswdh = passwordHashing(pswd);
            sqlconn = new SqlConnection(ConnectionString);
            string getcred = "Select * from logincr where username=@uname";
            SqlCommand oCmd = new SqlCommand(getcred, sqlconn);
            oCmd.Parameters.AddWithValue("@uname", uname);
            sqlconn.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    tempA = oReader["username"].ToString();
                    tempB = oReader["password"].ToString();
                }
                sqlconn.Close();
                if (tempB == pswdh && tempA == uname)
                {
                    var frm = new MainMenu();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Show(); };
                    frm.Show();
                    this.Hide();
                    tbUname.Clear();
                    tbPass.Clear();
                }
                else
                {
                    MessageBox.Show("Username and password doesn't match or is not exist");
                }
            }
        }

        private void createClick()
        {
            uname = tbUname.Text;
            pswd = tbPass.Text;
            pswdh = passwordHashing(pswd);
            sqlconn = new SqlConnection(ConnectionString);
            string getcred = "Select * from logincr where username=@uname";
            SqlCommand oCmd = new SqlCommand(getcred, sqlconn);
            oCmd.Parameters.AddWithValue("@uname", uname);
            sqlconn.Open();
            //membaca database mengecek kesamaan username
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    tempA = oReader["username"].ToString();
                    tempB = oReader["password"].ToString();
                }
                
            }
            if (tempA == uname)
            {
                MessageBox.Show("username sudah ada");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into logincr values(@uname, @pswdh)", sqlconn);
                cmd.Parameters.AddWithValue("@uname", uname);
                cmd.Parameters.AddWithValue("@pswdh", pswdh);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully.");
            }
            sqlconn.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            loginClick();
        }
    }

}
