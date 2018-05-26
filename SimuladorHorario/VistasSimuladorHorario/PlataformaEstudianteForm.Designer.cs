namespace VistasSimuladorHorario
{
    partial class PlataformaEstudianteForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlataformaEstudianteForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wIWIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeSHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.AgendaDataGrid = new System.Windows.Forms.DataGridView();
            this.Agenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miéricoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sábado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cerrarSesionButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgendaDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.wIWIToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.guardarToolStripMenuItem.Text = "Guardar...";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // wIWIToolStripMenuItem
            // 
            this.wIWIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscribirCursoToolStripMenuItem,
            this.modificarPerfilToolStripMenuItem});
            this.wIWIToolStripMenuItem.Name = "wIWIToolStripMenuItem";
            this.wIWIToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.wIWIToolStripMenuItem.Text = "Acciones";
            this.wIWIToolStripMenuItem.Click += new System.EventHandler(this.wIWIToolStripMenuItem_Click);
            // 
            // inscribirCursoToolStripMenuItem
            // 
            this.inscribirCursoToolStripMenuItem.Name = "inscribirCursoToolStripMenuItem";
            this.inscribirCursoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.inscribirCursoToolStripMenuItem.Text = "Inscribir Curso...";
            this.inscribirCursoToolStripMenuItem.Click += new System.EventHandler(this.inscribirCursoToolStripMenuItem_Click);
            // 
            // modificarPerfilToolStripMenuItem
            // 
            this.modificarPerfilToolStripMenuItem.Name = "modificarPerfilToolStripMenuItem";
            this.modificarPerfilToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.modificarPerfilToolStripMenuItem.Text = "Modificar Perfil...";
            this.modificarPerfilToolStripMenuItem.Click += new System.EventHandler(this.modificarPerfilToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentacionToolStripMenuItem,
            this.acercaDeSHToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // documentacionToolStripMenuItem
            // 
            this.documentacionToolStripMenuItem.Name = "documentacionToolStripMenuItem";
            this.documentacionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.documentacionToolStripMenuItem.Text = "Documentacion";
            this.documentacionToolStripMenuItem.Click += new System.EventHandler(this.documentacionToolStripMenuItem_Click);
            // 
            // acercaDeSHToolStripMenuItem
            // 
            this.acercaDeSHToolStripMenuItem.Name = "acercaDeSHToolStripMenuItem";
            this.acercaDeSHToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.acercaDeSHToolStripMenuItem.Text = "Acerca de SH";
            this.acercaDeSHToolStripMenuItem.Click += new System.EventHandler(this.acercaDeSHToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.MintCream;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.AgendaDataGrid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(983, 516);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 1;
            // 
            // AgendaDataGrid
            // 
            this.AgendaDataGrid.AllowUserToAddRows = false;
            this.AgendaDataGrid.AllowUserToDeleteRows = false;
            this.AgendaDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AgendaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgendaDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agenda,
            this.dataGridViewTextBoxColumn1});
            this.AgendaDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgendaDataGrid.Location = new System.Drawing.Point(0, 0);
            this.AgendaDataGrid.Name = "AgendaDataGrid";
            this.AgendaDataGrid.ReadOnly = true;
            this.AgendaDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.AgendaDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AgendaDataGrid.Size = new System.Drawing.Size(326, 516);
            this.AgendaDataGrid.TabIndex = 0;
            this.AgendaDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Agenda
            // 
            this.Agenda.HeaderText = "Próximos Eventos";
            this.Agenda.Name = "Agenda";
            this.Agenda.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hora,
            this.Lunes,
            this.Martes,
            this.Miéricoles,
            this.Jueves,
            this.Viernes,
            this.Sábado});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(649, 516);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Hora
            // 
            this.Hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.DefaultCellStyle = dataGridViewCellStyle2;
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 69;
            // 
            // Lunes
            // 
            this.Lunes.HeaderText = "Lunes";
            this.Lunes.Name = "Lunes";
            this.Lunes.ReadOnly = true;
            // 
            // Martes
            // 
            this.Martes.HeaderText = "Martes";
            this.Martes.Name = "Martes";
            this.Martes.ReadOnly = true;
            // 
            // Miéricoles
            // 
            this.Miéricoles.HeaderText = "Miércoles";
            this.Miéricoles.Name = "Miéricoles";
            this.Miéricoles.ReadOnly = true;
            // 
            // Jueves
            // 
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.Name = "Jueves";
            this.Jueves.ReadOnly = true;
            // 
            // Viernes
            // 
            this.Viernes.HeaderText = "Viernes";
            this.Viernes.Name = "Viernes";
            this.Viernes.ReadOnly = true;
            // 
            // Sábado
            // 
            this.Sábado.HeaderText = "Sábado";
            this.Sábado.Name = "Sábado";
            this.Sábado.ReadOnly = true;
            // 
            // aplicacionBindingSource
            // 
            this.aplicacionBindingSource.DataSource = typeof(SimuladorHorario.Aplicacion);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(SimuladorHorario.Usuario);
            // 
            // horarioBindingSource
            // 
            this.horarioBindingSource.DataSource = typeof(SimuladorHorario.Horario);
            // 
            // cerrarSesionButton
            // 
            this.cerrarSesionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrarSesionButton.Location = new System.Drawing.Point(879, 0);
            this.cerrarSesionButton.Name = "cerrarSesionButton";
            this.cerrarSesionButton.Size = new System.Drawing.Size(92, 23);
            this.cerrarSesionButton.TabIndex = 2;
            this.cerrarSesionButton.Text = "Cerrar Sesion";
            this.cerrarSesionButton.UseVisualStyleBackColor = true;
            this.cerrarSesionButton.Click += new System.EventHandler(this.cerrarSesionButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(340, 5);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(49, 13);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "Usuario: ";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // PlataformaEstudianteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 540);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.cerrarSesionButton);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlataformaEstudianteForm";
            this.Text = "Plataforma Estudiante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlataformaEstudianteForm_FormClosing);
            this.Load += new System.EventHandler(this.PlataformaEstudianteForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AgendaDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.BindingSource horarioBindingSource;
        private System.Windows.Forms.BindingSource aplicacionBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeSHToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView AgendaDataGrid;
        private System.Windows.Forms.ToolStripMenuItem wIWIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscribirCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPerfilToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button cerrarSesionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miéricoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sábado;
        private System.Windows.Forms.Label userNameLabel;
    }
}