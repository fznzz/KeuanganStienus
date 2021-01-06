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
    public partial class DataMahasiswa : Form
    {
        public string nimRef { get; set; }
        public string namaRef { get; set; }
        public string jurusanRef { get; set; }
        public string kelasRef { get; set; }
        public DataMahasiswa()
        {
            InitializeComponent();
        }
        public void deployData()
        {
            tbNim.Text = nimRef;
            tbNama.Text = namaRef;
            tbJurusan.Text = jurusanRef;
            tbKelas.Text = kelasRef;
            
        }

        private void dataMahasiswa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
