﻿using System;

namespace VistasSimuladorHorario
{
    partial class GestorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ActualizarCursoButton = new System.Windows.Forms.Button();
            this.ActualizarAvanceB = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Curso";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CrearCursoButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eliminar Curso";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EliminarCursoButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Leer Curso";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LeerCursoButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(490, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cerrar Sesión";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CerrarSesionButton_Click);
            // 
            // ActualizarCursoButton
            // 
            this.ActualizarCursoButton.Location = new System.Drawing.Point(397, 138);
            this.ActualizarCursoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ActualizarCursoButton.Name = "ActualizarCursoButton";
            this.ActualizarCursoButton.Size = new System.Drawing.Size(148, 44);
            this.ActualizarCursoButton.TabIndex = 4;
            this.ActualizarCursoButton.Text = "Actualizar Curso";
            this.ActualizarCursoButton.UseVisualStyleBackColor = true;
            this.ActualizarCursoButton.Click += new System.EventHandler(this.ActualizarCursoButton_Click);
            // 
            // ActualizarAvanceB
            // 
            this.ActualizarAvanceB.Location = new System.Drawing.Point(37, 137);
            this.ActualizarAvanceB.Name = "ActualizarAvanceB";
            this.ActualizarAvanceB.Size = new System.Drawing.Size(148, 45);
            this.ActualizarAvanceB.TabIndex = 5;
            this.ActualizarAvanceB.Text = "Actualizar Avance de Malla";
            this.ActualizarAvanceB.UseVisualStyleBackColor = true;
            this.ActualizarAvanceB.Click += new System.EventHandler(this.ActualizarAvanceB_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(39, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "Crear Nuevo Administrador";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // GestorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ActualizarAvanceB);
            this.Controls.Add(this.ActualizarCursoButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestorForm";
            this.Text = "Gestor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestorForm_FormClosing);
            this.Load += new System.EventHandler(this.GestorForm_Load);
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ActualizarCursoButton;
        private System.Windows.Forms.Button ActualizarAvanceB;
        private System.Windows.Forms.Button button5;
    }
}