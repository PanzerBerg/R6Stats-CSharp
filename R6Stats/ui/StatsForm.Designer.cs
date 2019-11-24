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
            this.defesaPicture = new System.Windows.Forms.PictureBox();
            this.ataquePicture = new System.Windows.Forms.PictureBox();
            this.ataqueOpIcon = new System.Windows.Forms.PictureBox();
            this.defesaOpIcon = new System.Windows.Forms.PictureBox();
            this.ataqueOpLabel = new System.Windows.Forms.Label();
            this.defesaOpLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.defesaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataquePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataqueOpIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defesaOpIcon)).BeginInit();
            this.SuspendLayout();
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
            // ataqueOpIcon
            // 
            this.ataqueOpIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ataqueOpIcon.Location = new System.Drawing.Point(19, 51);
            this.ataqueOpIcon.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ataqueOpIcon.Name = "ataqueOpIcon";
            this.ataqueOpIcon.Size = new System.Drawing.Size(64, 64);
            this.ataqueOpIcon.TabIndex = 2;
            this.ataqueOpIcon.TabStop = false;
            // 
            // defesaOpIcon
            // 
            this.defesaOpIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.defesaOpIcon.Location = new System.Drawing.Point(669, 51);
            this.defesaOpIcon.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.defesaOpIcon.Name = "defesaOpIcon";
            this.defesaOpIcon.Size = new System.Drawing.Size(64, 64);
            this.defesaOpIcon.TabIndex = 3;
            this.defesaOpIcon.TabStop = false;
            // 
            // ataqueOpLabel
            // 
            this.ataqueOpLabel.AutoSize = true;
            this.ataqueOpLabel.BackColor = System.Drawing.Color.Transparent;
            this.ataqueOpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ataqueOpLabel.ForeColor = System.Drawing.Color.Orange;
            this.ataqueOpLabel.Location = new System.Drawing.Point(16, 31);
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
            this.defesaOpLabel.Location = new System.Drawing.Point(681, 31);
            this.defesaOpLabel.Name = "defesaOpLabel";
            this.defesaOpLabel.Size = new System.Drawing.Size(52, 17);
            this.defesaOpLabel.TabIndex = 5;
            this.defesaOpLabel.Text = "label1";
            this.defesaOpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Atacante mais utilizado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Defensor mais utilizado";
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
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
            ((System.ComponentModel.ISupportInitialize)(this.defesaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataquePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ataqueOpIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defesaOpIcon)).EndInit();
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
    }
}