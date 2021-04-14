using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganStienus
{
    public partial class EditTagihan_Password : Form
    {
        EditTagihan editTagihan;
        public MainMenu main { get; set; }
        private const string selectQuery = "select * from logincr where username='master'";
        MySqlCommand cmd;
        MySqlDataReader reader;
        string temp, pwd;
        public EditTagihan_Password()
        {
            InitializeComponent();
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            passwordChecker();
        }
        private void passwordChecker()
        {
            pwd = hash.passwordHashing(tbPassword.Text);
            var (sshClient, localPort) = ssh.ConnectSsh();
            using (sshClient)
            {
                MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                using (var connection = new MySqlConnection(csb.ConnectionString))
                {
                    cmd = new MySqlCommand(selectQuery, connection);
                    connection.Open();
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            temp = reader["password"].ToString();
                        }
                        connection.Close();
                        if (pwd == temp)
                        {
                            //go to next
                            editTagihan = new EditTagihan();
                            editTagihan.TopLevel = false;
                            editTagihan.AutoScroll = false;
                            editTagihan.main = main;
                            main.changePanelContent(editTagihan);
                            main.lastform1 = editTagihan;
                        }
                        else
                        {
                            MessageBox.Show("Maaf, password yang anda masukkan salah");
                        }
                    }
                }
            }
        }
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                passwordChecker();
            }
        }
    }
}
