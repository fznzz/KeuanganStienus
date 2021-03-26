using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace KeuanganStienus
{
    public partial class EditTagihan_Password : Form
    {
        EditTagihan editTagihan;
        public MainMenu main { get; set; }
        private const string selectQuery = "select * from logincr where username='master'";
        MySqlConnection conn;
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
            pwd = passwordHashing(tbPassword.Text);
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
            cmd = new MySqlCommand(selectQuery, conn);
            conn.Open();
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    temp = reader["password"].ToString();
                }
                conn.Close();
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
        private string passwordHashing(string pass)
        {
            SHA256Managed MyHash = new SHA256Managed();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] hash = MyHash.ComputeHash(data);
            string hashstr = System.Text.Encoding.ASCII.GetString(hash);
            return hashstr;
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
