using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace KeuanganStienus
{
    public partial class InputPembayaran_VerifikasiBayar : Form
    {
        private const string updateTagihanQuery = "update tagihan set sisaTagihan=@sisatagihan,statusTagihan=@statustagihan " +
            "where tagihanID=@tagihanid";
        private const string addPembayaranQuery = "insert into pembayaran (tagihanID,nim,jumlahBayar,tanggalBayar,adminBayar)" +
            "values (@tagihanid, @nim, @jumlahbayar,NOW(), @adminbayar)";
        private const string addHisPembayaranQuery = "insert into hispembayaran (tagihanID,nim,jumlahBayar,tanggalBayar,adminBayar)" +
            "values (@tagihanid, @nim, @jumlahbayar,NOW(), @adminbayar)";
        private const string depositQuery = "update mahasiswa set deposit=deposit+@jumlahdep where nim=@nim";
        public List<string> tagihanID = new List<string>();
        public List<string> namaTagihan = new List<string>();
        public List<int> sisaTagihan = new List<int>();
        public List<int> jumlahBayar = new List<int>();
        public int totalDep { get; set; }
        public int minDep { get; set; }
        public int plusDep { get; set; }
        public bool isDepositOnly { get; set; }
        public int rownumber { get; set; }
        public string namaRef { get; set; }
        public string nimRef { get; set; }
        public string currentadmin { get; set; }
        public MainMenu main { get; set; }
        public InputPembayaran_Bayar bayar { get; set; }
        public InputPembayaran_VerifikasiBayar()
        {
            InitializeComponent();
        }
        public void deployData()
        {
            tbSaldo.Text = totalDep.ToString();
            tbPlusDeposit.Text = plusDep.ToString();
            tbMinusDeposit.Text = minDep.ToString();
            tbNama.Text = namaRef;
            tbNim.Text = nimRef;
            if (isDepositOnly == true)
            {
                //do nothing
            }
            else
            {
                DataGridViewColumn colTagihanID = new DataGridViewTextBoxColumn();
                colTagihanID.HeaderText = "ID Tagihan";
                colTagihanID.Width = 190;
                DataGridViewColumn colNamaTagihan = new DataGridViewTextBoxColumn();
                colNamaTagihan.HeaderText = "Nama Tagihan";
                colNamaTagihan.Width = 250;
                DataGridViewColumn colSisaTagihan = new DataGridViewTextBoxColumn();
                colSisaTagihan.HeaderText = "Sisa Tagihan";
                colSisaTagihan.Width = 150;
                DataGridViewColumn colJumlahBayar = new DataGridViewTextBoxColumn();
                colJumlahBayar.HeaderText = "Jumlah Pembayaran";
                colJumlahBayar.Width = 150;
                dtPembayaran.Columns.AddRange(colTagihanID);
                dtPembayaran.Columns.AddRange(colNamaTagihan);
                dtPembayaran.Columns.AddRange(colSisaTagihan);
                dtPembayaran.Columns.AddRange(colJumlahBayar);
                for (int i = 0; i < rownumber; i++)
                {
                    dtPembayaran.Rows.Add(tagihanID[i], namaTagihan[i], sisaTagihan[i], jumlahBayar[i]);
                }
            }
        }

        private void btBayar_Click(object sender, EventArgs e)
        {
            if (isDepositOnly == true)
            {
                bayarDepositOnly();
            }
            else bayarNormal();
            back();
        }

        private void bayarDepositOnly()
        {
            if(minDep!=0 || plusDep!=0)
            {
                var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
                var cmdDep = new MySqlCommand(depositQuery, conn);
                var cmdPemb = new MySqlCommand(addPembayaranQuery, conn);
                int depChanges = 0;
                if (minDep != 0)
                {
                    depChanges = -1 * minDep;
                }
                if (plusDep != 0)
                {
                    depChanges = plusDep;
                }
                conn.Open();
                cmdDep.Parameters.AddWithValue("@nim", nimRef);
                cmdDep.Parameters.AddWithValue("@jumlahdep", depChanges);
                cmdDep.ExecuteNonQuery();
                cmdPemb.Parameters.AddWithValue("@tagihanid", nimRef + "dep");
                cmdPemb.Parameters.AddWithValue("@nim", nimRef);
                cmdPemb.Parameters.AddWithValue("@jumlahbayar", depChanges);
                cmdPemb.Parameters.AddWithValue("@adminbayar", currentadmin);
                cmdPemb.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Perubahan deposit telah tersimpan");
            }
        }

        private void bayarNormal()
        {
            if(minDep!=0||plusDep!=0)
            {
                bayarDepositOnly();
            }
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
            var sqlcomBayar = new MySqlCommand(addPembayaranQuery, conn);
            var sqlcomTagihan = new MySqlCommand(updateTagihanQuery, conn);
            var sqlcomHisBayar = new MySqlCommand(addHisPembayaranQuery, conn);
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
                if (selisih == 0)
                {
                    statusCurrent = "Lunas";
                }
                else { statusCurrent = "Belum Lunas"; }
                //input ke pembayaran
                sqlcomHisBayar.Parameters.AddWithValue("@tagihanid", tagihanID[i]);
                sqlcomHisBayar.Parameters.AddWithValue("@nim", nimRef);
                sqlcomHisBayar.Parameters.AddWithValue("@jumlahbayar", jumlahBayar[i]);
                sqlcomHisBayar.Parameters.AddWithValue("@adminbayar", currentadmin);
                //update ke tagihan
                sqlcomTagihan.Parameters.AddWithValue("@sisatagihan", selisih);
                sqlcomTagihan.Parameters.AddWithValue("@statustagihan", statusCurrent);
                sqlcomTagihan.Parameters.AddWithValue("@tagihanid", tagihanID[i]);
                sqlcomBayar.ExecuteNonQuery();
                sqlcomHisBayar.ExecuteNonQuery();
                sqlcomTagihan.ExecuteNonQuery();
            }
            conn.Close();
            MessageBox.Show("Pembayaran telah diterima");
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            back();
        }

        private void back()
        {
            main.changePanelBack();
            main.formlevel = 1;
            bayar.deployData();
            this.Dispose();
        }
    }
}
