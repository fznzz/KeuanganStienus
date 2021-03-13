using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganStienus
{
    public partial class Pengaturan_KelolaAkun_Uname : Form
    {
        private const string updateQuery = "update logincr set username=@unamenew where username=@unameold";
        public MainMenu main { get; set; }
        public Pengaturan_KelolaAkun kelolaAkun { get; set; }
        public string unameOld { get; set; }
        MySqlConnection conn;
        MySqlCommand cmd;
        public Pengaturan_KelolaAkun_Uname()
        {
            InitializeComponent();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            resetUname();
        }

        private void resetUname()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlConnectionString"].ConnectionString);
            cmd = new MySqlCommand(updateQuery, conn);
            var unameNew = tbUnameNew.Text;
            cmd.Parameters.AddWithValue("@unameold", unameOld);
            cmd.Parameters.AddWithValue("@unamenew", unameNew);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil mengganti username");
            conn.Close();
            back();
        }

        public void deployData()
        {
            tbUname.Text = unameOld;
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            back();
        }
        private void back()
        {
            kelolaAkun.refreshAkun();
            main.changePanelBack();
            main.formlevel = 1;
            this.Dispose();
        }

        private void tbUnameNew_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                resetUname();
            }
        }
    }
}
