using System;

namespace VistasSimuladorHorario
{
    partial class InscribirCursoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscribirCursoForm));
            this.CursosComboBox = new System.Windows.Forms.ComboBox();
            this.InscribirButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CursosComboBox
            // 
            this.CursosComboBox.FormattingEnabled = true;
            this.CursosComboBox.Location = new System.Drawing.Point(12, 41);
            this.CursosComboBox.Name = "CursosComboBox";
            this.CursosComboBox.Size = new System.Drawing.Size(470, 21);
            this.CursosComboBox.TabIndex = 0;
            this.CursosComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // InscribirButton
            // 
            this.InscribirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InscribirButton.Location = new System.Drawing.Point(494, 39);
            this.InscribirButton.Name = "InscribirButton";
            this.InscribirButton.Size = new System.Drawing.Size(75, 23);
            this.InscribirButton.TabIndex = 1;
            this.InscribirButton.Text = "Inscribir";
            this.InscribirButton.UseVisualStyleBackColor = true;
            this.InscribirButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un Curso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InscribirCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 74);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InscribirButton);
            this.Controls.Add(this.CursosComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InscribirCursoForm";
            this.Text = "Inscribir Curso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InscribirCursoForm_FormClosing);
            this.Load += new System.EventHandler(this.InscribirCursoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CursosComboBox;
        private System.Windows.Forms.Button InscribirButton;
        private System.Windows.Forms.Label label1;
    }
}