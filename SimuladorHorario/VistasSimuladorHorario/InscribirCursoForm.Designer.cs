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
            this.SuspendLayout();
            // 
            // CursosComboBox
            // 
            this.CursosComboBox.FormattingEnabled = true;
            this.CursosComboBox.Location = new System.Drawing.Point(61, 82);
            this.CursosComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CursosComboBox.Name = "CursosComboBox";
            this.CursosComboBox.Size = new System.Drawing.Size(625, 24);
            this.CursosComboBox.TabIndex = 0;
            this.CursosComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // InscribirButton
            // 
            this.InscribirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InscribirButton.Location = new System.Drawing.Point(951, 511);
            this.InscribirButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InscribirButton.Name = "InscribirButton";
            this.InscribirButton.Size = new System.Drawing.Size(100, 28);
            this.InscribirButton.TabIndex = 1;
            this.InscribirButton.Text = "Inscribir";
            this.InscribirButton.UseVisualStyleBackColor = true;
            this.InscribirButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // InscribirCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.InscribirButton);
            this.Controls.Add(this.CursosComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InscribirCursoForm";
            this.Text = "InscribirCursoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InscribirCursoForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CursosComboBox;
        private System.Windows.Forms.Button InscribirButton;
    }
}