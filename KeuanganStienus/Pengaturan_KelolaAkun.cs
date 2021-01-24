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
    public partial class Pengaturan_KelolaAkun : Form
    {
        private const string selectQuery = "Select username from logincr";
        private const string deleteQuery = "delete from logincr where username=@uname";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        SqlConnection conn;
        SqlCommand cmd;
        Pengaturan_KelolaAkun_Uname gantiUname;
        Pengaturan_KelolaAkun_Pass gantiPass;
        public MainMenu main { get; set; }
        public Pengaturan_KelolaAkun()
        {
            InitializeComponent();
        }
        public void refreshAkun()
        {
            tbSearch.Clear();
            using (var connection = new SqlConnection(ConnectionString))
            using (var adapter = new SqlDataAdapter(selectQuery,connection))
            {
                var table = new DataTable();
                adapter.Fill(table);
                dtListAkun.DataSource = table;
                dtListAkun.Columns[0].HeaderText = "Username";
                dtListAkun.Columns[0].Width = 200;
            }
        }

        private void btConn_Click(object sender, EventArgs e)
        {
            refreshAkun();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length <= 0) return;
            string s = tbSearch.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = tbSearch.SelectionStart;
                int curSelLength = tbSearch.SelectionLength;
                tbSearch.SelectionStart = 0;
                tbSearch.SelectionLength = 1;
                tbSearch.SelectedText = s.ToUpper();
                tbSearch.SelectionStart = curSelStart;
                tbSearch.SelectionLength = curSelLength;
            }
            BindingSource bs = new BindingSource
            {
                DataSource = dtListAkun.DataSource,
                Filter = string.Format("username LIKE '%{0}%'", tbSearch.Text)
            };
            dtListAkun.DataSource = bs;
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

        private void btGantiPass_Click(object sender, EventArgs e)
        {
            gantiPass = new Pengaturan_KelolaAkun_Pass()
            {
                TopLevel = false,
                AutoScroll = false,
                main = main,
                currentAdmin=selectedRowIndexValue()
            };
            gantiPass.deployData();
            main.changePanelContent(gantiPass);
            main.formlevel = 2;
            main.lastform2 = this;
        }

        private void btGantiUsername_Click(object sender, EventArgs e)
        {
            if(selectedRowIndexValue()!="master")
            {
                gantiUname = new Pengaturan_KelolaAkun_Uname
                {
                    TopLevel = false,
                    AutoScroll = false,
                    main = main,
                    unameOld = selectedRowIndexValue(),
                    kelolaAkun = this
                };
                gantiUname.deployData();
                main.changePanelContent(gantiUname);
                main.formlevel = 2;
                main.lastform2 = this;
            }    
            else
            {
                MessageBox.Show("Pilihan tidak valid untuk username tersebut");
            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            if(selectedRowIndexValue()!="master")
            {
                DialogResult result = MessageBox.Show("Apakah anda yakin akan menghapus akun " + selectedRowIndexValue()
                + " ? Tindakan ini tidak dapat dibatalkan!", "Peringatan!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (selectedRowIndexValue() != "master")
                    {
                        conn = new SqlConnection(ConnectionString);
                        cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@uname", selectedRowIndexValue());
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        refreshAkun();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilihan tidak valid untuk username tersebut");
            }
        }
        private string selectedRowIndexValue()
        {
            int selectedindex = dtListAkun.CurrentCell.RowIndex;
            string value = dtListAkun.Rows[selectedindex].Cells[0].Value.ToString();
            return value;
        }
    }
}
