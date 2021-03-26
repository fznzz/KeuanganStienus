using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace KeuanganStienus
{
    public partial class Pengaturan_Perubahan : Form
    {
        private const string selectQuery = "select * from changes";
        private const string selectMonthQuery = "select * from changes where datetime between " +
            "date_sub(now(), interval 90 day) and now()";
        public MainMenu main { get; set; }
        MySqlConnection conn;
        bool isAll;
        public Pengaturan_Perubahan()
        {
            InitializeComponent();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            main.changePanelBack();
            main.formlevel = 1;
            this.Dispose();
        }

        public void deployData()
        {
            conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
            using(conn)
            using(MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery,conn))
            {
                var table = new DataTable();
                adapter.Fill(table);
                this.dtHistori.DataSource = table;
                dtHistori.Columns[0].HeaderText = "ID Perubahan";
                dtHistori.Columns[1].HeaderText = "ID Tagihan/Pembayaran";
                dtHistori.Columns[2].HeaderText = "Admin";
                dtHistori.Columns[3].HeaderText = "Apa yang diubah";
                dtHistori.Columns[4].HeaderText = "Tanggal";
                dtHistori.Columns[5].HeaderText = "Catatan";
                dtHistori.Columns[0].Width = 150;
                dtHistori.Columns[1].Width = 150;
                dtHistori.Columns[2].Width = 150;
                dtHistori.Columns[3].Width = 650;
                dtHistori.Columns[4].Width = 180;
                dtHistori.Columns[5].Width = 200;
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
                        var sqlcon = new MySqlConnection(ConfigurationManager.ConnectionStrings["myuwucs"].ConnectionString);
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
                                dt.Columns[0].ColumnName = "ID Perubahan";
                                dt.Columns[1].ColumnName = "ID Tagihan/Pembayaran Terdampak";
                                dt.Columns[2].ColumnName = "Admin Pengganti";
                                dt.Columns[3].ColumnName = "Keterangan Perubahan";
                                dt.Columns[4].ColumnName = "Tanggal Perubahan";
                                dt.Columns[5].ColumnName = "Catatan";
                                using (XLWorkbook wb = new XLWorkbook())
                                {
                                    var sheet = wb.Worksheets.Add(dt, "Perubahan");
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
    }
}
