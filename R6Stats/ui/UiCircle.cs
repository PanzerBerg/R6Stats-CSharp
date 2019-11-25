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
    public partial class UiCircle : UserControl
    {
        public UiCircle()
        {
            InitializeComponent();
        }

        private void UiCircle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen obj_pen = new Pen(Color.FromArgb(31, 36, 42));
            Rectangle rectangle = new Rectangle(0 - this.Width / 2 + 1, 0 - this.Height / 2 + 1, this.Width - 2, this.Height - 2);
            e.Graphics.DrawPie(obj_pen, rectangle, 0, 360);// 360 / 100 = 3,6
            e.Graphics.FillPie(new SolidBrush(Color.FromArgb(31, 36, 42)), rectangle, 0, 360);

        }
    }
}
