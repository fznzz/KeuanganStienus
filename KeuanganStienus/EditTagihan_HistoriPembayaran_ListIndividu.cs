using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace KeuanganStienus
{
    public partial class EditTagihan_HistoriPembayaran_ListIndividu : Form
    {
        public MainMenu main { get; set; }
        private const string selectMhsQuery = "select * from mahasiswa";
        private const string selectQuery = "select * from pembayaran where nim=@nim";
        private const string selectMonthQuery = "select * from pembayaran where nim=@nim and tanggalBayar between " +
            "date_sub(now(), interval 90 day) and now()";
        bool isAll;
        public EditTagihan_HistoriPembayaran_ListIndividu()
        {
            InitializeComponent();
        }

        public void deployData()
        {
            tbSearch.Clear();
            using (var connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlConnectionString"].ConnectionString))
            using (var adapter = new MySqlDataAdapter(selectMhsQuery, connection))
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.dtHistori.DataSource = table;
                for (int i = 0; i < dtHistori.Columns.Count; i++)
                {
                    dtHistori.Columns[i].HeaderText = main.HeaderName("hdMahasiswa" + i.ToString());
                    dtHistori.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            back();
        }

        private void back()
        {
            main.changePanelBack();
            main.formlevel = 1;
            this.Dispose();
        }

        private void btConn_Click(object sender, EventArgs e)
        {
            deployData();
        }

        private void btExportAll_Click(object sender, EventArgs e)
        {
            isAll = true;
            export(isAll);
        }

        private void btExport6_Click(object sender, EventArgs e)
        {
            isAll = false;
            export(isAll);
        }

        private void export(bool all)
        {
            int rowindex = dtHistori.CurrentCell.RowIndex;
            var nimSelected = dtHistori.Rows[rowindex].Cells[0].Value.ToString();
            MessageBox.Show(nimSelected);
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var sqlcon = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlConnectionString"].ConnectionString);
                        var sqlcmd = new MySqlCommand();
                        sqlcmd.Connection = sqlcon;
                        switch (isAll)
                        {
                            case true:
                                sqlcmd.CommandText = selectQuery;
                                sqlcmd.Parameters.AddWithValue("@nim", nimSelected);
                                break;
                            case false:
                                sqlcmd.CommandText = selectMonthQuery;
                                sqlcmd.Parameters.AddWithValue("@nim", nimSelected);
                                break;
                        }
                        using (MySqlDataAdapter adp = new MySqlDataAdapter(sqlcmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                adp.Fill(dt);
                                for (int i = 0; i < dt.Columns.Count; i++)
                                {
                                    dt.Columns[i].ColumnName = main.HeaderName("hdPembayaran" + i.ToString());
                                }
                                using (XLWorkbook wb = new XLWorkbook())
                                {
                                    var sheet = wb.Worksheets.Add(dt, "Tagihan");
                                    sheet.Columns("A", "F").AdjustToContents();
                                    wb.SaveAs(sfd.FileName);
                                }
                            }
                        }
                        MessageBox.Show("Berhasil menyimpan file!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
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
                DataSource = dtHistori.DataSource,
                Filter = string.Format("nama LIKE '%{0}%'", tbSearch.Text)
            };
            dtHistori.DataSource = bs;
        }
    }
}
