using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;

namespace KeuanganStienus
{
    public partial class DataMahasiswa : Form 
    {
        private const string selectQuery = "Select * from mahasiswa";
        public MainMenu main { get; set; }
        DataMahasiswa_TambahMahasiswa tambah;

        public DataMahasiswa()
        {
            InitializeComponent();
        }

        private void btConn_Click(object sender, EventArgs e)
        {
            deployData();
        }

        public void deployData()
        {
            tbSearch.Clear();
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlConnectionString"].ConnectionString))
            using (var adapter = new MySqlDataAdapter(selectQuery, connection))
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.dtListMahasiswa.DataSource = table;
                for(int i = 0; i<dtListMahasiswa.Columns.Count; i++)
                {
                    dtListMahasiswa.Columns[i].HeaderText = main.HeaderName("hdMahasiswa" + i.ToString());
                    dtListMahasiswa.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length <= 0)
            {
                deployData();
                return;
            }
            string s = tbSearch.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = tbSearch.SelectionStart;
                int curSelLength = tbSearch.SelectionLength;
                tbSearch.SelectionStart = 0;
                tbSearch.SelectionLength = 1;
                tbSearch.SelectedText = s.ToUpper();
                tbSearch.SelectionStart = curSelStart;
                tbSearch.SelectionLength = curSelLength;
            }
            BindingSource bs = new BindingSource
            {
                DataSource = dtListMahasiswa.DataSource,
                Filter = string.Format("nama LIKE '%{0}%'", tbSearch.Text)
            };
            dtListMahasiswa.DataSource = bs;
        }
        private void gridData1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dtListMahasiswa.Rows[e.RowIndex];
                DataMahasiswa_Detail datamahasiswa = new DataMahasiswa_Detail
                {
                    TopLevel = false,
                    AutoScroll = false,
                    nimRef = row.Cells[0].Value.ToString(),
                    namaRef = row.Cells[1].Value.ToString(),
                    jurusanRef = row.Cells[2].Value.ToString(),
                    kelasRef = row.Cells[3].Value.ToString(),
                    main = main
                };
                datamahasiswa.deployDataTagihan();
                main.changePanelContent(datamahasiswa);
                main.lastform1 = this;
                main.formlevel = 1;
            }
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            tambah = new DataMahasiswa_TambahMahasiswa
            {
                TopLevel = false,
                AutoScroll = false,
                main = main
            };
            main.changePanelContent(tambah);
            main.lastform1 = this;
            main.formlevel = 1;
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
                        var sqlcon = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlConnectionString"].ConnectionString);
                        var sqlcmd = new MySqlCommand(selectQuery);
                        sqlcmd.Connection = sqlcon;
                        using (MySqlDataAdapter adp = new MySqlDataAdapter(sqlcmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                adp.Fill(dt);
                                for (int i = 0; i < dt.Columns.Count; i++) 
                                {
                                    dt.Columns[i].ColumnName = main.HeaderName("hdMahasiswa" + i.ToString());
                                }
                                using (XLWorkbook wb = new XLWorkbook())
                                {
                                    var sheet = wb.Worksheets.Add(dt, "Daftar Mahasiswa");
                                    sheet.Columns("A", "G").AdjustToContents();
                                    wb.SaveAs(sfd.FileName);
                                }
                            }
                        }
                        MessageBox.Show("Berhasil menyimpan file!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        return;
                    }
                }
            }
        }
    }
}
