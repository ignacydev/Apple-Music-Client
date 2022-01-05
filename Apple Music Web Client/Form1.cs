using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apple_Music_Web_Client
{
    public partial class Form1 : Form
    {
        public Point mouseLocation;

        public Form1()
        {
            InitializeComponent();
            wvAppleMusic.Source = new Uri("https://music.apple.com");
        }

        private void AppleMusicShow_Click(object sender, EventArgs e)
        {

        }

        private void pnlDrag_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pnlDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
