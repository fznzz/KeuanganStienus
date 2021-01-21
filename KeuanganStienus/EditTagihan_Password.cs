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
    public partial class EditTagihan_Password : Form
    {
        EditTagihan editTagihan;
        public MainMenu main { get; set; }
        string pwd = "password";
        public EditTagihan_Password()
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
                editTagihan = new EditTagihan();
                editTagihan.TopLevel = false;
                editTagihan.AutoScroll = false;
                editTagihan.main = main;
                main.changePanelContent(editTagihan);
                main.lastform1 = editTagihan;
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
