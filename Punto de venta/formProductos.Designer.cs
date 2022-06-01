namespace Punto_de_venta
{
    partial class FormProductos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puntoDeVentaDataSet = new Punto_de_venta.PuntoDeVentaDataSet();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.cbCancelado = new System.Windows.Forms.CheckBox();
            this.tbEnPedido = new System.Windows.Forms.TextBox();
            this.lblEnPedido = new System.Windows.Forms.Label();
            this.tbCantidadUnidad = new System.Windows.Forms.TextBox();
            this.lblcantidadUnidad = new System.Windows.Forms.Label();
            this.btnAgregarFoto = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdInfo = new System.Windows.Forms.RadioButton();
            this.rdBorrar = new System.Windows.Forms.RadioButton();
            this.rdActualizar = new System.Windows.Forms.RadioButton();
            this.rdNuevo = new System.Windows.Forms.RadioButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.productosTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.ProductosTableAdapter();
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queriesTableAdapter1 = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).BeginInit();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.Location = new System.Drawing.Point(63, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(46, 151);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrecio.Location = new System.Drawing.Point(80, 114);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 17);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCodigoBarra.Location = new System.Drawing.Point(116, 73);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(25, 17);
            this.lblCodigoBarra.TabIndex = 4;
            this.lblCodigoBarra.Text = "ID:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStock.Location = new System.Drawing.Point(386, 43);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 17);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock:";
            // 
            // tbNombre
            // 
            this.tbNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "NombreProducto", true));
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbNombre.Location = new System.Drawing.Point(146, 40);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(160, 23);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras_KeyPress);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // puntoDeVentaDataSet
            // 
            this.puntoDeVentaDataSet.DataSetName = "PuntoDeVentaDataSet";
            this.puntoDeVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbID
            // 
            this.tbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "IdProducto", true));
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbID.Location = new System.Drawing.Point(147, 73);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(159, 23);
            this.tbID.TabIndex = 1;
            this.tbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // tbPrecio
            // 
            this.tbPrecio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "PrecioUnidad", true));
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPrecio.Location = new System.Drawing.Point(147, 111);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(159, 23);
            this.tbPrecio.TabIndex = 2;
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // tbStock
            // 
            this.tbStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "UnidadesEnExistencia", true));
            this.tbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbStock.Location = new System.Drawing.Point(439, 40);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(152, 23);
            this.tbStock.TabIndex = 3;
            this.tbStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.pbFoto);
            this.gbProductos.Controls.Add(this.cbCancelado);
            this.gbProductos.Controls.Add(this.tbEnPedido);
            this.gbProductos.Controls.Add(this.lblEnPedido);
            this.gbProductos.Controls.Add(this.tbCantidadUnidad);
            this.gbProductos.Controls.Add(this.lblcantidadUnidad);
            this.gbProductos.Controls.Add(this.btnAgregarFoto);
            this.gbProductos.Controls.Add(this.tbPrecio);
            this.gbProductos.Controls.Add(this.tbID);
            this.gbProductos.Controls.Add(this.tbDescripcion);
            this.gbProductos.Controls.Add(this.tbNombre);
            this.gbProductos.Controls.Add(this.tbStock);
            this.gbProductos.Controls.Add(this.lblStock);
            this.gbProductos.Controls.Add(this.lblPrecio);
            this.gbProductos.Controls.Add(this.lblCodigoBarra);
            this.gbProductos.Controls.Add(this.lblNombre);
            this.gbProductos.Controls.Add(this.lblDescripcion);
            this.gbProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProductos.Enabled = false;
            this.gbProductos.Location = new System.Drawing.Point(0, 94);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(1064, 243);
            this.gbProductos.TabIndex = 13;
            this.gbProductos.TabStop = false;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoto.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productosBindingSource, "Foto", true));
            this.pbFoto.Location = new System.Drawing.Point(783, 19);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(200, 150);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 34;
            this.pbFoto.TabStop = false;
            // 
            // cbCancelado
            // 
            this.cbCancelado.AutoSize = true;
            this.cbCancelado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCancelado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.productosBindingSource, "Cancelado", true));
            this.cbCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCancelado.Location = new System.Drawing.Point(613, 40);
            this.cbCancelado.Name = "cbCancelado";
            this.cbCancelado.Size = new System.Drawing.Size(95, 20);
            this.cbCancelado.TabIndex = 21;
            this.cbCancelado.Text = "Cancelado:";
            this.cbCancelado.UseVisualStyleBackColor = true;
            // 
            // tbEnPedido
            // 
            this.tbEnPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "UnidadesEnPedido", true));
            this.tbEnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbEnPedido.Location = new System.Drawing.Point(439, 105);
            this.tbEnPedido.Name = "tbEnPedido";
            this.tbEnPedido.Size = new System.Drawing.Size(152, 23);
            this.tbEnPedido.TabIndex = 17;
            this.tbEnPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblEnPedido
            // 
            this.lblEnPedido.AutoSize = true;
            this.lblEnPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEnPedido.Location = new System.Drawing.Point(386, 108);
            this.lblEnPedido.Name = "lblEnPedido";
            this.lblEnPedido.Size = new System.Drawing.Size(47, 17);
            this.lblEnPedido.TabIndex = 18;
            this.lblEnPedido.Text = "Stock:";
            // 
            // tbCantidadUnidad
            // 
            this.tbCantidadUnidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "CantidadPorUnidad", true));
            this.tbCantidadUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbCantidadUnidad.Location = new System.Drawing.Point(439, 70);
            this.tbCantidadUnidad.Name = "tbCantidadUnidad";
            this.tbCantidadUnidad.Size = new System.Drawing.Size(152, 23);
            this.tbCantidadUnidad.TabIndex = 15;
            this.tbCantidadUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblcantidadUnidad
            // 
            this.lblcantidadUnidad.AutoSize = true;
            this.lblcantidadUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblcantidadUnidad.Location = new System.Drawing.Point(316, 73);
            this.lblcantidadUnidad.Name = "lblcantidadUnidad";
            this.lblcantidadUnidad.Size = new System.Drawing.Size(117, 17);
            this.lblcantidadUnidad.TabIndex = 16;
            this.lblcantidadUnidad.Text = "Cantidad/Unidad:";
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.Location = new System.Drawing.Point(783, 185);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.Size = new System.Drawing.Size(200, 43);
            this.btnAgregarFoto.TabIndex = 5;
            this.btnAgregarFoto.Text = "Agregar Foto";
            this.btnAgregarFoto.UseVisualStyleBackColor = true;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Descripcion", true));
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbDescripcion.Location = new System.Drawing.Point(146, 148);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(444, 80);
            this.tbDescripcion.TabIndex = 4;
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
            this.panel2.Size = new System.Drawing.Size(1064, 94);
            this.panel2.TabIndex = 23;
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
            this.rdInfo.Size = new System.Drawing.Size(269, 94);
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
            this.rdBorrar.Size = new System.Drawing.Size(271, 94);
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
            this.rdActualizar.Size = new System.Drawing.Size(271, 94);
            this.rdActualizar.TabIndex = 9;
            this.rdActualizar.Text = "Actualizar";
            this.rdActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdActualizar.UseVisualStyleBackColor = false;
            this.rdActualizar.CheckedChanged += new System.EventHandler(this.rdActualizar_CheckedChanged);
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
            this.rdNuevo.Size = new System.Drawing.Size(270, 94);
            this.rdNuevo.TabIndex = 8;
            this.rdNuevo.Text = "Nuevo";
            this.rdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdNuevo.UseVisualStyleBackColor = false;
            this.rdNuevo.CheckedChanged += new System.EventHandler(this.rdNuevo_CheckedChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPedido";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdPedido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdCliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdEmpleado";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdEmpleado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaPedido";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaPedido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Cancelado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Cancelado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // gbBotones
            // 
            this.gbBotones.Controls.Add(this.btnBorrar);
            this.gbBotones.Controls.Add(this.btnGuardar);
            this.gbBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbBotones.Location = new System.Drawing.Point(0, 337);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(1064, 61);
            this.gbBotones.TabIndex = 30;
            this.gbBotones.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(581, 22);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(404, 22);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // productosDataGridView
            // 
            this.productosDataGridView.AllowUserToAddRows = false;
            this.productosDataGridView.AllowUserToDeleteRows = false;
            this.productosDataGridView.AutoGenerateColumns = false;
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn11});
            this.productosDataGridView.DataSource = this.productosBindingSource;
            this.productosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productosDataGridView.Location = new System.Drawing.Point(0, 398);
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.ReadOnly = true;
            this.productosDataGridView.Size = new System.Drawing.Size(1064, 175);
            this.productosDataGridView.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdProducto";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdProducto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NombreProducto";
            this.dataGridViewTextBoxColumn6.HeaderText = "NombreProducto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CantidadPorUnidad";
            this.dataGridViewTextBoxColumn7.HeaderText = "CantidadPorUnidad";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PrecioUnidad";
            this.dataGridViewTextBoxColumn8.HeaderText = "PrecioUnidad";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "UnidadesEnExistencia";
            this.dataGridViewTextBoxColumn9.HeaderText = "UnidadesEnExistencia";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "UnidadesEnPedido";
            this.dataGridViewTextBoxColumn10.HeaderText = "UnidadesEnPedido";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Cancelado";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Cancelado";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "Foto";
            this.dataGridViewImageColumn1.HeaderText = "Foto";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn11.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.productosDataGridView);
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.panel2);
            this.Name = "FormProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.formProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).EndInit();
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gbBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdInfo;
        private System.Windows.Forms.RadioButton rdBorrar;
        private System.Windows.Forms.RadioButton rdActualizar;
        private System.Windows.Forms.RadioButton rdNuevo;
        private System.Windows.Forms.Button btnAgregarFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private PuntoDeVentaDataSet puntoDeVentaDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private PuntoDeVentaDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridView productosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.CheckBox cbCancelado;
        private System.Windows.Forms.TextBox tbEnPedido;
        private System.Windows.Forms.Label lblEnPedido;
        private System.Windows.Forms.TextBox tbCantidadUnidad;
        private System.Windows.Forms.Label lblcantidadUnidad;
        private PuntoDeVentaDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.PictureBox pbFoto;
    }
}

