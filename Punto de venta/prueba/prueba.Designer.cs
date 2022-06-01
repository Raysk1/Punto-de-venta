namespace Punto_de_venta.prueba
{
    partial class prueba
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
            this.puntoDeVentaDataSet = new Punto_de_venta.PuntoDeVentaDataSet();
            this.sp_EmpleadosSelectAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_EmpleadosSelectAllTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.Sp_EmpleadosSelectAllTableAdapter();
            this.tableAdapterManager = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.TableAdapterManager();
            this.sp_EmpleadosSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_EmpleadosSelectTableAdapter = new Punto_de_venta.PuntoDeVentaDataSetTableAdapters.Sp_EmpleadosSelectTableAdapter();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.fadeManager1 = new Krypton.Toolkit.Suite.Extended.Effects.FadeManager();
            this.rdNuevo = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.rdInfo = new Krypton.Toolkit.KryptonCheckButton();
            this.rdBorrar = new Krypton.Toolkit.KryptonCheckButton();
            this.rdActualizar = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton2 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonCheckButton4 = new Krypton.Toolkit.KryptonCheckButton();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EmpleadosSelectAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EmpleadosSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // puntoDeVentaDataSet
            // 
            this.puntoDeVentaDataSet.DataSetName = "PuntoDeVentaDataSet";
            this.puntoDeVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sp_EmpleadosSelectBindingSource
            // 
            this.sp_EmpleadosSelectBindingSource.DataMember = "Sp_EmpleadosSelect";
            this.sp_EmpleadosSelectBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // sp_EmpleadosSelectTableAdapter
            // 
            this.sp_EmpleadosSelectTableAdapter.ClearBeforeFill = true;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ControlStyles.ControlCommon.StateNormal.Back.Color1 = System.Drawing.Color.Lime;
            this.kryptonPalette1.ControlStyles.ControlCommon.StateNormal.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.kryptonPalette1.ControlStyles.ControlCommon.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.kryptonPalette1.LabelStyles.LabelNormalPanel.OverrideFocus.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Disabled;
            this.kryptonPalette1.LabelStyles.LabelNormalPanel.OverrideNotVisited.Image.Effect = Krypton.Toolkit.PaletteImageEffect.GrayScaleRed;
            this.kryptonPalette1.LabelStyles.LabelNormalPanel.StateCommon.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Disabled;
            this.kryptonPalette1.LabelStyles.LabelNormalPanel.StateCommon.Image.ImageColorMap = System.Drawing.Color.Cyan;
            this.kryptonPalette1.LabelStyles.LabelNormalPanel.StateNormal.Image.Effect = Krypton.Toolkit.PaletteImageEffect.Dark;
            this.kryptonPalette1.LabelStyles.LabelTitleControl.StateNormal.Image.Effect = Krypton.Toolkit.PaletteImageEffect.DarkDark;
            // 
            // fadeManager1
            // 
            this.fadeManager1.FadeSpeed = 5F;
            this.fadeManager1.ParentWindow = null;
            this.fadeManager1.WindowToFade = null;
            // 
            // rdNuevo
            // 
            this.rdNuevo.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.rdNuevo.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdNuevo.Location = new System.Drawing.Point(0, 0);
            this.rdNuevo.Name = "rdNuevo";
            this.rdNuevo.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleDarkMode;
            this.rdNuevo.Size = new System.Drawing.Size(270, 96);
            this.rdNuevo.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.rdNuevo.StateCheckedNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rdNuevo.StateCheckedNormal.Border.Width = 0;
            this.rdNuevo.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdNuevo.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.rdNuevo.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, -1);
            this.rdNuevo.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNuevo.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdNuevo.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.rdNuevo.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.rdNuevo.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rdNuevo.StateNormal.Border.Width = 0;
            this.rdNuevo.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdNuevo.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.rdNuevo.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNuevo.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdNuevo.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.rdNuevo.TabIndex = 7;
            this.rdNuevo.Values.Image = global::Punto_de_venta.Properties.Resources.boton_agregar;
            this.rdNuevo.Values.Text = "NUEVO";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.rdInfo);
            this.kryptonPanel1.Controls.Add(this.rdBorrar);
            this.kryptonPanel1.Controls.Add(this.rdActualizar);
            this.kryptonPanel1.Controls.Add(this.rdNuevo);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            this.kryptonPanel1.Size = new System.Drawing.Size(1081, 96);
            this.kryptonPanel1.TabIndex = 8;
            // 
            // rdInfo
            // 
            this.rdInfo.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.rdInfo.Checked = true;
            this.rdInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdInfo.Location = new System.Drawing.Point(810, 0);
            this.rdInfo.Name = "rdInfo";
            this.rdInfo.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            this.rdInfo.Size = new System.Drawing.Size(270, 96);
            this.rdInfo.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.rdInfo.StateCheckedNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rdInfo.StateCheckedNormal.Border.Width = 0;
            this.rdInfo.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdInfo.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.rdInfo.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, -1);
            this.rdInfo.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInfo.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdInfo.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.rdInfo.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.rdInfo.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rdInfo.StateNormal.Border.Width = 0;
            this.rdInfo.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdInfo.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.rdInfo.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInfo.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdInfo.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.rdInfo.TabIndex = 10;
            this.rdInfo.Values.Image = global::Punto_de_venta.Properties.Resources.informacion;
            this.rdInfo.Values.Text = "INFORMACION";
            // 
            // rdBorrar
            // 
            this.rdBorrar.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.rdBorrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdBorrar.Location = new System.Drawing.Point(540, 0);
            this.rdBorrar.Name = "rdBorrar";
            this.rdBorrar.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            this.rdBorrar.Size = new System.Drawing.Size(270, 96);
            this.rdBorrar.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.rdBorrar.StateCheckedNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rdBorrar.StateCheckedNormal.Border.Width = 0;
            this.rdBorrar.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdBorrar.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.rdBorrar.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, -1);
            this.rdBorrar.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBorrar.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdBorrar.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.rdBorrar.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.rdBorrar.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rdBorrar.StateNormal.Border.Width = 0;
            this.rdBorrar.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdBorrar.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.rdBorrar.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBorrar.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdBorrar.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.rdBorrar.TabIndex = 9;
            this.rdBorrar.Values.Image = global::Punto_de_venta.Properties.Resources.borrar__1_;
            this.rdBorrar.Values.Text = "BORRAR";
            // 
            // rdActualizar
            // 
            this.rdActualizar.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.rdActualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdActualizar.Location = new System.Drawing.Point(270, 0);
            this.rdActualizar.Name = "rdActualizar";
            this.rdActualizar.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            this.rdActualizar.Size = new System.Drawing.Size(270, 96);
            this.rdActualizar.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.rdActualizar.StateCheckedNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rdActualizar.StateCheckedNormal.Border.Width = 0;
            this.rdActualizar.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdActualizar.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.rdActualizar.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, -1);
            this.rdActualizar.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdActualizar.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdActualizar.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.rdActualizar.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.rdActualizar.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rdActualizar.StateNormal.Border.Width = 0;
            this.rdActualizar.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdActualizar.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.rdActualizar.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdActualizar.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.rdActualizar.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.rdActualizar.TabIndex = 8;
            this.rdActualizar.Values.Image = global::Punto_de_venta.Properties.Resources.actualizado__1_;
            this.rdActualizar.Values.Text = "ACTUALIZAR";
            // 
            // kryptonCheckButton2
            // 
            this.kryptonCheckButton2.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.kryptonCheckButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonCheckButton2.Location = new System.Drawing.Point(270, 0);
            this.kryptonCheckButton2.Name = "kryptonCheckButton2";
            this.kryptonCheckButton2.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            this.kryptonCheckButton2.Size = new System.Drawing.Size(270, 96);
            this.kryptonCheckButton2.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonCheckButton2.StateCheckedNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton2.StateCheckedNormal.Border.Width = 0;
            this.kryptonCheckButton2.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCheckButton2.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCheckButton2.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, -1);
            this.kryptonCheckButton2.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckButton2.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCheckButton2.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCheckButton2.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonCheckButton2.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton2.StateNormal.Border.Width = 0;
            this.kryptonCheckButton2.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCheckButton2.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.kryptonCheckButton2.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckButton2.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCheckButton2.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCheckButton2.TabIndex = 8;
            this.kryptonCheckButton2.Values.Image = global::Punto_de_venta.Properties.Resources.actualizado__1_;
            this.kryptonCheckButton2.Values.Text = "ACTUALIZAR";
            // 
            // kryptonCheckButton4
            // 
            this.kryptonCheckButton4.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.kryptonCheckButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonCheckButton4.Location = new System.Drawing.Point(810, 0);
            this.kryptonCheckButton4.Name = "kryptonCheckButton4";
            this.kryptonCheckButton4.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleLightMode;
            this.kryptonCheckButton4.Size = new System.Drawing.Size(270, 96);
            this.kryptonCheckButton4.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonCheckButton4.StateCheckedNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton4.StateCheckedNormal.Border.Width = 0;
            this.kryptonCheckButton4.StateCheckedNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCheckButton4.StateCheckedNormal.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.kryptonCheckButton4.StateCheckedNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 5, -1, -1);
            this.kryptonCheckButton4.StateCheckedNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckButton4.StateCheckedNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCheckButton4.StateCheckedNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCheckButton4.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.kryptonCheckButton4.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonCheckButton4.StateNormal.Border.Width = 0;
            this.kryptonCheckButton4.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCheckButton4.StateNormal.Content.Padding = new System.Windows.Forms.Padding(-1, 2, -1, -1);
            this.kryptonCheckButton4.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonCheckButton4.StateNormal.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonCheckButton4.StateNormal.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.kryptonCheckButton4.TabIndex = 10;
            this.kryptonCheckButton4.Values.Image = global::Punto_de_venta.Properties.Resources.informacion;
            this.kryptonCheckButton4.Values.Text = "INFORMACION";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.DataSource = this.sp_EmpleadosSelectAllBindingSource;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 96);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.PaletteMode = Krypton.Toolkit.PaletteMode.SparklePurpleDarkMode;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1081, 404);
            this.kryptonDataGridView1.TabIndex = 9;
            // 
            // prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1081, 500);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "prueba";
            this.Text = "prueba";
            this.Load += new System.EventHandler(this.prueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EmpleadosSelectAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_EmpleadosSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PuntoDeVentaDataSet puntoDeVentaDataSet;
        private System.Windows.Forms.BindingSource sp_EmpleadosSelectAllBindingSource;
        private PuntoDeVentaDataSetTableAdapters.Sp_EmpleadosSelectAllTableAdapter sp_EmpleadosSelectAllTableAdapter;
        private PuntoDeVentaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sp_EmpleadosSelectBindingSource;
        private PuntoDeVentaDataSetTableAdapters.Sp_EmpleadosSelectTableAdapter sp_EmpleadosSelectTableAdapter;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.Suite.Extended.Effects.FadeManager fadeManager1;
        private Krypton.Toolkit.KryptonCheckButton rdNuevo;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonCheckButton rdInfo;
        private Krypton.Toolkit.KryptonCheckButton rdBorrar;
        private Krypton.Toolkit.KryptonCheckButton rdActualizar;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton2;
        private Krypton.Toolkit.KryptonCheckButton kryptonCheckButton4;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
    }
}