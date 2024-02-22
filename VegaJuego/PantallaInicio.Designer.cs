namespace VegaJuego
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            button1 = new Button();
            logoCes = new PictureBox();
            logoZelda = new PictureBox();
            checkSonido = new CheckBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)logoCes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoZelda).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.BackgroundImage = Properties.Resources.Boton;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(467, 368);
            button1.Name = "button1";
            button1.Size = new Size(218, 49);
            button1.TabIndex = 0;
            button1.Text = "Comienza la aventura";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // logoCes
            // 
            logoCes.BackColor = Color.Transparent;
            logoCes.BackgroundImage = Properties.Resources.LogoBueno;
            logoCes.BackgroundImageLayout = ImageLayout.Stretch;
            logoCes.Location = new Point(1, 1);
            logoCes.Name = "logoCes";
            logoCes.Size = new Size(163, 147);
            logoCes.TabIndex = 1;
            logoCes.TabStop = false;
            // 
            // logoZelda
            // 
            logoZelda.BackColor = Color.Transparent;
            logoZelda.BackgroundImage = Properties.Resources.ZeldaLogo;
            logoZelda.BackgroundImageLayout = ImageLayout.Stretch;
            logoZelda.Location = new Point(517, 56);
            logoZelda.Name = "logoZelda";
            logoZelda.Size = new Size(198, 92);
            logoZelda.TabIndex = 2;
            logoZelda.TabStop = false;
            // 
            // checkSonido
            // 
            checkSonido.AutoSize = true;
            checkSonido.BackColor = Color.Transparent;
            checkSonido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkSonido.Location = new Point(517, 168);
            checkSonido.Name = "checkSonido";
            checkSonido.Size = new Size(118, 21);
            checkSonido.TabIndex = 3;
            checkSonido.Text = "Sonido On/Off";
            checkSonido.UseVisualStyleBackColor = false;
            checkSonido.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(496, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 20);
            textBox1.TabIndex = 4;
            textBox1.Text = "Creado por Pedro Antonio Lopez";
            // 
            // PantallaInicio
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoPantalla;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 467);
            Controls.Add(textBox1);
            Controls.Add(checkSonido);
            Controls.Add(logoZelda);
            Controls.Add(logoCes);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PantallaInicio";
            FormClosed += PantallaInicio_FormClosed;
            ((System.ComponentModel.ISupportInitialize)logoCes).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoZelda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox logoCes;
        private PictureBox logoZelda;
        private CheckBox checkSonido;
        private TextBox textBox1;
    }
}