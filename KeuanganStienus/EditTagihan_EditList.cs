using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace KeuanganStienus
{
    public partial class EditTagihan_EditList : Form
    {
        private string getQuery = "Select * from mahasiswa";
        public MainMenu main { get; set; }
        public EditTagihan_EditList()
        {
            InitializeComponent();
        }
        public void RefreshMahasiswa()
        {
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString))
            using (var adapter = new MySqlDataAdapter(getQuery, connection))
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.dtListMahasiswa.DataSource = table;
                for (int i = 0; i < dtListMahasiswa.Columns.Count; i++)
                {
                    dtListMahasiswa.Columns[i].HeaderText = main.HeaderName("hdMahasiswa" + i.ToString());
                    dtListMahasiswa.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
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
            (dtListMahasiswa.DataSource as DataTable).DefaultView.RowFilter = string.Format("nama LIKE '%{0}%'", tbSearch.Text);
        }

        private void dtListMahasiswa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtListMahasiswa.Rows[e.RowIndex];
                EditTagihan_EditList_Detail datamahasiswa = new EditTagihan_EditList_Detail
                {
                    TopLevel = false,
                    AutoScroll = false,
                    nimRef = row.Cells[0].Value.ToString(),
                    namaRef = row.Cells[1].Value.ToString(),
                    jurusanRef = row.Cells[2].Value.ToString(),
                    kelasRef = row.Cells[3].Value.ToString(),
                    main = main
                };
                datamahasiswa.deployData();
                main.changePanelContent(datamahasiswa);
                main.lastform2 = this;
                main.formlevel = 2;
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            main.changePanelBack();
            this.Dispose();
        }
    }
}
