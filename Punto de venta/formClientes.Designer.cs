namespace Punto_de_venta
{
    partial class formClientes
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
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.dtpFecNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApPaterno = new System.Windows.Forms.TextBox();
            this.tbApMaterno = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApPaterno = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblApMaterno = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoPaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoMaternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teléfonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_ClientesSelectAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puntoDeVentaDataSet = new Punto_de_venta.PuntoDeVentaDataSet();
            this.sp_ClientesSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ClientesSelectTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.Sp_ClientesSelectTableAdapter();
            this.tableAdapterManager = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.TableAdapterManager();
            this.btnBuscarId = new System.Windows.Forms.ToolStrip();
            this.idClienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.tbBuscarId = new System.Windows.Forms.ToolStripTextBox();
            this.sp_ClientesSelectAllTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.Sp_ClientesSelectAllTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdInfo = new System.Windows.Forms.RadioButton();
            this.rdBorrar = new System.Windows.Forms.RadioButton();
            this.rdActualizar = new System.Windows.Forms.RadioButton();
            this.rdNuevo = new System.Windows.Forms.RadioButton();
            this.queriesTableAdapter1 = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.QueriesTableAdapter();
            this.btnBorrarBusqueda = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ClientesSelectAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ClientesSelectBindingSource)).BeginInit();
            this.btnBuscarId.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.btnGuardar);
            this.gbClientes.Controls.Add(this.cbSexo);
            this.gbClientes.Controls.Add(this.lblSexo);
            this.gbClientes.Controls.Add(this.dtpFecNacimiento);
            this.gbClientes.Controls.Add(this.tbNombre);
            this.gbClientes.Controls.Add(this.tbApPaterno);
            this.gbClientes.Controls.Add(this.tbApMaterno);
            this.gbClientes.Controls.Add(this.tbTelefono);
            this.gbClientes.Controls.Add(this.lblNombre);
            this.gbClientes.Controls.Add(this.lblApPaterno);
            this.gbClientes.Controls.Add(this.lblTelefono);
            this.gbClientes.Controls.Add(this.lblFechaNac);
            this.gbClientes.Controls.Add(this.lblApMaterno);
            this.gbClientes.Controls.Add(this.lblIdCliente);
            this.gbClientes.Controls.Add(this.tbIdCliente);
            this.gbClientes.Location = new System.Drawing.Point(0, 96);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(1081, 317);
            this.gbClientes.TabIndex = 19;
            this.gbClientes.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(432, 240);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "H"});
            this.cbSexo.Location = new System.Drawing.Point(134, 210);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(200, 21);
            this.cbSexo.TabIndex = 32;
            this.cbSexo.Text = "Seleccionar";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(93, 213);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 31;
            this.lblSexo.Text = "Sexo:";
            // 
            // dtpFecNacimiento
            // 
            this.dtpFecNacimiento.Location = new System.Drawing.Point(134, 242);
            this.dtpFecNacimiento.Name = "dtpFecNacimiento";
            this.dtpFecNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFecNacimiento.TabIndex = 23;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(134, 80);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 20);
            this.tbNombre.TabIndex = 22;
            // 
            // tbApPaterno
            // 
            this.tbApPaterno.Location = new System.Drawing.Point(134, 112);
            this.tbApPaterno.Name = "tbApPaterno";
            this.tbApPaterno.Size = new System.Drawing.Size(200, 20);
            this.tbApPaterno.TabIndex = 21;
            // 
            // tbApMaterno
            // 
            this.tbApMaterno.Location = new System.Drawing.Point(134, 144);
            this.tbApMaterno.Name = "tbApMaterno";
            this.tbApMaterno.Size = new System.Drawing.Size(200, 20);
            this.tbApMaterno.TabIndex = 20;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(134, 175);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(200, 20);
            this.tbTelefono.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(81, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.Location = new System.Drawing.Point(41, 115);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(87, 13);
            this.lblApPaterno.TabIndex = 10;
            this.lblApPaterno.Text = "Apellido Paterno:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(76, 178);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(32, 245);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(96, 13);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.Location = new System.Drawing.Point(39, 147);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(89, 13);
            this.lblApMaterno.TabIndex = 2;
            this.lblApMaterno.Text = "Apellido Materno:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(72, 52);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(56, 13);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "ID Cliente:";
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.Location = new System.Drawing.Point(134, 49);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(200, 20);
            this.tbIdCliente.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.idCliente1DataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoPaternoDataGridViewTextBoxColumn,
            this.apellidoMaternoDataGridViewTextBoxColumn,
            this.teléfonoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sp_ClientesSelectAllBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 463);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1081, 286);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCliente1DataGridViewTextBoxColumn
            // 
            this.idCliente1DataGridViewTextBoxColumn.DataPropertyName = "IdCliente1";
            this.idCliente1DataGridViewTextBoxColumn.HeaderText = "IdCliente1";
            this.idCliente1DataGridViewTextBoxColumn.Name = "idCliente1DataGridViewTextBoxColumn";
            this.idCliente1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoPaternoDataGridViewTextBoxColumn
            // 
            this.apellidoPaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoPaterno";
            this.apellidoPaternoDataGridViewTextBoxColumn.Name = "apellidoPaternoDataGridViewTextBoxColumn";
            // 
            // apellidoMaternoDataGridViewTextBoxColumn
            // 
            this.apellidoMaternoDataGridViewTextBoxColumn.DataPropertyName = "ApellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.HeaderText = "ApellidoMaterno";
            this.apellidoMaternoDataGridViewTextBoxColumn.Name = "apellidoMaternoDataGridViewTextBoxColumn";
            // 
            // teléfonoDataGridViewTextBoxColumn
            // 
            this.teléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono";
            this.teléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.teléfonoDataGridViewTextBoxColumn.Name = "teléfonoDataGridViewTextBoxColumn";
            // 
            // sp_ClientesSelectAllBindingSource
            // 
            this.sp_ClientesSelectAllBindingSource.DataMember = "Sp_ClientesSelectAll";
            this.sp_ClientesSelectAllBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // puntoDeVentaDataSet
            // 
            this.puntoDeVentaDataSet.DataSetName = "PuntoDeVentaDataSet";
            this.puntoDeVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_ClientesSelectBindingSource
            // 
            this.sp_ClientesSelectBindingSource.DataMember = "Sp_ClientesSelect";
            this.sp_ClientesSelectBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // sp_ClientesSelectTableAdapter
            // 
            this.sp_ClientesSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Punto_de_venta.PuntoDeVentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBuscarId.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idClienteToolStripLabel,
            this.tbBuscarId,
            this.toolStripButton1,
            this.btnBorrarBusqueda});
            this.btnBuscarId.Location = new System.Drawing.Point(0, 438);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(1081, 25);
            this.btnBuscarId.TabIndex = 21;
            this.btnBuscarId.Text = "fillToolStrip";
            this.btnBuscarId.Click += new System.EventHandler(this.fillToolStrip_Click);
            // 
            // idClienteToolStripLabel
            // 
            this.idClienteToolStripLabel.Name = "idClienteToolStripLabel";
            this.idClienteToolStripLabel.Size = new System.Drawing.Size(57, 22);
            this.idClienteToolStripLabel.Text = "IdCliente:";
            // 
            // tbBuscarId
            // 
            this.tbBuscarId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbBuscarId.Name = "tbBuscarId";
            this.tbBuscarId.Size = new System.Drawing.Size(100, 25);
            // 
            // sp_ClientesSelectAllTableAdapter
            // 
            this.sp_ClientesSelectAllTableAdapter.ClearBeforeFill = true;
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
            this.panel2.TabIndex = 22;
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
            // btnBorrarBusqueda
            // 
            this.btnBorrarBusqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBorrarBusqueda.Name = "btnBorrarBusqueda";
            this.btnBorrarBusqueda.Size = new System.Drawing.Size(43, 22);
            this.btnBorrarBusqueda.Text = "Borrar";
            this.btnBorrarBusqueda.Click += new System.EventHandler(this.btnBorrarBusqueda_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Buscar";
            // 
            // formClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBuscarId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbClientes);
            this.Name = "formClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.formClientes_Load);
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ClientesSelectAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ClientesSelectBindingSource)).EndInit();
            this.btnBuscarId.ResumeLayout(false);
            this.btnBuscarId.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApPaterno;
        private System.Windows.Forms.TextBox tbApMaterno;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApPaterno;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApMaterno;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.DateTimePicker dtpFecNacimiento;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PuntoDeVentaDataSet puntoDeVentaDataSet;
        private System.Windows.Forms.BindingSource sp_ClientesSelectBindingSource;
        private PuntoDeVentaDataSetTableAdapters.Sp_ClientesSelectTableAdapter sp_ClientesSelectTableAdapter;
        private PuntoDeVentaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip btnBuscarId;
        private System.Windows.Forms.ToolStripLabel idClienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox tbBuscarId;
        private System.Windows.Forms.BindingSource sp_ClientesSelectAllBindingSource;
        private PuntoDeVentaDataSetTableAdapters.Sp_ClientesSelectAllTableAdapter sp_ClientesSelectAllTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdInfo;
        private System.Windows.Forms.RadioButton rdBorrar;
        private System.Windows.Forms.RadioButton rdActualizar;
        private System.Windows.Forms.RadioButton rdNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teléfonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGuardar;
        private PuntoDeVentaDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.ToolStripButton btnBorrarBusqueda;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}