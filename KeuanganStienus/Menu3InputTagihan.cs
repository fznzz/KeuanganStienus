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
    public partial class Menu3InputTagihan : Form
    {
        public Menu3InputTagihan()
        {
            InitializeComponent();
        }

        private void btTambahTagihan_Click(object sender, EventArgs e)
        {
            TambahTagihan tambahTagihan = new TambahTagihan();
            tambahTagihan.ShowDialog();
        }

        private void btEditTagihan_Click(object sender, EventArgs e)
        {
            EditTagihan editTagihan = new EditTagihan();
            editTagihan.ShowDialog();
        }
    }
}
