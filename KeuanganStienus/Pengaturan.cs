using System;
using System.Windows.Forms;

namespace KeuanganStienus
{
    public partial class Pengaturan : Form
    {
        Pengaturan_EditPassword editPassword;
        Pengaturan_KelolaAkun hapusAkun;
        Pengaturan_TambahAkun tambahAkun;
        Pengaturan_Perubahan perubahan;
        Pengaturan_Password gatekeeper;
        public MainMenu main { get; set; }
        public Pengaturan()
        {
            InitializeComponent();
        }
        private void btTambahAkun_Click(object sender, EventArgs e)
        {
            bukaGatekeeper("tambah");
        }
        private void btEditPassword_Click(object sender, EventArgs e)
        {
            bukaEditPassword();
        }
        private void btHapusAkun_Click(object sender, EventArgs e)
        {
            bukaGatekeeper("hapus");
        }
        private void btHistori_Click(object sender, EventArgs e)
        {
            bukaGatekeeper("perubahan");   
        }
        public void bukaTambahAkun()
        {
            tambahAkun = new Pengaturan_TambahAkun
            {
                TopLevel = false,
                AutoScroll = false,
                main = main
            };
            main.changePanelContent(tambahAkun);
            main.lastform1 = this;
            main.formlevel = 1;
        }
        private void bukaEditPassword()
        {
            editPassword = new Pengaturan_EditPassword
            {
                TopLevel = false,
                AutoScroll = false,
                main = main,
                currentAdmin = main.currentadmin
            };
            editPassword.deployData();
            main.changePanelContent(editPassword);
            main.lastform1 = this;
            main.formlevel = 1;
        }
        public void bukaHapusAkun()
        {
            hapusAkun = new Pengaturan_KelolaAkun
            {
                TopLevel = false,
                AutoScroll = false,
                main = main
            };
            hapusAkun.refreshAkun();
            main.changePanelContent(hapusAkun);
            main.lastform1 = this;
            main.formlevel = 1;
        }
        public void bukaPerubahan()
        {
            perubahan = new Pengaturan_Perubahan
            {
                TopLevel = false,
                AutoScroll = false,
                main = main
            };
            perubahan.deployData();
            main.changePanelContent(perubahan);
            main.lastform1 = this;
            main.formlevel = 1;
        }
        private void bukaGatekeeper(string o)
        {
            gatekeeper = new Pengaturan_Password
            {
                TopLevel = false,
                AutoScroll = false,
                opsi = o,
                main = main,
                pengaturan = this
            };
            main.changePanelContent(gatekeeper);
        }        
    }
}
