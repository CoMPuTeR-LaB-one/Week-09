using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlus_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap bmp = new Bitmap("D:\\saitama.JPG");
            this.SetClientSizeCore(bmp.Width, bmp.Height);
            Rectangle topLeft = new Rectangle(0, 0, bmp.Width / 2, bmp.Height / 2);
            Rectangle topRight = new Rectangle(0, bmp.Height / 2, bmp.Width / 2, bmp.Height / 2);
            Rectangle bottomLeft = new Rectangle(0, bmp.Height / 2, bmp.Width / 2, bmp.Height / 2);
            Rectangle bottomRight = new Rectangle(bmp.Width / 2, bmp.Height / 2, bmp.Width / 2, bmp.Height / 2);

            bmp.RotateFlip(RotateFlipType.RotateNoneFlipNone);
            e.Graphics.DrawImage(bmp, topLeft);

            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            e.Graphics.DrawImage(bmp, topRight);

            bmp.RotateFlip(RotateFlipType.RotateNoneFlipNone);
            e.Graphics.DrawImage(bmp, bottomLeft);

            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            e.Graphics.DrawImage(bmp, bottomRight);

        }
    }
}
