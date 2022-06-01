namespace Punto_de_venta
{
    partial class FormUsuarios
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
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label idNivelLabel;
            System.Windows.Forms.Label idEmpleadoLabel;
            this.puntoDeVentaDataSet = new Punto_de_venta.PuntoDeVentaDataSet();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.usuariosTableAdapter();
            this.usuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdInfo = new System.Windows.Forms.RadioButton();
            this.rdBorrar = new System.Windows.Forms.RadioButton();
            this.rdActualizar = new System.Windows.Forms.RadioButton();
            this.rdNuevo = new System.Windows.Forms.RadioButton();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.tbIdEmpleado = new System.Windows.Forms.TextBox();
            this.queriesTableAdapter1 = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.QueriesTableAdapter();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.sp_EmpleadosSelectTableAdapter1 = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.Sp_EmpleadosSelectTableAdapter();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            usuarioLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            idNivelLabel = new System.Windows.Forms.Label();
            idEmpleadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbUsuarios.SuspendLayout();
            this.gbBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(200, 45);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(65, 20);
            usuarioLabel.TabIndex = 0;
            usuarioLabel.Text = "usuario:";
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            claveLabel.Location = new System.Drawing.Point(200, 80);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(49, 20);
            claveLabel.TabIndex = 2;
            claveLabel.Text = "clave:";
            // 
            // idNivelLabel
            // 
            idNivelLabel.AutoSize = true;
            idNivelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idNivelLabel.Location = new System.Drawing.Point(650, 77);
            idNivelLabel.Name = "idNivelLabel";
            idNivelLabel.Size = new System.Drawing.Size(46, 20);
            idNivelLabel.TabIndex = 4;
            idNivelLabel.Text = "Nivel:";
            // 
            // idEmpleadoLabel
            // 
            idEmpleadoLabel.AutoSize = true;
            idEmpleadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idEmpleadoLabel.Location = new System.Drawing.Point(593, 45);
            idEmpleadoLabel.Name = "idEmpleadoLabel";
            idEmpleadoLabel.Size = new System.Drawing.Size(103, 20);
            idEmpleadoLabel.TabIndex = 6;
            idEmpleadoLabel.Text = "Id Empleado:";
            // 
            // puntoDeVentaDataSet
            // 
            this.puntoDeVentaDataSet.DataSetName = "PuntoDeVentaDataSet";
            this.puntoDeVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosDataGridView
            // 
            this.usuariosDataGridView.AllowUserToAddRows = false;
            this.usuariosDataGridView.AllowUserToDeleteRows = false;
            this.usuariosDataGridView.AutoGenerateColumns = false;
            this.usuariosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.usuariosDataGridView.DataSource = this.usuariosBindingSource;
            this.usuariosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usuariosDataGridView.Location = new System.Drawing.Point(0, 305);
            this.usuariosDataGridView.Name = "usuariosDataGridView";
            this.usuariosDataGridView.ReadOnly = true;
            this.usuariosDataGridView.Size = new System.Drawing.Size(1081, 444);
            this.usuariosDataGridView.TabIndex = 1;
            this.usuariosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuariosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "usuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "clave";
            this.dataGridViewTextBoxColumn2.HeaderText = "clave";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdNivel";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdNivel";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdEmpleado";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdEmpleado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            this.panel2.Size = new System.Drawing.Size(1081, 94);
            this.panel2.TabIndex = 24;
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
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.cbNivel);
            this.gbUsuarios.Controls.Add(usuarioLabel);
            this.gbUsuarios.Controls.Add(this.tbUsuario);
            this.gbUsuarios.Controls.Add(claveLabel);
            this.gbUsuarios.Controls.Add(this.tbClave);
            this.gbUsuarios.Controls.Add(idNivelLabel);
            this.gbUsuarios.Controls.Add(idEmpleadoLabel);
            this.gbUsuarios.Controls.Add(this.tbIdEmpleado);
            this.gbUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUsuarios.Enabled = false;
            this.gbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuarios.Location = new System.Drawing.Point(0, 94);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(1081, 145);
            this.gbUsuarios.TabIndex = 25;
            this.gbUsuarios.TabStop = false;
            // 
            // tbUsuario
            // 
            this.tbUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "usuario", true));
            this.tbUsuario.Location = new System.Drawing.Point(275, 42);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(179, 26);
            this.tbUsuario.TabIndex = 1;
            // 
            // tbClave
            // 
            this.tbClave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "clave", true));
            this.tbClave.Location = new System.Drawing.Point(275, 77);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(179, 26);
            this.tbClave.TabIndex = 3;
            // 
            // tbIdEmpleado
            // 
            this.tbIdEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "IdEmpleado", true));
            this.tbIdEmpleado.Location = new System.Drawing.Point(702, 42);
            this.tbIdEmpleado.Name = "tbIdEmpleado";
            this.tbIdEmpleado.Size = new System.Drawing.Size(179, 26);
            this.tbIdEmpleado.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.Location = new System.Drawing.Point(359, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBorrar.Location = new System.Drawing.Point(563, 19);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // gbBotones
            // 
            this.gbBotones.Controls.Add(this.btnBorrar);
            this.gbBotones.Controls.Add(this.btnGuardar);
            this.gbBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbBotones.Location = new System.Drawing.Point(0, 239);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(1081, 66);
            this.gbBotones.TabIndex = 26;
            this.gbBotones.TabStop = false;
            // 
            // sp_EmpleadosSelectTableAdapter1
            // 
            this.sp_EmpleadosSelectTableAdapter1.ClearBeforeFill = true;
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Admin",
            "Empleado"});
            this.cbNivel.Location = new System.Drawing.Point(702, 75);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(179, 28);
            this.cbNivel.TabIndex = 8;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 749);
            this.Controls.Add(this.usuariosDataGridView);
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.gbUsuarios);
            this.Controls.Add(this.panel2);
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gbUsuarios.ResumeLayout(false);
            this.gbUsuarios.PerformLayout();
            this.gbBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PuntoDeVentaDataSet puntoDeVentaDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private PuntoDeVentaDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridView usuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdInfo;
        private System.Windows.Forms.RadioButton rdBorrar;
        private System.Windows.Forms.RadioButton rdActualizar;
        private System.Windows.Forms.RadioButton rdNuevo;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.TextBox tbIdEmpleado;
        private PuntoDeVentaDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox gbBotones;
        private PuntoDeVentaDataSetTableAdapters.Sp_EmpleadosSelectTableAdapter sp_EmpleadosSelectTableAdapter1;
        private System.Windows.Forms.ComboBox cbNivel;
    }
}