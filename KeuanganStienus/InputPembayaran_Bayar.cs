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
    public partial class InputPembayaran_Bayar : Form
    {
        //query untuk sql server
        private string selectMahasiswaQuery = "Select * from mahasiswa where nim=@nim";
        private string selectTagihanQuery = "Select * from tagihan where nim=@nim";
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial " +
            "Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        string tempA, tempB;
        //getter dan setter untuk nama dan nim dari form sebelumnya
        public string nimRef { get; set; }
        public string namaRef { get; set; }
        public string currentadmin { get; set; }
        public InputPembayaran_Bayar()
        {
            InitializeComponent();
        }
        public void deployData()
        {
            //mengubah informasi textbox menjadi nama dan nim, lalu mengecek data di sql
            tbNama.Text = namaRef;
            tbNim.Text = nimRef;
            checkMahasiswa(nimRef);
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            //membuat object verifikasi, kemudian setiap ada pembayaran yang dimasukkan akan di add ke list
            //dimana akan ditampilkan di form verifikasi
            InputPembayaran_VerifikasiBayar verifikasi = new InputPembayaran_VerifikasiBayar();
            verifikasi.rownumber = dtListTagihan.RowCount;
            verifikasi.namaRef = namaRef;
            verifikasi.nimRef = nimRef;
            verifikasi.currentadmin = currentadmin;
            for(int i=0; i < dtListTagihan.RowCount; i++)
            {
                
                DataGridViewRow row = dtListTagihan.Rows[i];
                if (row.Cells[0].Value == null) continue;
                verifikasi.tagihanID.Add(row.Cells[1].Value.ToString());
                verifikasi.namaTagihan.Add(row.Cells[4].Value.ToString());
                verifikasi.sisaTagihan.Add(int.Parse(row.Cells[6].Value.ToString()));
                //entah bagaimana, column baru selalu menempati index 0
                verifikasi.jumlahBayar.Add(int.Parse(row.Cells[0].Value.ToString()));
            }
            if(verifikasi.tagihanID.Count==0)
            {
                MessageBox.Show("Belum ada input Pembayaran");
            }
            else
            {
                verifikasi.deployData();
                verifikasi.ShowDialog();
            }
        }

        private void dtListTagihan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dtListTagihan_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(dtListTagihan_KeyPress);
            if (dtListTagihan.CurrentCell.ColumnIndex == 7) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dtListTagihan_KeyPress);
                }
            }
        }
        private void checkMahasiswa(string nim)
        {
            var sqlconn = new SqlConnection(ConnectionString);
            SqlCommand oCmd = new SqlCommand(selectMahasiswaQuery, sqlconn);
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
                    var adapter = new SqlDataAdapter(selectTagihanQuery, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@nim", nim);
                    using (connection)
                    using (adapter)
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        this.dtListTagihan.DataSource = table;
                        DataGridViewColumn colPembayaran = new DataGridViewTextBoxColumn();
                        colPembayaran.HeaderText = "Pembayaran";
                        dtListTagihan.Columns[0].HeaderText = "ID Tagihan";
                        dtListTagihan.Columns[1].HeaderText = "NIM";
                        dtListTagihan.Columns[2].HeaderText = "Semester";
                        dtListTagihan.Columns[3].HeaderText = "Nama Tagihan";
                        dtListTagihan.Columns[4].HeaderText = "Jumlah";
                        dtListTagihan.Columns[5].HeaderText = "Kekurangan";
                        dtListTagihan.Columns[6].HeaderText = "Status";
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
