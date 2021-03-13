using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;

namespace KeuanganStienus
{
    public partial class EditTagihan_HistoriPembayaran : Form
    {
        public MainMenu main { get; set; }
        MySqlConnection conn;
        private const string selectQuery = "select * from pembayaran";
        private const string selectMonthQuery = "select * from pembayaran where tanggalBayar between " +
            "date_sub(now(), interval 90 day) and now()";
        bool isAll;

        public EditTagihan_HistoriPembayaran()
        {
            InitializeComponent();
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

        public void deployData()
        {
            //display data of the table
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mysqlConnectionString"].ConnectionString);
            using (conn)
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, conn))
            {
                //rename column header from mysql column name and control column width
                var table = new DataTable();
                adapter.Fill(table);
                this.dtHistori.DataSource = table;
                for (int i = 0; i < dtHistori.Columns.Count; i++)
                {
                    dtHistori.Columns[i].HeaderText = main.HeaderName("hdPembayaran" + i.ToString());
                    dtHistori.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
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
            //because the choice is 6 month or ALL, we use bool for 2 choice option
            isAll = false;
            export(isAll);
        }
        private void export(bool all)
        {
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
                                break;
                            case false:
                                sqlcmd.CommandText = selectMonthQuery;
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

        private void btListPembayaran_Click(object sender, EventArgs e)
        {
            deployPembayaran();
        }

        private void deployPembayaran()
        {
            EditTagihan_HistoriPembayaran_ListIndividu listIndividu = new EditTagihan_HistoriPembayaran_ListIndividu
            {
                TopLevel = false,
                AutoScroll = false,
                main = main
            };
            listIndividu.deployData();
            main.changePanelContent(listIndividu);
            main.lastform2 = this;
            main.formlevel = 2;
        }
    }
}
