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
        int selected=0;
        Menu1DataMahasiswa menu1;
        Menu2InputPembayaran menu2;
        Menu3 menu3;
        string input;

        public MainMenu()
        {
            InitializeComponent();
            menu1 = new Menu1DataMahasiswa();
            menu1.TopLevel = false;
            menu1.AutoScroll = true;
            menu1.FormBorderStyle = FormBorderStyle.None;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(menu1);
            menu1.Show();
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            inputBox.ClientSize = size;
            inputBox.Text = "Password";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
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
                    //start menu1
                    menu1 = new Menu1DataMahasiswa();
                    menu1.TopLevel = false;
                    menu1.AutoScroll = true;
                    menu1.FormBorderStyle = FormBorderStyle.None;
                    splitContainer1.Panel2.Controls.Clear();
                    splitContainer1.Panel2.Controls.Add(menu1);
                    menu1.Show();
                    break;
                case 1:
                    //start menu2
                    menu2 = new Menu2InputPembayaran();
                    menu2.TopLevel = false;
                    menu2.AutoScroll = true;
                    menu2.FormBorderStyle = FormBorderStyle.None;
                    splitContainer1.Panel2.Controls.Clear();
                    splitContainer1.Panel2.Controls.Add(menu2);
                    menu2.Show();
                    break;
                case 2:
                    //start menu3
                    string hasil = ShowInputDialog(ref input).ToString();
                    if(hasil=="OK")
                    {
                        if (input == "password")
                        {
                            menu3 = new Menu3();
                            menu3.TopLevel = false;
                            menu3.AutoScroll = true;
                            menu3.FormBorderStyle = FormBorderStyle.None;
                            splitContainer1.Panel2.Controls.Clear();
                            splitContainer1.Panel2.Controls.Add(menu3);
                            menu3.Show();
                        }
                        else MessageBox.Show("Password salah");
                    }
                    break;
            }
        }
        public void upperCaseGen(TextBox a)
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            a.Text = textInfo.ToTitleCase(a.Text.ToLower());
        }
    }
}
