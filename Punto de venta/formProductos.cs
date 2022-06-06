using System;
using System.Drawing;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class FormProductos : Form
    {
        int filaActual = 0;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void formProductos_Load(object sender, System.EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.sp_ProductosSelectTableAdapter1.Fill(this.puntoDeVentaDataSet.Sp_ProductosSelect, -1);
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.Pedido' Puede moverla o quitarla según sea necesario.


        }

        private void btnAgregarFoto_Click(object sender, System.EventArgs e)
        {
            //abre una ventana de busqueda de archivos,devuelve la imagen seleccionada y se le asigna al pbFoto
            Image image = Utilidades.ElegirImagen();
            if (image != null)
                pbFoto.Image = image;
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            //comprueba que los campos esten llenos
            if (!Utilidades.ComprobarCampos(gbProductos.Controls))
            {
                //lanza un mensaje alertando llenar los campos
                MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           


            
            //se transforma la imagen en un array de bits para su posterior insercion en la base de datos y controla los nulos
            byte[] image = pbFoto.Image == null ? null : Utilidades.imageToByteArray(pbFoto.Image, pbFoto.Image.RawFormat);
            //si el rd esta seleccionado para nuevo se aplica un insert
            if (rdNuevo.Checked)
            {
                if (sp_ProductosSelectTableAdapter1.GetData(Convert.ToInt32(tbID.Text)).Rows.Count > 0)
                {
                    MessageBox.Show("Producto con ese ID ya existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //peticion de un sp a la base de datos para insertar un nuevo cliente
                queriesTableAdapter1.Sp_ProductosInsert(Convert.ToInt32(tbID.Text), tbNombre.Text.TrimEnd(' '), tbCantidadUnidad.Text.TrimEnd(' '),
                    Convert.ToInt32(tbPrecio.Text), Convert.ToInt16(tbStock.Text), 0, cbCancelado.Checked, image, tbDescripcion.Text.TrimEnd(' '));
                
                //actualiza los datos
                filaActual = sp_ProductosSelectDataGridView.Rows.Count;
                this.sp_ProductosSelectTableAdapter1.Fill(this.puntoDeVentaDataSet.Sp_ProductosSelect, -1);
                if (sp_ProductosSelectDataGridView.Rows.Count != 0)
                {
                    sp_ProductosSelectDataGridView.CurrentCell = sp_ProductosSelectDataGridView.Rows[filaActual].Cells[0];
                }
                Utilidades.LimpiarCampos(gbProductos.Controls);
                //lanza un mensaje de confirmacion
                MessageBox.Show("Guardado Con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //si el rd esta seleccionado para actualizar aplica un Update
            else if (rdActualizar.Checked)
            {

                //peticion de un sp a la base de datos para actualizar un nuevo cliente
                queriesTableAdapter1.Sp_ProductosUpdate(Convert.ToInt32(tbID.Text), tbNombre.Text.TrimEnd(' '), tbCantidadUnidad.Text.TrimEnd(' '),
                    Convert.ToDecimal(tbPrecio.Text), Convert.ToInt16(tbStock.Text), Convert.ToInt16(tbEnPedido.Text), cbCancelado.Checked, image,
                     tbDescripcion.Text.TrimEnd(' '));




                //lanza un mensaje de confirmacion
                MessageBox.Show("Actualizado Con Exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filaActual = sp_ProductosSelectDataGridView.Rows.IndexOf(sp_ProductosSelectDataGridView.CurrentRow);
                //actualiza los datos
                this.sp_ProductosSelectTableAdapter1.Fill(this.puntoDeVentaDataSet.Sp_ProductosSelect, -1);
                sp_ProductosSelectDataGridView.CurrentCell = sp_ProductosSelectDataGridView.Rows[filaActual].Cells[0];

            }
        }


        private void rdInfo_CheckedChanged(object sender, EventArgs e)
        {
            //cuando info esta seleccionado desactiva el grupbox de datos para evitar su modificacion
            //y lo activa cuando este ya no esta seleccionado
            gbProductos.Enabled = !rdInfo.Checked;

            gbBotones.Enabled = !rdInfo.Checked;
        }



        private void rdBorrar_CheckedChanged(object sender, EventArgs e)
        {
            //apaga todos los campos y enciende el boton borrar
            gbProductos.Enabled = !rdBorrar.Checked;
            btnGuardar.Enabled = !rdBorrar.Checked;
            btnBorrar.Enabled = rdBorrar.Checked;
           
        }

        private void rdActualizar_CheckedChanged(object sender, EventArgs e)
        {
            //activa el boton guadar cuando rdActualizar esta checked y viceversa
            btnGuardar.Enabled = rdActualizar.Checked;
            tbID.Enabled = !rdActualizar.Checked;
        }

        private void rdNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNuevo.Checked)
            {


                //borra todo los campos de los textbox
                Utilidades.LimpiarCampos(gbProductos.Controls);

                btnGuardar.Enabled = rdNuevo.Checked;
                tbEnPedido.Text = "0";
                cbCancelado.Checked = false;


            }
            else
            {
                this.sp_ProductosSelectTableAdapter1.Fill(this.puntoDeVentaDataSet.Sp_ProductosSelect, -1);

            }


            //vuelve activar el datagrid
            sp_ProductosSelectDataGridView.Enabled = !rdNuevo.Checked;
            fillToolStrip.Enabled = !rdNuevo.Checked;
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esta linea hace que el textbox solo acepte numeros
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(sp_ProductosSelectDataGridView.Rows.Count <= 0)
            {
                return;
            }

           if((bool)queriesTableAdapter1.ExisteProductoEnRegistros(Convert.ToInt32(tbID.Text)))
            {
                
                MessageBox.Show("No se puede borrar el producto debido a que ya " +
                    "hay registros con este id, el status del producto sera cambiado " +
                    "a cancelado", "Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                byte[] image = pbFoto.Image == null ? null : Utilidades.imageToByteArray(pbFoto.Image, pbFoto.Image.RawFormat);
                //peticion de un sp a la base de datos para actualizar un nuevo cliente
                queriesTableAdapter1.Sp_ProductosUpdate(Convert.ToInt32(tbID.Text), tbNombre.Text.TrimEnd(' '), tbCantidadUnidad.Text.TrimEnd(' '),
                    Convert.ToDecimal(tbPrecio.Text), Convert.ToInt16(tbStock.Text), Convert.ToInt16(tbEnPedido.Text), true,image,
                     tbDescripcion.Text.TrimEnd(' '));

                filaActual = sp_ProductosSelectDataGridView.Rows.IndexOf(sp_ProductosSelectDataGridView.CurrentRow);
                //actualiza los datos
                this.sp_ProductosSelectTableAdapter1.Fill(this.puntoDeVentaDataSet.Sp_ProductosSelect, -1);
                sp_ProductosSelectDataGridView.CurrentCell = sp_ProductosSelectDataGridView.Rows[filaActual].Cells[0];
                return;
            }

            queriesTableAdapter1.Sp_ProductosDelete(Convert.ToInt32(tbID.Text));
            this.sp_ProductosSelectTableAdapter1.Fill(this.puntoDeVentaDataSet.Sp_ProductosSelect,-1);
            MessageBox.Show("Borrado Con Exito", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_ProductosSelectTableAdapter1.Fill(this.puntoDeVentaDataSet.Sp_ProductosSelect, new System.Nullable<int>(((int)(System.Convert.ChangeType(tbBuscarId.Text, typeof(int))))));
                if (rdNuevo.Checked)
                {
                    Utilidades.LimpiarCampos(gbProductos.Controls);
                    
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.sp_ProductosSelectTableAdapter1.Fill(this.puntoDeVentaDataSet.Sp_ProductosSelect, -1);
            tbBuscarId.Text = "";
            
        }
    }
}
