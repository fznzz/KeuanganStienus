using System;
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
        MySqlCommand cmd;
        public string nimRef { get; set; }
        private string tagihanID, nim, semester, namaTagihan, jumlahTagihan;
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
            var (sshClient, localPort) = ssh.ConnectSsh();
            using (sshClient)
            {
                MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                using (var connection = new MySqlConnection(csb.ConnectionString))
                {
                    cmd = new MySqlCommand(insertQuery, connection);
                    cmd.Parameters.AddWithValue("@tagihanid", tagihanID);
                    cmd.Parameters.AddWithValue("@nim", nim);
                    cmd.Parameters.AddWithValue("@semester", semester);
                    cmd.Parameters.AddWithValue("@namatagihan", namaTagihan);
                    cmd.Parameters.AddWithValue("@jumlah", jumlahTagihan);
                    cmd.Parameters.AddWithValue("@sisa", jumlahTagihan);
                    cmd.Parameters.AddWithValue("@status", "Belum Lunas");
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data telah tersimpan");
                    back();
                }
            }
        }
    }
}
