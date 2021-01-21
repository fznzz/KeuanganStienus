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
    public partial class EditTagihan_EditList_Detail : Form
    {
        public string nimRef { get; set; }
        public string namaRef { get; set; }
        public string jurusanRef { get; set; }
        public string kelasRef { get; set; }
        public MainMenu main { get; set; }
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

        }
        private void btBack_Click(object sender, EventArgs e)
        {
            main.changePanelBack();
            main.formlevel = 1;
        }
    }
}
