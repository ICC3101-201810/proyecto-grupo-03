using System;

namespace VistasSimuladorHorario
{
    partial class profesorLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profesorLabel));
            this.CursosComboBox = new System.Windows.Forms.ComboBox();
            this.InscribirButton = new System.Windows.Forms.Button();
            this.profesorComboBox = new System.Windows.Forms.ComboBox();
            this.nombreCursoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CursosComboBox
            // 
            this.CursosComboBox.FormattingEnabled = true;
            this.CursosComboBox.Location = new System.Drawing.Point(46, 67);
            this.CursosComboBox.Name = "CursosComboBox";
            this.CursosComboBox.Size = new System.Drawing.Size(470, 21);
            this.CursosComboBox.TabIndex = 0;
            this.CursosComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // InscribirButton
            // 
            this.InscribirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InscribirButton.Location = new System.Drawing.Point(458, 222);
            this.InscribirButton.Name = "InscribirButton";
            this.InscribirButton.Size = new System.Drawing.Size(75, 23);
            this.InscribirButton.TabIndex = 1;
            this.InscribirButton.Text = "Inscribir";
            this.InscribirButton.UseVisualStyleBackColor = true;
            this.InscribirButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // profesorComboBox
            // 
            this.profesorComboBox.FormattingEnabled = true;
            this.profesorComboBox.Location = new System.Drawing.Point(46, 133);
            this.profesorComboBox.Name = "profesorComboBox";
            this.profesorComboBox.Size = new System.Drawing.Size(337, 21);
            this.profesorComboBox.TabIndex = 2;
            // 
            // nombreCursoLabel
            // 
            this.nombreCursoLabel.AutoSize = true;
            this.nombreCursoLabel.Location = new System.Drawing.Point(43, 51);
            this.nombreCursoLabel.Name = "nombreCursoLabel";
            this.nombreCursoLabel.Size = new System.Drawing.Size(74, 13);
            this.nombreCursoLabel.TabIndex = 3;
            this.nombreCursoLabel.Text = "Nombre Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Profesor";
            // 
            // profesorLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreCursoLabel);
            this.Controls.Add(this.profesorComboBox);
            this.Controls.Add(this.InscribirButton);
            this.Controls.Add(this.CursosComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "profesorLabel";
            this.Text = "InscribirCursoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InscribirCursoForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CursosComboBox;
        private System.Windows.Forms.Button InscribirButton;
        private System.Windows.Forms.ComboBox profesorComboBox;
        private System.Windows.Forms.Label nombreCursoLabel;
        private System.Windows.Forms.Label label1;
    }
}