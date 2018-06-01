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
            this.AgregarCursoB = new System.Windows.Forms.Button();
            this.CursosDisponiblesLB = new System.Windows.Forms.ListBox();
            this.EliminarCursoB = new System.Windows.Forms.Button();
            this.PreRequisitosLB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GuardarRegresarB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-44, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cursos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "PreRequisitos";
            // 
            // AgregarCursoB
            // 
            this.AgregarCursoB.Location = new System.Drawing.Point(298, 82);
            this.AgregarCursoB.Name = "AgregarCursoB";
            this.AgregarCursoB.Size = new System.Drawing.Size(126, 23);
            this.AgregarCursoB.TabIndex = 12;
            this.AgregarCursoB.Text = "Agregar Curso >>";
            this.AgregarCursoB.UseVisualStyleBackColor = true;
            this.AgregarCursoB.Click += new System.EventHandler(this.AgregarCursoB_Click);
            // 
            // CursosDisponiblesLB
            // 
            this.CursosDisponiblesLB.FormattingEnabled = true;
            this.CursosDisponiblesLB.Location = new System.Drawing.Point(49, 73);
            this.CursosDisponiblesLB.Name = "CursosDisponiblesLB";
            this.CursosDisponiblesLB.Size = new System.Drawing.Size(243, 134);
            this.CursosDisponiblesLB.TabIndex = 11;
            // 
            // EliminarCursoB
            // 
            this.EliminarCursoB.Location = new System.Drawing.Point(298, 146);
            this.EliminarCursoB.Name = "EliminarCursoB";
            this.EliminarCursoB.Size = new System.Drawing.Size(126, 23);
            this.EliminarCursoB.TabIndex = 10;
            this.EliminarCursoB.Text = "<< Eliminar Curso";
            this.EliminarCursoB.UseVisualStyleBackColor = true;
            this.EliminarCursoB.Click += new System.EventHandler(this.EliminarCursoB_Click);
            // 
            // PreRequisitosLB
            // 
            this.PreRequisitosLB.FormattingEnabled = true;
            this.PreRequisitosLB.Location = new System.Drawing.Point(430, 73);
            this.PreRequisitosLB.Name = "PreRequisitosLB";
            this.PreRequisitosLB.Size = new System.Drawing.Size(243, 134);
            this.PreRequisitosLB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Curso";
            // 
            // GuardarRegresarB
            // 
            this.GuardarRegresarB.Location = new System.Drawing.Point(578, 232);
            this.GuardarRegresarB.Name = "GuardarRegresarB";
            this.GuardarRegresarB.Size = new System.Drawing.Size(121, 30);
            this.GuardarRegresarB.TabIndex = 18;
            this.GuardarRegresarB.Text = "Guardar y Regresar";
            this.GuardarRegresarB.UseVisualStyleBackColor = true;
            this.GuardarRegresarB.Click += new System.EventHandler(this.GuardarRegresarB_Click);
            // 
            // ActualizarPreRequisitosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 274);
            this.Controls.Add(this.GuardarRegresarB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarCursoB);
            this.Controls.Add(this.CursosDisponiblesLB);
            this.Controls.Add(this.EliminarCursoB);
            this.Controls.Add(this.PreRequisitosLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActualizarPreRequisitosForm";
            this.Text = "Actualizar PreRequisitos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActualizarPreRequisitosForm_FormClosing);
            this.Load += new System.EventHandler(this.ActualizarPreRequisitosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AgregarCursoB;
        private System.Windows.Forms.ListBox CursosDisponiblesLB;
        private System.Windows.Forms.Button EliminarCursoB;
        private System.Windows.Forms.ListBox PreRequisitosLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GuardarRegresarB;
    }
}