using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeuanganStienus
{
    public partial class Pengaturan_TambahAkun : Form
    {
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        SqlConnection conn;
        SqlCommand cmd;
        public MainMenu main { get; set; }
        private string uname, pass, passR,pswdh;
        private string tempA;
        private string tempB;

        public Pengaturan_TambahAkun()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            back();
        }

        private void back()
        {
            main.changePanelBack();
            this.Dispose();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            tambahAkun();
        }

        private void tbNewPassRepeat_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                tambahAkun();
            }
        }

        private void tambahAkun()
        {
            uname = tbUname.Text;
            pass = tbNewPass.Text;
            passR = tbNewPassRepeat.Text;
            if(pass==passR)
            {
                DialogResult result = MessageBox.Show("Apakah data yang dimasukkan sudah benar?", "Peringatan!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result==DialogResult.Yes)
                {
                    //do somthing yes
                    createClick();
                }
            }
            else
            {
                MessageBox.Show("Password tidak cocok");
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
        private void createClick()
        {
            pswdh = passwordHashing(pass);
            conn = new SqlConnection(ConnectionString);
            string getcred = "Select * from logincr where username=@uname";
            SqlCommand oCmd = new SqlCommand(getcred, conn);
            oCmd.Parameters.AddWithValue("@uname", uname);
            conn.Open();
            //membaca database mengecek kesamaan username
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    tempA = oReader["username"].ToString();
                }

            }
            if (tempA == uname)
            {
                MessageBox.Show("username sudah ada");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into logincr values(@uname, @pswdh)", conn);
                cmd.Parameters.AddWithValue("@uname", uname);
                cmd.Parameters.AddWithValue("@pswdh", pswdh);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Akun berhasil dibuat");
            }
            conn.Close();
            back();
        }
    }
}
