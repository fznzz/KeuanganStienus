using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace KeuanganStienus
{
    public partial class DataMahasiswa_Detail : Form
    {
        private string tagihanQuery = "Select * from tagihan where nim=@nim";
        private string pembayaranQuery = "Select * from pembayaran where nim=@nim";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        public string nimRef { get; set; }
        public string namaRef { get; set; }
        public string jurusanRef { get; set; }
        public string kelasRef { get; set; }
        public DataMahasiswa_Detail()
        {
            InitializeComponent();
        }
        public void deployDataTagihan()
        {
            dtMahasiswa.DataSource = null;
            dtMahasiswa.Rows.Clear();
            tbNim.Text = nimRef;
            tbNama.Text = namaRef;
            tbJurusan.Text = jurusanRef;
            tbKelas.Text = kelasRef;
            var connection = new SqlConnection(ConnectionString);
            var adapter = new SqlDataAdapter(tagihanQuery, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@nim", nimRef);
            using (connection)
            using (adapter)
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.dtMahasiswa.DataSource = table;
                dtMahasiswa.Columns[0].HeaderText = "ID Tagihan";
                dtMahasiswa.Columns[1].HeaderText = "NIM";
                dtMahasiswa.Columns[2].HeaderText = "Semester";
                dtMahasiswa.Columns[3].HeaderText = "Nama Tagihan";
                dtMahasiswa.Columns[4].HeaderText = "Jumlah Tagihan";
                dtMahasiswa.Columns[5].HeaderText = "Sisa Tagihan";
                dtMahasiswa.Columns[6].HeaderText = "Status Tagihan";
            }
        }
        public void deployDataPembayaran()
        {
            dtMahasiswa.DataSource = null;
            dtMahasiswa.Rows.Clear();
            tbNim.Text = nimRef;
            tbNama.Text = namaRef;
            tbJurusan.Text = jurusanRef;
            tbKelas.Text = kelasRef;
            var connection = new SqlConnection(ConnectionString);
            var adapter = new SqlDataAdapter(pembayaranQuery, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@nim", nimRef);
            using (connection)
            using (adapter)
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.dtMahasiswa.DataSource = table;
                dtMahasiswa.Columns[0].HeaderText = "ID Pembayaran";
                dtMahasiswa.Columns[1].HeaderText = "ID Tagihan";
                dtMahasiswa.Columns[2].HeaderText = "NIM";
                dtMahasiswa.Columns[3].HeaderText = "Jumlah Pembayaran";
                dtMahasiswa.Columns[4].HeaderText = "Tanggal Pembayaran";
                dtMahasiswa.Columns[5].HeaderText = "Admin Penerima";
            }
        }

        private void dataMahasiswa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btTagihan_Click(object sender, EventArgs e)
        {
            deployDataTagihan();
        }

        private void btPembayaran_Click(object sender, EventArgs e)
        {
            deployDataPembayaran();
        }
    }
}
