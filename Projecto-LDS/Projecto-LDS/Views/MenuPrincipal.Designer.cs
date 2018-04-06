namespace Projecto_LDS
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Electricidade
            // 
            this.Electricidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Electricidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Electricidade.Location = new System.Drawing.Point(343, 119);
            this.Electricidade.Name = "Electricidade";
            this.Electricidade.Size = new System.Drawing.Size(189, 40);
            this.Electricidade.TabIndex = 1;
            this.Electricidade.Text = "Energia Eléctrica";
            this.Electricidade.UseVisualStyleBackColor = true;
            this.Electricidade.Click += new System.EventHandler(this.Electricidade_Click);
            // 
            // GN
            // 
            this.GN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GN.Location = new System.Drawing.Point(343, 184);
            this.GN.Name = "GN";
            this.GN.Size = new System.Drawing.Size(189, 42);
            this.GN.TabIndex = 2;
            this.GN.Text = "Gás Natural";
            this.GN.UseVisualStyleBackColor = true;
            this.GN.Click += new System.EventHandler(this.GN_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(673, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Configurações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GN);
            this.Controls.Add(this.Electricidade);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Electricidade;
        private System.Windows.Forms.Button GN;
        private System.Windows.Forms.Button button1;
    }
}

