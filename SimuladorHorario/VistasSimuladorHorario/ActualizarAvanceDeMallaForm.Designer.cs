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
            this.AvanceMallaLB = new System.Windows.Forms.ListBox();
            this.EliminarCursoB = new System.Windows.Forms.Button();
            this.CursosDisponiblesLB = new System.Windows.Forms.ListBox();
            this.AgregarCursoB = new System.Windows.Forms.Button();
            this.AlumnosCB = new System.Windows.Forms.ComboBox();
            this.Alumno = new System.Windows.Forms.Label();
            this.RegresarB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AvanceMallaLB
            // 
            this.AvanceMallaLB.FormattingEnabled = true;
            this.AvanceMallaLB.Location = new System.Drawing.Point(497, 178);
            this.AvanceMallaLB.Name = "AvanceMallaLB";
            this.AvanceMallaLB.Size = new System.Drawing.Size(243, 134);
            this.AvanceMallaLB.TabIndex = 0;
            this.AvanceMallaLB.SelectedIndexChanged += new System.EventHandler(this.AvanceMallaLB_SelectedIndexChanged);
            // 
            // EliminarCursoB
            // 
            this.EliminarCursoB.Location = new System.Drawing.Point(334, 252);
            this.EliminarCursoB.Name = "EliminarCursoB";
            this.EliminarCursoB.Size = new System.Drawing.Size(126, 23);
            this.EliminarCursoB.TabIndex = 1;
            this.EliminarCursoB.Text = "<< Eliminar Curso";
            this.EliminarCursoB.UseVisualStyleBackColor = true;
            this.EliminarCursoB.Click += new System.EventHandler(this.EliminarCursoB_Click);
            // 
            // CursosDisponiblesLB
            // 
            this.CursosDisponiblesLB.FormattingEnabled = true;
            this.CursosDisponiblesLB.Location = new System.Drawing.Point(53, 178);
            this.CursosDisponiblesLB.Name = "CursosDisponiblesLB";
            this.CursosDisponiblesLB.Size = new System.Drawing.Size(243, 134);
            this.CursosDisponiblesLB.TabIndex = 2;
            // 
            // AgregarCursoB
            // 
            this.AgregarCursoB.Location = new System.Drawing.Point(334, 205);
            this.AgregarCursoB.Name = "AgregarCursoB";
            this.AgregarCursoB.Size = new System.Drawing.Size(126, 23);
            this.AgregarCursoB.TabIndex = 3;
            this.AgregarCursoB.Text = "Agregar Curso >>";
            this.AgregarCursoB.UseVisualStyleBackColor = true;
            this.AgregarCursoB.Click += new System.EventHandler(this.AgregarCursoB_Click);
            // 
            // AlumnosCB
            // 
            this.AlumnosCB.FormattingEnabled = true;
            this.AlumnosCB.Location = new System.Drawing.Point(244, 75);
            this.AlumnosCB.Name = "AlumnosCB";
            this.AlumnosCB.Size = new System.Drawing.Size(295, 21);
            this.AlumnosCB.TabIndex = 4;
            this.AlumnosCB.SelectedIndexChanged += new System.EventHandler(this.AlumnosCB_SelectedIndexChanged);
            // 
            // Alumno
            // 
            this.Alumno.AutoSize = true;
            this.Alumno.Location = new System.Drawing.Point(196, 78);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(42, 13);
            this.Alumno.TabIndex = 5;
            this.Alumno.Text = "Alumno";
            // 
            // RegresarB
            // 
            this.RegresarB.Location = new System.Drawing.Point(689, 402);
            this.RegresarB.Margin = new System.Windows.Forms.Padding(2);
            this.RegresarB.Name = "RegresarB";
            this.RegresarB.Size = new System.Drawing.Size(102, 38);
            this.RegresarB.TabIndex = 6;
            this.RegresarB.Text = "Regresar";
            this.RegresarB.UseVisualStyleBackColor = true;
            this.RegresarB.Click += new System.EventHandler(this.RegresarB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Avance de malla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cursos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ActualizarAvanceDeMallaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegresarB);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.AlumnosCB);
            this.Controls.Add(this.AgregarCursoB);
            this.Controls.Add(this.CursosDisponiblesLB);
            this.Controls.Add(this.EliminarCursoB);
            this.Controls.Add(this.AvanceMallaLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActualizarAvanceDeMallaForm";
            this.Text = "Actualizar Avance de Malla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActualizarAvanceDeMallaForm_FormClosing);
            this.Load += new System.EventHandler(this.ActualizarAvanceDeMallaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AvanceMallaLB;
        private System.Windows.Forms.Button EliminarCursoB;
        private System.Windows.Forms.ListBox CursosDisponiblesLB;
        private System.Windows.Forms.Button AgregarCursoB;
        private System.Windows.Forms.ComboBox AlumnosCB;
        private System.Windows.Forms.Label Alumno;
        private System.Windows.Forms.Button RegresarB;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;
    }
}