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
    public partial class EditTagihan_EditList_Detail : Form
    {
        public string nimRef { get; set; }
        public string namaRef { get; set; }
        public string jurusanRef { get; set; }
        public string kelasRef { get; set; }
        public MainMenu main { get; set; }
        private const string selectQuery = "select * from tagihan where nim=@nim";
        private const string updateQuery = "update tagihan set tagihanID=@tagihanidnew,nim=@nim,semesterTagihan=@semester,jumlahTagihan=@jumlah," +
            "sisaTagihan=@sisa,statusTagihan=@status where tagihanID=@tagihanid";
        private const string changesQuery = ""; //buat tabel CHANGES di SQL
        private const string ConnectionString = "Data Source=LAPTOP-TRVBE94C\\SQLEXPRESS;Initial Catalog=stienus;Persist Security Info=True;User ID=stienusadmin;Password=abcd1234";
        SqlDataAdapter adapter;
        SqlConnection conn,conn2;
        SqlCommand cmd;
        DataTable initData;
        bool[] dataChanged;
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
            conn = new SqlConnection(ConnectionString);
            adapter = new SqlDataAdapter(selectQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@nim", nimRef);
            using (conn)
            using (adapter)
            {
                var table = new DataTable();
                adapter.Fill(table);
                adapter.Fill(initData);
                this.dtListTagihan.DataSource = table;
                dtListTagihan.Columns[0].HeaderText = "ID Tagihan";
                dtListTagihan.Columns[1].HeaderText = "NIM";
                dtListTagihan.Columns[1].ReadOnly = true;
                dtListTagihan.Columns[2].HeaderText = "Semester";
                dtListTagihan.Columns[3].HeaderText = "Nama Tagihan";
                dtListTagihan.Columns[4].HeaderText = "Jumlah";
                dtListTagihan.Columns[5].HeaderText = "Sisa";
                dtListTagihan.Columns[6].HeaderText = "Status";
                dtListTagihan.Columns[0].Width = 190;
                dtListTagihan.Columns[1].Width = 150;
                dtListTagihan.Columns[2].Width = 150;
                dtListTagihan.Columns[3].Width = 250;
                dtListTagihan.Columns[4].Width = 150;
                dtListTagihan.Columns[5].Width = 150;
                dtListTagihan.Columns[6].Width = 150;
            }
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            main.changePanelBack();
            main.formlevel = 1;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin akan merubah data dari mahasiswa " +
                "ini? Segala perubahan akan tercatat di Histori Pembayaran.", 
                "Peringatan!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //update data tagihan, insert into pembayaran
                dataChanged = new bool[dtListTagihan.Rows.Count];
                for (int i = 0; i < dtListTagihan.Rows.Count; i++)
                {
                    for (int j = 0; j < dtListTagihan.Columns.Count; j++)
                    {
                        if(dtListTagihan.Rows[i].Cells[j].Value.ToString()!=initData.Rows[i].ItemArray[j].ToString())
                        {
                            MessageBox.Show("detect: "+dtListTagihan.Rows[i].Cells[j].Value.ToString());
                            dataChanged[i] = true;
                        }
                    }
                }
                conn2 = new SqlConnection(ConnectionString);
                conn2.Open();
                for (int i = 0; i < dataChanged.Length; i++)
                {
                    if(dataChanged[i]==true)
                    {
                        //update to tagihan
                        cmd = new SqlCommand(updateQuery, conn2);
                        cmd.Parameters.AddWithValue("@tagihanidnew", dtListTagihan.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@nim", dtListTagihan.Rows[i].Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@semester", dtListTagihan.Rows[i].Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@jumlah", int.Parse(dtListTagihan.Rows[i].Cells[3].Value.ToString()));
                        cmd.Parameters.AddWithValue("@sisa", int.Parse(dtListTagihan.Rows[i].Cells[4].Value.ToString()));
                        cmd.Parameters.AddWithValue("@status", dtListTagihan.Rows[i].Cells[5].Value.ToString());
                        cmd.ExecuteNonQuery();
                        //insert into changes
                    }
                    MessageBox.Show(dataChanged[i].ToString());
                }
            }
        }
    }
}
