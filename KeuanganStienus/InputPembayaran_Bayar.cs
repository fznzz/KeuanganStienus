using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KeuanganStienus
{
    public partial class InputPembayaran_Bayar : Form
    {
        //query untuk sql server
        private string selectMahasiswaQuery = "Select * from mahasiswa where nim=@nim";
        private string selectTagihanQuery = "Select * from tagihan where nim=@nim";
        string tempA, tempB;
        //getter dan setter untuk nama dan nim dari form sebelumnya
        public string nimRef { get; set; }
        public string namaRef { get; set; }
        public string currentadmin { get; set; }
        public MainMenu main { get; set; }
        public InputPembayaran bayar { get; set; }
        bool atLeastOne,depositOnly;
        int availNumber,totalDep,minDep,plusDep;
        bool[] available;
        public InputPembayaran_Bayar()
        {
            InitializeComponent();
        }
        public void deployData()
        {
            var (sshClient, localPort) = ssh.ConnectSsh();
            using (sshClient)
            {
                MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                using (var connection = new MySqlConnection(csb.ConnectionString))
                {
                    var cmd = new MySqlCommand("select deposit from mahasiswa where nim=@nim", connection);
                    cmd.Parameters.AddWithValue("@nim", nimRef);
                    connection.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tbSaldo.Text = reader["deposit"].ToString();
                        }
                        connection.Close();
                    }
                    //mengubah informasi textbox menjadi nama dan nim, lalu mengecek data di sql
                    tbNama.Text = namaRef;
                    tbNim.Text = nimRef;
                    checkMahasiswa(nimRef);
                }
            }
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            next();
        }
        private void next()
        {
            depositOnly = false;
            minDep = 0;
            totalDep = 0;
            plusDep = 0;
            if (chbDepositOnly.Checked == true)
            {
                depositOnly = true;
            }
            totalDep = int.Parse(tbSaldo.Text);
            if(tbMinusDeposit.Text!=string.Empty)
            {
                minDep = int.Parse(tbMinusDeposit.Text);
            }
            if(tbPlusDeposit.Text!=string.Empty)
            {
                plusDep = int.Parse(tbPlusDeposit.Text);
            }
            if(minDep>totalDep)
            {
                MessageBox.Show("Masukan deposit tidak valid");
            }
            else
            {
                availNumber = 0;
                available = new bool[dtListTagihan.Rows.Count];
                foreach (DataGridViewRow r in dtListTagihan.Rows)
                {
                    if (r.Cells[0].Value == null)
                    {
                        available[r.Index] = false;
                    }
                    else
                    {
                        if (int.Parse(r.Cells[0].Value.ToString()) == 0)
                        {
                            available[r.Index] = false;
                        }
                        else
                        {
                            if (int.Parse(r.Cells[0].Value.ToString()) > int.Parse(r.Cells[6].Value.ToString()))
                            {
                                available[r.Index] = false;
                            }
                            else
                            {
                                available[r.Index] = true;
                                availNumber += 1;
                            }
                        }
                    }
                }
                for (int i = 0; i < available.Length; i++)
                {
                    if (available[i] == true)
                    {
                        atLeastOne = true;
                    }
                }
                if(depositOnly==true)
                {
                    //override these shit go upload the deposit only even if the gridview is filled
                    InputPembayaran_VerifikasiBayar verifikasiDeposit = new InputPembayaran_VerifikasiBayar();
                    verifikasiDeposit.TopLevel = false;
                    verifikasiDeposit.AutoScroll = false;
                    verifikasiDeposit.namaRef = namaRef;
                    verifikasiDeposit.nimRef = nimRef;
                    verifikasiDeposit.currentadmin = currentadmin;
                    verifikasiDeposit.totalDep = totalDep;
                    verifikasiDeposit.plusDep = plusDep;
                    verifikasiDeposit.minDep = minDep;
                    verifikasiDeposit.main = main;
                    verifikasiDeposit.bayar = this;
                    verifikasiDeposit.isDepositOnly = true;
                    verifikasiDeposit.deployData();
                    main.changePanelContent(verifikasiDeposit);
                    main.lastform2 = this;
                    main.formlevel = 2;
                }
                else
                {
                    if (atLeastOne != true)
                    {
                        MessageBox.Show("Jumlah pembayaran tidak valid");
                    }
                    else
                    {
                        //membuat object verifikasi, kemudian setiap ada pembayaran yang dimasukkan akan di add ke list
                        //dimana akan ditampilkan di form verifikasi
                        InputPembayaran_VerifikasiBayar verifikasi = new InputPembayaran_VerifikasiBayar();
                        verifikasi.TopLevel = false;
                        verifikasi.AutoScroll = false;
                        verifikasi.rownumber = availNumber;
                        verifikasi.namaRef = namaRef;
                        verifikasi.nimRef = nimRef;
                        verifikasi.currentadmin = currentadmin;
                        verifikasi.totalDep = totalDep;
                        verifikasi.plusDep = plusDep;
                        verifikasi.minDep = minDep;
                        verifikasi.main = main;
                        verifikasi.bayar = this;
                        verifikasi.isDepositOnly = false;
                        for (int i = 0; i < dtListTagihan.RowCount; i++)
                        {
                            if (available[i] == false)
                            {
                                continue;
                            }
                            DataGridViewRow row = dtListTagihan.Rows[i];
                            if (row.Cells[0].Value == null) continue;
                            verifikasi.tagihanID.Add(row.Cells[1].Value.ToString());
                            verifikasi.namaTagihan.Add(row.Cells[4].Value.ToString());
                            verifikasi.sisaTagihan.Add(int.Parse(row.Cells[6].Value.ToString()));
                            //entah bagaimana, column baru selalu menempati index 0
                            verifikasi.jumlahBayar.Add(int.Parse(row.Cells[0].Value.ToString()));
                        }
                        verifikasi.deployData();
                        main.changePanelContent(verifikasi);
                        main.lastform2 = this;
                        main.formlevel = 2;
                    }
                }
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
            if (dtListTagihan.CurrentCell.ColumnIndex == 0) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(dtListTagihan_KeyPress);
                }
            }
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            bayar.refreshMahasiswa();
            main.changePanelBack();
            this.Dispose();
        }
        private void tbMinusDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbPlusDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void setEnabled()
        {
            if(tbMinusDeposit.Text!=string.Empty)
            {
                tbPlusDeposit.Enabled = false;
                tbMinusDeposit.Enabled = true;
            }
            else
            {
                tbMinusDeposit.Enabled = true;
                tbPlusDeposit.Enabled = true;
            }
            if(tbPlusDeposit.Text!=string.Empty)
            {
                tbPlusDeposit.Enabled = true;
                tbMinusDeposit.Enabled = false;
            }
        }
        private void tbMinusDeposit_TextChanged(object sender, EventArgs e)
        {
            setEnabled();
        }
        private void tbPlusDeposit_TextChanged(object sender, EventArgs e)
        {
            setEnabled();
        }
        private void checkMahasiswa(string nim)
        {
            var (sshClient, localPort) = ssh.ConnectSsh();
            using (sshClient)
            {
                MySqlConnectionStringBuilder csb = ssh.csbCall(localPort);
                using (var connection = new MySqlConnection(csb.ConnectionString))
                {
                    MySqlCommand oCmd = new MySqlCommand(selectMahasiswaQuery, connection);
                    oCmd.Parameters.AddWithValue("@nim", nim);
                    connection.Open();
                    using (MySqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            tempA = oReader["nim"].ToString();
                            tempB = oReader["nama"].ToString();
                        }
                        connection.Close();
                        if (tempA == nim)
                        {
                            tbNama.Text = tempB;
                            //mulai isi datagridview
                            var adapter = new MySqlDataAdapter(selectTagihanQuery, connection);
                            adapter.SelectCommand.Parameters.AddWithValue("@nim", nim);
                            using (connection)
                            using (adapter)
                            {
                                var table = new DataTable();
                                adapter.Fill(table);
                                this.dtListTagihan.DataSource = table;
                                DataGridViewColumn colPembayaran = new DataGridViewTextBoxColumn();
                                colPembayaran.HeaderText = "Pembayaran";
                                colPembayaran.Width = 150;
                                for (int i = 0; i < dtListTagihan.Columns.Count; i++)
                                {
                                    dtListTagihan.Columns[i].HeaderText = main.HeaderName("hdTagihan" + i.ToString());
                                    dtListTagihan.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                                    dtListTagihan.Columns[i].ReadOnly = true;
                                }
                                dtListTagihan.Columns.AddRange(colPembayaran);
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
    }
}
