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
            this.SuspendLayout();
            // 
            // AvanceMallaLB
            // 
            this.AvanceMallaLB.FormattingEnabled = true;
            this.AvanceMallaLB.ItemHeight = 16;
            this.AvanceMallaLB.Location = new System.Drawing.Point(631, 219);
            this.AvanceMallaLB.Margin = new System.Windows.Forms.Padding(4);
            this.AvanceMallaLB.Name = "AvanceMallaLB";
            this.AvanceMallaLB.Size = new System.Drawing.Size(240, 164);
            this.AvanceMallaLB.TabIndex = 0;
            // 
            // EliminarCursoB
            // 
            this.EliminarCursoB.Location = new System.Drawing.Point(400, 329);
            this.EliminarCursoB.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarCursoB.Name = "EliminarCursoB";
            this.EliminarCursoB.Size = new System.Drawing.Size(168, 28);
            this.EliminarCursoB.TabIndex = 1;
            this.EliminarCursoB.Text = "<< Eliminar Curso";
            this.EliminarCursoB.UseVisualStyleBackColor = true;
            // 
            // CursosDisponiblesLB
            // 
            this.CursosDisponiblesLB.FormattingEnabled = true;
            this.CursosDisponiblesLB.ItemHeight = 16;
            this.CursosDisponiblesLB.Location = new System.Drawing.Point(113, 219);
            this.CursosDisponiblesLB.Margin = new System.Windows.Forms.Padding(4);
            this.CursosDisponiblesLB.Name = "CursosDisponiblesLB";
            this.CursosDisponiblesLB.Size = new System.Drawing.Size(240, 164);
            this.CursosDisponiblesLB.TabIndex = 2;
            // 
            // AgregarCursoB
            // 
            this.AgregarCursoB.Location = new System.Drawing.Point(400, 247);
            this.AgregarCursoB.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarCursoB.Name = "AgregarCursoB";
            this.AgregarCursoB.Size = new System.Drawing.Size(168, 28);
            this.AgregarCursoB.TabIndex = 3;
            this.AgregarCursoB.Text = "Agregar Curso >>";
            this.AgregarCursoB.UseVisualStyleBackColor = true;
            // 
            // AlumnosCB
            // 
            this.AlumnosCB.FormattingEnabled = true;
            this.AlumnosCB.Location = new System.Drawing.Point(228, 92);
            this.AlumnosCB.Margin = new System.Windows.Forms.Padding(4);
            this.AlumnosCB.Name = "AlumnosCB";
            this.AlumnosCB.Size = new System.Drawing.Size(444, 24);
            this.AlumnosCB.TabIndex = 4;
            this.AlumnosCB.SelectedIndexChanged += new System.EventHandler(this.AlumnosCB_SelectedIndexChanged);
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
            this.Controls.Add(this.AlumnosCB);
            this.Controls.Add(this.AgregarCursoB);
            this.Controls.Add(this.CursosDisponiblesLB);
            this.Controls.Add(this.EliminarCursoB);
            this.Controls.Add(this.AvanceMallaLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ActualizarAvanceDeMallaForm";
            this.Text = "ActualizarAvanceDeMalla";
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
    }
}