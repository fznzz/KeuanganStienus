using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace KeuanganStienus
{
    public partial class DataMahasiswa_TambahMahasiswa : Form
    {
        private string selectQuery = "Select * from mahasiswa where nim=@nim";
        private string insertQuery = "Insert into mahasiswa (nim,nama,jurusan,kelas,angkatan,deposit,status) values (@nim , @nama , @jurusan , @kelas, @angkatan,0,@status)";
        string tempA, nim, nama, jurusan, kelas;
        int angkatan;
        bool status=false;
        public MainMenu main { get; set; }
        private void btOk_Click(object sender, EventArgs e)
        {
            clickTambah();
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            back();
        }
        private void back()
        {
            main.changePanelBack();
            this.Dispose();
        }
        public DataMahasiswa_TambahMahasiswa()
        {
            InitializeComponent();
        }
        private void btImport_Click(object sender, EventArgs e)
        {
            try {
                import();
                MessageBox.Show("Selesai mengimpor data");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void import()
        {
            openFileDialog1.Filter = "Excel Office | *.xls; *.xlsx";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            if (filename != string.Empty)
            {
                try
                {
                    OleDbConnection con;
                    DataTable dataSet;
                    OleDbDataAdapter adapter;
                    con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filename +
                        "; Extended Properties = Excel 8.0");
                    adapter = new OleDbDataAdapter("select * from [sheet1$]", con);
                    dataSet = new DataTable();
                    adapter.Fill(dataSet);
                    con.Close();
                    var (sshClient, localPort) = ssh.ConnectSsh();
                    using (sshClient)
                    {
                        MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                        using (var connection = new MySqlConnection(csb.ConnectionString))
                        {
                            connection.Open();
                            for (int i = 0; i < dataSet.Rows.Count; i++)
                            {
                                tempA = "0";
                                MySqlCommand ncom = new MySqlCommand("select exists(select * from mahasiswa where nim=@nim)", connection);
                                ncom.Parameters.AddWithValue("@nim", dataSet.Rows[i].ItemArray[0].ToString());
                                using (MySqlDataReader reader = ncom.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        tempA = reader[0].ToString();
                                    }
                                }
                                if (tempA == "0")
                                {
                                    MySqlCommand oCmd = new MySqlCommand(insertQuery, connection);
                                    oCmd.Parameters.AddWithValue("@nim", dataSet.Rows[i].ItemArray[0].ToString());
                                    oCmd.Parameters.AddWithValue("@nama", dataSet.Rows[i].ItemArray[1].ToString());
                                    oCmd.Parameters.AddWithValue("@jurusan", dataSet.Rows[i].ItemArray[2].ToString());
                                    oCmd.Parameters.AddWithValue("@kelas", dataSet.Rows[i].ItemArray[3].ToString());
                                    oCmd.Parameters.AddWithValue("@angkatan", dataSet.Rows[i].ItemArray[4].ToString());
                                    oCmd.Parameters.AddWithValue("@status", "Aktif");
                                    oCmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    MessageBox.Show("Mahasiswa dengan NIM :" + dataSet.Rows[i].ItemArray[0].ToString() + " sudah" +
                                        " ada dalam database");
                                }
                            }
                            connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Filename kosong");
            }
        }
        private void tbAngkatan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
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
            angkatan = int.Parse(tbAngkatan.Text);
            var (sshClient, localPort) = ssh.ConnectSsh();
            using (sshClient)
            {
                MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                using (var connection = new MySqlConnection(csb.ConnectionString))
                {
                    MySqlCommand oCmd = new MySqlCommand(selectQuery, connection);
                    oCmd.Parameters.AddWithValue("@nim", nim);
                    connection.Open();
                    using (MySqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            tempA = oReader["nim"].ToString();
                        }
                        connection.Close();
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
            }
        }
        private void tambahMhs()
        {
            if (status == false)
            {
                var (sshClient, localPort) = ssh.ConnectSsh();
                using (sshClient)
                {
                    MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                    using (var connection = new MySqlConnection(csb.ConnectionString))
                    {
                        MySqlCommand oCmd = new MySqlCommand(insertQuery, connection);
                        oCmd.Parameters.AddWithValue("@nim", nim);
                        oCmd.Parameters.AddWithValue("@nama", nama);
                        oCmd.Parameters.AddWithValue("@jurusan", jurusan);
                        oCmd.Parameters.AddWithValue("@kelas", kelas);
                        oCmd.Parameters.AddWithValue("@angkatan", angkatan);
                        oCmd.Parameters.AddWithValue("@status", "Aktif");
                        connection.Open();
                        oCmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Data mahasiswa telah ditambah!");
                    }
                }
            }
            else MessageBox.Show("Mahasiswa dengan NIM yang sama telah ada di database!");
            back();
        }
    }
}
