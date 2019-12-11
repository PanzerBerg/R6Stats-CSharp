using R6Stats.controllers;
using R6Stats.ui.forms;
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
            SetStats();
            UpdateProgress();
        }

        private void UpdateProgress()
        {
            Task.Run(() => 
            {
                double porcentage = (double.Parse(IdController.ContaWL) / 2) * 100; 
                for(int num = 0; num <= porcentage; num++)
                {
                    new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(this.ProgressUpgradeWL)).Start(num) ;
                    System.Threading.Thread.Sleep(30);
                }
            });

            Task.Run(() =>
            {
                double porcentage = (double.Parse(IdController.ContaKD.Replace(".", ",")) / 2) * 100;
                for (int num = 0; num <= porcentage; num++)
                {
                    new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(this.ProgressUpgradeKD)).Start(num);
                    System.Threading.Thread.Sleep(30);
                }
            });

        }

        private void ProgressUpgradeWL(object progress)
        {
            try
            {
                WLProgress.Invoke((MethodInvoker)delegate { WLProgress.UpdateProgress(Convert.ToInt32(progress)); });
            } catch (InvalidOperationException e)
            {
                Console.WriteLine("Closing application: " + e.Message);
                Application.Exit();
            } catch (InvalidAsynchronousStateException e)
            {
                Console.WriteLine("Closing application: " + e.Message);
                Application.Exit();
            }
        }

        private void ProgressUpgradeKD(object progress)
        {
            try
            {
                KDProgress.Invoke((MethodInvoker)delegate { KDProgress.UpdateProgress(Convert.ToInt32(progress)); });
            } catch (InvalidOperationException e)
            {
                Console.WriteLine("Closing application: " + e.Message);
                Application.Exit();
            } catch (InvalidAsynchronousStateException e)
            {
                Console.WriteLine("Closing application: " + e.Message);
                Application.Exit();
            }
        }

        private void SetStats()
        {
            ataqueOpTime.Text = IdController.OpAtqTime;
            ataqueOpWL.Text = IdController.OpAtqWL;
            ataqueOpKD.Text = IdController.OpAtqKD;

            defesaOpTime.Text = IdController.OpDefTime;
            defesaOpWL.Text = IdController.OpDefWL;
            defesaOpKD.Text = IdController.OpDefKD;

            nameLabel.Text = IdController.ContaName;
        }

        private void SetImages()
        {
            string ataque = IdController.OpAtq.ToLower();
            string defesa = IdController.OpDef.ToLower();

            ataquePicture.BackColor = Color.Transparent;
            defesaPicture.BackColor = Color.Transparent;
            ataquePicture.Parent = defesaPicture;
            ataquePicture.Size = new Size(480, 800);
            defesaPicture.Size = new Size(800, 800);
            defesaPicture.Location = new Point(100, -60);
            ataquePicture.Location = new Point (-30, -2);

            ataquePicture.Image = Image.FromFile(Application.StartupPath + "\\images\\operators\\ataque\\" + ataque + ".png");
            defesaPicture.Image = Image.FromFile(Application.StartupPath + "\\images\\operators\\defesa\\" + defesa + ".png");


            ataqueOpIcon.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\operators\\icons_ataque\\" + ataque + ".png");
            defesaOpIcon.BackgroundImage = Image.FromFile(Application.StartupPath + "\\images\\operators\\icons_defesa\\" + defesa + ".png");

            ataqueOpLabel.Text = ataque.ToUpper();
            defesaOpLabel.Text = defesa.ToUpper();
        }

        private void TrocaFrom(Form form)
        {
            Program.Context.MainForm = form;
            this.Close();
            Program.Context.MainForm.Show();
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            Form form = new AttackersForm();
            TrocaFrom(form);
        }

        private void Deffense_Click(object sender, EventArgs e)
        {
            Form form = new DefendersForm();
            TrocaFrom(form);
        }

        private void Account_Click(object sender, EventArgs e)
        {
            Form form = new AccountForm();
            TrocaFrom(form);
        }

        private void search_Click(object sender, EventArgs e)
        {
            Form form = new IDForm();
            TrocaFrom(form);
        }
    }
}
