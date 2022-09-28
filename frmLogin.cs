using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemThiTracNghiem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            Event.ReleaseCapture();
            Event.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
