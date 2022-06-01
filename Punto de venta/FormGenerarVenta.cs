﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static Punto_de_venta.PuntoDeVentaDataSet;

namespace Punto_de_venta
{
    public partial class FormGenerarVenta : Form
    {
        private bool clienteExiste = false;
        private bool productoExiste = false;
        Sp_ProductosSelectDataTable datosProducto;
        Sp_ClientesSelectDataTable datosCliente;
        DataTable datosVenta;

        public FormGenerarVenta()
        {
            InitializeComponent();
        }

        private void FormGenerarVenta_Load(object sender, EventArgs e)
        {
            //carga los datos de la tabla
            tbIdEmpleado.Text = String.Empty + Usuario.idEmpleado;
            datosVenta = puntoDeVentaDataSet.Tables["Sp_DatosDeVentaSelect"];




        }



        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //this.sp_DatosDeVentaSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_DatosDeVentaSelect, new System.Nullable<int>(((int)(System.Convert.ChangeType(idVentaToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //comprueba si el producto existe
        private bool ComprobarIdProducto()
        {
            int id = tbIdProducto.Text == String.Empty ? -1 : Convert.ToInt32(tbIdProducto.Text);
            datosProducto = sp_ProductosSelectTableAdapter1.GetData(id);
            return datosProducto.Rows.Count > 0;
        }

        //comprueba si el cliente existe
        private bool ComprobarIdCliente()
        {
            int id = tbIdCliente.Text == String.Empty ? -1 : Convert.ToInt32(tbIdCliente.Text);

            datosCliente = sp_ClientesSelectTableAdapter1.GetData(Convert.ToInt32(id));


            return datosCliente.Rows.Count > 0;
        }

