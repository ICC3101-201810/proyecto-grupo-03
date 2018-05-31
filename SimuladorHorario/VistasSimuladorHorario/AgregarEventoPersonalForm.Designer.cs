namespace VistasSimuladorHorario
{
    partial class AgregarEventoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEventoForm));
            this.FechaEvento = new System.Windows.Forms.DateTimePicker();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SalaUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BloqueHComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DuracionComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AgregarEventoButton = new System.Windows.Forms.Button();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FechaEvento
            // 
            this.FechaEvento.Location = new System.Drawing.Point(123, 54);
            this.FechaEvento.Margin = new System.Windows.Forms.Padding(2);
            this.FechaEvento.Name = "FechaEvento";
            this.FechaEvento.Size = new System.Drawing.Size(151, 20);
            this.FechaEvento.TabIndex = 0;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(20, 58);
            this.FechaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(37, 13);
            this.FechaLabel.TabIndex = 3;
            this.FechaLabel.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sala";
            // 
            // SalaUser
            // 
            this.SalaUser.Location = new System.Drawing.Point(123, 140);
            this.SalaUser.Margin = new System.Windows.Forms.Padding(2);
            this.SalaUser.Name = "SalaUser";
            this.SalaUser.Size = new System.Drawing.Size(92, 20);
            this.SalaUser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hora de Inicio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BloqueHComboBox
            // 
            this.BloqueHComboBox.FormattingEnabled = true;
            this.BloqueHComboBox.Location = new System.Drawing.Point(123, 185);
            this.BloqueHComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.BloqueHComboBox.Name = "BloqueHComboBox";
            this.BloqueHComboBox.Size = new System.Drawing.Size(92, 21);
            this.BloqueHComboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 232);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Duración";
            // 
            // DuracionComboBox
            // 
            this.DuracionComboBox.FormattingEnabled = true;
            this.DuracionComboBox.Location = new System.Drawing.Point(123, 226);
            this.DuracionComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.DuracionComboBox.Name = "DuracionComboBox";
            this.DuracionComboBox.Size = new System.Drawing.Size(44, 21);
            this.DuracionComboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hrs.";
            // 
            // AgregarEventoButton
            // 
            this.AgregarEventoButton.Location = new System.Drawing.Point(406, 51);
            this.AgregarEventoButton.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarEventoButton.Name = "AgregarEventoButton";
            this.AgregarEventoButton.Size = new System.Drawing.Size(136, 191);
            this.AgregarEventoButton.TabIndex = 6;
            this.AgregarEventoButton.Text = "Agregar Evento";
            this.AgregarEventoButton.UseVisualStyleBackColor = true;
            this.AgregarEventoButton.Click += new System.EventHandler(this.AgregarEventoButton_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(123, 98);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(151, 20);
            this.nombreTextBox.TabIndex = 2;
            // 
            // AgregarEventoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.AgregarEventoButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DuracionComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BloqueHComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SalaUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.FechaEvento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarEventoForm";
            this.Text = "Agregar Evento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarEventoForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaEvento;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SalaUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BloqueHComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DuracionComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AgregarEventoButton;
        private System.Windows.Forms.TextBox nombreTextBox;
    }
}