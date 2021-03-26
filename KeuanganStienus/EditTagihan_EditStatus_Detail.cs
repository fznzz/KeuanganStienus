using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace KeuanganStienus
{
    public partial class EditTagihan_EditStatus_Detail : Form
    {
        private const string updateQuery = "update mahasiswa set nim=@nimNew,nama=@nama,jurusan=@jurusan" +
            ",kelas=@kelas,angkatan=@angkatan,status=@status where nim=@nimOld";
        public MainMenu main { get; set; }
        public EditTagihan_EditStatus editstatus { get; set; }
        public string nimRef { get; set; }
        public string namaRef { get; set; }
        public string jurusanRef { get; set; }
        public string kelasRef { get; set; }
        public string angkatanRef { get; set; }
        public int depositRef { get; set; }
        public string statusRef { get; set; }
        MySqlConnection con;
        MySqlCommand cmd;
        public EditTagihan_EditStatus_Detail()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            back();
        }

        private void back()
        {
            editstatus.deployData();
            main.changePanelBack();
            main.formlevel = 1;
        }
        public void deployData()
        {
            tbNama.Text = namaRef;
            tbNim.Text = nimRef;
            cbJurusan.Text = jurusanRef;
            cbKelas.Text = kelasRef;
            tbAngkatan.Text=angkatanRef;
            tbStatus.Text=statusRef;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            updateDataMahasiswa();
        }

        private void updateDataMahasiswa()
        {
            var namaUp = tbNama.Text;
            var nimUp = tbNim.Text;
            var jurusanUp = cbJurusan.Text;
            var kelasUp = cbKelas.Text;
            var angkatanUp = tbAngkatan.Text;
            var statusUp = tbStatus.Text;
            con = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
            cmd = new MySqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@nimOld",nimRef);
            cmd.Parameters.AddWithValue("@nimNew", nimUp);
            cmd.Parameters.AddWithValue("@nama", namaUp);
            cmd.Parameters.AddWithValue("@jurusan", jurusanUp);
            cmd.Parameters.AddWithValue("@kelas", kelasUp);
            cmd.Parameters.AddWithValue("@angkatan", angkatanUp);
            cmd.Parameters.AddWithValue("@status", statusUp);
            con.Open();
            int scCheck = cmd.ExecuteNonQuery();
            con.Close();
            if(scCheck>0)
            {
                MessageBox.Show("Data berhasil tersimpan.");
                back();
            }
            else
            {
                MessageBox.Show("Data gagal tersimpan.");
            }
        }
    }
}
