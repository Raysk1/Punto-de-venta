using System;
using System.Drawing;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }


        private void formClientes_Load(object sender, System.EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.puntoDeVentaDataSet.Clientes);


        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (!Utilidades.ComprobarCampos(gbClientes.Controls))
            {
                //lanza un mensaje alertando llenar los campos
                MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int filaActual = 0;
            //se transforma la imagen en un array de bits para su posterior insercion en la base de datos y controla los nulos
            byte[] image = pbFoto.Image == null ? null : Utilidades.imageToByteArray(pbFoto.Image, pbFoto.Image.RawFormat);
            //si el rd esta seleccionado para nuevo se aplica un insert
            if (rdNuevo.Checked)
            {

                //peticion de un sp a la base de datos para insertar un nuevo cliente
                queriesTableAdapter1.Sp_ClientesInsert(tbNombre.Text.TrimEnd(' '), tbApPaterno.Text.TrimEnd(' '), tbApMaterno.Text.TrimEnd(' '),
                    tbTelefono.Text.TrimEnd(' '), cbSexo.Text.TrimEnd(' '), dtpFecNacimiento.Value, image);


                //actualiza los datos
                filaActual = clientesDataGridView.Rows.Count;
                this.clientesTableAdapter.Fill(this.puntoDeVentaDataSet.Clientes);
                clientesDataGridView.CurrentCell = clientesDataGridView.Rows[filaActual].Cells[0];
                Utilidades.LimpiarCampos(gbClientes.Controls);
                tbIdCliente.Text = Utilidades.SiguienteID(queriesTableAdapter1, "Clientes");
                //lanza un mensaje de confirmacion
                MessageBox.Show("Guardado Con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //si el rd esta seleccionado para actualizar aplica un Update
            else if (rdActualizar.Checked)
            {
                //peticion de un sp a la base de datos para actualizar un nuevo cliente
                queriesTableAdapter1.Sp_ClientesUpdate(Convert.ToInt32(tbIdCliente.Text), tbNombre.Text.TrimEnd(' '), tbApPaterno.Text.TrimEnd(' '),
                    tbApMaterno.Text.TrimEnd(' '), tbTelefono.Text.TrimEnd(' '), cbSexo.Text.TrimEnd(' '), dtpFecNacimiento.Value, image);
                //lanza un mensaje de confirmacion
                MessageBox.Show("Actualizado Con Exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filaActual = clientesDataGridView.Rows.IndexOf(clientesDataGridView.CurrentRow);
                clientesDataGridView.CurrentCell = clientesDataGridView.Rows[filaActual].Cells[0];
            }




        }


        private void rdInfo_CheckedChanged(object sender, EventArgs e)
        {
            //cuando info esta seleccionado desactiva el grupbox de datos para evitar su modificacion
            //y lo activa cuando este ya no esta seleccionado
            gbClientes.Enabled = !rdInfo.Checked;

            gbBotones.Enabled = !rdInfo.Checked;
        }



        private void rdBorrar_CheckedChanged(object sender, EventArgs e)
        {
            //apaga todos los campos y enciende el boton borrar
            gbClientes.Enabled = !rdBorrar.Checked;
            btnGuardar.Enabled = !rdBorrar.Checked;
            btnBorrar.Enabled = rdBorrar.Checked;
        }

        private void rdActualizar_CheckedChanged(object sender, EventArgs e)
        {
            //activa el boton guadar cuando rdActualizar esta checked y viceversa
            btnGuardar.Enabled = rdActualizar.Checked;
        }

        private void rdNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNuevo.Checked)
            {


                //borra todo los campos de los textbox
                Utilidades.LimpiarCampos(gbClientes.Controls);
                tbIdCliente.Text = Utilidades.SiguienteID(queriesTableAdapter1, "Clientes");

                btnGuardar.Enabled = rdNuevo.Checked;


            }
            else
            {
                this.clientesTableAdapter.Fill(this.puntoDeVentaDataSet.Clientes);
            }


            //vuelve activar el datagrid
            clientesDataGridView.Enabled = !rdNuevo.Checked;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            queriesTableAdapter1.Sp_ClientesDelete(Convert.ToInt32(tbIdCliente.Text));
            this.clientesTableAdapter.Fill(this.puntoDeVentaDataSet.Clientes);
            MessageBox.Show("Borrado Con Exito", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            //abre una ventana de busqueda de archivos,devuelve la imagen seleccionada y se le asigna al pbFoto
            Image image = Utilidades.ElegirImagen();
            if (image != null)
                pbFoto.Image = image;
        }

    }
}

