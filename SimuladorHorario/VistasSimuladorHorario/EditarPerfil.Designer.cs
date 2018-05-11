namespace VistasSimuladorHorario
{
    partial class avanceMallaComboBox
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
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.cursosInscitosComboBox = new System.Windows.Forms.ComboBox();
            this.cursosInscritosLabel = new System.Windows.Forms.Label();
            this.avanceMallaLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.guardarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(33, 53);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(46, 13);
            this.usuarioLabel.TabIndex = 0;
            this.usuarioLabel.Text = "Usuario:";
            this.usuarioLabel.Click += new System.EventHandler(this.usuarioLabel_Click);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(36, 69);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(209, 20);
            this.usuarioTextBox.TabIndex = 1;
            this.usuarioTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 3;
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Location = new System.Drawing.Point(33, 101);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(64, 13);
            this.contraseñaLabel.TabIndex = 2;
            this.contraseñaLabel.Text = "Contraseña:";
            // 
            // cursosInscitosComboBox
            // 
            this.cursosInscitosComboBox.FormattingEnabled = true;
            this.cursosInscitosComboBox.Location = new System.Drawing.Point(286, 69);
            this.cursosInscitosComboBox.Name = "cursosInscitosComboBox";
            this.cursosInscitosComboBox.Size = new System.Drawing.Size(209, 21);
            this.cursosInscitosComboBox.TabIndex = 4;
            // 
            // cursosInscritosLabel
            // 
            this.cursosInscritosLabel.AutoSize = true;
            this.cursosInscritosLabel.Location = new System.Drawing.Point(283, 53);
            this.cursosInscritosLabel.Name = "cursosInscritosLabel";
            this.cursosInscritosLabel.Size = new System.Drawing.Size(81, 13);
            this.cursosInscritosLabel.TabIndex = 5;
            this.cursosInscritosLabel.Text = "Cursos Inscritos";
            // 
            // avanceMallaLabel
            // 
            this.avanceMallaLabel.AutoSize = true;
            this.avanceMallaLabel.Location = new System.Drawing.Point(523, 53);
            this.avanceMallaLabel.Name = "avanceMallaLabel";
            this.avanceMallaLabel.Size = new System.Drawing.Size(72, 13);
            this.avanceMallaLabel.TabIndex = 7;
            this.avanceMallaLabel.Text = "Avance Malla";
            this.avanceMallaLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(526, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // guardarButton
            // 
            this.guardarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guardarButton.Location = new System.Drawing.Point(713, 415);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 23);
            this.guardarButton.TabIndex = 8;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            // 
            // avanceMallaComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.avanceMallaLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cursosInscritosLabel);
            this.Controls.Add(this.cursosInscitosComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.usuarioLabel);
            this.Name = "avanceMallaComboBox";
            this.Text = "Perfil Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.ComboBox cursosInscitosComboBox;
        private System.Windows.Forms.Label cursosInscritosLabel;
        private System.Windows.Forms.Label avanceMallaLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button guardarButton;
    }
}