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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeerCursoForm));
            this.LeerCursosComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RegresarButton = new System.Windows.Forms.Button();
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
            // RegresarButton
            // 
            this.RegresarButton.Location = new System.Drawing.Point(623, 264);
            this.RegresarButton.Name = "RegresarButton";
            this.RegresarButton.Size = new System.Drawing.Size(75, 23);
            this.RegresarButton.TabIndex = 2;
            this.RegresarButton.Text = "Regresar";
            this.RegresarButton.UseVisualStyleBackColor = true;
            this.RegresarButton.Click += new System.EventHandler(this.RegresarButton_Click);
            // 
            // LeerCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegresarButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LeerCursosComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeerCursoForm";
            this.Text = "LeerCursoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LeerCursoForm_FormClosing);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LeerCursoForm_GiveFeedback);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox LeerCursosComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RegresarButton;
    }
}