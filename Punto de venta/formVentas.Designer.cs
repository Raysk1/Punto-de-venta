namespace Punto_de_venta
{
    partial class FormVentas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdInfo = new System.Windows.Forms.RadioButton();
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.puntoDeVentaDataSet = new Punto_de_venta.PuntoDeVentaDataSet();
            this.view_VentaCabeceraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_VentaCabeceraTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.View_VentaCabeceraTableAdapter();
            this.tableAdapterManager = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.TableAdapterManager();
            this.view_VentaCabeceraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbIdVenta = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblIdVenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbCancelado = new System.Windows.Forms.CheckBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_VentaCabeceraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_VentaCabeceraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.rdInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 96);
            this.panel1.TabIndex = 18;
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
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.btnDetalles);
            this.gbVentas.Controls.Add(this.cbCancelado);
            this.gbVentas.Controls.Add(this.dateTimePicker1);
            this.gbVentas.Controls.Add(this.label1);
            this.gbVentas.Controls.Add(this.tbCantidad);
            this.gbVentas.Controls.Add(this.tbNombre);
            this.gbVentas.Controls.Add(this.tbIdVenta);
            this.gbVentas.Controls.Add(this.lblNombreCliente);
            this.gbVentas.Controls.Add(this.lblNombreEmpleado);
            this.gbVentas.Controls.Add(this.lblIdVenta);
            this.gbVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbVentas.Location = new System.Drawing.Point(0, 96);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(1081, 237);
            this.gbVentas.TabIndex = 19;
            this.gbVentas.TabStop = false;
            // 
            // puntoDeVentaDataSet
            // 
            this.puntoDeVentaDataSet.DataSetName = "PuntoDeVentaDataSet";
            this.puntoDeVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_VentaCabeceraBindingSource
            // 
            this.view_VentaCabeceraBindingSource.DataMember = "View_VentaCabecera";
            this.view_VentaCabeceraBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // view_VentaCabeceraTableAdapter
            // 
            this.view_VentaCabeceraTableAdapter.ClearBeforeFill = true;
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
            // view_VentaCabeceraDataGridView
            // 
            this.view_VentaCabeceraDataGridView.AllowUserToAddRows = false;
            this.view_VentaCabeceraDataGridView.AllowUserToDeleteRows = false;
            this.view_VentaCabeceraDataGridView.AutoGenerateColumns = false;
            this.view_VentaCabeceraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.view_VentaCabeceraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_VentaCabeceraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.view_VentaCabeceraDataGridView.DataSource = this.view_VentaCabeceraBindingSource;
            this.view_VentaCabeceraDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view_VentaCabeceraDataGridView.Location = new System.Drawing.Point(0, 333);
            this.view_VentaCabeceraDataGridView.Name = "view_VentaCabeceraDataGridView";
            this.view_VentaCabeceraDataGridView.ReadOnly = true;
            this.view_VentaCabeceraDataGridView.Size = new System.Drawing.Size(1081, 416);
            this.view_VentaCabeceraDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdVenta";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdVenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreCliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreEmpleado";
            this.dataGridViewTextBoxColumn3.HeaderText = "NombreEmpleado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            // tbCantidad
            // 
            this.tbCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_VentaCabeceraBindingSource, "NombreCliente", true));
            this.tbCantidad.Enabled = false;
            this.tbCantidad.Location = new System.Drawing.Point(220, 104);
            this.tbCantidad.Multiline = true;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(194, 25);
            this.tbCantidad.TabIndex = 38;
            // 
            // tbNombre
            // 
            this.tbNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_VentaCabeceraBindingSource, "NombreEmpleado", true));
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(220, 61);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(194, 25);
            this.tbNombre.TabIndex = 37;
            // 
            // tbIdVenta
            // 
            this.tbIdVenta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.view_VentaCabeceraBindingSource, "IdVenta", true));
            this.tbIdVenta.Enabled = false;
            this.tbIdVenta.Location = new System.Drawing.Point(220, 20);
            this.tbIdVenta.Multiline = true;
            this.tbIdVenta.Name = "tbIdVenta";
            this.tbIdVenta.Size = new System.Drawing.Size(194, 25);
            this.tbIdVenta.TabIndex = 36;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(70, 109);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(144, 20);
            this.lblNombreCliente.TabIndex = 35;
            this.lblNombreCliente.Text = "Nombre del cliente:";
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(46, 66);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(168, 20);
            this.lblNombreEmpleado.TabIndex = 34;
            this.lblNombreEmpleado.Text = "Nombre del empleado:";
            // 
            // lblIdVenta
            // 
            this.lblIdVenta.AutoSize = true;
            this.lblIdVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVenta.Location = new System.Drawing.Point(108, 25);
            this.lblIdVenta.Name = "lblIdVenta";
            this.lblIdVenta.Size = new System.Drawing.Size(106, 20);
            this.lblIdVenta.TabIndex = 33;
            this.lblIdVenta.Text = "Codigo venta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Fecha de la venta:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.view_VentaCabeceraBindingSource, "FechaPedido", true));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(718, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // cbCancelado
            // 
            this.cbCancelado.AutoSize = true;
            this.cbCancelado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbCancelado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.view_VentaCabeceraBindingSource, "Cancelado", true));
            this.cbCancelado.Enabled = false;
            this.cbCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCancelado.Location = new System.Drawing.Point(623, 62);
            this.cbCancelado.Name = "cbCancelado";
            this.cbCancelado.Size = new System.Drawing.Size(128, 24);
            this.cbCancelado.TabIndex = 41;
            this.cbCancelado.Text = "Cancelado:     ";
            this.cbCancelado.UseVisualStyleBackColor = true;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.Location = new System.Drawing.Point(699, 135);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(209, 45);
            this.btnDetalles.TabIndex = 42;
            this.btnDetalles.Text = "Ver detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 749);
            this.Controls.Add(this.view_VentaCabeceraDataGridView);
            this.Controls.Add(this.gbVentas);
            this.Controls.Add(this.panel1);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.panel1.ResumeLayout(false);
            this.gbVentas.ResumeLayout(false);
            this.gbVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_VentaCabeceraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_VentaCabeceraDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdInfo;
        private System.Windows.Forms.GroupBox gbVentas;
        private PuntoDeVentaDataSet puntoDeVentaDataSet;
        private System.Windows.Forms.BindingSource view_VentaCabeceraBindingSource;
        private PuntoDeVentaDataSetTableAdapters.View_VentaCabeceraTableAdapter view_VentaCabeceraTableAdapter;
        private PuntoDeVentaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView view_VentaCabeceraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbIdVenta;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblIdVenta;
        private System.Windows.Forms.CheckBox cbCancelado;
        private System.Windows.Forms.Button btnDetalles;
    }
}