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
    public partial class InputPembayaran_VerifikasiBayar : Form
    {
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial " +
            "Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        private const string updateTagihanQuery = "update tagihan set sisaTagihan=@sisatagihan,statusTagihan=@statustagihan " +
            "where tagihanID=@tagihanid";
        private const string addPembayaranQuery = "insert into pembayaran (tagihanID,nim,jumlahBayar,tanggalBayar,adminBayar)" +
            "values (@tagihanid, @nim, @jumlahbayar" +
            ",GETDATE(), @adminbayar)";
        public List<string> tagihanID = new List<string>();
        public List<string> namaTagihan = new List<string>();
        public List<int> sisaTagihan = new List<int>();
        public List<int> jumlahBayar = new List<int>();
        DateTimePicker dtp = new DateTimePicker();
        
        public int rownumber { get; set; }
        public string namaRef { get; set; }
        public string nimRef { get; set; }
        public string currentadmin { get; set; }
        public InputPembayaran_VerifikasiBayar()
        {
            InitializeComponent();
            DataGridViewColumn colTagihanID = new DataGridViewTextBoxColumn();
            colTagihanID.HeaderText = "ID Tagihan";
            DataGridViewColumn colNamaTagihan = new DataGridViewTextBoxColumn();
            colNamaTagihan.HeaderText = "Nama Tagihan";
            DataGridViewColumn colSisaTagihan = new DataGridViewTextBoxColumn();
            colSisaTagihan.HeaderText = "Sisa Tagihan";
            DataGridViewColumn colJumlahBayar = new DataGridViewTextBoxColumn();
            colJumlahBayar.HeaderText = "Jumlah Pembayaran";
            dtPembayaran.Columns.AddRange(colTagihanID);
            dtPembayaran.Columns.AddRange(colNamaTagihan);
            dtPembayaran.Columns.AddRange(colSisaTagihan);
            dtPembayaran.Columns.AddRange(colJumlahBayar);
        }
        public void deployData()
        {
            tbNama.Text = namaRef;
            tbNim.Text = nimRef;
            for (int i = 0; i < rownumber; i++)
            {
                dtPembayaran.Rows.Add(tagihanID[i], namaTagihan[i], sisaTagihan[i], jumlahBayar[i]);
            }
        }

        private void btBayar_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection(ConnectionString);
            var sqlcomBayar = new SqlCommand(addPembayaranQuery, conn);
            var sqlcomTagihan = new SqlCommand(updateTagihanQuery, conn);
            int selisih;
            string statusCurrent;
            conn.Open();
            for (int i = 0; i < rownumber; i++)
            {
                //input ke pembayaran
                sqlcomBayar.Parameters.AddWithValue("@tagihanid", tagihanID[i]);
                sqlcomBayar.Parameters.AddWithValue("@nim", nimRef);
                sqlcomBayar.Parameters.AddWithValue("@jumlahbayar", jumlahBayar[i]);
                sqlcomBayar.Parameters.AddWithValue("@adminbayar", currentadmin);
                selisih = sisaTagihan[i] - jumlahBayar[i];
                if(selisih==0)
                {
                    statusCurrent = "Lunas";
                }
                else { statusCurrent = "Belum Lunas"; }
                //update ke tagihan
                sqlcomTagihan.Parameters.AddWithValue("@sisatagihan", selisih);
                sqlcomTagihan.Parameters.AddWithValue("@statustagihan", statusCurrent);
                sqlcomTagihan.Parameters.AddWithValue("@tagihanid", tagihanID[i]);
                sqlcomBayar.ExecuteNonQuery();
                sqlcomTagihan.ExecuteNonQuery();
            }
            conn.Close();
            MessageBox.Show("Pembayaran telah diterima");
            this.Dispose();
        }
    }
}
