namespace Punto_de_venta
{
    partial class formVentas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.puntoDeVentaDataSet = new Punto_de_venta.PuntoDeVentaDataSet();
            this.viewPedidoCuerpoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_PedidoCuerpoTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.view_PedidoCuerpoTableAdapter();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.tbIdProducto = new System.Windows.Forms.TextBox();
            this.tbPrecioUnitario = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.viewVentaCabeceraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_VentaCabeceraTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.View_VentaCabeceraTableAdapter();
            this.idVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canceladoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPedidoCuerpoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewVentaCabeceraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVentaDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.nombreEmpleadoDataGridViewTextBoxColumn,
            this.fechaPedidoDataGridViewTextBoxColumn,
            this.canceladoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.viewVentaCabeceraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // puntoDeVentaDataSet
            // 
            this.puntoDeVentaDataSet.DataSetName = "PuntoDeVentaDataSet";
            this.puntoDeVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewPedidoCuerpoBindingSource
            // 
            this.viewPedidoCuerpoBindingSource.DataMember = "view_PedidoCuerpo";
            this.viewPedidoCuerpoBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // view_PedidoCuerpoTableAdapter
            // 
            this.view_PedidoCuerpoTableAdapter.ClearBeforeFill = true;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblIdProducto.Location = new System.Drawing.Point(605, 62);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(180, 26);
            this.lblIdProducto.TabIndex = 1;
            this.lblIdProducto.Text = "Codigo Producto:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNombre.Location = new System.Drawing.Point(605, 123);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 26);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCantidad.Location = new System.Drawing.Point(605, 237);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(105, 26);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(820, 475);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 25);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPrecioUnitario.Location = new System.Drawing.Point(605, 296);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(161, 26);
            this.lblPrecioUnitario.TabIndex = 5;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(786, 446);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(104, 25);
            this.lblSubTotal.TabIndex = 6;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // tbIdProducto
            // 
            this.tbIdProducto.Location = new System.Drawing.Point(791, 68);
            this.tbIdProducto.Name = "tbIdProducto";
            this.tbIdProducto.Size = new System.Drawing.Size(223, 20);
            this.tbIdProducto.TabIndex = 7;
            // 
            // tbPrecioUnitario
            // 
            this.tbPrecioUnitario.Location = new System.Drawing.Point(772, 302);
            this.tbPrecioUnitario.Name = "tbPrecioUnitario";
            this.tbPrecioUnitario.Size = new System.Drawing.Size(174, 20);
            this.tbPrecioUnitario.TabIndex = 8;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(772, 243);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(174, 20);
            this.tbCantidad.TabIndex = 9;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(914, 480);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 10;
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Location = new System.Drawing.Point(914, 451);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(100, 20);
            this.tbSubtotal.TabIndex = 11;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(772, 129);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(276, 73);
            this.tbNombre.TabIndex = 12;
            // 
            // viewVentaCabeceraBindingSource
            // 
            this.viewVentaCabeceraBindingSource.DataMember = "View_VentaCabecera";
            this.viewVentaCabeceraBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // view_VentaCabeceraTableAdapter
            // 
            this.view_VentaCabeceraTableAdapter.ClearBeforeFill = true;
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            this.idVentaDataGridViewTextBoxColumn.DataPropertyName = "IdVenta";
            this.idVentaDataGridViewTextBoxColumn.HeaderText = "IdVenta";
            this.idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreEmpleadoDataGridViewTextBoxColumn
            // 
            this.nombreEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.HeaderText = "NombreEmpleado";
            this.nombreEmpleadoDataGridViewTextBoxColumn.Name = "nombreEmpleadoDataGridViewTextBoxColumn";
            this.nombreEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPedidoDataGridViewTextBoxColumn
            // 
            this.fechaPedidoDataGridViewTextBoxColumn.DataPropertyName = "FechaPedido";
            this.fechaPedidoDataGridViewTextBoxColumn.HeaderText = "FechaPedido";
            this.fechaPedidoDataGridViewTextBoxColumn.Name = "fechaPedidoDataGridViewTextBoxColumn";
            // 
            // canceladoDataGridViewCheckBoxColumn
            // 
            this.canceladoDataGridViewCheckBoxColumn.DataPropertyName = "Cancelado";
            this.canceladoDataGridViewCheckBoxColumn.HeaderText = "Cancelado";
            this.canceladoDataGridViewCheckBoxColumn.Name = "canceladoDataGridViewCheckBoxColumn";
            // 
            // formVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 749);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbPrecioUnitario);
            this.Controls.Add(this.tbIdProducto);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formVentas";
            this.Text = "formVentas";
            this.Load += new System.EventHandler(this.formVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPedidoCuerpoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewVentaCabeceraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PuntoDeVentaDataSet puntoDeVentaDataSet;
        private System.Windows.Forms.BindingSource viewPedidoCuerpoBindingSource;
        private PuntoDeVentaDataSetTableAdapters.view_PedidoCuerpoTableAdapter view_PedidoCuerpoTableAdapter;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox tbIdProducto;
        private System.Windows.Forms.TextBox tbPrecioUnitario;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.BindingSource viewVentaCabeceraBindingSource;
        private PuntoDeVentaDataSetTableAdapters.View_VentaCabeceraTableAdapter view_VentaCabeceraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canceladoDataGridViewCheckBoxColumn;
    }
}