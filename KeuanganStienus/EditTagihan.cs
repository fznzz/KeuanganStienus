using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            EditTagihan_EditList editTagihan = new EditTagihan_EditList();
            editTagihan.TopLevel = false;
            editTagihan.AutoScroll = false;
            editTagihan.main = main;
            main.changePanelContent(editTagihan);
            main.lastform1 = this;
            main.formlevel = 1;
        }
    }
}
