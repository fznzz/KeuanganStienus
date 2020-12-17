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
    public partial class Form2 : Form
    {
        int selected;
        public Form2()
        {
            InitializeComponent();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            /*selected = listView1.SelectedItems[0].Index;*/
            if (listMenu.SelectedItems.Count > 0)
            {
                for (int i = 0; i <= listMenu.Items.Count - 1; i++)
                {
                    if (listMenu.Items[i].Selected == true)
                    {
                        selected = i;
                        break;
                    }
                }
            }
            switch (selected)
            {
                case 0:
                    MessageBox.Show("open menu1!");
                    break;
                case 1:
                    MessageBox.Show("open menu2!");
                    break;
                case 2:
                    MessageBox.Show("open menu3!");
                    break;
            }
        }
    }
}
