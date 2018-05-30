namespace VistasSimuladorHorario
{
    partial class ActualizarAvanceDeMalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarAvanceDeMalla));
            this.AvanceMalla = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CursosDisponibles = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Alumno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AvanceMalla
            // 
            this.AvanceMalla.FormattingEnabled = true;
            this.AvanceMalla.Location = new System.Drawing.Point(473, 178);
            this.AvanceMalla.Name = "AvanceMalla";
            this.AvanceMalla.Size = new System.Drawing.Size(181, 134);
            this.AvanceMalla.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "<< Eliminar Curso";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CursosDisponibles
            // 
            this.CursosDisponibles.FormattingEnabled = true;
            this.CursosDisponibles.Location = new System.Drawing.Point(85, 178);
            this.CursosDisponibles.Name = "CursosDisponibles";
            this.CursosDisponibles.Size = new System.Drawing.Size(181, 134);
            this.CursosDisponibles.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar Curso >>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Alumno
            // 
            this.Alumno.AutoSize = true;
            this.Alumno.Location = new System.Drawing.Point(82, 75);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(42, 13);
            this.Alumno.TabIndex = 5;
            this.Alumno.Text = "Alumno";
            // 
            // ActualizarAvanceDeMalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CursosDisponibles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AvanceMalla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActualizarAvanceDeMalla";
            this.Text = "ActualizarAvanceDeMalla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AvanceMalla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox CursosDisponibles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Alumno;
    }
}