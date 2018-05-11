namespace VistasSimuladorHorario
{
    partial class EditarPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPerfil));
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.cursosInscritosComboBox = new System.Windows.Forms.ComboBox();
            this.cursosInscritosLabel = new System.Windows.Forms.Label();
            this.avanceMallaLabel = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(100, 46);
            this.usuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(61, 17);
            this.usuarioLabel.TabIndex = 0;
            this.usuarioLabel.Text = "Usuario:";
            this.usuarioLabel.Click += new System.EventHandler(this.usuarioLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 134);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(332, 22);
            this.textBox2.TabIndex = 3;
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Location = new System.Drawing.Point(100, 114);
            this.contraseñaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(85, 17);
            this.contraseñaLabel.TabIndex = 2;
            this.contraseñaLabel.Text = "Contraseña:";
            // 
            // cursosInscritosComboBox
            // 
            this.cursosInscritosComboBox.FormattingEnabled = true;
            this.cursosInscritosComboBox.Location = new System.Drawing.Point(104, 217);
            this.cursosInscritosComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cursosInscritosComboBox.Name = "cursosInscritosComboBox";
            this.cursosInscritosComboBox.Size = new System.Drawing.Size(332, 24);
            this.cursosInscritosComboBox.TabIndex = 5;
            // 
            // cursosInscritosLabel
            // 
            this.cursosInscritosLabel.AutoSize = true;
            this.cursosInscritosLabel.Location = new System.Drawing.Point(100, 197);
            this.cursosInscritosLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cursosInscritosLabel.Name = "cursosInscritosLabel";
            this.cursosInscritosLabel.Size = new System.Drawing.Size(108, 17);
            this.cursosInscritosLabel.TabIndex = 6;
            this.cursosInscritosLabel.Text = "Cursos Inscritos";
            // 
            // avanceMallaLabel
            // 
            this.avanceMallaLabel.AutoSize = true;
            this.avanceMallaLabel.Location = new System.Drawing.Point(527, 44);
            this.avanceMallaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.avanceMallaLabel.Name = "avanceMallaLabel";
            this.avanceMallaLabel.Size = new System.Drawing.Size(92, 17);
            this.avanceMallaLabel.TabIndex = 7;
            this.avanceMallaLabel.Text = "Avance Malla";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(788, 465);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 28);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(531, 65);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // EditarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 508);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.avanceMallaLabel);
            this.Controls.Add(this.cursosInscritosLabel);
            this.Controls.Add(this.cursosInscritosComboBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.usuarioLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditarPerfil";
            this.Text = "EditarPerfil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarPerfil_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.ComboBox cursosInscritosComboBox;
        private System.Windows.Forms.Label cursosInscritosLabel;
        private System.Windows.Forms.Label avanceMallaLabel;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}