using System;
using System.Windows.Forms;

namespace KeuanganStienus
{
    public partial class EditTagihan : Form
    {
        public MainMenu main { get; set; }
        public EditTagihan()
        {
            InitializeComponent();
        }

        private void btTambahTagihan_Click(object sender, EventArgs e)
        {
            EditTagihan_TambahTagihan tambahTagihan = new EditTagihan_TambahTagihan();
            tambahTagihan.TopLevel = false;
            tambahTagihan.AutoScroll = false;
            tambahTagihan.edit = this;
            tambahTagihan.main = main;
            main.changePanelContent(tambahTagihan);
            main.lastform1 = this;
            main.formlevel = 1;
        }

        private void btEditTagihan_Click(object sender, EventArgs e)
        {
            EditTagihan_EditList editTagihan = new EditTagihan_EditList
            {
                TopLevel = false,
                AutoScroll = false,
                main = main
            };
            editTagihan.RefreshMahasiswa();
            main.changePanelContent(editTagihan);
            main.lastform1 = this;
            main.formlevel = 1;
        }

        private void btPembayaran_Click(object sender, EventArgs e)
        {
            EditTagihan_HistoriPembayaran histori = new EditTagihan_HistoriPembayaran();
            histori.TopLevel = false;
            histori.AutoScroll = false;
            histori.main = main;
            histori.deployData();
            main.changePanelContent(histori);
            main.lastform1 = this;
            main.formlevel = 1;
        }

        private void btEditStatus_Click(object sender, EventArgs e)
        {
            EditTagihan_EditStatus status = new EditTagihan_EditStatus
            {
                TopLevel = false,
                AutoScroll = false,
                main = main
            };
            status.deployData();
            main.changePanelContent(status);
            main.lastform1 = this;
            main.formlevel = 1;
        }
    }
}
