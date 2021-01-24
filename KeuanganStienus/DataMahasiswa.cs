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
using System.Globalization;

namespace KeuanganStienus
{
    public partial class DataMahasiswa : Form 
    {
        private const string selectQuery = "Select * from mahasiswa";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        public MainMenu main { get; set; }
        DataMahasiswa_TambahMahasiswa tambah;
        public DataMahasiswa()
        {
            InitializeComponent();
            refreshMahasiswa();
        }
        private void btConn_Click(object sender, EventArgs e)
        {
            refreshMahasiswa();
            
        }
        private void refreshMahasiswa()
        {
            tbSearch.Clear();
            using (var connection = new SqlConnection(ConnectionString))
            using (var adapter = new SqlDataAdapter(selectQuery, connection))
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.dtListMahasiswa.DataSource = table;
                dtListMahasiswa.Columns[0].HeaderText = "NIM";
                dtListMahasiswa.Columns[1].HeaderText = "Nama";
                dtListMahasiswa.Columns[2].HeaderText = "Jurusan";
                dtListMahasiswa.Columns[3].HeaderText = "Kelas";
            }
            dtListMahasiswa.Columns[0].Width = 150;
            dtListMahasiswa.Columns[1].Width = 150;
            dtListMahasiswa.Columns[2].Width = 150;
            dtListMahasiswa.Columns[3].Width = 150;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
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
                DataSource = mahasiswaBindingSource,
                Filter = string.Format("nama LIKE '%{0}%'", tbSearch.Text)
            };
            dtListMahasiswa.DataSource = bs;
        }
        private void gridData1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dtListMahasiswa.Rows[e.RowIndex];
                DataMahasiswa_Detail datamahasiswa = new DataMahasiswa_Detail
                {
                    TopLevel = false,
                    AutoScroll = false,
                    nimRef = row.Cells[0].Value.ToString(),
                    namaRef = row.Cells[1].Value.ToString(),
                    jurusanRef = row.Cells[2].Value.ToString(),
                    kelasRef = row.Cells[3].Value.ToString(),
                    main = main
                };
                datamahasiswa.deployDataTagihan();
                main.changePanelContent(datamahasiswa);
                main.lastform1 = this;
                main.formlevel = 1;
            }
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            tambah = new DataMahasiswa_TambahMahasiswa
            {
                TopLevel = false,
                AutoScroll = false,
                main = main
            };
            main.changePanelContent(tambah);
            main.lastform1 = this;
            main.formlevel = 1;
        }

        private void DataMahasiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stienusDataSet.mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.stienusDataSet.mahasiswa);
        }
    }
}
