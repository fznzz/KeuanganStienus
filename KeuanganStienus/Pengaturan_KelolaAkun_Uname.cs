using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeuanganStienus
{
    public partial class Pengaturan_KelolaAkun_Uname : Form
    {
        private const string updateQuery = "update logincr set username=@unamenew where username=@unameold";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";

        public MainMenu main { get; set; }
        public Pengaturan_KelolaAkun kelolaAkun { get; set; }
        public string unameOld { get; set; }
        SqlConnection conn;
        SqlCommand cmd;
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
            conn = new SqlConnection(ConnectionString);
            cmd = new SqlCommand(updateQuery, conn);
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
