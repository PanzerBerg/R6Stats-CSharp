namespace R6Stats
{
    partial class IDForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.background = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pcRadio = new System.Windows.Forms.RadioButton();
            this.psRadio = new System.Windows.Forms.RadioButton();
            this.xboxRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Location = new System.Drawing.Point(-8, -17);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(768, 432);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.WaitOnLoad = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(400, 122);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(69, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Procurar";
            this.metroButton1.UseSelectable = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            // 
            // pcRadio
            // 
            this.pcRadio.AutoSize = true;
            this.pcRadio.Location = new System.Drawing.Point(269, 127);
            this.pcRadio.Name = "pcRadio";
            this.pcRadio.Size = new System.Drawing.Size(85, 17);
            this.pcRadio.TabIndex = 3;
            this.pcRadio.TabStop = true;
            this.pcRadio.Text = "radioButton1";
            this.pcRadio.UseVisualStyleBackColor = true;
            // 
            // psRadio
            // 
            this.psRadio.AutoSize = true;
            this.psRadio.Location = new System.Drawing.Point(269, 151);
            this.psRadio.Name = "psRadio";
            this.psRadio.Size = new System.Drawing.Size(85, 17);
            this.psRadio.TabIndex = 4;
            this.psRadio.TabStop = true;
            this.psRadio.Text = "radioButton1";
            this.psRadio.UseVisualStyleBackColor = true;
            // 
            // xboxRadio
            // 
            this.xboxRadio.AutoSize = true;
            this.xboxRadio.Location = new System.Drawing.Point(269, 175);
            this.xboxRadio.Name = "xboxRadio";
            this.xboxRadio.Size = new System.Drawing.Size(85, 17);
            this.xboxRadio.TabIndex = 5;
            this.xboxRadio.TabStop = true;
            this.xboxRadio.Text = "radioButton1";
            this.xboxRadio.UseVisualStyleBackColor = true;
            // 
            // IDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.xboxRadio);
            this.Controls.Add(this.psRadio);
            this.Controls.Add(this.pcRadio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IDForm";
            this.Text = "R6Stats";
            this.Load += new System.EventHandler(this.R6Stats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton pcRadio;
        private System.Windows.Forms.RadioButton psRadio;
        private System.Windows.Forms.RadioButton xboxRadio;
    }
}

