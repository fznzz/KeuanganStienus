using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace KeuanganStienus
{
    public partial class InputPembayaran : Form
    {
        public string currentadmin { get; set; }
        private const string getQuery = "Select * from mahasiswa where status='Aktif'";
        public MainMenu main { get; set; }
        public InputPembayaran()
        {
            InitializeComponent();
        }
        public void refreshMahasiswa()
        {
            tbSearch.Clear();
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlConnectionString"].ConnectionString))
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

        private void datagridMahasiswa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtListMahasiswa.Rows[e.RowIndex];
                InputPembayaran_Bayar tambahPembayaran = new InputPembayaran_Bayar();
                tambahPembayaran.TopLevel = false;
                tambahPembayaran.AutoScroll = false;
                tambahPembayaran.nimRef = row.Cells[0].Value.ToString();
                tambahPembayaran.namaRef = row.Cells[1].Value.ToString();
                tambahPembayaran.currentadmin = currentadmin;
                tambahPembayaran.main = main;
                tambahPembayaran.bayar = this;
                tambahPembayaran.deployData();
                main.changePanelContent(tambahPembayaran);
                main.lastform1 = this;
                main.formlevel = 1;
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

        private void btConn_Click(object sender, EventArgs e)
        {
            refreshMahasiswa();
        }
    }
}
