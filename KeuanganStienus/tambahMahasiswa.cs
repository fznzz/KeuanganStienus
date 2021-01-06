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
    public partial class tambahMahasiswa : Form
    {
        private string selectQuery = "Select * from mahasiswa where nim=@nim";
        private string insertQuery = "Insert into mahasiswa values (@nim , @nama , @jurusan , @kelas)";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        string tempA, nim, nama, jurusan, kelas;
        bool status=false;

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            clickTambah();
        }

        public tambahMahasiswa()
        {
            InitializeComponent();
        }
        public void clickTambah()
        {
            cekMhs();
            tambahMhs();
        }
        private void cekMhs()
        {
            nim = tbNim.Text;
            nama = tbNama.Text;
            jurusan = tbJurusan.Text;
            kelas = tbKelas.Text;
            var sqlconn = new SqlConnection(ConnectionString);
            SqlCommand oCmd = new SqlCommand(selectQuery, sqlconn);
            oCmd.Parameters.AddWithValue("@nim", nim);
            sqlconn.Open();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    tempA = oReader["nim"].ToString();
                }
                sqlconn.Close();
                if (tempA == nim)
                {
                    status = true;
                    MessageBox.Show("status true, nim not available");
                }
                else
                {
                    status = false;
                    MessageBox.Show("status false, nim available");
                }
            }
        }
        private void tambahMhs()
        {
            MessageBox.Show("masuk tambah mhs");
            if (status == false)
            {
                var sqlconn = new SqlConnection(ConnectionString);
                SqlCommand oCmd = new SqlCommand(insertQuery, sqlconn);
                oCmd.Parameters.AddWithValue("@nim", nim);
                oCmd.Parameters.AddWithValue("@nama", nama);
                oCmd.Parameters.AddWithValue("@jurusan", jurusan);
                oCmd.Parameters.AddWithValue("@kelas", kelas);
                sqlconn.Open();
                oCmd.ExecuteNonQuery();
                sqlconn.Close();
                MessageBox.Show("Data mahasiswa telah ditambah!");
            }
            else MessageBox.Show("Mahasiswa dengan NIM yang sama telah ada di database!");
            
        }
    }
}
