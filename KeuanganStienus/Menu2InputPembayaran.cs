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
    public partial class Menu2InputPembayaran : Form
    {
        public string currentadmin { get; set; }
        private string getQuery = "Select * from mahasiswa";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        public Menu2InputPembayaran()
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
                this.datagridMahasiswa.DataSource = table;
            }
        }

        private void datagridMahasiswa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridMahasiswa.Rows[e.RowIndex];
                TambahPembayaran tambahPembayaran = new TambahPembayaran();
                tambahPembayaran.nimRef = row.Cells[0].Value.ToString();
                tambahPembayaran.namaRef = row.Cells[1].Value.ToString();
                tambahPembayaran.currentadmin = currentadmin;
                tambahPembayaran.deployData();
                tambahPembayaran.ShowDialog();
            }
        }
    }
}
