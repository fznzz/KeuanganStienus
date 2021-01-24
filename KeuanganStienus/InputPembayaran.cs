using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KeuanganStienus
{
    public partial class InputPembayaran : Form
    {
        public string currentadmin { get; set; }
        private const string getQuery = "Select * from mahasiswa";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        public MainMenu main { get; set; }
        public InputPembayaran()
        {
            InitializeComponent();
            refreshMahasiswa();
        }
        private void refreshMahasiswa()
        {
            tbSearch.Clear();
            using (var connection = new SqlConnection(ConnectionString))
            using (var adapter = new SqlDataAdapter(getQuery, connection))
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.dtListMahasiswa.DataSource = table;
                dtListMahasiswa.Columns[0].HeaderText = "NIM";
                dtListMahasiswa.Columns[1].HeaderText = "Nama";
                dtListMahasiswa.Columns[2].HeaderText = "Jurusan";
                dtListMahasiswa.Columns[3].HeaderText = "Kelas";
            }
            dtListMahasiswa.Columns[0].Width= 150;
            dtListMahasiswa.Columns[1].Width = 150;
            dtListMahasiswa.Columns[2].Width = 150;
            dtListMahasiswa.Columns[3].Width = 150;
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
