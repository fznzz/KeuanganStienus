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
    public partial class Pengaturan_Password : Form
    {
        Pengaturan pengaturan;
        public MainMenu main { get; set; }
        string pwd = "password";
        public Pengaturan_Password()
        {
            InitializeComponent();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            passwordChecker();
        }
        private void passwordChecker()
        {
            if (tbPassword.Text == pwd)
            {
                //go to next
                pengaturan = new Pengaturan();
                pengaturan.TopLevel = false;
                pengaturan.AutoScroll = false;
                main.changePanelContent(pengaturan);
                main.lastform1 = pengaturan;
            }
            else
            {
                MessageBox.Show("Maaf, password yang anda masukkan salah");
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                passwordChecker();
            }
        }
    }
}
