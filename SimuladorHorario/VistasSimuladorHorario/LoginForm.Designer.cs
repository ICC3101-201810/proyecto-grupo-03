namespace VistasSimuladorHorario
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.usuarioText = new System.Windows.Forms.TextBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.contraseñaText = new System.Windows.Forms.TextBox();
            this.ingresarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuarioText
            // 
            this.usuarioText.Location = new System.Drawing.Point(139, 96);
            this.usuarioText.Name = "usuarioText";
            this.usuarioText.Size = new System.Drawing.Size(214, 20);
            this.usuarioText.TabIndex = 0;
            this.usuarioText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(90, 99);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(43, 13);
            this.usuarioLabel.TabIndex = 1;
            this.usuarioLabel.Text = "Usuario";
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Location = new System.Drawing.Point(73, 125);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(61, 13);
            this.contraseñaLabel.TabIndex = 3;
            this.contraseñaLabel.Text = "Contraseña";
            // 
            // contraseñaText
            // 
            this.contraseñaText.Location = new System.Drawing.Point(139, 122);
            this.contraseñaText.Name = "contraseñaText";
            this.contraseñaText.Size = new System.Drawing.Size(214, 20);
            this.contraseñaText.TabIndex = 2;
            this.contraseñaText.UseSystemPasswordChar = true;
            this.contraseñaText.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ingresarButton
            // 
            this.ingresarButton.Location = new System.Drawing.Point(278, 148);
            this.ingresarButton.Name = "ingresarButton";
            this.ingresarButton.Size = new System.Drawing.Size(75, 23);
            this.ingresarButton.TabIndex = 4;
            this.ingresarButton.Text = "Ingresar";
            this.ingresarButton.UseVisualStyleBackColor = true;
            this.ingresarButton.Click += new System.EventHandler(this.ingresarButton_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 256);
            this.Controls.Add(this.ingresarButton);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.contraseñaText);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.usuarioText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "loginForm";
            this.Text = "Inicio Sesion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioText;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.TextBox contraseñaText;
        private System.Windows.Forms.Button ingresarButton;
    }
}

