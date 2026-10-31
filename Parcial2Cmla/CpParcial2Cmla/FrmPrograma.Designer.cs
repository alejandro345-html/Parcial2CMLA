namespace CpParcial2Cmla
{
    partial class FrmPrograma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrograma));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cbxCanal = new System.Windows.Forms.ComboBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.mtbxHoraFin = new System.Windows.Forms.MaskedTextBox();
            this.mtbxHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtConductorPrincipal = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.lblConductorPrincipal = new System.Windows.Forms.Label();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblTituloPrograma = new System.Windows.Forms.Label();
            this.lblDiaSemana = new System.Windows.Forms.Label();
            this.lblCanal = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gxbLista = new System.Windows.Forms.GroupBox();
            this.dgvListarProgramas = new System.Windows.Forms.DataGridView();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.erpTitulo = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpHoraInicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpHoraFin = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpDiaSemana = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpConductorPrincipal = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCanal = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.gxbLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarProgramas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHoraInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHoraFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDiaSemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpConductorPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCanal)).BeginInit();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(646, 428);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(645, 363);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 49;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(671, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(118, 42);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(145, 19);
            this.lblBuscar.TabIndex = 47;
            this.lblBuscar.Text = "Buscar Programas";
            // 
            // cbxCanal
            // 
            this.cbxCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCanal.FormattingEnabled = true;
            this.cbxCanal.Location = new System.Drawing.Point(178, 319);
            this.cbxCanal.Name = "cbxCanal";
            this.cbxCanal.Size = new System.Drawing.Size(411, 21);
            this.cbxCanal.TabIndex = 45;
            // 
            // txtParametro
            // 
            this.txtParametro.BackColor = System.Drawing.Color.AliceBlue;
            this.txtParametro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParametro.Location = new System.Drawing.Point(269, 43);
            this.txtParametro.MaxLength = 50;
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(396, 20);
            this.txtParametro.TabIndex = 46;
            this.txtParametro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParametro_KeyPress);
            // 
            // mtbxHoraFin
            // 
            this.mtbxHoraFin.Location = new System.Drawing.Point(448, 388);
            this.mtbxHoraFin.Mask = "00:00";
            this.mtbxHoraFin.Name = "mtbxHoraFin";
            this.mtbxHoraFin.Size = new System.Drawing.Size(141, 20);
            this.mtbxHoraFin.TabIndex = 44;
            this.mtbxHoraFin.ValidatingType = typeof(System.DateTime);
            // 
            // mtbxHoraInicio
            // 
            this.mtbxHoraInicio.Location = new System.Drawing.Point(229, 388);
            this.mtbxHoraInicio.Mask = "00:00";
            this.mtbxHoraInicio.Name = "mtbxHoraInicio";
            this.mtbxHoraInicio.Size = new System.Drawing.Size(135, 20);
            this.mtbxHoraInicio.TabIndex = 43;
            this.mtbxHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(290, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(502, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 40;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(393, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.Location = new System.Drawing.Point(189, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 38;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtConductorPrincipal
            // 
            this.txtConductorPrincipal.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConductorPrincipal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtConductorPrincipal.Location = new System.Drawing.Point(273, 472);
            this.txtConductorPrincipal.MaxLength = 100;
            this.txtConductorPrincipal.Name = "txtConductorPrincipal";
            this.txtConductorPrincipal.Size = new System.Drawing.Size(316, 20);
            this.txtConductorPrincipal.TabIndex = 37;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTitulo.Location = new System.Drawing.Point(178, 355);
            this.txtTitulo.MaxLength = 100;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(411, 20);
            this.txtTitulo.TabIndex = 36;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDiaSemana.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDiaSemana.Location = new System.Drawing.Point(254, 429);
            this.txtDiaSemana.MaxLength = 20;
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(335, 20);
            this.txtDiaSemana.TabIndex = 35;
            // 
            // lblConductorPrincipal
            // 
            this.lblConductorPrincipal.AutoSize = true;
            this.lblConductorPrincipal.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConductorPrincipal.Location = new System.Drawing.Point(109, 471);
            this.lblConductorPrincipal.Name = "lblConductorPrincipal";
            this.lblConductorPrincipal.Size = new System.Drawing.Size(158, 19);
            this.lblConductorPrincipal.TabIndex = 34;
            this.lblConductorPrincipal.Text = "Conductor Principal";
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraFin.Location = new System.Drawing.Point(370, 387);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(72, 19);
            this.lblHoraFin.TabIndex = 33;
            this.lblHoraFin.Text = "Hora Fin";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(109, 387);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(114, 19);
            this.lblHoraInicio.TabIndex = 32;
            this.lblHoraInicio.Text = "Hora de Inicio";
            // 
            // lblTituloPrograma
            // 
            this.lblTituloPrograma.AutoSize = true;
            this.lblTituloPrograma.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrograma.Location = new System.Drawing.Point(110, 354);
            this.lblTituloPrograma.Name = "lblTituloPrograma";
            this.lblTituloPrograma.Size = new System.Drawing.Size(52, 19);
            this.lblTituloPrograma.TabIndex = 31;
            this.lblTituloPrograma.Text = "Titulo";
            // 
            // lblDiaSemana
            // 
            this.lblDiaSemana.AutoSize = true;
            this.lblDiaSemana.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaSemana.Location = new System.Drawing.Point(110, 428);
            this.lblDiaSemana.Name = "lblDiaSemana";
            this.lblDiaSemana.Size = new System.Drawing.Size(139, 19);
            this.lblDiaSemana.TabIndex = 30;
            this.lblDiaSemana.Text = "Día de la Semana";
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanal.Location = new System.Drawing.Point(110, 320);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(51, 19);
            this.lblCanal.TabIndex = 29;
            this.lblCanal.Text = "Canal";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitulo.Location = new System.Drawing.Point(293, -4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 50);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "PROGRAMAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gxbLista
            // 
            this.gxbLista.Controls.Add(this.dgvListarProgramas);
            this.gxbLista.Location = new System.Drawing.Point(12, 65);
            this.gxbLista.Name = "gxbLista";
            this.gxbLista.Size = new System.Drawing.Size(830, 200);
            this.gxbLista.TabIndex = 42;
            this.gxbLista.TabStop = false;
            this.gxbLista.Text = "Lista de Programas";
            // 
            // dgvListarProgramas
            // 
            this.dgvListarProgramas.AllowUserToAddRows = false;
            this.dgvListarProgramas.AllowUserToDeleteRows = false;
            this.dgvListarProgramas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListarProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarProgramas.Location = new System.Drawing.Point(4, 17);
            this.dgvListarProgramas.MultiSelect = false;
            this.dgvListarProgramas.Name = "dgvListarProgramas";
            this.dgvListarProgramas.ReadOnly = true;
            this.dgvListarProgramas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarProgramas.Size = new System.Drawing.Size(820, 178);
            this.dgvListarProgramas.TabIndex = 17;
            // 
            // gbxDatos
            // 
            this.gbxDatos.Location = new System.Drawing.Point(90, 306);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(675, 200);
            this.gbxDatos.TabIndex = 51;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // erpTitulo
            // 
            this.erpTitulo.ContainerControl = this;
            // 
            // erpHoraInicio
            // 
            this.erpHoraInicio.ContainerControl = this;
            // 
            // erpHoraFin
            // 
            this.erpHoraFin.ContainerControl = this;
            // 
            // erpDiaSemana
            // 
            this.erpDiaSemana.ContainerControl = this;
            // 
            // erpConductorPrincipal
            // 
            this.erpConductorPrincipal.ContainerControl = this;
            // 
            // erpCanal
            // 
            this.erpCanal.ContainerControl = this;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnCerrar);
            this.pnlAcciones.Location = new System.Drawing.Point(12, 266);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(830, 34);
            this.pnlAcciones.TabIndex = 52;
            // 
            // FrmPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 511);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.cbxCanal);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.mtbxHoraFin);
            this.Controls.Add(this.mtbxHoraInicio);
            this.Controls.Add(this.txtConductorPrincipal);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtDiaSemana);
            this.Controls.Add(this.lblConductorPrincipal);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblTituloPrograma);
            this.Controls.Add(this.lblDiaSemana);
            this.Controls.Add(this.lblCanal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gxbLista);
            this.Controls.Add(this.gbxDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":::::: Programas :::::: -Parcial2Cmla-";
            this.Load += new System.EventHandler(this.FrmPrograma_Load);
            this.gxbLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarProgramas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHoraInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpHoraFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpDiaSemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpConductorPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCanal)).EndInit();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cbxCanal;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.MaskedTextBox mtbxHoraFin;
        private System.Windows.Forms.MaskedTextBox mtbxHoraInicio;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtConductorPrincipal;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.Label lblConductorPrincipal;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblTituloPrograma;
        private System.Windows.Forms.Label lblDiaSemana;
        private System.Windows.Forms.Label lblCanal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gxbLista;
        private System.Windows.Forms.DataGridView dgvListarProgramas;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.ErrorProvider erpTitulo;
        private System.Windows.Forms.ErrorProvider erpHoraInicio;
        private System.Windows.Forms.ErrorProvider erpHoraFin;
        private System.Windows.Forms.ErrorProvider erpDiaSemana;
        private System.Windows.Forms.ErrorProvider erpConductorPrincipal;
        private System.Windows.Forms.ErrorProvider erpCanal;
        private System.Windows.Forms.Panel pnlAcciones;
    }
}

