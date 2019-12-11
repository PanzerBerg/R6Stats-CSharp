using System.Drawing;

namespace R6Stats.ui
{
    partial class StatsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ataqueOpLabel = new System.Windows.Forms.Label();
            this.defesaOpLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ataqueOpTime = new System.Windows.Forms.Label();
            this.ataqueOpWL = new System.Windows.Forms.Label();
            this.ataqueOpKD = new System.Windows.Forms.Label();
            this.defesaOpKD = new System.Windows.Forms.Label();
            this.defesaOpWL = new System.Windows.Forms.Label();
            this.defesaOpTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.defesaOpIcon = new System.Windows.Forms.PictureBox();
            this.ataqueOpIcon = new System.Windows.Forms.PictureBox();
            this.ataquePicture = new System.Windows.Forms.PictureBox();
            this.defesaPicture = new System.Windows.Forms.PictureBox();
            this.uiCircle4 = new R6Stats.ui.UiCircle();
            this.uiCircle3 = new R6Stats.ui.UiCircle();
            this.uiCircle2 = new R6Stats.ui.UiCircle();
            this.uiCircle1 = new R6Stats.ui.UiCircle();
            this.KDProgress = new R6Stats.ui.CircularProgressBar();
            this.WLProgress = new R6Stats.ui.CircularProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defesaOpIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataqueOpIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataquePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defesaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ataqueOpLabel
            // 
            this.ataqueOpLabel.AutoSize = true;
            this.ataqueOpLabel.BackColor = System.Drawing.Color.Transparent;
            this.ataqueOpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ataqueOpLabel.ForeColor = System.Drawing.Color.Orange;
            this.ataqueOpLabel.Location = new System.Drawing.Point(16, 81);
            this.ataqueOpLabel.Name = "ataqueOpLabel";
            this.ataqueOpLabel.Size = new System.Drawing.Size(52, 17);
            this.ataqueOpLabel.TabIndex = 4;
            this.ataqueOpLabel.Text = "label1";
            this.ataqueOpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defesaOpLabel
            // 
            this.defesaOpLabel.AutoSize = true;
            this.defesaOpLabel.BackColor = System.Drawing.Color.Transparent;
            this.defesaOpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defesaOpLabel.ForeColor = System.Drawing.Color.Orange;
            this.defesaOpLabel.Location = new System.Drawing.Point(666, 81);
            this.defesaOpLabel.Name = "defesaOpLabel";
            this.defesaOpLabel.Size = new System.Drawing.Size(52, 17);
            this.defesaOpLabel.TabIndex = 5;
            this.defesaOpLabel.Text = "label1";
            this.defesaOpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Atacante mais utilizado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(618, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Defensor mais utilizado";
            // 
            // ataqueOpTime
            // 
            this.ataqueOpTime.AutoSize = true;
            this.ataqueOpTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ataqueOpTime.Location = new System.Drawing.Point(49, 178);
            this.ataqueOpTime.Name = "ataqueOpTime";
            this.ataqueOpTime.Size = new System.Drawing.Size(48, 13);
            this.ataqueOpTime.TabIndex = 14;
            this.ataqueOpTime.Text = "00h 00m";
            // 
            // ataqueOpWL
            // 
            this.ataqueOpWL.AutoSize = true;
            this.ataqueOpWL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ataqueOpWL.Location = new System.Drawing.Point(49, 208);
            this.ataqueOpWL.Name = "ataqueOpWL";
            this.ataqueOpWL.Size = new System.Drawing.Size(28, 13);
            this.ataqueOpWL.TabIndex = 15;
            this.ataqueOpWL.Text = "0.00";
            // 
            // ataqueOpKD
            // 
            this.ataqueOpKD.AutoSize = true;
            this.ataqueOpKD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ataqueOpKD.Location = new System.Drawing.Point(49, 238);
            this.ataqueOpKD.Name = "ataqueOpKD";
            this.ataqueOpKD.Size = new System.Drawing.Size(28, 13);
            this.ataqueOpKD.TabIndex = 16;
            this.ataqueOpKD.Text = "0.00";
            // 
            // defesaOpKD
            // 
            this.defesaOpKD.AutoSize = true;
            this.defesaOpKD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.defesaOpKD.Location = new System.Drawing.Point(675, 238);
            this.defesaOpKD.Name = "defesaOpKD";
            this.defesaOpKD.Size = new System.Drawing.Size(28, 13);
            this.defesaOpKD.TabIndex = 19;
            this.defesaOpKD.Text = "0.00";
            this.defesaOpKD.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // defesaOpWL
            // 
            this.defesaOpWL.AutoSize = true;
            this.defesaOpWL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.defesaOpWL.Location = new System.Drawing.Point(675, 208);
            this.defesaOpWL.Name = "defesaOpWL";
            this.defesaOpWL.Size = new System.Drawing.Size(28, 13);
            this.defesaOpWL.TabIndex = 18;
            this.defesaOpWL.Text = "0.00";
            this.defesaOpWL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // defesaOpTime
            // 
            this.defesaOpTime.AutoSize = true;
            this.defesaOpTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.defesaOpTime.Location = new System.Drawing.Point(655, 178);
            this.defesaOpTime.Name = "defesaOpTime";
            this.defesaOpTime.Size = new System.Drawing.Size(48, 13);
            this.defesaOpTime.TabIndex = 17;
            this.defesaOpTime.Text = "00h 00m";
            this.defesaOpTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(52, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 11);
            this.label1.TabIndex = 26;
            this.label1.Text = "PROPORÇÃO V/D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(643, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 11);
            this.label4.TabIndex = 27;
            this.label4.Text = "PROPORÇÃO E/M";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameLabel.Location = new System.Drawing.Point(208, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 17);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "label5";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameLabel.Click += new System.EventHandler(this.Account_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Image = global::R6Stats.Properties.Resources.DefWhite;
            this.pictureBox10.Location = new System.Drawing.Point(696, 17);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(30, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 33;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.Deffense_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::R6Stats.Properties.Resources.AtqWhite;
            this.pictureBox9.Location = new System.Drawing.Point(27, 17);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 32;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.Attack_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.pictureBox8.Image = global::R6Stats.Properties.Resources.trophy_icon_white;
            this.pictureBox8.Location = new System.Drawing.Point(73, 284);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(24, 24);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 25;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(42)))));
            this.pictureBox7.Image = global::R6Stats.Properties.Resources.Skull_white;
            this.pictureBox7.Location = new System.Drawing.Point(664, 284);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::R6Stats.Properties.Resources.Skull_white;
            this.pictureBox4.Location = new System.Drawing.Point(709, 232);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::R6Stats.Properties.Resources.trophy_icon_white;
            this.pictureBox5.Location = new System.Drawing.Point(709, 202);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::R6Stats.Properties.Resources.icon_trading_white;
            this.pictureBox6.Location = new System.Drawing.Point(709, 172);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::R6Stats.Properties.Resources.Skull_white;
            this.pictureBox3.Location = new System.Drawing.Point(19, 232);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::R6Stats.Properties.Resources.trophy_icon_white;
            this.pictureBox2.Location = new System.Drawing.Point(19, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::R6Stats.Properties.Resources.icon_trading_white;
            this.pictureBox1.Location = new System.Drawing.Point(19, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // defesaOpIcon
            // 
            this.defesaOpIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.defesaOpIcon.Location = new System.Drawing.Point(669, 101);
            this.defesaOpIcon.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.defesaOpIcon.Name = "defesaOpIcon";
            this.defesaOpIcon.Size = new System.Drawing.Size(64, 64);
            this.defesaOpIcon.TabIndex = 3;
            this.defesaOpIcon.TabStop = false;
            // 
            // ataqueOpIcon
            // 
            this.ataqueOpIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ataqueOpIcon.Location = new System.Drawing.Point(19, 101);
            this.ataqueOpIcon.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ataqueOpIcon.Name = "ataqueOpIcon";
            this.ataqueOpIcon.Size = new System.Drawing.Size(64, 64);
            this.ataqueOpIcon.TabIndex = 2;
            this.ataqueOpIcon.TabStop = false;
            // 
            // ataquePicture
            // 
            this.ataquePicture.BackColor = System.Drawing.Color.Transparent;
            this.ataquePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ataquePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.ataquePicture.Location = new System.Drawing.Point(222, -19);
            this.ataquePicture.Name = "ataquePicture";
            this.ataquePicture.Size = new System.Drawing.Size(240, 400);
            this.ataquePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ataquePicture.TabIndex = 0;
            this.ataquePicture.TabStop = false;
            // 
            // defesaPicture
            // 
            this.defesaPicture.BackColor = System.Drawing.Color.Transparent;
            this.defesaPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.defesaPicture.Location = new System.Drawing.Point(296, -19);
            this.defesaPicture.Name = "defesaPicture";
            this.defesaPicture.Size = new System.Drawing.Size(240, 400);
            this.defesaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.defesaPicture.TabIndex = 0;
            this.defesaPicture.TabStop = false;
            // 
            // uiCircle4
            // 
            this.uiCircle4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCircle4.Location = new System.Drawing.Point(19, 9);
            this.uiCircle4.Name = "uiCircle4";
            this.uiCircle4.Size = new System.Drawing.Size(45, 45);
            this.uiCircle4.TabIndex = 31;
            this.uiCircle4.Click += new System.EventHandler(this.Attack_Click);
            // 
            // uiCircle3
            // 
            this.uiCircle3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCircle3.Location = new System.Drawing.Point(688, 9);
            this.uiCircle3.Name = "uiCircle3";
            this.uiCircle3.Size = new System.Drawing.Size(45, 45);
            this.uiCircle3.TabIndex = 30;
            this.uiCircle3.Click += new System.EventHandler(this.Deffense_Click);
            // 
            // uiCircle2
            // 
            this.uiCircle2.Location = new System.Drawing.Point(655, 275);
            this.uiCircle2.Name = "uiCircle2";
            this.uiCircle2.Size = new System.Drawing.Size(40, 40);
            this.uiCircle2.TabIndex = 23;
            // 
            // uiCircle1
            // 
            this.uiCircle1.Location = new System.Drawing.Point(64, 275);
            this.uiCircle1.Name = "uiCircle1";
            this.uiCircle1.Size = new System.Drawing.Size(40, 40);
            this.uiCircle1.TabIndex = 22;
            // 
            // KDProgress
            // 
            this.KDProgress.Location = new System.Drawing.Point(610, 269);
            this.KDProgress.Name = "KDProgress";
            this.KDProgress.Size = new System.Drawing.Size(130, 130);
            this.KDProgress.TabIndex = 21;
            // 
            // WLProgress
            // 
            this.WLProgress.Location = new System.Drawing.Point(19, 269);
            this.WLProgress.Name = "WLProgress";
            this.WLProgress.Size = new System.Drawing.Size(130, 130);
            this.WLProgress.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(416, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Procurar novamente.";
            this.label5.Click += new System.EventHandler(this.search_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.uiCircle4);
            this.Controls.Add(this.uiCircle3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.uiCircle2);
            this.Controls.Add(this.uiCircle1);
            this.Controls.Add(this.KDProgress);
            this.Controls.Add(this.WLProgress);
            this.Controls.Add(this.defesaOpKD);
            this.Controls.Add(this.defesaOpWL);
            this.Controls.Add(this.defesaOpTime);
            this.Controls.Add(this.ataqueOpKD);
            this.Controls.Add(this.ataqueOpWL);
            this.Controls.Add(this.ataqueOpTime);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.defesaOpLabel);
            this.Controls.Add(this.ataqueOpLabel);
            this.Controls.Add(this.defesaOpIcon);
            this.Controls.Add(this.ataqueOpIcon);
            this.Controls.Add(this.ataquePicture);
            this.Controls.Add(this.defesaPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatsForm";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defesaOpIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataqueOpIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataquePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defesaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox defesaPicture;
        private System.Windows.Forms.PictureBox ataqueOpIcon;
        private System.Windows.Forms.PictureBox defesaOpIcon;
        private System.Windows.Forms.Label ataqueOpLabel;
        private System.Windows.Forms.Label defesaOpLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ataquePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label ataqueOpTime;
        private System.Windows.Forms.Label ataqueOpWL;
        private System.Windows.Forms.Label ataqueOpKD;
        private System.Windows.Forms.Label defesaOpKD;
        private System.Windows.Forms.Label defesaOpWL;
        private System.Windows.Forms.Label defesaOpTime;
        private CircularProgressBar WLProgress;
        private CircularProgressBar KDProgress;
        private UiCircle uiCircle1;
        private UiCircle uiCircle2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameLabel;
        private UiCircle uiCircle3;
        private UiCircle uiCircle4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label5;
    }
}