using R6Stats.controllers;
using R6Stats.controllers.entities;
using R6Stats.ui;
using R6Stats.webCrawler;
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
        Alerts alerts = new Alerts();

        public IDForm()
        {
            InitializeComponent();
        }

        private void R6Stats_Load(object sender, EventArgs e)
        {
            ChangeBackground();
        }

        private void TrocarForm()
        {
            Program.Context.MainForm = new StatsForm();
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void ChangeBackground()
        {
            Random random = new Random();
            int imagem = random.Next(1, 6);

            this.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\background\\" + imagem + ".jpg");
        }

        private void procurar_Click(object sender, EventArgs e)
        {
            string plat = "";
            if (pcRadio.Checked)
            {
                plat = "pc";
            } else if (psRadio.Checked)
            {
                plat = "psn";
            } else if (xboxRadio.Checked)
            {
                plat = "xbox";
            }
            WebCrawler.StartCrawler(plat, idTextBox.Text);

            if (!IdController.GetExiste())
            {
                string message = "Id de jogador não encontrado";
                string caption = "Erro";
                alerts.Alert(message, caption);
            } else
            {
                TrocarForm();
            }
        }

    }
}
