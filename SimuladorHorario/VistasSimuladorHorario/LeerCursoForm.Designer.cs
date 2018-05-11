namespace VistasSimuladorHorario
{
    partial class LeerCursoForm
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
            this.LeerCursosComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeerCursosComboBox
            // 
            this.LeerCursosComboBox.FormattingEnabled = true;
            this.LeerCursosComboBox.Location = new System.Drawing.Point(311, 201);
            this.LeerCursosComboBox.Name = "LeerCursosComboBox";
            this.LeerCursosComboBox.Size = new System.Drawing.Size(314, 21);
            this.LeerCursosComboBox.TabIndex = 0;
            this.LeerCursosComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Leer Curso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LeerCursoButton_Click);
            // 
            // LeerCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LeerCursosComboBox);
            this.Name = "LeerCursoForm";
            this.Text = "LeerCursoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox LeerCursosComboBox;
        private System.Windows.Forms.Button button1;
    }
}