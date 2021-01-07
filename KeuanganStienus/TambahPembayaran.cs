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
    public partial class TambahPembayaran : Form
    {
        private string selectQuery = "Select * from mahasiswa where nim=@nim";
        private string getQuery = "Select * from tagihan where nim=@nim";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        string tempA, tempB;
        public string nimRef { get; set; }
        public string namaRef { get; set; }
        public TambahPembayaran()
        {
            InitializeComponent();
        }
        public void deployData()
        {
            tbNama.Text = namaRef;
            tbNim.Text = nimRef;
            checkMahasiswa(nimRef);
        }
        private void btNimCheck_Click(object sender, EventArgs e)
        {
            
        }

        private void checkMahasiswa(string nim)
        {
            var sqlconn = new SqlConnection(ConnectionString);
            SqlCommand oCmd = new SqlCommand(selectQuery, sqlconn);
            oCmd.Parameters.AddWithValue("@nim", nim);
            sqlconn.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    tempA = oReader["nim"].ToString();
                    tempB = oReader["nama"].ToString();
                }
                sqlconn.Close();
                if (tempA == nim)
                {
                    tbNama.Text = tempB;
                    //mulai isi datagridview
                    var connection = new SqlConnection(ConnectionString);
                    var adapter = new SqlDataAdapter(getQuery, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@nim", nim);
                    using (connection)
                    using (adapter)
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        this.dtListTagihan.DataSource = table;
                        DataGridViewColumn colPembayaran = new DataGridViewTextBoxColumn();
                        colPembayaran.HeaderText = "Pembayaran";
                        dtListTagihan.Columns.AddRange(colPembayaran);
                        for(int i=0; i<7;i++)
                        {
                            dtListTagihan.Columns[i].ReadOnly = true;
                        }    
                        
                    }
                    
                }
                else
                {

                    MessageBox.Show("NIM Mahasiswa tidak terdaftar");
                }
            }
        }
    }
}
