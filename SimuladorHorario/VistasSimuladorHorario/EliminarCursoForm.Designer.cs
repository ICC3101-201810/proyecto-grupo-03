namespace VistasSimuladorHorario
{
    partial class EliminarCursoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarCursoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.EliminarCursosComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el curso que quiere eliminar:";
            // 
            // EliminarCursosComboBox
            // 
            this.EliminarCursosComboBox.FormattingEnabled = true;
            this.EliminarCursosComboBox.Location = new System.Drawing.Point(389, 196);
            this.EliminarCursosComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EliminarCursosComboBox.Name = "EliminarCursosComboBox";
            this.EliminarCursosComboBox.Size = new System.Drawing.Size(425, 24);
            this.EliminarCursosComboBox.TabIndex = 1;
            this.EliminarCursosComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar Curso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EliminarCursoButton_Click);
            // 
            // EliminarCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EliminarCursosComboBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EliminarCursoForm";
            this.Text = "EliminarCursoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EliminarCursoForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EliminarCursosComboBox;
        private System.Windows.Forms.Button button1;
    }
}