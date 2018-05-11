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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarseForm));
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
            this.TextUser.Location = new System.Drawing.Point(255, 50);
            this.TextUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(131, 20);
            this.TextUser.TabIndex = 0;
            this.TextUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // PassUser
            // 
            this.PassUser.Location = new System.Drawing.Point(255, 85);
            this.PassUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PassUser.Name = "PassUser";
            this.PassUser.Size = new System.Drawing.Size(131, 20);
            this.PassUser.TabIndex = 3;
            this.PassUser.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Especialidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EspecialidadCB
            // 
            this.EspecialidadCB.FormattingEnabled = true;
            this.EspecialidadCB.Location = new System.Drawing.Point(255, 124);
            this.EspecialidadCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EspecialidadCB.Name = "EspecialidadCB";
            this.EspecialidadCB.Size = new System.Drawing.Size(131, 21);
            this.EspecialidadCB.TabIndex = 5;
            this.EspecialidadCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Concentración Tecnológica";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ConcentracionComboBox
            // 
            this.ConcentracionComboBox.FormattingEnabled = true;
            this.ConcentracionComboBox.Location = new System.Drawing.Point(255, 164);
            this.ConcentracionComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConcentracionComboBox.Name = "ConcentracionComboBox";
            this.ConcentracionComboBox.Size = new System.Drawing.Size(131, 21);
            this.ConcentracionComboBox.TabIndex = 7;
            // 
            // RegistrarseButton
            // 
            this.RegistrarseButton.Location = new System.Drawing.Point(311, 231);
            this.RegistrarseButton.Name = "RegistrarseButton";
            this.RegistrarseButton.Size = new System.Drawing.Size(75, 23);
            this.RegistrarseButton.TabIndex = 8;
            this.RegistrarseButton.Text = "Registrarse";
            this.RegistrarseButton.UseVisualStyleBackColor = true;
            this.RegistrarseButton.Click += new System.EventHandler(this.registrarseButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(505, 328);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 9;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RegresarButton_Click);
            // 
            // RegistrarseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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