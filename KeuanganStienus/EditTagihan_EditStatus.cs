using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KeuanganStienus
{
    public partial class EditTagihan_EditStatus : Form
    {
        public MainMenu main { get; set; }
        private const string selectQuery = "select * from mahasiswa";
        public EditTagihan_EditStatus()
        {
            InitializeComponent();
        }
        public void deployData()
        {
            //display data of the table
            var (sshClient, localPort) = ssh.ConnectSsh();
            using (sshClient)
            {
                MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                using (var connection = new MySqlConnection(csb.ConnectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection))
                    {
                        //rename column header from mysql column name and control column width
                        var table = new DataTable();
                        adapter.Fill(table);
                        this.dtHistori.DataSource = table;
                        for (int i = 0; i < dtHistori.Columns.Count; i++)
                        {
                            dtHistori.Columns[i].HeaderText = main.HeaderName("hdMahasiswa" + i.ToString());
                            dtHistori.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        }
                    }
                }
            }
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
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length <= 0)
            {
                deployData();
                return;
            }
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
                DataSource = dtHistori.DataSource,
                Filter = string.Format("nama LIKE '%{0}%'", tbSearch.Text)
            };
            dtHistori.DataSource = bs;
        }
        private void dtHistori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtHistori.Rows[e.RowIndex];
                EditTagihan_EditStatus_Detail detailStatus = new EditTagihan_EditStatus_Detail
                {
                    TopLevel = false,
                    AutoScroll = false,
                    nimRef = row.Cells[0].Value.ToString(),
                    namaRef = row.Cells[1].Value.ToString(),
                    jurusanRef = row.Cells[2].Value.ToString(),
                    kelasRef = row.Cells[3].Value.ToString(),
                    angkatanRef = row.Cells[4].Value.ToString(),
                    depositRef = int.Parse(row.Cells[5].Value.ToString()),
                    statusRef = row.Cells[6].Value.ToString(),
                    main = main,
                    editstatus = this
                };
                detailStatus.deployData();
                main.changePanelContent(detailStatus);
                main.lastform2 = this;
                main.formlevel = 2;
            }
        }
    }
}
