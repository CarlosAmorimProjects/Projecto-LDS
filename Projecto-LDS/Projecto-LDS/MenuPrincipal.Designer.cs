﻿namespace Projecto_LDS
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.Electricidade = new System.Windows.Forms.Button();
            this.GN = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Electricidade
            // 
            this.Electricidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Electricidade.Location = new System.Drawing.Point(73, 60);
            this.Electricidade.Name = "Electricidade";
            this.Electricidade.Size = new System.Drawing.Size(100, 23);
            this.Electricidade.TabIndex = 1;
            this.Electricidade.Text = "Energia Eléctrica";
            this.Electricidade.UseVisualStyleBackColor = true;
            // 
            // GN
            // 
            this.GN.Location = new System.Drawing.Point(73, 109);
            this.GN.Name = "GN";
            this.GN.Size = new System.Drawing.Size(75, 23);
            this.GN.TabIndex = 2;
            this.GN.Text = "Gás Natural";
            this.GN.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LawnGreen;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 26);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Cálculo de consumos de energia";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.GN);
            this.Controls.Add(this.Electricidade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Electricidade;
        private System.Windows.Forms.Button GN;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
