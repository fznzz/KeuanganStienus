using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace KeuanganStienus
{
    public partial class MainMenu : Form
    {
        DataMahasiswa menu1;
        InputPembayaran menu2;
        EditTagihan menu3;
        public Form lastform1 { get; set; }
        public Form lastform2 { get; set; }
        public Form lastform3 { get; set; }
        public int formlevel { get; set; }

        EditTagihan_Password menu3password;
        Pengaturan_Password menu4password;
        string input;
        public string currentadmin { get; set; }

        public MainMenu()
        {
            InitializeComponent();
        }

        public void deployInitData()
        {
            timerJam.Enabled = true;
            menu1 = new DataMahasiswa();
            menu1.TopLevel = false;
            menu1.AutoScroll = true;
            menu1.FormBorderStyle = FormBorderStyle.None;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(menu1);
            lbLABELADMIN.Text += currentadmin;
            menu1.Show();
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
            menu1 = new DataMahasiswa();
            menu1.TopLevel = false;
            menu1.AutoScroll = true;
            menu1.FormBorderStyle = FormBorderStyle.None;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(menu1);
            menu1.Show();
            lastform1 = menu1;
            geserPanelSide(btMenuDataMahasiswa);
        }

        private void btMenuInputPembayaran_Click(object sender, EventArgs e)
        {
            menu2 = new InputPembayaran();
            menu2.currentadmin = currentadmin;
            menu2.TopLevel = false;
            menu2.AutoScroll = true;
            menu2.FormBorderStyle = FormBorderStyle.None;
            pnContent.Controls.Clear();
            pnContent.Controls.Add(menu2);
            menu2.Show();
            lastform1 = menu2;
            geserPanelSide(btMenuInputPembayaran);
        }

        private void btMenuEditTagihan_Click(object sender, EventArgs e)
        {
            menu3password = new EditTagihan_Password();
            menu3password.TopLevel = false;
            menu3password.AutoScroll = true;
            menu3password.main = this;
            changePanelContent(menu3password);
            lastform1 = menu3password;
            geserPanelSide(btMenuEditTagihan);
        }

        private void timerJam_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbTanggal.Text = dt.ToString("G");
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            menu4password = new Pengaturan_Password();
            menu4password.TopLevel = false;
            menu4password.AutoScroll = true;
            menu4password.main = this;
            changePanelContent(menu4password);
            /*pnContent.Controls.Clear();
            pnContent.Controls.Add(menu4password);
            menu3password.Show();*/
            lastform1 = menu4password;
            geserPanelSide(btSettings);
        }
        public void changePanelContent(Form form)
        {
            pnContent.Controls.Clear();
            pnContent.Controls.Add(form);
            form.Show();
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
    }
}
