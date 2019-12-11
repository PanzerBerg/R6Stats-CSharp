using R6Stats.controllers;
using R6Stats.webCrawler;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace R6Stats.ui.forms
{
    public partial class AttackersForm : Form
    {
        private string opperator = "";

        public AttackersForm()
        {
            InitializeComponent();
        }

        private void AttackersForm_Load(object sender, EventArgs e)
        {
            WebCrawler.AttackersAsync();
            SetStats();
            SetImages();
        }

        private void SetStats()
        {
            ataqueOpTime.Text = IdController.OpAtqTime;

            ataqueKills.Text = "";
            ataqueDeaths.Text = "";
            ataqueKD.Text = IdController.OpAtqKD;

            ataqueWins.Text = IdController.OpAtqWins;
            ataqueLosses.Text = IdController.OpAtqLosses;
            ataqueWL.Text = IdController.OpAtqWL;

            ataqueMelee.Text = "";
            ataqueHeadshots.Text = "";
            ataqueDBNOS.Text = "";
        }

        private void SetImages()
        {
            string op = IdController.OpAtq.ToLower();

            ataqueOpLabel.Text = IdController.OpAtq;

            ataqueOpIcon.Image = Image.FromFile(Application.StartupPath + "\\images\\operators\\icons_ataque\\" + op + ".png");
            ataquePicture.Image = Image.FromFile(Application.StartupPath + "\\images\\operators\\ataque\\" + op + ".png");
        }
    }
}
