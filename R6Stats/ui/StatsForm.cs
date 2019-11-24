using R6Stats.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R6Stats.ui
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            SetImages();
        }

        private void SetImages()
        {
            string ataque = IdController.GetOpAtq().ToLower();
            string defesa = IdController.GetOpDef().ToLower();

            ataquePicture.BackColor = Color.Transparent;
            defesaPicture.BackColor = Color.Transparent;
            ataquePicture.Parent = defesaPicture;
            ataquePicture.Size = new Size(480, 800);
            defesaPicture.Size = new Size(800, 800);
            defesaPicture.Location = new Point(100, -80);
            ataquePicture.Location = new Point (-30, -2);

            ataquePicture.Image = Image.FromFile(Application.StartupPath + "\\images\\operators\\ataque\\" + ataque + ".png");
            defesaPicture.Image = Image.FromFile(Application.StartupPath + "\\images\\operators\\defesa\\" + defesa + ".png");


            ataqueOpIcon.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\operators\\icons_ataque\\" + ataque + ".png");
            defesaOpIcon.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\operators\\icons_defesa\\" + defesa + ".png");

            ataqueOpLabel.Text = ataque.ToUpper();
            defesaOpLabel.Text = defesa.ToUpper();
        }

    }
}
