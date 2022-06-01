namespace Punto_de_venta
{
    partial class FormGenerarVenta
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label fechaPedidoLabel;
            System.Windows.Forms.Label idEmpleadoLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label label6;
            this.datosDeVentaSelectDataGridView = new System.Windows.Forms.DataGridView();
            this.gbDatosProducto = new System.Windows.Forms.GroupBox();
            this.pbFotoProducto = new System.Windows.Forms.PictureBox();
            this.tbNombreProducto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnComprobarProducto = new System.Windows.Forms.Button();
            this.tbDescuento = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.idVentaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idVentaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.tbIdEmpleado = new System.Windows.Forms.TextBox();
            this.tbIdCliente = new System.Windows.Forms.TextBox();
            this.cbIdCliente = new System.Windows.Forms.CheckBox();
            this.btnComprobarCliente = new System.Windows.Forms.Button();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.gbDatosVenta = new System.Windows.Forms.GroupBox();
            this.btnTerminarVenta = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_DatosDeVentaSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.puntoDeVentaDataSet = new Punto_de_venta.PuntoDeVentaDataSet();
            this.sp_ClientesSelectTableAdapter1 = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.Sp_ClientesSelectTableAdapter();
            this.sp_ProductosSelectTableAdapter1 = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.Sp_ProductosSelectTableAdapter();
            this.queriesTableAdapter1 = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.QueriesTableAdapter();
            this.sp_DatosDeVentaSelectTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.Sp_DatosDeVentaSelectTableAdapter();
            this.detallesPedidoTableAdapter1 = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.DetallesPedidoTableAdapter();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            fechaPedidoLabel = new System.Windows.Forms.Label();
            idEmpleadoLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datosDeVentaSelectDataGridView)).BeginInit();
            this.gbDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProducto)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.gbDatosVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DatosDeVentaSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(20, 358);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 20);
            label4.TabIndex = 29;
            label4.Text = "Descuento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(34, 323);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 20);
            label3.TabIndex = 27;
            label3.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(54, 291);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 20);
            label2.TabIndex = 25;
            label2.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(17, 227);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 20);
            label1.TabIndex = 23;
            label1.Text = "Id producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(42, 262);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(69, 20);
            label5.TabIndex = 34;
            label5.Text = "Nombre:";
            // 
            // datosDeVentaSelectDataGridView
            // 
            this.datosDeVentaSelectDataGridView.AllowUserToAddRows = false;
            this.datosDeVentaSelectDataGridView.AllowUserToDeleteRows = false;
            this.datosDeVentaSelectDataGridView.AutoGenerateColumns = false;
            this.datosDeVentaSelectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datosDeVentaSelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosDeVentaSelectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.datosDeVentaSelectDataGridView.DataSource = this.sp_DatosDeVentaSelectBindingSource;
            this.datosDeVentaSelectDataGridView.Location = new System.Drawing.Point(10, 28);
            this.datosDeVentaSelectDataGridView.Name = "datosDeVentaSelectDataGridView";
            this.datosDeVentaSelectDataGridView.ReadOnly = true;
            this.datosDeVentaSelectDataGridView.Size = new System.Drawing.Size(654, 603);
            this.datosDeVentaSelectDataGridView.TabIndex = 12;
            // 
            // gbDatosProducto
            // 
            this.gbDatosProducto.Controls.Add(this.btnTerminarVenta);
            this.gbDatosProducto.Controls.Add(this.pbFotoProducto);
            this.gbDatosProducto.Controls.Add(label5);
            this.gbDatosProducto.Controls.Add(this.tbNombreProducto);
            this.gbDatosProducto.Controls.Add(this.btnAgregar);
            this.gbDatosProducto.Controls.Add(this.btnLimpiar);
            this.gbDatosProducto.Controls.Add(this.btnComprobarProducto);
            this.gbDatosProducto.Controls.Add(label4);
            this.gbDatosProducto.Controls.Add(this.tbDescuento);
            this.gbDatosProducto.Controls.Add(label3);
            this.gbDatosProducto.Controls.Add(this.tbCantidad);
            this.gbDatosProducto.Controls.Add(label2);
            this.gbDatosProducto.Controls.Add(this.tbPrecio);
            this.gbDatosProducto.Controls.Add(label1);
            this.gbDatosProducto.Controls.Add(this.tbIdProducto);
            this.gbDatosProducto.Location = new System.Drawing.Point(670, 192);
            this.gbDatosProducto.Name = "gbDatosProducto";
            this.gbDatosProducto.Size = new System.Drawing.Size(399, 439);
            this.gbDatosProducto.TabIndex = 22;
            this.gbDatosProducto.TabStop = false;
            this.gbDatosProducto.Text = "Datos del producto";
            // 
            // pbFotoProducto
            // 
            this.pbFotoProducto.Image = global::Punto_de_venta.Properties.Resources.No_Product;
            this.pbFotoProducto.InitialImage = null;
            this.pbFotoProducto.Location = new System.Drawing.Point(97, 19);
            this.pbFotoProducto.Name = "pbFotoProducto";
            this.pbFotoProducto.Size = new System.Drawing.Size(220, 172);
            this.pbFotoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFotoProducto.TabIndex = 36;
            this.pbFotoProducto.TabStop = false;
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.Enabled = false;
            this.tbNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreProducto.Location = new System.Drawing.Point(117, 256);
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(200, 26);
            this.tbNombreProducto.TabIndex = 35;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(97, 399);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(242, 399);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 32;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnComprobarProducto
            // 
            this.btnComprobarProducto.Location = new System.Drawing.Point(324, 224);
            this.btnComprobarProducto.Name = "btnComprobarProducto";
            this.btnComprobarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnComprobarProducto.TabIndex = 31;
            this.btnComprobarProducto.Text = "Comprobar";
            this.btnComprobarProducto.UseVisualStyleBackColor = true;
            this.btnComprobarProducto.Click += new System.EventHandler(this.btnComprobarProducto_Click);
            // 
            // tbDescuento
            // 
            this.tbDescuento.Enabled = false;
            this.tbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescuento.Location = new System.Drawing.Point(117, 352);
            this.tbDescuento.Name = "tbDescuento";
            this.tbDescuento.Size = new System.Drawing.Size(200, 26);
            this.tbDescuento.TabIndex = 30;
            this.tbDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Enabled = false;
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(117, 320);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(200, 26);
            this.tbCantidad.TabIndex = 28;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Enabled = false;
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.Location = new System.Drawing.Point(117, 288);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(200, 26);
            this.tbPrecio.TabIndex = 26;
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdProducto.Location = new System.Drawing.Point(117, 224);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.Size = new System.Drawing.Size(200, 26);
            this.tbIdProducto.TabIndex = 24;
            this.tbIdProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // idVentaToolStripLabel
            // 
            this.idVentaToolStripLabel.Name = "idVentaToolStripLabel";
            this.idVentaToolStripLabel.Size = new System.Drawing.Size(49, 22);
            this.idVentaToolStripLabel.Text = "IdVenta:";
            // 
            // idVentaToolStripTextBox
            // 
            this.idVentaToolStripTextBox.Name = "idVentaToolStripTextBox";
            this.idVentaToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idVentaToolStripLabel,
            this.idVentaToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1081, 25);
            this.fillToolStrip.TabIndex = 12;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // dtFecha
            // 
            this.dtFecha.Enabled = false;
            this.dtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(117, 115);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 26);
            this.dtFecha.TabIndex = 27;
            // 
            // fechaPedidoLabel
            // 
            fechaPedidoLabel.AutoSize = true;
            fechaPedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaPedidoLabel.Location = new System.Drawing.Point(0, 120);
            fechaPedidoLabel.Name = "fechaPedidoLabel";
            fechaPedidoLabel.Size = new System.Drawing.Size(111, 20);
            fechaPedidoLabel.TabIndex = 26;
            fechaPedidoLabel.Text = "Fecha Pedido:";
            // 
            // tbIdEmpleado
            // 
            this.tbIdEmpleado.Enabled = false;
            this.tbIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdEmpleado.Location = new System.Drawing.Point(117, 19);
            this.tbIdEmpleado.Name = "tbIdEmpleado";
            this.tbIdEmpleado.Size = new System.Drawing.Size(200, 26);
            this.tbIdEmpleado.TabIndex = 25;
            // 
            // idEmpleadoLabel
            // 
            idEmpleadoLabel.AutoSize = true;
            idEmpleadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idEmpleadoLabel.Location = new System.Drawing.Point(8, 25);
            idEmpleadoLabel.Name = "idEmpleadoLabel";
            idEmpleadoLabel.Size = new System.Drawing.Size(103, 20);
            idEmpleadoLabel.TabIndex = 24;
            idEmpleadoLabel.Text = "Id Empleado:";
            // 
            // tbIdCliente
            // 
            this.tbIdCliente.Enabled = false;
            this.tbIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCliente.Location = new System.Drawing.Point(117, 51);
            this.tbIdCliente.Name = "tbIdCliente";
            this.tbIdCliente.Size = new System.Drawing.Size(200, 26);
            this.tbIdCliente.TabIndex = 23;
            this.tbIdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idClienteLabel.Location = new System.Drawing.Point(31, 57);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(80, 20);
            idClienteLabel.TabIndex = 22;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // cbIdCliente
            // 
            this.cbIdCliente.AutoSize = true;
            this.cbIdCliente.Location = new System.Drawing.Point(10, 62);
            this.cbIdCliente.Name = "cbIdCliente";
            this.cbIdCliente.Size = new System.Drawing.Size(15, 14);
            this.cbIdCliente.TabIndex = 28;
            this.cbIdCliente.UseVisualStyleBackColor = true;
            this.cbIdCliente.CheckedChanged += new System.EventHandler(this.cbIdCliente_CheckedChanged);
            // 
            // btnComprobarCliente
            // 
            this.btnComprobarCliente.Enabled = false;
            this.btnComprobarCliente.Location = new System.Drawing.Point(324, 51);
            this.btnComprobarCliente.Name = "btnComprobarCliente";
            this.btnComprobarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnComprobarCliente.TabIndex = 32;
            this.btnComprobarCliente.Text = "Comprobar";
            this.btnComprobarCliente.UseVisualStyleBackColor = true;
            this.btnComprobarCliente.Click += new System.EventHandler(this.btnComprobarCliente_Click);
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Enabled = false;
            this.tbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreCliente.Location = new System.Drawing.Point(117, 83);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(200, 26);
            this.tbNombreCliente.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(42, 89);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(69, 20);
            label6.TabIndex = 33;
            label6.Text = "Nombre:";
            // 
            // gbDatosVenta
            // 
            this.gbDatosVenta.Controls.Add(label6);
            this.gbDatosVenta.Controls.Add(this.tbNombreCliente);
            this.gbDatosVenta.Controls.Add(this.btnComprobarCliente);
            this.gbDatosVenta.Controls.Add(this.cbIdCliente);
            this.gbDatosVenta.Controls.Add(idClienteLabel);
            this.gbDatosVenta.Controls.Add(this.tbIdCliente);
            this.gbDatosVenta.Controls.Add(idEmpleadoLabel);
            this.gbDatosVenta.Controls.Add(this.tbIdEmpleado);
            this.gbDatosVenta.Controls.Add(fechaPedidoLabel);
            this.gbDatosVenta.Controls.Add(this.dtFecha);
            this.gbDatosVenta.Location = new System.Drawing.Point(670, 28);
            this.gbDatosVenta.Name = "gbDatosVenta";
            this.gbDatosVenta.Size = new System.Drawing.Size(399, 158);
            this.gbDatosVenta.TabIndex = 23;
            this.gbDatosVenta.TabStop = false;
            this.gbDatosVenta.Text = "Datos de Venta";
            // 
            // btnTerminarVenta
            // 
            this.btnTerminarVenta.Location = new System.Drawing.Point(0, 399);
            this.btnTerminarVenta.Name = "btnTerminarVenta";
            this.btnTerminarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnTerminarVenta.TabIndex = 34;
            this.btnTerminarVenta.Text = "Terminar Venta";
            this.btnTerminarVenta.UseVisualStyleBackColor = true;
            this.btnTerminarVenta.Click += new System.EventHandler(this.btnTerminarVenta_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProducto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreProducto";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreProducto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrecioUnidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "PrecioUnidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descuento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Subtotal";
            this.dataGridViewTextBoxColumn6.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // sp_DatosDeVentaSelectBindingSource
            // 
            this.sp_DatosDeVentaSelectBindingSource.DataMember = "Sp_DatosDeVentaSelect";
            this.sp_DatosDeVentaSelectBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // puntoDeVentaDataSet
            // 
            this.puntoDeVentaDataSet.DataSetName = "PuntoDeVentaDataSet";
            this.puntoDeVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_ClientesSelectTableAdapter1
            // 
            this.sp_ClientesSelectTableAdapter1.ClearBeforeFill = true;
            // 
            // sp_ProductosSelectTableAdapter1
            // 
            this.sp_ProductosSelectTableAdapter1.ClearBeforeFill = true;
            // 
            // sp_DatosDeVentaSelectTableAdapter
            // 
            this.sp_DatosDeVentaSelectTableAdapter.ClearBeforeFill = true;
            // 
            // detallesPedidoTableAdapter1
            // 
            this.detallesPedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // FormGenerarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 749);
            this.Controls.Add(this.gbDatosVenta);
            this.Controls.Add(this.gbDatosProducto);
            this.Controls.Add(this.datosDeVentaSelectDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Name = "FormGenerarVenta";
            this.Text = "FormGenerarVenta";
            this.Load += new System.EventHandler(this.FormGenerarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosDeVentaSelectDataGridView)).EndInit();
            this.gbDatosProducto.ResumeLayout(false);
            this.gbDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoProducto)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.gbDatosVenta.ResumeLayout(false);
            this.gbDatosVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_DatosDeVentaSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PuntoDeVentaDataSet puntoDeVentaDataSet;
        private System.Windows.Forms.DataGridView datosDeVentaSelectDataGridView;
        private PuntoDeVentaDataSetTableAdapters.Sp_ClientesSelectTableAdapter sp_ClientesSelectTableAdapter1;
        private PuntoDeVentaDataSetTableAdapters.Sp_ProductosSelectTableAdapter sp_ProductosSelectTableAdapter1;
        private System.Windows.Forms.GroupBox gbDatosProducto;
        private System.Windows.Forms.Button btnComprobarProducto;
        private System.Windows.Forms.TextBox tbDescuento;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbNombreProducto;
        private System.Windows.Forms.PictureBox pbFotoProducto;
        private PuntoDeVentaDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private PuntoDeVentaDataSetTableAdapters.Sp_DatosDeVentaSelectTableAdapter sp_DatosDeVentaSelectTableAdapter;
        private System.Windows.Forms.BindingSource sp_DatosDeVentaSelectBindingSource;
        private System.Windows.Forms.ToolStripLabel idVentaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idVentaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox tbIdEmpleado;
        private System.Windows.Forms.TextBox tbIdCliente;
        private System.Windows.Forms.CheckBox cbIdCliente;
        private System.Windows.Forms.Button btnComprobarCliente;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.GroupBox gbDatosVenta;
        private System.Windows.Forms.Button btnTerminarVenta;
        private PuntoDeVentaDataSetTableAdapters.DetallesPedidoTableAdapter detallesPedidoTableAdapter1;
    }
}