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
    public partial class DataMahasiswa_TambahMahasiswa : Form
    {
        private string selectQuery = "Select * from mahasiswa where nim=@nim";
        private string insertQuery = "Insert into mahasiswa values (@nim , @nama , @jurusan , @kelas)";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        string tempA, nim, nama, jurusan, kelas;
        bool status=false;
        public MainMenu main { get; set; }
        private void btOk_Click(object sender, EventArgs e)
        {
            clickTambah();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            main.changePanelBack();
            this.Dispose();
        }

        public DataMahasiswa_TambahMahasiswa()
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
            jurusan = cbJurusan.Text;
            kelas = cbKelas.Text;
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
                }
                else
                {
                    status = false;
                }
            }
        }
        private void tambahMhs()
        {
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
