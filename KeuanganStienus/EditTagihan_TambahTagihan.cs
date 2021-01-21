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
    public partial class EditTagihan_TambahTagihan : Form
    {
        public MainMenu main { get; set; }
        string namaTagihan, kodeTagihan, jurusan, kelas, semesterTagihan, angkatan, nimlike, jurusanKode;
        int jumlahTagihan;
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        private const string selectQuery = "select * from mahasiswa where kelas=@kelas and nim like @nimlike";
        private const string insertQuery = "insert into tagihan values (@tagihanid, @nim, @semester, @namatagihan, " +
            "@jumlah, @sisa, @status)";
        SqlConnection conn;
        SqlCommand cmdInsert;
        SqlDataAdapter cmdSelect;
        DataTable table;
        DataRow[] datarow;
        String[] nimArray;
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
                    "Lanjutkan?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    nimlike = angkatan + jurusanKode + "%";
                    conn = new SqlConnection(ConnectionString);
                    cmdSelect = new SqlDataAdapter(selectQuery, conn);
                    cmdSelect.SelectCommand.Parameters.AddWithValue("@kelas", kelas);
                    cmdSelect.SelectCommand.Parameters.AddWithValue("@nimlike", nimlike);
                    using (conn)
                    using (var adapter = cmdSelect)
                    {
                        table = new DataTable();
                        adapter.Fill(table);
                        datarow = new DataRow[table.Rows.Count];
                        table.Rows.CopyTo(datarow, 0);
                    }
                    if(datarow.Length==0)
                    {
                        MessageBox.Show("Maaf, mahasiswa dengan kriteria yang dipilih tidak ditemukan");
                    }
                    else
                    {
                        nimArray = Array.ConvertAll(datarow, new Converter<DataRow, string>(dataRowToString));
                        conn.Open();
                        for (int i = 0; i < nimArray.Length; i++)
                        {
                            cmdInsert = new SqlCommand(insertQuery, conn);
                            cmdInsert.Parameters.AddWithValue("@tagihanid", nimArray[i] + kodeTagihan);
                            cmdInsert.Parameters.AddWithValue("@nim", nimArray[i]);
                            cmdInsert.Parameters.AddWithValue("@semester", semesterTagihan);
                            cmdInsert.Parameters.AddWithValue("@namatagihan", namaTagihan);
                            cmdInsert.Parameters.AddWithValue("@jumlah", jumlahTagihan);
                            cmdInsert.Parameters.AddWithValue("@sisa", jumlahTagihan);
                            cmdInsert.Parameters.AddWithValue("@sisa", "Belum Lunas");
                            cmdInsert.ExecuteNonQuery();
                        }
                        conn.Close();
                        this.Dispose();
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
