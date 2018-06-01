namespace VistasSimuladorHorario
{
    partial class ActualizarPreRequisitosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarPreRequisitosForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Alumno = new System.Windows.Forms.Label();
            this.CursosCB = new System.Windows.Forms.ComboBox();
            this.AgregarCursoB = new System.Windows.Forms.Button();
            this.CursosDisponiblesLB = new System.Windows.Forms.ListBox();
            this.EliminarCursoB = new System.Windows.Forms.Button();
            this.PreRequisitosLB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-59, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cursos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "PreRequisitos";
            // 
            // Alumno
            // 
            this.Alumno.AutoSize = true;
            this.Alumno.Location = new System.Drawing.Point(212, 107);
            this.Alumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Alumno.Name = "Alumno";
            this.Alumno.Size = new System.Drawing.Size(45, 17);
            this.Alumno.TabIndex = 14;
            this.Alumno.Text = "Curso";
            // 
            // CursosCB
            // 
            this.CursosCB.FormattingEnabled = true;
            this.CursosCB.Location = new System.Drawing.Point(276, 103);
            this.CursosCB.Margin = new System.Windows.Forms.Padding(4);
            this.CursosCB.Name = "CursosCB";
            this.CursosCB.Size = new System.Drawing.Size(392, 24);
            this.CursosCB.TabIndex = 13;
            // 
            // AgregarCursoB
            // 
            this.AgregarCursoB.Location = new System.Drawing.Point(396, 263);
            this.AgregarCursoB.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarCursoB.Name = "AgregarCursoB";
            this.AgregarCursoB.Size = new System.Drawing.Size(168, 28);
            this.AgregarCursoB.TabIndex = 12;
            this.AgregarCursoB.Text = "Agregar Curso >>";
            this.AgregarCursoB.UseVisualStyleBackColor = true;
            // 
            // CursosDisponiblesLB
            // 
            this.CursosDisponiblesLB.FormattingEnabled = true;
            this.CursosDisponiblesLB.ItemHeight = 16;
            this.CursosDisponiblesLB.Location = new System.Drawing.Point(22, 230);
            this.CursosDisponiblesLB.Margin = new System.Windows.Forms.Padding(4);
            this.CursosDisponiblesLB.Name = "CursosDisponiblesLB";
            this.CursosDisponiblesLB.Size = new System.Drawing.Size(323, 164);
            this.CursosDisponiblesLB.TabIndex = 11;
            // 
            // EliminarCursoB
            // 
            this.EliminarCursoB.Location = new System.Drawing.Point(396, 321);
            this.EliminarCursoB.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarCursoB.Name = "EliminarCursoB";
            this.EliminarCursoB.Size = new System.Drawing.Size(168, 28);
            this.EliminarCursoB.TabIndex = 10;
            this.EliminarCursoB.Text = "<< Eliminar Curso";
            this.EliminarCursoB.UseVisualStyleBackColor = true;
            // 
            // PreRequisitosLB
            // 
            this.PreRequisitosLB.FormattingEnabled = true;
            this.PreRequisitosLB.ItemHeight = 16;
            this.PreRequisitosLB.Location = new System.Drawing.Point(614, 230);
            this.PreRequisitosLB.Margin = new System.Windows.Forms.Padding(4);
            this.PreRequisitosLB.Name = "PreRequisitosLB";
            this.PreRequisitosLB.Size = new System.Drawing.Size(323, 164);
            this.PreRequisitosLB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Curso";
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(800, 485);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(151, 57);
            this.Regresar.TabIndex = 18;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            // 
            // ActualizarPreRequisitosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 554);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Alumno);
            this.Controls.Add(this.CursosCB);
            this.Controls.Add(this.AgregarCursoB);
            this.Controls.Add(this.CursosDisponiblesLB);
            this.Controls.Add(this.EliminarCursoB);
            this.Controls.Add(this.PreRequisitosLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActualizarPreRequisitosForm";
            this.Text = "Actualizar PreRequisitos";
            this.Load += new System.EventHandler(this.ActualizarPreRequisitosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Alumno;
        private System.Windows.Forms.ComboBox CursosCB;
        private System.Windows.Forms.Button AgregarCursoB;
        private System.Windows.Forms.ListBox CursosDisponiblesLB;
        private System.Windows.Forms.Button EliminarCursoB;
        private System.Windows.Forms.ListBox PreRequisitosLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Regresar;
    }
}