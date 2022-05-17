namespace Punto_de_venta
{
    partial class formEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEmpleados));
            this.queriesTableAdapter1 = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.QueriesTableAdapter();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.gbEmpleados = new System.Windows.Forms.GroupBox();
            this.tbIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.dtpFecContratacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFecNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApPaterno = new System.Windows.Forms.TextBox();
            this.tbApMaterno = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbNotas = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblFecContratacion = new System.Windows.Forms.Label();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdInfo = new System.Windows.Forms.RadioButton();
            this.rdBorrar = new System.Windows.Forms.RadioButton();
            this.rdActualizar = new System.Windows.Forms.RadioButton();
            this.rdNuevo = new System.Windows.Forms.RadioButton();
            this.puntoDeVentaDataSet = new Punto_de_venta.PuntoDeVentaDataSet();
            this.sp_EmpleadosSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_EmpleadosSelectTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.Sp_EmpleadosSelectTableAdapter();
            this.tableAdapterManager = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.TableAdapterManager();
            this.sp_EmpleadosSelectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tbPage = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sp_EmpleadosSelectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.idEmpleadoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.tbBuscarId = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscarId = new System.Windows.Forms.ToolStripButton();
            this.btnBorrarBusqueda = new System.Windows.Forms.ToolStripButton();
            this.sp_EmpleadosSelectAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_EmpleadosSelectAllTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.Sp_EmpleadosSelectAllTableAdapter();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaContrataciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queriesTableAdapter2 = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.QueriesTableAdapter();
            this.panelDatos.SuspendLayout();
            this.gbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EmpleadosSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EmpleadosSelectBindingNavigator)).BeginInit();
            this.sp_EmpleadosSelectBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EmpleadosSelectAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.SystemColors.Control;
            this.panelDatos.Controls.Add(this.gbEmpleados);
            this.panelDatos.Controls.Add(this.panel2);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatos.Location = new System.Drawing.Point(0, 0);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1081, 413);
            this.panelDatos.TabIndex = 0;
            // 
            // gbEmpleados
            // 
            this.gbEmpleados.Controls.Add(this.tbIdEmpleado);
            this.gbEmpleados.Controls.Add(this.lblIdEmpleado);
            this.gbEmpleados.Controls.Add(this.cbSexo);
            this.gbEmpleados.Controls.Add(this.btnGuardar);
            this.gbEmpleados.Controls.Add(this.btnAgregarFoto);
            this.gbEmpleados.Controls.Add(this.pbFoto);
            this.gbEmpleados.Controls.Add(this.dtpFecContratacion);
            this.gbEmpleados.Controls.Add(this.dtpFecNacimiento);
            this.gbEmpleados.Controls.Add(this.tbNombre);
            this.gbEmpleados.Controls.Add(this.tbApPaterno);
            this.gbEmpleados.Controls.Add(this.tbApMaterno);
            this.gbEmpleados.Controls.Add(this.tbTelefono);
            this.gbEmpleados.Controls.Add(this.tbNotas);
            this.gbEmpleados.Controls.Add(this.lblNombre);
            this.gbEmpleados.Controls.Add(this.lblApPaterno);
            this.gbEmpleados.Controls.Add(this.lblNotas);
            this.gbEmpleados.Controls.Add(this.lblTelefono);
            this.gbEmpleados.Controls.Add(this.lblCargo);
            this.gbEmpleados.Controls.Add(this.lblFechaNac);
            this.gbEmpleados.Controls.Add(this.lblFecContratacion);
            this.gbEmpleados.Controls.Add(this.lblApMaterno);
            this.gbEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEmpleados.Enabled = false;
            this.gbEmpleados.Location = new System.Drawing.Point(0, 96);
            this.gbEmpleados.Margin = new System.Windows.Forms.Padding(10, 6, 0, 6);
            this.gbEmpleados.Name = "gbEmpleados";
            this.gbEmpleados.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.gbEmpleados.Size = new System.Drawing.Size(1081, 317);
            this.gbEmpleados.TabIndex = 22;
            this.gbEmpleados.TabStop = false;
            // 
            // tbIdEmpleado
            // 
            this.tbIdEmpleado.Enabled = false;
            this.tbIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdEmpleado.Location = new System.Drawing.Point(205, 9);
            this.tbIdEmpleado.Margin = new System.Windows.Forms.Padding(6);
            this.tbIdEmpleado.Name = "tbIdEmpleado";
            this.tbIdEmpleado.Size = new System.Drawing.Size(194, 22);
            this.tbIdEmpleado.TabIndex = 26;
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleado.Location = new System.Drawing.Point(173, 12);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(23, 16);
            this.lblIdEmpleado.TabIndex = 27;
            this.lblIdEmpleado.Text = "ID:";
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "H",
            "M"});
            this.cbSexo.Location = new System.Drawing.Point(205, 139);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(6);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(194, 24);
            this.cbSexo.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(424, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFoto.Location = new System.Drawing.Point(780, 188);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(176, 47);
            this.btnAgregarFoto.TabIndex = 10;
            this.btnAgregarFoto.Text = "Agregar Foto";
            this.btnAgregarFoto.UseVisualStyleBackColor = true;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoto.Location = new System.Drawing.Point(780, 19);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(176, 150);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 25;
            this.pbFoto.TabStop = false;
            // 
            // dtpFecContratacion
            // 
            this.dtpFecContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecContratacion.Location = new System.Drawing.Point(541, 9);
            this.dtpFecContratacion.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFecContratacion.Name = "dtpFecContratacion";
            this.dtpFecContratacion.Size = new System.Drawing.Size(194, 20);
            this.dtpFecContratacion.TabIndex = 7;
            // 
            // dtpFecNacimiento
            // 
            this.dtpFecNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecNacimiento.Location = new System.Drawing.Point(205, 172);
            this.dtpFecNacimiento.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFecNacimiento.Name = "dtpFecNacimiento";
            this.dtpFecNacimiento.Size = new System.Drawing.Size(194, 20);
            this.dtpFecNacimiento.TabIndex = 6;
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(205, 43);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(6);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(194, 22);
            this.tbNombre.TabIndex = 2;
            // 
            // tbApPaterno
            // 
            this.tbApPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApPaterno.Location = new System.Drawing.Point(205, 107);
            this.tbApPaterno.Margin = new System.Windows.Forms.Padding(6);
            this.tbApPaterno.Name = "tbApPaterno";
            this.tbApPaterno.Size = new System.Drawing.Size(194, 22);
            this.tbApPaterno.TabIndex = 3;
            // 
            // tbApMaterno
            // 
            this.tbApMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApMaterno.Location = new System.Drawing.Point(205, 75);
            this.tbApMaterno.Margin = new System.Windows.Forms.Padding(6);
            this.tbApMaterno.Name = "tbApMaterno";
            this.tbApMaterno.Size = new System.Drawing.Size(194, 22);
            this.tbApMaterno.TabIndex = 4;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(541, 41);
            this.tbTelefono.Margin = new System.Windows.Forms.Padding(6);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(194, 22);
            this.tbTelefono.TabIndex = 8;
            // 
            // tbNotas
            // 
            this.tbNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNotas.Location = new System.Drawing.Point(541, 73);
            this.tbNotas.Margin = new System.Windows.Forms.Padding(6);
            this.tbNotas.Multiline = true;
            this.tbNotas.Name = "tbNotas";
            this.tbNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNotas.Size = new System.Drawing.Size(194, 85);
            this.tbNotas.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(144, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApPaterno.Location = new System.Drawing.Point(90, 113);
            this.lblApPaterno.Margin = new System.Windows.Forms.Padding(6);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(110, 16);
            this.lblApPaterno.TabIndex = 10;
            this.lblApPaterno.Text = "Apellido Paterno:";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(475, 94);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(46, 16);
            this.lblNotas.TabIndex = 8;
            this.lblNotas.Text = "Notas:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(461, 47);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 16);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(162, 145);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(41, 16);
            this.lblCargo.TabIndex = 5;
            this.lblCargo.Text = "Sexo:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(84, 179);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(119, 16);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // lblFecContratacion
            // 
            this.lblFecContratacion.AutoSize = true;
            this.lblFecContratacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecContratacion.Location = new System.Drawing.Point(413, 15);
            this.lblFecContratacion.Name = "lblFecContratacion";
            this.lblFecContratacion.Size = new System.Drawing.Size(126, 16);
            this.lblFecContratacion.TabIndex = 3;
            this.lblFecContratacion.Text = "Fecha Contratacion:";
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApMaterno.Location = new System.Drawing.Point(91, 81);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(112, 16);
            this.lblApMaterno.TabIndex = 2;
            this.lblApMaterno.Text = "Apellido Materno:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdInfo);
            this.panel2.Controls.Add(this.rdBorrar);
            this.panel2.Controls.Add(this.rdActualizar);
            this.panel2.Controls.Add(this.rdNuevo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 96);
            this.panel2.TabIndex = 21;
            // 
            // rdInfo
            // 
            this.rdInfo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rdInfo.Checked = true;
            this.rdInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdInfo.FlatAppearance.BorderSize = 0;
            this.rdInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.rdInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.rdInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInfo.ForeColor = System.Drawing.Color.White;
            this.rdInfo.Image = global::Punto_de_venta.Properties.Resources.informacion;
            this.rdInfo.Location = new System.Drawing.Point(812, 0);
            this.rdInfo.Margin = new System.Windows.Forms.Padding(0);
            this.rdInfo.Name = "rdInfo";
            this.rdInfo.Size = new System.Drawing.Size(270, 96);
            this.rdInfo.TabIndex = 11;
            this.rdInfo.TabStop = true;
            this.rdInfo.Text = "Informacion";
            this.rdInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdInfo.UseVisualStyleBackColor = false;
            this.rdInfo.CheckedChanged += new System.EventHandler(this.rdInfo_CheckedChanged);
            // 
            // rdBorrar
            // 
            this.rdBorrar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rdBorrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdBorrar.FlatAppearance.BorderSize = 0;
            this.rdBorrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.rdBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.rdBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBorrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBorrar.ForeColor = System.Drawing.Color.White;
            this.rdBorrar.Image = global::Punto_de_venta.Properties.Resources.borrar__1_;
            this.rdBorrar.Location = new System.Drawing.Point(541, 0);
            this.rdBorrar.Margin = new System.Windows.Forms.Padding(0);
            this.rdBorrar.Name = "rdBorrar";
            this.rdBorrar.Size = new System.Drawing.Size(271, 96);
            this.rdBorrar.TabIndex = 10;
            this.rdBorrar.Text = "Borrar";
            this.rdBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdBorrar.UseVisualStyleBackColor = false;
            this.rdBorrar.CheckedChanged += new System.EventHandler(this.rdBorrar_CheckedChanged);
            // 
            // rdActualizar
            // 
            this.rdActualizar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rdActualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdActualizar.FlatAppearance.BorderSize = 0;
            this.rdActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.rdActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.rdActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdActualizar.ForeColor = System.Drawing.Color.White;
            this.rdActualizar.Image = global::Punto_de_venta.Properties.Resources.actualizado__1_;
            this.rdActualizar.Location = new System.Drawing.Point(270, 0);
            this.rdActualizar.Margin = new System.Windows.Forms.Padding(0);
            this.rdActualizar.Name = "rdActualizar";
            this.rdActualizar.Size = new System.Drawing.Size(271, 96);
            this.rdActualizar.TabIndex = 9;
            this.rdActualizar.Text = "Actualizar";
            this.rdActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdActualizar.UseVisualStyleBackColor = false;
            // 
            // rdNuevo
            // 
            this.rdNuevo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rdNuevo.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdNuevo.FlatAppearance.BorderSize = 0;
            this.rdNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.rdNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.rdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNuevo.ForeColor = System.Drawing.Color.White;
            this.rdNuevo.Image = global::Punto_de_venta.Properties.Resources.boton_agregar;
            this.rdNuevo.Location = new System.Drawing.Point(0, 0);
            this.rdNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.rdNuevo.Name = "rdNuevo";
            this.rdNuevo.Size = new System.Drawing.Size(270, 96);
            this.rdNuevo.TabIndex = 8;
            this.rdNuevo.Text = "Nuevo";
            this.rdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdNuevo.UseVisualStyleBackColor = false;
            // 
            // puntoDeVentaDataSet
            // 
            this.puntoDeVentaDataSet.DataSetName = "PuntoDeVentaDataSet";
            this.puntoDeVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_EmpleadosSelectBindingSource
            // 
            this.sp_EmpleadosSelectBindingSource.DataMember = "Sp_EmpleadosSelect";
            this.sp_EmpleadosSelectBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // sp_EmpleadosSelectTableAdapter
            // 
            this.sp_EmpleadosSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Punto_de_venta.PuntoDeVentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_EmpleadosSelectBindingNavigator
            // 
            this.sp_EmpleadosSelectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sp_EmpleadosSelectBindingNavigator.BindingSource = this.sp_EmpleadosSelectBindingSource;
            this.sp_EmpleadosSelectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sp_EmpleadosSelectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sp_EmpleadosSelectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.tbPage,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sp_EmpleadosSelectBindingNavigatorSaveItem});
            this.sp_EmpleadosSelectBindingNavigator.Location = new System.Drawing.Point(0, 413);
            this.sp_EmpleadosSelectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sp_EmpleadosSelectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sp_EmpleadosSelectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sp_EmpleadosSelectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sp_EmpleadosSelectBindingNavigator.Name = "sp_EmpleadosSelectBindingNavigator";
            this.sp_EmpleadosSelectBindingNavigator.PositionItem = this.tbPage;
            this.sp_EmpleadosSelectBindingNavigator.Size = new System.Drawing.Size(1081, 25);
            this.sp_EmpleadosSelectBindingNavigator.TabIndex = 1;
            this.sp_EmpleadosSelectBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tbPage
            // 
            this.tbPage.AccessibleName = "Posición";
            this.tbPage.AutoSize = false;
            this.tbPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(50, 23);
            this.tbPage.Text = "0";
            this.tbPage.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sp_EmpleadosSelectBindingNavigatorSaveItem
            // 
            this.sp_EmpleadosSelectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sp_EmpleadosSelectBindingNavigatorSaveItem.Enabled = false;
            this.sp_EmpleadosSelectBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sp_EmpleadosSelectBindingNavigatorSaveItem.Image")));
            this.sp_EmpleadosSelectBindingNavigatorSaveItem.Name = "sp_EmpleadosSelectBindingNavigatorSaveItem";
            this.sp_EmpleadosSelectBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sp_EmpleadosSelectBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idEmpleadoToolStripLabel,
            this.tbBuscarId,
            this.btnBuscarId,
            this.btnBorrarBusqueda});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 438);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1081, 25);
            this.fillToolStrip.TabIndex = 2;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // idEmpleadoToolStripLabel
            // 
            this.idEmpleadoToolStripLabel.Name = "idEmpleadoToolStripLabel";
            this.idEmpleadoToolStripLabel.Size = new System.Drawing.Size(73, 22);
            this.idEmpleadoToolStripLabel.Text = "IdEmpleado:";
            // 
            // tbBuscarId
            // 
            this.tbBuscarId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbBuscarId.Name = "tbBuscarId";
            this.tbBuscarId.Size = new System.Drawing.Size(100, 25);
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(46, 22);
            this.btnBuscarId.Text = "Buscar";
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // btnBorrarBusqueda
            // 
            this.btnBorrarBusqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBorrarBusqueda.MergeIndex = 0;
            this.btnBorrarBusqueda.Name = "btnBorrarBusqueda";
            this.btnBorrarBusqueda.Size = new System.Drawing.Size(43, 22);
            this.btnBorrarBusqueda.Text = "Borrar";
            this.btnBorrarBusqueda.Click += new System.EventHandler(this.btnBorrarBusqueda_Click);
            // 
            // sp_EmpleadosSelectAllBindingSource
            // 
            this.sp_EmpleadosSelectAllBindingSource.DataMember = "Sp_EmpleadosSelectAll";
            this.sp_EmpleadosSelectAllBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // sp_EmpleadosSelectAllTableAdapter
            // 
            this.sp_EmpleadosSelectAllTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoPaternoDataGridViewTextBoxColumn,
            this.apellidoMaternoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.fechaContrataciónDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.notasDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.sp_EmpleadosSelectAllBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 463);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1081, 286);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowEnter);
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoPaternoDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
            this.apellidoPaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoMaternoDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
            this.apellidoMaternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaContrataciónDataGridViewTextBoxColumn
            // 
            this.fechaContrataciónDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaContrataciónDataGridViewTextBoxColumn.DataPropertyName = "FechaContratación";
            this.fechaContrataciónDataGridViewTextBoxColumn.HeaderText = "FechaContratación";
            this.fechaContrataciónDataGridViewTextBoxColumn.Name = "fechaContrataciónDataGridViewTextBoxColumn";
            this.fechaContrataciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.ReadOnly = true;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1081, 749);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.sp_EmpleadosSelectBindingNavigator);
            this.Controls.Add(this.panelDatos);
            this.Name = "formEmpleados";
            this.Text = "formEmpleados";
            this.Load += new System.EventHandler(this.formEmpleados_Load);
            this.panelDatos.ResumeLayout(false);
            this.gbEmpleados.ResumeLayout(false);
            this.gbEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EmpleadosSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EmpleadosSelectBindingNavigator)).EndInit();
            this.sp_EmpleadosSelectBindingNavigator.ResumeLayout(false);
            this.sp_EmpleadosSelectBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EmpleadosSelectAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PuntoDeVentaDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdBorrar;
        private System.Windows.Forms.RadioButton rdActualizar;
        private System.Windows.Forms.RadioButton rdNuevo;
        private PuntoDeVentaDataSet puntoDeVentaDataSet;
        private System.Windows.Forms.BindingSource sp_EmpleadosSelectBindingSource;
        private PuntoDeVentaDataSetTableAdapters.Sp_EmpleadosSelectTableAdapter sp_EmpleadosSelectTableAdapter;
        private PuntoDeVentaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sp_EmpleadosSelectBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox tbPage;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sp_EmpleadosSelectBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel idEmpleadoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox tbBuscarId;
        private System.Windows.Forms.ToolStripButton btnBuscarId;
        private System.Windows.Forms.BindingSource sp_EmpleadosSelectAllBindingSource;
        private PuntoDeVentaDataSetTableAdapters.Sp_EmpleadosSelectAllTableAdapter sp_EmpleadosSelectAllTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox gbEmpleados;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregarFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.DateTimePicker dtpFecContratacion;
        private System.Windows.Forms.DateTimePicker dtpFecNacimiento;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApPaterno;
        private System.Windows.Forms.TextBox tbApMaterno;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbNotas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblFecContratacion;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.RadioButton rdInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaContrataciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbIdEmpleado;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.ToolStripButton btnBorrarBusqueda;
        private PuntoDeVentaDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter2;
    }
}