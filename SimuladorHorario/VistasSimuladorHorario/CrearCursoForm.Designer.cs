namespace VistasSimuladorHorario
{
    partial class CrearCursoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCursoForm));
            this.NRCUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NCursoUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NProfeUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AProfeUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreditosUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EspecialidadCB = new System.Windows.Forms.ComboBox();
            this.CrearCursoButton = new System.Windows.Forms.Button();
            this.EventAddButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NRCUser
            // 
            this.NRCUser.Location = new System.Drawing.Point(213, 55);
            this.NRCUser.Name = "NRCUser";
            this.NRCUser.Size = new System.Drawing.Size(62, 22);
            this.NRCUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "NRC";
            // 
            // NCursoUser
            // 
            this.NCursoUser.Location = new System.Drawing.Point(213, 113);
            this.NCursoUser.Name = "NCursoUser";
            this.NCursoUser.Size = new System.Drawing.Size(149, 22);
            this.NCursoUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Curso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NProfeUser
            // 
            this.NProfeUser.Location = new System.Drawing.Point(213, 171);
            this.NProfeUser.Name = "NProfeUser";
            this.NProfeUser.Size = new System.Drawing.Size(149, 22);
            this.NProfeUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre Profesor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido Profesor";
            // 
            // AProfeUser
            // 
            this.AProfeUser.Location = new System.Drawing.Point(551, 171);
            this.AProfeUser.Name = "AProfeUser";
            this.AProfeUser.Size = new System.Drawing.Size(100, 22);
            this.AProfeUser.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Créditos";
            // 
            // CreditosUser
            // 
            this.CreditosUser.Location = new System.Drawing.Point(213, 225);
            this.CreditosUser.Name = "CreditosUser";
            this.CreditosUser.Size = new System.Drawing.Size(62, 22);
            this.CreditosUser.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Especialidad";
            // 
            // EspecialidadCB
            // 
            this.EspecialidadCB.FormattingEnabled = true;
            this.EspecialidadCB.Location = new System.Drawing.Point(213, 281);
            this.EspecialidadCB.Name = "EspecialidadCB";
            this.EspecialidadCB.Size = new System.Drawing.Size(149, 24);
            this.EspecialidadCB.TabIndex = 12;
            // 
            // CrearCursoButton
            // 
            this.CrearCursoButton.Location = new System.Drawing.Point(761, 108);
            this.CrearCursoButton.Name = "CrearCursoButton";
            this.CrearCursoButton.Size = new System.Drawing.Size(154, 363);
            this.CrearCursoButton.TabIndex = 13;
            this.CrearCursoButton.Text = "Crear Curso";
            this.CrearCursoButton.UseVisualStyleBackColor = true;
            this.CrearCursoButton.Click += new System.EventHandler(this.CrearCursoButton_Click);
            // 
            // EventAddButton
            // 
            this.EventAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventAddButton.Location = new System.Drawing.Point(83, 344);
            this.EventAddButton.Name = "EventAddButton";
            this.EventAddButton.Size = new System.Drawing.Size(34, 37);
            this.EventAddButton.TabIndex = 14;
            this.EventAddButton.Text = "+";
            this.EventAddButton.UseVisualStyleBackColor = true;
            this.EventAddButton.Click += new System.EventHandler(this.EventAddButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Agregar Evento";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 388);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // CrearCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 598);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EventAddButton);
            this.Controls.Add(this.CrearCursoButton);
            this.Controls.Add(this.EspecialidadCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreditosUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AProfeUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NProfeUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NCursoUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NRCUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearCursoForm";
            this.Text = "CrearCursoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrearCursoForm_FormClosing);
            this.Load += new System.EventHandler(this.CrearCursoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NRCUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NCursoUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NProfeUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AProfeUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CreditosUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EspecialidadCB;
        private System.Windows.Forms.Button CrearCursoButton;
        private System.Windows.Forms.Button EventAddButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}