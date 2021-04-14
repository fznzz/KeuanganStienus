using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;

namespace KeuanganStienus
{
    public partial class EditTagihan_EditList_Detail : Form
    {
        public string nimRef { get; set; }
        public string namaRef { get; set; }
        public string jurusanRef { get; set; }
        public string kelasRef { get; set; }
        public MainMenu main { get; set; }
        private const string selectQuery = "select * from tagihan where nim=@nim";
        private const string updateQuery = "update tagihan set tagihanID=@tagihanidnew,nim=@nim,semesterTagihan=@semester,namaTagihan=@namatag," +
            "jumlahTagihan=@jumlah,sisaTagihan=@sisa,statusTagihan=@status where tagihanID=@tagihanid";
        private const string changesQuery = "insert into changes (changeCode,adminChanger,whatChanges,datetime,catatan) " +
            "values (@cc,@admin,@wc,NOW(),@catatan)";
        private const string deleteQuery = "delete from tagihan where tagihanID=@tagihanid";
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        DataTable initData;
        bool[] dataChanged;
        string[] tagihanIdOld;
        public EditTagihan_EditList_Detail()
        {
            InitializeComponent();
        }
        public void deployData()
        {
            //deploy data for dgv
            tbNama.Text = namaRef;
            tbNim.Text = nimRef;
            tbJurusan.Text = jurusanRef;
            tbKelas.Text = kelasRef;
            deployDataGridView();
        }
        public void deployDataGridView()
        {
            initData = new DataTable();
            var (sshClient, localPort) = ssh.ConnectSsh();
            using (sshClient)
            {
                MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                using (var connection = new MySqlConnection(csb.ConnectionString))
                {
                    adapter = new MySqlDataAdapter(selectQuery, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@nim", nimRef);
                    using (adapter)
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        adapter.Fill(initData);
                        this.dtListTagihan.DataSource = table;
                        for (int i = 0; i < dtListTagihan.Columns.Count; i++)
                        {
                            dtListTagihan.Columns[i].HeaderText = main.HeaderName("hdTagihan" + i.ToString());
                            dtListTagihan.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        }
                        dtListTagihan.Columns[0].ReadOnly = true;
                        dtListTagihan.Columns[1].ReadOnly = true;
                        tagihanIdOld = new string[dtListTagihan.Rows.Count];
                        for (int i = 0; i < dtListTagihan.Rows.Count; i++)
                        {
                            tagihanIdOld[i] = dtListTagihan.Rows[i].Cells[0].Value.ToString();
                        }
                    }
                }
            }
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            main.changePanelBack();
            main.formlevel = 1;
        }
        private void dtListTagihan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Data yang dimasukkan tidak valid");
        }
        private void btHapus_Click(object sender, EventArgs e)
        {
            hapus();
        }
        private void hapus()
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin akan menghapus data dari mahasiswa " +
                "ini? Segala perubahan akan tercatat di Histori Pembayaran.",
                "Peringatan!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string promptValue = Prompt.ShowDialog("Masukkan Catatan untuk Penghapusan");
                if (promptValue != "")
                {
                    var (sshClient, localPort) = ssh.ConnectSsh();
                    using (sshClient)
                    {
                        MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                        using (var connection = new MySqlConnection(csb.ConnectionString))
                        {
                            cmd = new MySqlCommand(deleteQuery, connection);
                            cmd.Parameters.AddWithValue("@tagihanid", selectedRowIndexValue(0));
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            cmd = new MySqlCommand(changesQuery, connection);
                            cmd.Parameters.AddWithValue("@cc", selectedRowIndexValue(0));
                            cmd.Parameters.AddWithValue("@admin", main.currentadmin);
                            cmd.Parameters.AddWithValue("@wc", "Penghapusan pada tagihan " + selectedRowIndexValue(0));
                            cmd.Parameters.AddWithValue("@catatan", promptValue);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Data tagihan " + selectedRowIndexValue(0) + " berhasil dihapus!");
                            deployData();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mohon berikan catatan untuk data yang akan dihapus");
                }
            }
        }
        private string selectedRowIndexValue(int indexx)
        {
            int selectedindex = dtListTagihan.CurrentCell.RowIndex;
            string value = dtListTagihan.Rows[selectedindex].Cells[indexx].Value.ToString();
            return value;
        }
        private void btPrint_Click(object sender, EventArgs e)
        {
            export();
        }
        private void export()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var (sshClient, localPort) = ssh.ConnectSsh();
                        using (sshClient)
                        {
                            MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                            using (var connection = new MySqlConnection(csb.ConnectionString))
                            {
                                var sqlcmd = new MySqlCommand(selectQuery);
                                sqlcmd.Parameters.AddWithValue("@nim", nimRef);
                                sqlcmd.Connection = connection;
                                using (MySqlDataAdapter adp = new MySqlDataAdapter(sqlcmd))
                                {
                                    using (DataTable dt = new DataTable())
                                    {
                                        adp.Fill(dt);
                                        for (int i = 0; i < dt.Columns.Count; i++)
                                        {
                                            dt.Columns[i].ColumnName = main.HeaderName("hdTagihan" + i.ToString());
                                        }
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
                                            var sheetTagihan = wb.Worksheets.Add(dt, "Daftar Tagihan");
                                            sheetTagihan.Columns("A", "G").AdjustToContents();
                                            wb.SaveAs(sfd.FileName);
                                        }
                                    }
                                }
                                MessageBox.Show("Berhasil menyimpan file!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin akan merubah data dari mahasiswa " +
                "ini? Segala perubahan akan tercatat di Histori Pembayaran.", 
                "Peringatan!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string promptValue = Prompt.ShowDialog("Masukkan Catatan untuk Perubahan");
                if(promptValue!="")
                {
                    //update data tagihan, insert into pembayaran
                    dataChanged = new bool[dtListTagihan.Rows.Count];
                    for (int i = 0; i < dtListTagihan.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtListTagihan.Columns.Count; j++)
                        {
                            if (dtListTagihan.Rows[i].Cells[j].Value.ToString() != initData.Rows[i].ItemArray[j].ToString())
                            {
                                dataChanged[i] = true;
                            }
                        }
                    }
                    for (int index = 0; index < dataChanged.Length; index++)
                    {
                        if (dataChanged[index] == true)
                        {
                            MessageBox.Show("Index " + index + " is true");
                        }
                    }
                    var (sshClient, localPort) = ssh.ConnectSsh();
                    using (sshClient)
                    {
                        MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                        using (var connection = new MySqlConnection(csb.ConnectionString))
                        {
                            connection.Open();
                            for (int i = 0; i < dataChanged.Length; i++)
                            {
                                if (dataChanged[i] == true)
                                {
                                    //update to tagihan
                                    cmd = new MySqlCommand(updateQuery, connection);
                                    cmd.Parameters.AddWithValue("@tagihanidnew", dtListTagihan.Rows[i].Cells[0].Value.ToString());
                                    cmd.Parameters.AddWithValue("@nim", dtListTagihan.Rows[i].Cells[1].Value.ToString());
                                    cmd.Parameters.AddWithValue("@semester", dtListTagihan.Rows[i].Cells[2].Value.ToString());
                                    cmd.Parameters.AddWithValue("@namatag", dtListTagihan.Rows[i].Cells[3].Value.ToString());
                                    cmd.Parameters.AddWithValue("@jumlah", int.Parse(dtListTagihan.Rows[i].Cells[4].Value.ToString()));
                                    cmd.Parameters.AddWithValue("@sisa", int.Parse(dtListTagihan.Rows[i].Cells[5].Value.ToString()));
                                    cmd.Parameters.AddWithValue("@status", dtListTagihan.Rows[i].Cells[6].Value.ToString());
                                    cmd.Parameters.AddWithValue("@tagihanid", tagihanIdOld[i]);
                                    cmd.ExecuteNonQuery();
                                    //insert into changes
                                    cmd = new MySqlCommand(changesQuery, connection);
                                    cmd.Parameters.AddWithValue("@cc", tagihanIdOld[i]);
                                    cmd.Parameters.AddWithValue("@admin", main.currentadmin);
                                    cmd.Parameters.AddWithValue("@wc", "Perubahan pada tagihan " + tagihanIdOld[i]);
                                    cmd.Parameters.AddWithValue("@catatan", promptValue);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            connection.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mohon berikan catatan untuk data yang diubah");
                }
            }
        }
    }
}
