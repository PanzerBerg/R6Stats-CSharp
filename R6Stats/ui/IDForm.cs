using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R6Stats
{
    public partial class IDForm : Form
    {
        public IDForm()
        {
            InitializeComponent();
        }

        private void R6Stats_Load(object sender, EventArgs e)
        {
            ChangeBackground();
        }

        private void ChangeBackground()
        {
            Random random = new Random();
            int imagem = random.Next(1, 6);

            background.Image = Image.FromFile(Application.StartupPath + "\\images\\background\\" + imagem + ".jpg");
        }
    }
}
