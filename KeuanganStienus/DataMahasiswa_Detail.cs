using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using ClosedXML.Excel;

namespace KeuanganStienus
{
    public partial class DataMahasiswa_Detail : Form
    {
        private const string tagihanQuery = "Select * from tagihan where nim=@nim";
        private const string pembayaranQuery = "Select * from pembayaran where nim=@nim";
        private const string hispembayaranQuery = "Select * from hispembayaran where nim=@nim";
        private const string insertPembayaranQuery = "insert into pembayaran (tagihanID,nim,jumlahBayar,tanggalBayar,adminBayar)" +
            " values (@tagihanid, @nim, @jumlahbayar,NOW(), @adminbayar)";
        private const string deleteHispembayaranQuery = "delete from hispembayaran where bayarID=@bayarid";
        private const string changesQuery = "insert into changes (changeCode,adminChanger,whatChanges,datetime,catatan) " +
            "values (@changecode,@adminbayar,@apayangdiganti,NOW(),@catatan)";
        private const string selectTagihanQuery = "select sisaTagihan from tagihan where tagihanID=@tagihanid";
        private const string updateTagihanQuery = "update tagihan set sisaTagihan=@sisa where tagihanID=@tagihanid";
        public string nimRef { get; set; }
        public string namaRef { get; set; }
        public string jurusanRef { get; set; }
        public string kelasRef { get; set; }
        public MainMenu main;
        private bool isPembayaran;
        MySqlConnection conn;
        MySqlCommand cmd;
        string tempA;
        int tempB,tempC;
        DataMahasiswa_Detail_TambahTagihan tambahTagihan;
        public DataMahasiswa_Detail()
        {
            InitializeComponent();
        }
        public void deployDataTagihan()
        {
            isPembayaran = false;
            btEdit.Text = "Tambah Tagihan Baru";
            dtMahasiswa.DataSource = null;
            dtMahasiswa.Rows.Clear();
            tbNim.Text = nimRef;
            tbNama.Text = namaRef;
            tbJurusan.Text = jurusanRef;
            tbKelas.Text = kelasRef;
            var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
            var adapter = new MySqlDataAdapter(tagihanQuery, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@nim", nimRef);
            using (connection)
            using (adapter)
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.dtMahasiswa.DataSource = table;
                for (int i = 0; i < dtMahasiswa.Columns.Count; i++)
                {
                    dtMahasiswa.Columns[i].HeaderText = main.HeaderName("hdTagihan" + i.ToString());
                    dtMahasiswa.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }
        public void deployDataPembayaran()
        {
            isPembayaran = true;
            btEdit.Text = "Hapus Pembayaran";
            dtMahasiswa.DataSource = null;
            dtMahasiswa.Rows.Clear();
            tbNim.Text = nimRef;
            tbNama.Text = namaRef;
            tbJurusan.Text = jurusanRef;
            tbKelas.Text = kelasRef;
            var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
            var adapter = new MySqlDataAdapter(hispembayaranQuery, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@nim", nimRef);
            using (connection)
            using (adapter)
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.dtMahasiswa.DataSource = table;
                for (int i = 0; i < dtMahasiswa.Columns.Count; i++)
                {
                    dtMahasiswa.Columns[i].HeaderText = main.HeaderName("hdPembayaran" + i.ToString());
                    dtMahasiswa.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void dataMahasiswa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btTagihan_Click(object sender, EventArgs e)
        {
            deployDataTagihan();
        }

        private void btPembayaran_Click(object sender, EventArgs e)
        {
            deployDataPembayaran();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            main.changePanelBack();
            main.formlevel = 1;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (isPembayaran == true)
            {
                string dep = selectedRowIndexValue(1);
                string depcheck = dep.Substring(dep.Length - 3);
                if(depcheck=="dep")
                {
                    MessageBox.Show("Tidak dapat mengubah histori Deposit");
                }
                else
                {
                    var sqlconn = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
                    string getcred = "Select * from changes where changeCode=@code";
                    MySqlCommand oCmd = new MySqlCommand(getcred, sqlconn);
                    oCmd.Parameters.AddWithValue("@code", selectedRowIndexValue(0));
                    sqlconn.Open();
                    using (MySqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            tempA = oReader["changeCode"].ToString();
                        }
                        sqlconn.Close();
                        if (tempA == selectedRowIndexValue(0))
                        {
                            //error, sudah dihapus
                            MessageBox.Show("Pembayaran ini telah dihapus");
                        }
                        else
                        {
                            //do that
                            if (int.Parse(selectedRowIndexValue(3)) < 0)
                            {
                                MessageBox.Show("Tidak dapat menghapus histori Penghapusan");
                            }
                            else
                            {
                                string promptValue = Prompt.ShowDialog("Masukkan Catatan untuk Perubahan");
                                if (promptValue != "")
                                {
                                    //mencatatat penghapusan pembayaran terpilih dengan menambah pembayaran negatif
                                    conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
                                    cmd = new MySqlCommand(insertPembayaranQuery, conn);
                                    cmd.Parameters.AddWithValue("@tagihanid", selectedRowIndexValue(1));
                                    cmd.Parameters.AddWithValue("@nim", selectedRowIndexValue(2));
                                    cmd.Parameters.AddWithValue("@jumlahbayar", -1 * int.Parse(selectedRowIndexValue(3)));
                                    cmd.Parameters.AddWithValue("@adminbayar", main.currentadmin);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    //tambah ke tabel changes
                                    cmd = new MySqlCommand(changesQuery, conn);
                                    cmd.Parameters.AddWithValue("@changecode", selectedRowIndexValue(0));
                                    cmd.Parameters.AddWithValue("@adminbayar", main.currentadmin);
                                    cmd.Parameters.AddWithValue("@apayangdiganti", "Menghapus Pembayaran pada Mahasiswa dengan NIM " + selectedRowIndexValue(2) + " sejumlah " + selectedRowIndexValue(3));
                                    cmd.Parameters.AddWithValue("@catatan", promptValue);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    //hapus hispembayaran
                                    cmd = new MySqlCommand(deleteHispembayaranQuery, conn);
                                    cmd.Parameters.AddWithValue("@bayarid", selectedRowIndexValue(0));
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                    //menambahkan kembali ke tagihan aktif
                                    var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
                                    cmd = new MySqlCommand(selectTagihanQuery, connection);
                                    cmd.Parameters.AddWithValue("@tagihanid", selectedRowIndexValue(1));
                                    connection.Open();
                                    using (var rdr = cmd.ExecuteReader())
                                    {
                                        while (rdr.Read())
                                        {
                                            tempB = int.Parse(rdr["sisaTagihan"].ToString());
                                        }
                                        connection.Close();
                                        tempC = tempB + int.Parse(selectedRowIndexValue(3));
                                        var comd = new MySqlCommand(updateTagihanQuery, conn);
                                        comd.Parameters.AddWithValue("@sisa", tempC);
                                        comd.Parameters.AddWithValue("@tagihanid", selectedRowIndexValue(1));
                                        conn.Open();
                                        comd.ExecuteNonQuery();
                                        conn.Close();
                                    }
                                    deployDataPembayaran();
                                }
                                else
                                {
                                    MessageBox.Show("Mohon masukkan alasan penghapusan pada catatan");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                //buka tambah tagihan di panel
                //tambah tagihan individual baru
                tambahTagihan = new DataMahasiswa_Detail_TambahTagihan();
                tambahTagihan.TopLevel = false;
                tambahTagihan.AutoScroll = false;
                tambahTagihan.main = main;
                tambahTagihan.nimRef = nimRef;
                tambahTagihan.detail = this;
                main.changePanelContent(tambahTagihan);
                main.formlevel = 2;
                main.lastform2 = this;
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd= new SaveFileDialog() {Filter="Excel Workbook|*.xlsx" })
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        var sqlcon = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
                        var sqlcmd = new MySqlCommand("select nim,semestertagihan,namatagihan,jumlahtagihan," +
                            "sisatagihan,statustagihan from tagihan where nim=@nim", sqlcon);
                        sqlcmd.Parameters.AddWithValue("@nim", nimRef);
                        using (MySqlDataAdapter adp = new MySqlDataAdapter(sqlcmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                adp.Fill(dt);
                                for (int i = 0; i < dt.Columns.Count; i++)
                                {
                                    dt.Columns[i].ColumnName = main.HeaderName("hdMahasiswa" + i.ToString());
                                }
                                var sqlcon2 = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
                                var sqlcmd2 = new MySqlCommand("select bayarID,tagihanID,jumlahbayar,tanggalbayar" +
                                    ",adminbayar from hispembayaran where nim=@nim", sqlcon2);
                                sqlcmd2.Parameters.AddWithValue("@nim", nimRef);
                                using(MySqlDataAdapter adp2 = new MySqlDataAdapter(sqlcmd2))
                                {
                                    using (DataTable dt2 = new DataTable())
                                    {
                                        adp2.Fill(dt2);
                                        dt2.Columns[0].ColumnName = "ID Pembayaran";
                                        dt2.Columns[1].ColumnName = "ID Tagihan";
                                        dt2.Columns[2].ColumnName = "Jumlah Pembayaran";
                                        dt2.Columns[3].ColumnName = "Tanggal Pembayaran";
                                        dt2.Columns[4].ColumnName = "Admin Penerima";
                                        using (XLWorkbook wb = new XLWorkbook())
                                        {
                                            var sheetId = wb.Worksheets.Add("Identitas");
                                            sheetId.Cell("A1").Value = "Identitas Mahasiswa";
                                            sheetId.Cell("A1").Style.Font.FontSize = 14;
                                            sheetId.Cell("A1").Style.Font.Bold = true;
                                            sheetId.Cell("A1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                            sheetId.Cell("A1").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                                            sheetId.Range("A1:D2").Merge();
                                            sheetId.Cell(4, 2).Value = "Nama";
                                            sheetId.Cell(4, 3).Value = ":";
                                            sheetId.Cell(4, 4).Value = namaRef;
                                            sheetId.Cell(5, 2).Value = "NIM :";
                                            sheetId.Cell(5, 3).Value = ":";
                                            sheetId.Cell(5, 4).Value = nimRef;
                                            sheetId.Cell(6, 2).Value = "Jurusan :";
                                            sheetId.Cell(6, 3).Value = ":";
                                            sheetId.Cell(6, 4).Value = jurusanRef;
                                            sheetId.Cell(7, 2).Value = "Kelas :";
                                            sheetId.Cell(7, 3).Value = ":";
                                            sheetId.Cell(7, 4).Value = kelasRef;
                                            sheetId.Columns("B", "D").AdjustToContents();
                                            var sheetTagihan = wb.Worksheets.Add(dt, "Tagihan");
                                            sheetTagihan.Columns("A", "F").AdjustToContents();
                                            var sheetPembayaran = wb.Worksheets.Add(dt2,"Pembayaran");
                                            sheetPembayaran.Columns("A", "E").AdjustToContents();
                                            wb.SaveAs(sfd.FileName);
                                        }
                                    }
                                }
                            }
                        }
                        MessageBox.Show("Berhasil menyimpan file!");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        private string selectedRowIndexValue(int indexx)
        {
            int selectedindex = dtMahasiswa.CurrentCell.RowIndex;
            string value = dtMahasiswa.Rows[selectedindex].Cells[indexx].Value.ToString();
            return value;
        }
    }
    public static class Prompt
    {
        public static string ShowDialog(string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            /*Label textLabel = new Label() { Left = 50, Top = 20, Text = text };*/
            TextBox textBox = new TextBox() { Left = 50, Top = 30, Width = 400 };
            Button confirmation = new Button() { Text = "OK", Left = 350, Height = 30, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            /*prompt.Controls.Add(textLabel);*/
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
