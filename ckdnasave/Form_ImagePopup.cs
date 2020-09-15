using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ckdnasave
{
    public partial class Form_ImagePopup : Form
    {
        string fileLocation;
        bool isMove;
        Point fPt;
        public Form_ImagePopup(string src)
        {
            InitializeComponent();
            this.fileLocation = src;
            pictureBox1.Load(src);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Dispose();
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMove = true;
            fPt = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (fPt.X - e.X), this.Top - (fPt.Y - e.Y));
            }
        }
    }
}
