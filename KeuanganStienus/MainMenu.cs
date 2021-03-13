using System;
using System.Windows.Forms;

namespace KeuanganStienus
{
    public partial class MainMenu : Form
    {
        DataMahasiswa menu1;
        InputPembayaran menu2;
        Pengaturan menu4;
        public Form lastform1 { get; set; }
        public Form lastform2 { get; set; }
        public Form lastform3 { get; set; }
        public int formlevel { get; set; }

        EditTagihan_Password menu3password;
        string input;
        public string currentadmin { get; set; }
        Form currentform { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            if(this.WindowState==FormWindowState.Maximized)
            {
                btMinimize.Visible = true;
                btMaximize.Visible = false;
            }
            if(this.WindowState==FormWindowState.Normal)
            {
                btMinimize.Visible = false;
                btMaximize.Visible = true;
            }
        }

        public void deployInitData()
        {
            timerJam.Enabled = true;
            btMenu1();
            lbLABELADMIN.Text += currentadmin;
        }

        private void geserPanelSide(Button btDock)
        {
            pnSide.Top = btDock.Top;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btMenuDataMahasiswa_Click(object sender, EventArgs e)
        {
            btMenu1();
        }

        private void btMenu1()
        {
            menu1 = new DataMahasiswa
            {
                TopLevel = false,
                AutoScroll = true,
                FormBorderStyle = FormBorderStyle.None,
                main = this
            };
            menu1.deployData();
            changePanelContent(menu1);
            lastform1 = menu1;
            geserPanelSide(btMenuDataMahasiswa);
        }

        private void btMenu2()
        {
            menu2 = new InputPembayaran();
            menu2.currentadmin = currentadmin;
            menu2.TopLevel = false;
            menu2.AutoScroll = true;
            menu2.FormBorderStyle = FormBorderStyle.None;
            menu2.main = this;
            menu2.refreshMahasiswa();
            changePanelContent(menu2);
            lastform1 = menu2;
            geserPanelSide(btMenuInputPembayaran);
        }

        private void btMenu3()
        {
            menu3password = new EditTagihan_Password();
            menu3password.TopLevel = false;
            menu3password.AutoScroll = true;
            menu3password.main = this;
            changePanelContent(menu3password);
            lastform1 = menu3password;
            geserPanelSide(btMenuEditTagihan);
        }

        private void btMenu4()
        {
            menu4 = new Pengaturan();
            menu4.TopLevel = false;
            menu4.AutoScroll = true;
            menu4.main = this;
            changePanelContent(menu4);
            lastform1 = menu4;
            geserPanelSide(btSettings);
        }

        private void btMenuInputPembayaran_Click(object sender, EventArgs e)
        {
            btMenu2();
        }

        private void btMenuEditTagihan_Click(object sender, EventArgs e)
        {
            
            btMenu3();
        }

        private void timerJam_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbTanggal.Text = dt.ToString("G");
            if (this.WindowState == FormWindowState.Maximized)
            {
                btMinimize.Visible = true;
                btMaximize.Visible = false;
                resizeContent();
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                btMinimize.Visible = false;
                btMaximize.Visible = true;
                resizeContent();
            }
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            btMenu4();
        }

        public void changePanelContent(Form form)
        {
            pnContent.Controls.Clear();
            pnContent.Controls.Add(form);
            currentform = form;
            form.Show();
            resizeContent();
        }

        public void changePanelBack()
        {
            switch (formlevel)
            {
                case 1:
                    changePanelContent(lastform1);
                    break;
                case 2:
                    changePanelContent(lastform2);
                    break;
                case 3:
                    changePanelContent(lastform3);
                    break;
            }
        }

        private void btMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btMinimize.Visible = true;
            btMaximize.Visible = false;
            resizeContent();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btMaximize.Visible = true;
            btMinimize.Visible = false;
            resizeContent();
        }
        public void resizeContent()
        {
            currentform.Width = pnContent.Width;
            currentform.Height = pnContent.Height;
        }
        public string HeaderName(string hdname)
        {
            switch (hdname)
            {
                case "hdMahasiswa0":
                    return "NIM";
                case "hdMahasiswa1":
                    return "Nama";
                case "hdMahasiswa2":
                    return "Jurusan";
                case "hdMahasiswa3":
                    return "Kelas";
                case "hdMahasiswa4":
                    return "Angkatan";
                case "hdMahasiswa5":
                    return "Deposit";
                case "hdMahasiswa6":
                    return "Status";
                case "hdTagihan0":
                    return "ID Tagihan";
                case "hdTagihan1":
                    return "NIM";
                case "hdTagihan2":
                    return "Semester Tagihan";
                case "hdTagihan3":
                    return "Nama Tagihan";
                case "hdTagihan4":
                    return "Jumlah Tagihan";
                case "hdTagihan5":
                    return "Kekurangan";
                case "hdTagihan6":
                    return "Status";
                case "hdPembayaran0":
                    return "ID Pembayaran";
                case "hdPembayaran1":
                    return "ID Tagihan";
                case "hdPembayaran2":
                    return "NIM";
                case "hdPembayaran3":
                    return "Jumlah Pembayaran";
                case "hdPembayaran4":
                    return "Tanggal Pembayaran";
                case "hdPembayaran5":
                    return "Admin Penerima";
                case "hdPerubahan0":
                    return "ID Perubahan";
                case "hdPerubahan1":
                    return "ID Data yang Diubah";
                case "hdPerubahan2":
                    return "Admin Pengubah";
                case "hdPerubahan3":
                    return "Perubahan";
                case "hdPerubahan4":
                    return "Tanggal Perubahan";
                case "hdPerubahan5":
                    return "Catatan Perubahan";
                default:
                    return "Ini adalah bug, lapor ke developer";
            }
        }
        public class HeaderNames
        {

            public const string hdMahasiswa1 = "NIM";
            public const string hdMahasiswa2 = "Nama";
            public const string hdMahasiswa3 = "Jurusan";
            public const string hdMahasiswa4 = "Kelas";
            public const string hdMahasiswa5 = "Angkatan";
            public const string hdMahasiswa6 = "Deposit";
            public const string hdMahasiswa7 = "Status";
        }
    }
}
