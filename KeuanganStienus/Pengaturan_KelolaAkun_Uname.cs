using System;
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
            var (sshClient, localPort) = ssh.ConnectSsh();
            using (sshClient)
            {
                MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                using (var connection = new MySqlConnection(csb.ConnectionString))
                {
                    cmd = new MySqlCommand(updateQuery, connection);
                    var unameNew = tbUnameNew.Text;
                    cmd.Parameters.AddWithValue("@unameold", unameOld);
                    cmd.Parameters.AddWithValue("@unamenew", unameNew);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil mengganti username");
                    connection.Close();
                    back();
                }
            }
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
