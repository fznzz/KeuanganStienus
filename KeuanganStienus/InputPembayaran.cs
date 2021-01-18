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
        private string getQuery = "Select * from mahasiswa";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        public InputPembayaran()
        {
            InitializeComponent();
            refreshMahasiswa();
        }
        private void refreshMahasiswa()
        {
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
        }

        private void datagridMahasiswa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtListMahasiswa.Rows[e.RowIndex];
                InputPembayaran_Bayar tambahPembayaran = new InputPembayaran_Bayar();
                tambahPembayaran.nimRef = row.Cells[0].Value.ToString();
                tambahPembayaran.namaRef = row.Cells[1].Value.ToString();
                tambahPembayaran.currentadmin = currentadmin;
                tambahPembayaran.deployData();
                tambahPembayaran.ShowDialog();
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
    }
}
