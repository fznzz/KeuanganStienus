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
    public partial class DataMahasiswa : Form
    {
        private string getQuery = "Select * from tagihan where nim=@nim";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        public string nimRef { get; set; }
        public string namaRef { get; set; }
        public string jurusanRef { get; set; }
        public string kelasRef { get; set; }
        public DataMahasiswa()
        {
            InitializeComponent();
        }
        public void deployData()
        {
            tbNim.Text = nimRef;
            tbNama.Text = namaRef;
            tbJurusan.Text = jurusanRef;
            tbKelas.Text = kelasRef;
            var connection = new SqlConnection(ConnectionString);
            var adapter = new SqlDataAdapter(getQuery, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@nim", nimRef);
            using (connection)
            using (adapter)
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.dtMahasiswa.DataSource = table;
            }
        }

        private void dataMahasiswa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
