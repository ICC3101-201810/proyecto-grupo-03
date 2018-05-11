namespace VistasSimuladorHorario
{
    partial class RegistrarseForm
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
            this.TextUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EspecialidadCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConcentracionComboBox = new System.Windows.Forms.ComboBox();
            this.RegistrarseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextUser
            // 
            this.TextUser.Location = new System.Drawing.Point(340, 62);
            this.TextUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(173, 22);
            this.TextUser.TabIndex = 0;
            this.TextUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // PassUser
            // 
            this.PassUser.Location = new System.Drawing.Point(340, 105);
            this.PassUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassUser.Name = "PassUser";
            this.PassUser.Size = new System.Drawing.Size(173, 22);
            this.PassUser.TabIndex = 3;
            this.PassUser.UseSystemPasswordChar = true;
            this.PassUser.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Especialidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EspecialidadCB
            // 
            this.EspecialidadCB.FormattingEnabled = true;
            this.EspecialidadCB.Location = new System.Drawing.Point(340, 153);
            this.EspecialidadCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EspecialidadCB.Name = "EspecialidadCB";
            this.EspecialidadCB.Size = new System.Drawing.Size(173, 24);
            this.EspecialidadCB.TabIndex = 5;
            this.EspecialidadCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Concentración Tecnológica";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ConcentracionComboBox
            // 
            this.ConcentracionComboBox.FormattingEnabled = true;
            this.ConcentracionComboBox.Location = new System.Drawing.Point(340, 202);
            this.ConcentracionComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConcentracionComboBox.Name = "ConcentracionComboBox";
            this.ConcentracionComboBox.Size = new System.Drawing.Size(173, 24);
            this.ConcentracionComboBox.TabIndex = 7;
            // 
            // RegistrarseButton
            // 
            this.RegistrarseButton.Location = new System.Drawing.Point(415, 284);
            this.RegistrarseButton.Margin = new System.Windows.Forms.Padding(4);
            this.RegistrarseButton.Name = "RegistrarseButton";
            this.RegistrarseButton.Size = new System.Drawing.Size(100, 28);
            this.RegistrarseButton.TabIndex = 8;
            this.RegistrarseButton.Text = "Registrarse";
            this.RegistrarseButton.UseVisualStyleBackColor = true;
            this.RegistrarseButton.Click += new System.EventHandler(this.registrarseButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RegresarButton_Click);
            // 
            // RegistrarseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RegistrarseButton);
            this.Controls.Add(this.ConcentracionComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EspecialidadCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrarseForm";
            this.Text = "Registrarse";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarseForm_FormClosing);
            this.Load += new System.EventHandler(this.RegistrarseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EspecialidadCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ConcentracionComboBox;
        private System.Windows.Forms.Button RegistrarseButton;
        private System.Windows.Forms.Button button1;
    }
}