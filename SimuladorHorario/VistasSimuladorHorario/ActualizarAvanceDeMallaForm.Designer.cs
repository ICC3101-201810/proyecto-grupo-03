namespace VistasSimuladorHorario
{
    partial class ActualizarAvanceDeMallaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarAvanceDeMallaForm));
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
            this.AvanceMalla.ItemHeight = 16;
            this.AvanceMalla.Location = new System.Drawing.Point(631, 219);
            this.AvanceMalla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvanceMalla.Name = "AvanceMalla";
            this.AvanceMalla.Size = new System.Drawing.Size(240, 164);
            this.AvanceMalla.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "<< Eliminar Curso";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CursosDisponibles
            // 
            this.CursosDisponibles.FormattingEnabled = true;
            this.CursosDisponibles.ItemHeight = 16;
            this.CursosDisponibles.Location = new System.Drawing.Point(113, 219);
            this.CursosDisponibles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CursosDisponibles.Name = "CursosDisponibles";
            this.CursosDisponibles.Size = new System.Drawing.Size(240, 164);
            this.CursosDisponibles.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 247);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Agregar Curso >>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(228, 92);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(444, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // Alumno
            // 
            this.Alumno.AutoSize = true;
            this.Alumno.Location = new System.Drawing.Point(109, 92);
            this.Alumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(55, 17);
            this.Alumno.TabIndex = 5;
            this.Alumno.Text = "Alumno";
            // 
            // ActualizarAvanceDeMallaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CursosDisponibles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AvanceMalla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ActualizarAvanceDeMallaForm";
            this.Text = "ActualizarAvanceDeMalla";
            this.Load += new System.EventHandler(this.ActualizarAvanceDeMallaForm_Load);
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