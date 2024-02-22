namespace VegaJuego
{
    partial class LabelVida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelVida));
            MovEnemigoss = new System.Windows.Forms.Timer(components);
            labelViida = new Label();
            pictureBox1 = new PictureBox();
            Escudo = new PictureBox();
            Arma = new PictureBox();
            labelArma = new Label();
            labelEscudo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Escudo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Arma).BeginInit();
            SuspendLayout();
            // 
            // MovEnemigoss
            // 
            MovEnemigoss.Enabled = true;
            MovEnemigoss.Tick += timer1_Tick;
            // 
            // labelViida
            // 
            labelViida.AutoSize = true;
            labelViida.BackColor = Color.Transparent;
            labelViida.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelViida.ForeColor = Color.Gold;
            labelViida.Location = new Point(671, 116);
            labelViida.Name = "labelViida";
            labelViida.Size = new Size(39, 19);
            labelViida.TabIndex = 0;
            labelViida.Text = "Vida";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.salud;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(622, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 39);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Escudo
            // 
            Escudo.BackColor = Color.Transparent;
            Escudo.BackgroundImage = Properties.Resources.escudo;
            Escudo.BackgroundImageLayout = ImageLayout.Center;
            Escudo.Location = new Point(622, 153);
            Escudo.Name = "Escudo";
            Escudo.Size = new Size(43, 39);
            Escudo.TabIndex = 4;
            Escudo.TabStop = false;
            // 
            // Arma
            // 
            Arma.BackColor = Color.Transparent;
            Arma.BackgroundImage = Properties.Resources.Arma;
            Arma.BackgroundImageLayout = ImageLayout.Center;
            Arma.Location = new Point(622, 200);
            Arma.Name = "Arma";
            Arma.Size = new Size(43, 39);
            Arma.TabIndex = 5;
            Arma.TabStop = false;
            // 
            // labelArma
            // 
            labelArma.AutoSize = true;
            labelArma.BackColor = Color.Transparent;
            labelArma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelArma.ForeColor = Color.Gold;
            labelArma.Location = new Point(671, 210);
            labelArma.Name = "labelArma";
            labelArma.Size = new Size(46, 19);
            labelArma.TabIndex = 6;
            labelArma.Text = "Arma";
            // 
            // labelEscudo
            // 
            labelEscudo.AutoSize = true;
            labelEscudo.BackColor = Color.Transparent;
            labelEscudo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelEscudo.ForeColor = Color.Gold;
            labelEscudo.Location = new Point(671, 164);
            labelEscudo.Name = "labelEscudo";
            labelEscudo.Size = new Size(55, 19);
            labelEscudo.TabIndex = 7;
            labelEscudo.Text = "Escudo";
            // 
            // LabelVida
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoFinal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 467);
            Controls.Add(labelEscudo);
            Controls.Add(labelArma);
            Controls.Add(Arma);
            Controls.Add(Escudo);
            Controls.Add(pictureBox1);
            Controls.Add(labelViida);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LabelVida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VegaZelda";
            KeyPress += Level1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Escudo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Arma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer MovEnemigoss;
        private Label labelViida;
        private PictureBox pictureBox1;
        private PictureBox Escudo;
        private PictureBox Arma;
        private Label labelArma;
        private Label labelEscudo;
    }
}
