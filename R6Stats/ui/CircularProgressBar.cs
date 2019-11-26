using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R6Stats.ui
{
    public partial class CircularProgressBar : UserControl
    {
        double progress;
        public CircularProgressBar()
        {
            progress = 0;
            InitializeComponent();
        }

        private void CircularProgressBar_Paint(object sender, PaintEventArgs e)
        {
            StringFormat ft = new StringFormat();

            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.RotateTransform(-90);
            Pen obj_pen = new Pen(Color.FromArgb(245,245,245));
            Rectangle rectangle = new Rectangle(0-this.Width/2 + 20, 0-this.Height/2 + 20, this.Width - 40, this.Height - 40);
            e.Graphics.DrawPie(obj_pen, rectangle, 0, (int)(this.progress * 3.6));// 360 / 100 = 3,6
            e.Graphics.FillPie(new SolidBrush(Color.FromArgb(245, 245, 245)), rectangle, 0, (int)(this.progress * 3.6));

            obj_pen = new Pen(Color.FromArgb(26, 29, 34));
            rectangle = new Rectangle(0 - this.Width / 2 + 22, 0 - this.Height / 2 + 22, this.Width - 44, this.Height - 44);
            e.Graphics.DrawPie(obj_pen, rectangle, 0, 360);
            e.Graphics.FillPie(new SolidBrush(Color.FromArgb(26, 29, 34)), rectangle, 0, 360);

            double value = (this.progress / 100) * 2;
            string counter = String.Format("{0:0.00}", value);

            e.Graphics.RotateTransform(90);
            ft.LineAlignment = StringAlignment.Center;
            ft.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(counter , new Font("Sans Serif", 18), new SolidBrush(Color.FromArgb(245,245,245)), rectangle, ft);


        }

        public void UpdateProgress(double progress)
        {
            this.progress = progress;
            this.Invalidate();
        }
    }
}
