using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganStienus
{
    public partial class Pengaturan_TambahAkun : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        public MainMenu main { get; set; }
        private string uname, pass, passR,pswdh;
        private string tempA;

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
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlConnectionString"].ConnectionString);
            string getcred = "Select * from logincr where username=@uname";
            cmd = new MySqlCommand(getcred, conn);
            cmd.Parameters.AddWithValue("@uname", uname);
            conn.Open();
            //membaca database mengecek kesamaan username
            using (MySqlDataReader oReader = cmd.ExecuteReader())
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
                cmd = new MySqlCommand("insert into logincr values(@uname, @pswdh)", conn);
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
