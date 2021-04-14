using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganStienus
{
    public partial class Pengaturan_TambahAkun : Form
    {
        MySqlCommand cmd;
        public MainMenu main { get; set; }
        private string uname, pass, passR, pswdh, tempA;
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
        private void createClick()
        {
            pswdh = hash.passwordHashing(pass);
            var (sshClient, localPort) = ssh.ConnectSsh();
            using (sshClient)
            {
                MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                using (var connection = new MySqlConnection(csb.ConnectionString))
                {
                    string getcred = "Select * from logincr where username=@uname";
                    cmd = new MySqlCommand(getcred, connection);
                    cmd.Parameters.AddWithValue("@uname", uname);
                    connection.Open();
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
                        cmd = new MySqlCommand("insert into logincr values(@uname, @pswdh)", connection);
                        cmd.Parameters.AddWithValue("@uname", uname);
                        cmd.Parameters.AddWithValue("@pswdh", pswdh);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Akun berhasil dibuat");
                    }
                    connection.Close();
                    back();
                }
            }
        }
    }
}
