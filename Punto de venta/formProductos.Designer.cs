namespace Punto_de_venta
{
    partial class formProductos
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.tbCodBar = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.pbSalir = new System.Windows.Forms.PictureBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(78, 62);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(65, 169);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(91, 133);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.Location = new System.Drawing.Point(45, 95);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(86, 13);
            this.lblCodigoBarra.TabIndex = 4;
            this.lblCodigoBarra.Text = "Codigo de Barra:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(136, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(307, 340);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(480, 340);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(369, 133);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock:";
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(149, 72);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(444, 20);
            this.tbProducto.TabIndex = 9;
            // 
            // tbCodBar
            // 
            this.tbCodBar.Location = new System.Drawing.Point(150, 105);
            this.tbCodBar.Name = "tbCodBar";
            this.tbCodBar.Size = new System.Drawing.Size(443, 20);
            this.tbCodBar.TabIndex = 10;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(150, 143);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(159, 20);
            this.tbPrecio.TabIndex = 11;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(413, 130);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(167, 20);
            this.tbStock.TabIndex = 12;
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.pbSalir);
            this.gbProductos.Controls.Add(this.tbDescripcion);
            this.gbProductos.Controls.Add(this.tbStock);
            this.gbProductos.Controls.Add(this.lblStock);
            this.gbProductos.Controls.Add(this.pictureBox3);
            this.gbProductos.Controls.Add(this.lblPrecio);
            this.gbProductos.Controls.Add(this.pictureBox2);
            this.gbProductos.Controls.Add(this.lblCodigoBarra);
            this.gbProductos.Controls.Add(this.pictureBox1);
            this.gbProductos.Controls.Add(this.lblProducto);
            this.gbProductos.Controls.Add(this.lblDescripcion);
            this.gbProductos.Location = new System.Drawing.Point(13, 13);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(659, 436);
            this.gbProductos.TabIndex = 13;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // pbSalir
            // 
            this.pbSalir.Location = new System.Drawing.Point(7, 402);
            this.pbSalir.Name = "pbSalir";
            this.pbSalir.Size = new System.Drawing.Size(75, 28);
            this.pbSalir.TabIndex = 14;
            this.pbSalir.TabStop = false;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(136, 169);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(444, 133);
            this.tbDescripcion.TabIndex = 13;
            // 
            // formProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbCodBar);
            this.Controls.Add(this.tbProducto);
            this.Controls.Add(this.gbProductos);
            this.Name = "formProductos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.TextBox tbCodBar;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.PictureBox pbSalir;
    }
}

