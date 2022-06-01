namespace Punto_de_venta
{
    partial class FormDetallesVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetallesVentas));
            this.gbDetallesVenta = new System.Windows.Forms.GroupBox();
            this.tbIdVenta = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdVenta = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdInfo = new System.Windows.Forms.RadioButton();
            this.puntoDeVentaDataSet = new Punto_de_venta.PuntoDeVentaDataSet();
            this.sp_VentaCuerpoSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_VentaCuerpoSelectTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.Sp_VentaCuerpoSelectTableAdapter();
            this.tableAdapterManager = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.TableAdapterManager();
            this.sp_VentaCuerpoSelectBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sp_VentaCuerpoSelectBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.idToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.idToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sp_VentaCuerpoSelectDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.gbDetallesVenta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_VentaCuerpoSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_VentaCuerpoSelectBindingNavigator)).BeginInit();
            this.sp_VentaCuerpoSelectBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_VentaCuerpoSelectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetallesVenta
            // 
            this.gbDetallesVenta.Controls.Add(this.tbTotal);
            this.gbDetallesVenta.Controls.Add(this.tbSubtotal);
            this.gbDetallesVenta.Controls.Add(this.tbPrecio);
            this.gbDetallesVenta.Controls.Add(this.tbCantidad);
            this.gbDetallesVenta.Controls.Add(this.tbNombre);
            this.gbDetallesVenta.Controls.Add(this.lblSubTotal);
            this.gbDetallesVenta.Controls.Add(this.lblPrecioUnitario);
            this.gbDetallesVenta.Controls.Add(this.lblTotal);
            this.gbDetallesVenta.Controls.Add(this.tbIdVenta);
            this.gbDetallesVenta.Controls.Add(this.lblCantidad);
            this.gbDetallesVenta.Controls.Add(this.lblNombre);
            this.gbDetallesVenta.Controls.Add(this.lblIdVenta);
            this.gbDetallesVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDetallesVenta.Location = new System.Drawing.Point(0, 96);
            this.gbDetallesVenta.Name = "gbDetallesVenta";
            this.gbDetallesVenta.Size = new System.Drawing.Size(1081, 216);
            this.gbDetallesVenta.TabIndex = 16;
            this.gbDetallesVenta.TabStop = false;
            // 
            // tbIdVenta
            // 
            this.tbIdVenta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_VentaCuerpoSelectBindingSource, "IdVenta", true));
            this.tbIdVenta.Location = new System.Drawing.Point(190, 30);
            this.tbIdVenta.Multiline = true;
            this.tbIdVenta.Name = "tbIdVenta";
            this.tbIdVenta.Size = new System.Drawing.Size(194, 25);
            this.tbIdVenta.TabIndex = 25;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(107, 121);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 17;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(115, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIdVenta
            // 
            this.lblIdVenta.AutoSize = true;
            this.lblIdVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVenta.Location = new System.Drawing.Point(78, 35);
            this.lblIdVenta.Name = "lblIdVenta";
            this.lblIdVenta.Size = new System.Drawing.Size(106, 20);
            this.lblIdVenta.TabIndex = 15;
            this.lblIdVenta.Text = "Codigo venta:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(607, 76);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(77, 20);
            this.lblSubTotal.TabIndex = 28;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(568, 35);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(116, 20);
            this.lblPrecioUnitario.TabIndex = 27;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(636, 126);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "Total:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_VentaCuerpoSelectBindingSource, "Cantidad", true));
            this.tbCantidad.Location = new System.Drawing.Point(190, 121);
            this.tbCantidad.Multiline = true;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(194, 25);
            this.tbCantidad.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.rdInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 96);
            this.panel1.TabIndex = 17;
            // 
            // rdInfo
            // 
            this.rdInfo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rdInfo.Checked = true;
            this.rdInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdInfo.FlatAppearance.BorderSize = 0;
            this.rdInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.rdInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.rdInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInfo.ForeColor = System.Drawing.Color.White;
            this.rdInfo.Image = global::Punto_de_venta.Properties.Resources.informacion;
            this.rdInfo.Location = new System.Drawing.Point(0, 0);
            this.rdInfo.Margin = new System.Windows.Forms.Padding(0);
            this.rdInfo.Name = "rdInfo";
            this.rdInfo.Size = new System.Drawing.Size(1081, 96);
            this.rdInfo.TabIndex = 12;
            this.rdInfo.TabStop = true;
            this.rdInfo.Text = "Informacion";
            this.rdInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rdInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.rdInfo.UseVisualStyleBackColor = false;
            // 
            // puntoDeVentaDataSet
            // 
            this.puntoDeVentaDataSet.DataSetName = "PuntoDeVentaDataSet";
            this.puntoDeVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_VentaCuerpoSelectBindingSource
            // 
            this.sp_VentaCuerpoSelectBindingSource.DataMember = "Sp_VentaCuerpoSelect";
            this.sp_VentaCuerpoSelectBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // sp_VentaCuerpoSelectTableAdapter
            // 
            this.sp_VentaCuerpoSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ControlUsuarioTableAdapter = null;
            this.tableAdapterManager.DetallesPedidoTableAdapter = null;
            this.tableAdapterManager.DetallesVentaTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.NivelesTableAdapter = null;
            this.tableAdapterManager.PedidoTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Punto_de_venta.PuntoDeVentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            this.tableAdapterManager.VentaTableAdapter = null;
            // 
            // sp_VentaCuerpoSelectBindingNavigator
            // 
            this.sp_VentaCuerpoSelectBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sp_VentaCuerpoSelectBindingNavigator.BindingSource = this.sp_VentaCuerpoSelectBindingSource;
            this.sp_VentaCuerpoSelectBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sp_VentaCuerpoSelectBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sp_VentaCuerpoSelectBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sp_VentaCuerpoSelectBindingNavigatorSaveItem});
            this.sp_VentaCuerpoSelectBindingNavigator.Location = new System.Drawing.Point(0, 312);
            this.sp_VentaCuerpoSelectBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sp_VentaCuerpoSelectBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sp_VentaCuerpoSelectBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sp_VentaCuerpoSelectBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sp_VentaCuerpoSelectBindingNavigator.Name = "sp_VentaCuerpoSelectBindingNavigator";
            this.sp_VentaCuerpoSelectBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sp_VentaCuerpoSelectBindingNavigator.Size = new System.Drawing.Size(1081, 25);
            this.sp_VentaCuerpoSelectBindingNavigator.TabIndex = 18;
            this.sp_VentaCuerpoSelectBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // sp_VentaCuerpoSelectBindingNavigatorSaveItem
            // 
            this.sp_VentaCuerpoSelectBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sp_VentaCuerpoSelectBindingNavigatorSaveItem.Enabled = false;
            this.sp_VentaCuerpoSelectBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sp_VentaCuerpoSelectBindingNavigatorSaveItem.Image")));
            this.sp_VentaCuerpoSelectBindingNavigatorSaveItem.Name = "sp_VentaCuerpoSelectBindingNavigatorSaveItem";
            this.sp_VentaCuerpoSelectBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sp_VentaCuerpoSelectBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idToolStripLabel,
            this.idToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 337);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1081, 25);
            this.fillToolStrip.TabIndex = 19;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // idToolStripLabel
            // 
            this.idToolStripLabel.Name = "idToolStripLabel";
            this.idToolStripLabel.Size = new System.Drawing.Size(20, 22);
            this.idToolStripLabel.Text = "id:";
            // 
            // idToolStripTextBox
            // 
            this.idToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idToolStripTextBox.Name = "idToolStripTextBox";
            this.idToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_1);
            // 
            // sp_VentaCuerpoSelectDataGridView
            // 
            this.sp_VentaCuerpoSelectDataGridView.AutoGenerateColumns = false;
            this.sp_VentaCuerpoSelectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sp_VentaCuerpoSelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sp_VentaCuerpoSelectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.sp_VentaCuerpoSelectDataGridView.DataSource = this.sp_VentaCuerpoSelectBindingSource;
            this.sp_VentaCuerpoSelectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_VentaCuerpoSelectDataGridView.Location = new System.Drawing.Point(0, 362);
            this.sp_VentaCuerpoSelectDataGridView.Name = "sp_VentaCuerpoSelectDataGridView";
            this.sp_VentaCuerpoSelectDataGridView.Size = new System.Drawing.Size(1081, 387);
            this.sp_VentaCuerpoSelectDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdVenta";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdVenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreProducto";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreProducto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrecioUnidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "PrecioUnidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SubTotal";
            this.dataGridViewTextBoxColumn5.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // tbNombre
            // 
            this.tbNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_VentaCuerpoSelectBindingSource, "NombreProducto", true));
            this.tbNombre.Location = new System.Drawing.Point(190, 71);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(194, 25);
            this.tbNombre.TabIndex = 31;
            // 
            // tbPrecio
            // 
            this.tbPrecio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_VentaCuerpoSelectBindingSource, "PrecioUnidad", true));
            this.tbPrecio.Location = new System.Drawing.Point(690, 30);
            this.tbPrecio.Multiline = true;
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(194, 25);
            this.tbPrecio.TabIndex = 33;
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sp_VentaCuerpoSelectBindingSource, "SubTotal", true));
            this.tbSubtotal.Location = new System.Drawing.Point(690, 71);
            this.tbSubtotal.Multiline = true;
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(194, 25);
            this.tbSubtotal.TabIndex = 34;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(690, 121);
            this.tbTotal.Multiline = true;
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(194, 25);
            this.tbTotal.TabIndex = 35;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 749);
            this.Controls.Add(this.sp_VentaCuerpoSelectDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.sp_VentaCuerpoSelectBindingNavigator);
            this.Controls.Add(this.gbDetallesVenta);
            this.Controls.Add(this.panel1);
            this.Name = "FormVentas";
            this.Text = "formVentas";
            this.Load += new System.EventHandler(this.formVentas_Load);
            this.gbDetallesVenta.ResumeLayout(false);
            this.gbDetallesVenta.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_VentaCuerpoSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_VentaCuerpoSelectBindingNavigator)).EndInit();
            this.sp_VentaCuerpoSelectBindingNavigator.ResumeLayout(false);
            this.sp_VentaCuerpoSelectBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_VentaCuerpoSelectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetallesVenta;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbIdVenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdVenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdInfo;
        private PuntoDeVentaDataSet puntoDeVentaDataSet;
        private System.Windows.Forms.BindingSource sp_VentaCuerpoSelectBindingSource;
        private PuntoDeVentaDataSetTableAdapters.Sp_VentaCuerpoSelectTableAdapter sp_VentaCuerpoSelectTableAdapter;
        private PuntoDeVentaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sp_VentaCuerpoSelectBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sp_VentaCuerpoSelectBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel idToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox idToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.DataGridView sp_VentaCuerpoSelectDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}