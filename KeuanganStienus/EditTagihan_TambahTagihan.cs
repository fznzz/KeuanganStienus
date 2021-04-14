using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganStienus
{
    public partial class EditTagihan_TambahTagihan : Form
    {
        public MainMenu main { get; set; }
        string namaTagihan, kodeTagihan, jurusan, kelas, semesterTagihan, angkatan, nimlike, jurusanKode;
        int jumlahTagihan;
        private const string selectQuery = "select * from mahasiswa where kelas=@kelas and nim like @nimlike";
        private const string insertQuery = "insert into tagihan values (@tagihanid, @nim, @semester, @namatagihan, " +
            "@jumlah, @sisa, @status)";
        MySqlCommand cmdInsert;
        MySqlDataAdapter cmdSelect;
        public EditTagihan edit { get; set; }
        private void btBack_Click(object sender, EventArgs e)
        {
            main.changePanelBack();
            this.Dispose();
        }
        DataTable table;
        DataRow[] datarow;
        string[] nimArray;
        public EditTagihan_TambahTagihan()
        {
            InitializeComponent();
        }
        private void tbJumlahTagihan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNamaTagihan.Text)|| String.IsNullOrEmpty(tbKodeTagihan.Text) || 
                String.IsNullOrEmpty(tbJumlahTagihan.Text) ||String.IsNullOrEmpty(tbSemesterTagihan.Text)|| 
                String.IsNullOrEmpty(cbJurusan.Text)|| String.IsNullOrEmpty(cbKelas.Text)|| 
                String.IsNullOrEmpty(tbAngkatan.Text))
            {
                MessageBox.Show("Mohon lengkapi semua data terlebih dahulu");
            }
            else
            {
                namaTagihan = tbNamaTagihan.Text;
                kodeTagihan = tbKodeTagihan.Text;
                jumlahTagihan = int.Parse(tbJumlahTagihan.Text);
                semesterTagihan = tbSemesterTagihan.Text;
                jurusan = cbJurusan.Text;
                kelas = cbKelas.Text;
                angkatan = tbAngkatan.Text;
                if(jurusan == "Akuntansi")
                {
                    jurusanKode = "ak";
                }
                else
                {
                    jurusanKode = "ma";
                }
                DialogResult dialogResult = MessageBox.Show("Pastikan data telah di cek dengan benar.", 
                    "Lanjutkan?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    nimlike = angkatan + jurusanKode + "%";
                    var (sshClient, localPort) = ssh.ConnectSsh();
                    using (sshClient)
                    {
                        MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                        using (var connection = new MySqlConnection(csb.ConnectionString))
                        {
                            cmdSelect = new MySqlDataAdapter(selectQuery, connection);
                            cmdSelect.SelectCommand.Parameters.AddWithValue("@kelas", kelas);
                            cmdSelect.SelectCommand.Parameters.AddWithValue("@nimlike", nimlike);
                            using (var adapter = cmdSelect)
                            {
                                table = new DataTable();
                                adapter.Fill(table);
                                datarow = new DataRow[table.Rows.Count];
                                table.Rows.CopyTo(datarow, 0);
                            }
                            if (datarow.Length == 0)
                            {
                                MessageBox.Show("Maaf, mahasiswa dengan kriteria yang dipilih tidak ditemukan");
                            }
                            else
                            {
                                nimArray = Array.ConvertAll(datarow, new Converter<DataRow, string>(dataRowToString));
                                connection.Open();
                                for (int i = 0; i < nimArray.Length; i++)
                                {
                                    cmdInsert = new MySqlCommand(insertQuery, connection);
                                    cmdInsert.Parameters.AddWithValue("@tagihanid", nimArray[i] + kodeTagihan);
                                    cmdInsert.Parameters.AddWithValue("@nim", nimArray[i]);
                                    cmdInsert.Parameters.AddWithValue("@semester", semesterTagihan);
                                    cmdInsert.Parameters.AddWithValue("@namatagihan", namaTagihan);
                                    cmdInsert.Parameters.AddWithValue("@jumlah", jumlahTagihan);
                                    cmdInsert.Parameters.AddWithValue("@sisa", jumlahTagihan);
                                    cmdInsert.Parameters.AddWithValue("@status", "Belum Lunas");
                                    cmdInsert.ExecuteNonQuery();
                                }
                                connection.Close();
                                main.changePanelContent(edit);
                                this.Dispose();
                            }
                        }
                    }
                }
            }
        }
        public static string dataRowToString(DataRow dr)
        {
            return Convert.ToString(dr["nim"].ToString());
        }
    }
}
