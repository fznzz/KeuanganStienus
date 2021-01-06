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
    public partial class Menu1DataMahasiswa : Form 
    {
        private string getQuery = "Select * from mahasiswa";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        public Menu1DataMahasiswa()
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
            using (var connection = new SqlConnection(ConnectionString))
            using (var adapter = new SqlDataAdapter(getQuery, connection))
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.gridData1.DataSource = table;
            }
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
            (gridData1.DataSource as DataTable).DefaultView.RowFilter = string.Format("nama LIKE '%{0}%'", tbSearch.Text);
        }
        private void gridData1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridData1.Rows[e.RowIndex];
            DataMahasiswa datamahasiswa = new DataMahasiswa();
            datamahasiswa.nimRef = row.Cells[0].Value.ToString();
            datamahasiswa.namaRef = row.Cells[1].Value.ToString();
            datamahasiswa.jurusanRef = row.Cells[2].Value.ToString();
            datamahasiswa.kelasRef = row.Cells[3].Value.ToString();
            datamahasiswa.deployData();
            datamahasiswa.ShowDialog();
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            var frm = new tambahMahasiswa();
            frm.ShowDialog();
        }
    }
}
