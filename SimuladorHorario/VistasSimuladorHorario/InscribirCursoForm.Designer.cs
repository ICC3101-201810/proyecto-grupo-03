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
            this.CursosComboBox = new System.Windows.Forms.ComboBox();
            this.InscribirButton = new System.Windows.Forms.Button();
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
            this.InscribirButton.Location = new System.Drawing.Point(713, 415);
            this.InscribirButton.Name = "InscribirButton";
            this.InscribirButton.Size = new System.Drawing.Size(75, 23);
            this.InscribirButton.TabIndex = 1;
            this.InscribirButton.Text = "Inscribir";
            this.InscribirButton.UseVisualStyleBackColor = true;
            this.InscribirButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // InscribirCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InscribirButton);
            this.Controls.Add(this.CursosComboBox);
            this.Name = "InscribirCursoForm";
            this.Text = "InscribirCursoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CursosComboBox;
        private System.Windows.Forms.Button InscribirButton;
    }
}