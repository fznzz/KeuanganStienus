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
        public EditTagihan()
        {
            InitializeComponent();
        }

        private void btTambahTagihan_Click(object sender, EventArgs e)
        {
            EditTagihan_TambahTagihan tambahTagihan = new EditTagihan_TambahTagihan();
            tambahTagihan.ShowDialog();
        }

        private void btEditTagihan_Click(object sender, EventArgs e)
        {
            EditTagihan_EditList editTagihan = new EditTagihan_EditList();
            editTagihan.ShowDialog();
        }
    }
}
