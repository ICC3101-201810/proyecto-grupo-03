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
            this.EliminarCursoB = new System.Windows.Forms.Button();
            this.CursosDisponibles = new System.Windows.Forms.ListBox();
            this.AgregarCursoB = new System.Windows.Forms.Button();
            this.AlumnoCB = new System.Windows.Forms.ComboBox();
            this.Alumno = new System.Windows.Forms.Label();
            this.RegresarB = new System.Windows.Forms.Button();
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
            // EliminarCursoB
            // 
            this.EliminarCursoB.Location = new System.Drawing.Point(300, 267);
            this.EliminarCursoB.Name = "EliminarCursoB";
            this.EliminarCursoB.Size = new System.Drawing.Size(126, 23);
            this.EliminarCursoB.TabIndex = 1;
            this.EliminarCursoB.Text = "<< Eliminar Curso";
            this.EliminarCursoB.UseVisualStyleBackColor = true;
            // 
            // CursosDisponibles
            // 
            this.CursosDisponibles.FormattingEnabled = true;
            this.CursosDisponibles.Location = new System.Drawing.Point(85, 178);
            this.CursosDisponibles.Name = "CursosDisponibles";
            this.CursosDisponibles.Size = new System.Drawing.Size(181, 134);
            this.CursosDisponibles.TabIndex = 2;
            // 
            // AgregarCursoB
            // 
            this.AgregarCursoB.Location = new System.Drawing.Point(300, 201);
            this.AgregarCursoB.Name = "AgregarCursoB";
            this.AgregarCursoB.Size = new System.Drawing.Size(126, 23);
            this.AgregarCursoB.TabIndex = 3;
            this.AgregarCursoB.Text = "Agregar Curso >>";
            this.AgregarCursoB.UseVisualStyleBackColor = true;
            // 
            // AlumnoCB
            // 
            this.AlumnoCB.FormattingEnabled = true;
            this.AlumnoCB.Location = new System.Drawing.Point(171, 75);
            this.AlumnoCB.Name = "AlumnoCB";
            this.AlumnoCB.Size = new System.Drawing.Size(334, 21);
            this.AlumnoCB.TabIndex = 4;
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
            // RegresarB
            // 
            this.RegresarB.Location = new System.Drawing.Point(623, 382);
            this.RegresarB.Name = "RegresarB";
            this.RegresarB.Size = new System.Drawing.Size(146, 45);
            this.RegresarB.TabIndex = 6;
            this.RegresarB.Text = "<< Eliminar Curso";
            this.RegresarB.UseVisualStyleBackColor = true;
            // 
            // ActualizarAvanceDeMallaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegresarB);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.AlumnoCB);
            this.Controls.Add(this.AgregarCursoB);
            this.Controls.Add(this.CursosDisponibles);
            this.Controls.Add(this.EliminarCursoB);
            this.Controls.Add(this.AvanceMalla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActualizarAvanceDeMallaForm";
            this.Text = "ActualizarAvanceDeMalla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AvanceMalla;
        private System.Windows.Forms.Button EliminarCursoB;
        private System.Windows.Forms.ListBox CursosDisponibles;
        private System.Windows.Forms.Button AgregarCursoB;
        private System.Windows.Forms.ComboBox AlumnoCB;
        private System.Windows.Forms.Label Alumno;
        private System.Windows.Forms.Button RegresarB;
    }
}