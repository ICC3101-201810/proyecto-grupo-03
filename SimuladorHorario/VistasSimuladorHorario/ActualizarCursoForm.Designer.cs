namespace VistasSimuladorHorario
{
    partial class ActualizarCursoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarCursoForm));
            this.NrcTB = new System.Windows.Forms.TextBox();
            this.creditosTB = new System.Windows.Forms.TextBox();
            this.especialidadCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CambiarNrcB = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dddd5 = new System.Windows.Forms.Button();
            this.CursosCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NrcTB
            // 
            this.NrcTB.Location = new System.Drawing.Point(12, 163);
            this.NrcTB.Name = "NrcTB";
            this.NrcTB.Size = new System.Drawing.Size(100, 20);
            this.NrcTB.TabIndex = 0;
            // 
            // creditosTB
            // 
            this.creditosTB.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.creditosTB.Location = new System.Drawing.Point(180, 163);
            this.creditosTB.Name = "creditosTB";
            this.creditosTB.Size = new System.Drawing.Size(100, 20);
            this.creditosTB.TabIndex = 1;
            // 
            // especialidadCB
            // 
            this.especialidadCB.FormattingEnabled = true;
            this.especialidadCB.Location = new System.Drawing.Point(353, 163);
            this.especialidadCB.Name = "especialidadCB";
            this.especialidadCB.Size = new System.Drawing.Size(120, 21);
            this.especialidadCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NRC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Creditos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Especialidad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CambiarNrcB
            // 
            this.CambiarNrcB.Location = new System.Drawing.Point(12, 228);
            this.CambiarNrcB.Name = "CambiarNrcB";
            this.CambiarNrcB.Size = new System.Drawing.Size(100, 23);
            this.CambiarNrcB.TabIndex = 7;
            this.CambiarNrcB.Text = "Cambiar NRC";
            this.CambiarNrcB.UseVisualStyleBackColor = true;
            this.CambiarNrcB.Click += new System.EventHandler(this.CambiarNrcB_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cambiar Creditos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CambiarCreditosB_Click);
            // 
            // dddd5
            // 
            this.dddd5.Location = new System.Drawing.Point(353, 228);
            this.dddd5.Name = "dddd5";
            this.dddd5.Size = new System.Drawing.Size(120, 23);
            this.dddd5.TabIndex = 9;
            this.dddd5.Text = "Cambiar Especialidad";
            this.dddd5.UseVisualStyleBackColor = true;
            this.dddd5.Click += new System.EventHandler(this.CambiarEspecialidadB_Click);
            // 
            // CursosCB
            // 
            this.CursosCB.FormattingEnabled = true;
            this.CursosCB.Location = new System.Drawing.Point(142, 53);
            this.CursosCB.Name = "CursosCB";
            this.CursosCB.Size = new System.Drawing.Size(449, 21);
            this.CursosCB.TabIndex = 10;
            this.CursosCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Profesor";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(527, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox2.Location = new System.Drawing.Point(527, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Apellido";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cambiar Profesor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ActualizarCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CursosCB);
            this.Controls.Add(this.dddd5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CambiarNrcB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.especialidadCB);
            this.Controls.Add(this.creditosTB);
            this.Controls.Add(this.NrcTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActualizarCursoForm";
            this.Text = "ActualizarCursoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActualizarCursoForm_FormClosing);
            this.Load += new System.EventHandler(this.ActualizarCursoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NrcTB;
        private System.Windows.Forms.TextBox creditosTB;
        private System.Windows.Forms.ComboBox especialidadCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CambiarNrcB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button dddd5;
        private System.Windows.Forms.ComboBox CursosCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}