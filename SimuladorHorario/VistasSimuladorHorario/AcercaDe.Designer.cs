namespace VistasSimuladorHorario
{
    partial class AcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.descripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.SystemColors.Menu;
            this.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcion.Location = new System.Drawing.Point(14, 21);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(156, 142);
            this.descripcion.TabIndex = 0;
            this.descripcion.Text = "Simulador de Horario\r\n\r\n\r\n--Ditto Team--\r\n\r\n->Ignacio Figueroa\r\n->Vicente Correa\r" +
    "\n->Matías Cánepa\r\n\r\nV: 0.2";
            this.descripcion.TextChanged += new System.EventHandler(this.descripcion_TextChanged);
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 180);
            this.Controls.Add(this.descripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AcercaDe";
            this.Opacity = 0.95D;
            this.Text = "AcercaDe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descripcion;
    }
}