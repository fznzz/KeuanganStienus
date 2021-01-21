using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeuanganStienus
{
    class DragControl : Component
    {
        private Control handleControl;
        public Control selectControl
        {
            get
            {
                return this.handleControl;
            }
            set
            {
                this.handleControl = value;
                this.handleControl.MouseDown += new MouseEventHandler(this.dragForm_mouseControl);
            }
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private void dragForm_mouseControl(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;
            if(flag)
            {
                DragControl.ReleaseCapture();
                DragControl.SendMessage(this.selectControl.FindForm().Handle,161,2,0);
            }
        }
    }
}
