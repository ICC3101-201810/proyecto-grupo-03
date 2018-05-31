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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LeerCursosComboBox
            // 
            this.LeerCursosComboBox.FormattingEnabled = true;
            this.LeerCursosComboBox.Location = new System.Drawing.Point(293, 161);
            this.LeerCursosComboBox.Name = "LeerCursosComboBox";
            this.LeerCursosComboBox.Size = new System.Drawing.Size(254, 21);
            this.LeerCursosComboBox.TabIndex = 0;
            this.LeerCursosComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Leer Curso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LeerCursoButton_Click);
            // 
            // RegresarButton
            // 
            this.RegresarButton.Location = new System.Drawing.Point(472, 199);
            this.RegresarButton.Name = "RegresarButton";
            this.RegresarButton.Size = new System.Drawing.Size(75, 23);
            this.RegresarButton.TabIndex = 2;
            this.RegresarButton.Text = "Regresar";
            this.RegresarButton.UseVisualStyleBackColor = true;
            this.RegresarButton.Click += new System.EventHandler(this.RegresarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el curso que quiere leer:";
            // 
            // LeerCursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegresarButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LeerCursosComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeerCursoForm";
            this.Text = "Leer Curso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LeerCursoForm_FormClosing);
            this.Load += new System.EventHandler(this.LeerCursoForm_Load);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.LeerCursoForm_GiveFeedback);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LeerCursosComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RegresarButton;
        private System.Windows.Forms.Label label1;
    }
}