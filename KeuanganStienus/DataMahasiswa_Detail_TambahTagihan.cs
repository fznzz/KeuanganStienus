using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganStienus
{
    public partial class DataMahasiswa_Detail_TambahTagihan : Form
    {
        private const string insertQuery = "insert into tagihan values (@tagihanid, @nim, @semester, @namatagihan, " +
            "@jumlah, @sisa, @status)";
        public MainMenu main { get; set; }
        public DataMahasiswa_Detail detail { get; set; }
        public string nimRef { get; set; }
        private string tagihanID, nim, semester, namaTagihan, jumlahTagihan;
        MySqlConnection conn;

        private void btBack_Click(object sender, EventArgs e)
        {
            back();
        }
        private void back()
        {
            main.changePanelBack();
            main.formlevel = 1;
            detail.deployDataTagihan();
            this.Dispose();
        }

        MySqlCommand cmd;
        public DataMahasiswa_Detail_TambahTagihan()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            tambahTagihanIndividu();
        }
        private void tambahTagihanIndividu()
        {
            tagihanID = nimRef + tbKodeTagihan.Text;
            nim = nimRef;
            semester = tbSemesterTagihan.Text;
            namaTagihan = tbNamaTagihan.Text;
            jumlahTagihan = tbJumlahTagihan.Text;
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlConnectionString"].ConnectionString);
            cmd = new MySqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@tagihanid", tagihanID);
            cmd.Parameters.AddWithValue("@nim", nim);
            cmd.Parameters.AddWithValue("@semester", semester);
            cmd.Parameters.AddWithValue("@namatagihan", namaTagihan);
            cmd.Parameters.AddWithValue("@jumlah", jumlahTagihan);
            cmd.Parameters.AddWithValue("@sisa", jumlahTagihan);
            cmd.Parameters.AddWithValue("@status", "Belum Lunas");
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data telah tersimpan");
            back();
        }
    }
}
