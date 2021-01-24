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
            menu1 = new DataMahasiswa();
            menu1.TopLevel = false;
            menu1.AutoScroll = true;
            menu1.FormBorderStyle = FormBorderStyle.None;
            menu1.main = this;
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
    }
}