        private void btnComprobarProducto_Click(object sender, EventArgs e)
        {
            productoExiste = ComprobarIdProducto();
            if (productoExiste)
            {
                //llena los datos del producto
                btnComprobarProducto.Enabled = false;
                tbIdProducto.Enabled = false;
                tbCantidad.Enabled = true;
                tbDescuento.Enabled = true;
                tbNombreProducto.Text = datosProducto.Rows[0]["nombreProducto"].ToString();
                tbPrecio.Text = datosProducto.Rows[0]["PrecioUnidad"].ToString();
                byte[] byteImage = datosProducto.Rows[0]["Foto"].GetType() != typeof(System.DBNull) ? (byte[])datosProducto.Rows[0]["Foto"] : null;
                Image foto = Utilidades.byteArrayToImage(byteImage);
                pbFotoProducto.Image = foto != null ? foto : global::Punto_de_venta.Properties.Resources.No_Product;
            }
            else
            {
                MessageBox.Show("No se Ha encontrado el producto indicado", "Producto no existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbIdCliente_CheckedChanged(object sender, EventArgs e)
        {
            tbIdCliente.Enabled = cbIdCliente.Checked;
            btnComprobarCliente.Enabled = cbIdCliente.Checked;
            if (!cbIdCliente.Checked)
            {
                tbIdCliente.Text = String.Empty;
                tbNombreCliente.Text = String.Empty;
            }
        }

        private void btnComprobarCliente_Click(object sender, EventArgs e)
        {
            //llena los datos del cliente
            clienteExiste = ComprobarIdCliente();
            if (clienteExiste)
            {
                btnComprobarCliente.Enabled = false;
                tbNombreCliente.Text = datosCliente.Rows[0]["Nombre"].ToString() + " " + datosCliente.Rows[0]["ApellidoPaterno"].ToString() + " " +
                     datosCliente.Rows[0]["ApellidoMaterno"].ToString();
                tbIdCliente.Enabled = false;

            }
            else
            {
                MessageBox.Show("No se ha encontrado el cliente indicado", "Cliente no existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpia los campos del gbDatosProducto
            RestablecerGbDatosProducto();
        }

        private void RestablecerGbDatosProducto()
        {
            Utilidades.LimpiarCampos(gbDatosProducto.Controls);

            tbIdProducto.Enabled = true;
            tbCantidad.Enabled = false;
            tbPrecio.Enabled = false;
            tbDescuento.Enabled = false;
            btnComprobarProducto.Enabled = true;
            productoExiste = false;
            pbFotoProducto.Image = global::Punto_de_venta.Properties.Resources.No_Product;
        }


        //busca el id en la tabla y regresa su indice si existe, sino regresa -1
        private int IndiceDeIdEnTabla(int id)
        {
            foreach (DataRow row in datosVenta.Rows)
            {
                if ((int)row[0] == id)
                {
                    return datosVenta.Rows.IndexOf(row);
                }
            }
            return -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Utilidades.ComprobarCampos(gbDatosProducto.Controls))
            {
                MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            int id = Convert.ToInt32(tbIdProducto.Text);
            int index = IndiceDeIdEnTabla(id);
            decimal precio, descuento, cantidad;
            precio = Convert.ToDecimal(tbPrecio.Text);
            descuento = Convert.ToDecimal(tbDescuento.Text);
            cantidad = Convert.ToDecimal(tbCantidad.Text);

            //si el indice no existe crea una nueva fila con los datos
            if (index == -1)
            {
                DataRow row = datosVenta.NewRow();



                row[0] = id;
                row[1] = tbNombreProducto.Text;
                row[2] = cantidad;
                row[3] = precio;
                row[4] = descuento;
                row[5] = precio * cantidad - descuento;

                datosVenta.Rows.Add(row);

            }
            //actualiza los datos existentes
            else
            {
                DataRow row = datosVenta.Rows[index];
                cantidad += Convert.ToInt32(row[2]);
                row = datosVenta.NewRow();



                row[0] = id;
                row[1] = tbNombreProducto.Text;
                row[2] = cantidad;
                row[3] = precio;
                row[4] = descuento;
                row[5] = precio * cantidad - descuento;

                datosVenta.Rows.RemoveAt(index);
                datosVenta.Rows.InsertAt(row, index);


            }
            datosVenta.AcceptChanges();
            RestablecerGbDatosProducto();



        }

        private void btnTerminarVenta_Click(object sender, EventArgs e)
        {
            if (datosVenta.Rows.Count <= 0 )
            {
                MessageBox.Show("Agregue al menos un producto para realizar la venta","Alerta!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if( (!clienteExiste && cbIdCliente.Checked) | ((clienteExiste && !cbIdCliente.Checked)))
            {
                MessageBox.Show("Compruebe el ID del cliente o deseleccione la casilla", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            //genera el insert de venta
            int ventaId = Convert.ToInt32(Utilidades.SiguienteID(queriesTableAdapter1, "Venta"));
            if (clienteExiste)
            {

                queriesTableAdapter1.Sp_VentaInsert(Convert.ToInt32(tbIdCliente.Text), Usuario.idEmpleado, dtFecha.Value, false);

            }
            else
            {
                queriesTableAdapter1.Sp_VentaInsert(1, Usuario.idEmpleado, dtFecha.Value, false);
            }

            //genera los insert en detalle de venta para cada producto
            foreach (DataRow row in datosVenta.Rows)
            {
                queriesTableAdapter1.Sp_DetallesVentaInsert(ventaId, Convert.ToInt32(row[0]), Convert.ToDecimal(row[3]), Convert.ToInt16(row[2]), Convert.ToSingle(row[4]));
            }

            Utilidades.LimpiarCampos(gbDatosProducto.Controls);
            datosVenta.Rows.Clear();

            tbIdCliente.Enabled = false;
            cbIdCliente.Checked = false;
            btnComprobarCliente.Enabled = true;
            tbIdCliente.Text = String.Empty;
            tbNombreCliente.Text = String.Empty;
            MessageBox.Show("Venta realizada con exito", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esta linea hace que el textbox solo acepte numeros
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
