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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.defesaOpIcon = new System.Windows.Forms.PictureBox();
            this.ataqueOpIcon = new System.Windows.Forms.PictureBox();
            this.ataquePicture = new System.Windows.Forms.PictureBox();
            this.defesaPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.ataqueOpTime = new System.Windows.Forms.Label();
            this.ataqueOpWL = new System.Windows.Forms.Label();
            this.ataqueOpKD = new System.Windows.Forms.Label();
            this.defesaOpKD = new System.Windows.Forms.Label();
            this.defesaOpWL = new System.Windows.Forms.Label();
            this.defesaOpTime = new System.Windows.Forms.Label();
            this.WLProgress = new R6Stats.ui.CircularProgressBar();
            this.KDProgress = new R6Stats.ui.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defesaOpIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataqueOpIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataquePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defesaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // ataqueOpLabel
            // 
            this.ataqueOpLabel.AutoSize = true;
            this.ataqueOpLabel.BackColor = System.Drawing.Color.Transparent;
            this.ataqueOpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ataqueOpLabel.ForeColor = System.Drawing.Color.Orange;
            this.ataqueOpLabel.Location = new System.Drawing.Point(16, 56);
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
            this.defesaOpLabel.Location = new System.Drawing.Point(666, 56);
            this.defesaOpLabel.Name = "defesaOpLabel";
            this.defesaOpLabel.Size = new System.Drawing.Size(52, 17);
            this.defesaOpLabel.TabIndex = 5;
            this.defesaOpLabel.Text = "label1";
            this.defesaOpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Atacante mais utilizado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Defensor mais utilizado";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::R6Stats.Properties.Resources.Skull_512;
            this.pictureBox3.Location = new System.Drawing.Point(19, 207);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::R6Stats.Properties.Resources.trophy__icon__vector__eps_512;
            this.pictureBox2.Location = new System.Drawing.Point(19, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::R6Stats.Properties.Resources.icon_trading_19_512;
            this.pictureBox1.Location = new System.Drawing.Point(19, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // defesaOpIcon
            // 
            this.defesaOpIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.defesaOpIcon.Location = new System.Drawing.Point(669, 76);
            this.defesaOpIcon.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.defesaOpIcon.Name = "defesaOpIcon";
            this.defesaOpIcon.Size = new System.Drawing.Size(64, 64);
            this.defesaOpIcon.TabIndex = 3;
            this.defesaOpIcon.TabStop = false;
            // 
            // ataqueOpIcon
            // 
            this.ataqueOpIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ataqueOpIcon.Location = new System.Drawing.Point(19, 76);
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
            // pictureBox4
            // 
            this.pictureBox4.Image = global::R6Stats.Properties.Resources.Skull_512;
            this.pictureBox4.Location = new System.Drawing.Point(709, 207);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::R6Stats.Properties.Resources.trophy__icon__vector__eps_512;
            this.pictureBox5.Location = new System.Drawing.Point(709, 177);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::R6Stats.Properties.Resources.icon_trading_19_512;
            this.pictureBox6.Location = new System.Drawing.Point(709, 147);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // ataqueOpTime
            // 
            this.ataqueOpTime.AutoSize = true;
            this.ataqueOpTime.Location = new System.Drawing.Point(49, 153);
            this.ataqueOpTime.Name = "ataqueOpTime";
            this.ataqueOpTime.Size = new System.Drawing.Size(48, 13);
            this.ataqueOpTime.TabIndex = 14;
            this.ataqueOpTime.Text = "00h 00m";
            // 
            // ataqueOpWL
            // 
            this.ataqueOpWL.AutoSize = true;
            this.ataqueOpWL.Location = new System.Drawing.Point(49, 183);
            this.ataqueOpWL.Name = "ataqueOpWL";
            this.ataqueOpWL.Size = new System.Drawing.Size(28, 13);
            this.ataqueOpWL.TabIndex = 15;
            this.ataqueOpWL.Text = "0.00";
            // 
            // ataqueOpKD
            // 
            this.ataqueOpKD.AutoSize = true;
            this.ataqueOpKD.Location = new System.Drawing.Point(49, 213);
            this.ataqueOpKD.Name = "ataqueOpKD";
            this.ataqueOpKD.Size = new System.Drawing.Size(28, 13);
            this.ataqueOpKD.TabIndex = 16;
            this.ataqueOpKD.Text = "0.00";
            // 
            // defesaOpKD
            // 
            this.defesaOpKD.AutoSize = true;
            this.defesaOpKD.Location = new System.Drawing.Point(675, 213);
            this.defesaOpKD.Name = "defesaOpKD";
            this.defesaOpKD.Size = new System.Drawing.Size(28, 13);
            this.defesaOpKD.TabIndex = 19;
            this.defesaOpKD.Text = "0.00";
            this.defesaOpKD.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // defesaOpWL
            // 
            this.defesaOpWL.AutoSize = true;
            this.defesaOpWL.Location = new System.Drawing.Point(675, 183);
            this.defesaOpWL.Name = "defesaOpWL";
            this.defesaOpWL.Size = new System.Drawing.Size(28, 13);
            this.defesaOpWL.TabIndex = 18;
            this.defesaOpWL.Text = "0.00";
            this.defesaOpWL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // defesaOpTime
            // 
            this.defesaOpTime.AutoSize = true;
            this.defesaOpTime.Location = new System.Drawing.Point(655, 153);
            this.defesaOpTime.Name = "defesaOpTime";
            this.defesaOpTime.Size = new System.Drawing.Size(48, 13);
            this.defesaOpTime.TabIndex = 17;
            this.defesaOpTime.Text = "00h 00m";
            this.defesaOpTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WLProgress
            // 
            this.WLProgress.Location = new System.Drawing.Point(19, 251);
            this.WLProgress.Name = "WLProgress";
            this.WLProgress.Size = new System.Drawing.Size(130, 130);
            this.WLProgress.TabIndex = 20;
            // 
            // KDProgress
            // 
            this.KDProgress.Location = new System.Drawing.Point(610, 251);
            this.KDProgress.Name = "KDProgress";
            this.KDProgress.Size = new System.Drawing.Size(130, 130);
            this.KDProgress.TabIndex = 21;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(752, 393);
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
            this.Name = "StatsForm";
            this.Text = "StatsForm";
            this.Load += new System.EventHandler(this.StatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defesaOpIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataqueOpIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataquePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defesaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
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
    }
}