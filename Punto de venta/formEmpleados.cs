using System;
using System.Drawing;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //comprueba que los campos esten llenos
            if (!Utilidades.ComprobarCampos(gbEmpleados.Controls))
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
                queriesTableAdapter1.Sp_EmpleadosInsert(tbApPaterno.Text.TrimEnd(' '), tbApMaterno.Text.TrimEnd(' '),
                    tbNombre.Text.TrimEnd(' '), dtpFecNacimiento.Value, dtpFecContratacion.Value,
                    tbTelefono.Text.TrimEnd(' '), image, tbNotas.Text.TrimEnd(' '), cbSexo.Text.TrimEnd(' '));

                //actualiza los datos
                filaActual = empleadosDataGridView.Rows.Count - 1;
                this.sp_EmpleadosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_EmpleadosSelect, -1);
                empleadosDataGridView.CurrentCell = empleadosDataGridView.Rows[filaActual].Cells[0];
                Utilidades.LimpiarCampos(gbEmpleados.Controls);
                tbIdEmpleado.Text = Utilidades.SiguienteID(queriesTableAdapter1, "Empleados");
                //lanza un mensaje de confirmacion
                MessageBox.Show("Guardado Con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //si el rd esta seleccionado para actualizar aplica un Update
            else if (rdActualizar.Checked)
            {

                //peticion de un sp a la base de datos para actualizar un nuevo cliente
                queriesTableAdapter1.Sp_EmpleadosUpdate(Convert.ToInt32(tbIdEmpleado.Text), tbApPaterno.Text.TrimEnd(' '),
                    tbApMaterno.Text.TrimEnd(' '), tbNombre.Text, dtpFecNacimiento.Value, dtpFecContratacion.Value,
                    tbTelefono.Text.TrimEnd(' '), image, tbNotas.Text.TrimEnd(' '), cbSexo.Text.TrimEnd(' '));

                //lanza un mensaje de confirmacion
                MessageBox.Show("Actualizado Con Exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filaActual = empleadosDataGridView.Rows.IndexOf(empleadosDataGridView.CurrentRow);
                //actualiza los datos
                this.sp_EmpleadosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_EmpleadosSelect, -1);
                empleadosDataGridView.CurrentCell = empleadosDataGridView.Rows[filaActual].Cells[0];
            }

        }


        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            //abre una ventana de busqueda de archivos,devuelve la imagen seleccionada y se le asigna al pbFoto
            Image image = Utilidades.ElegirImagen();
            if (image != null)
                pbFoto.Image = image;

        }

        private void formEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.sp_EmpleadosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_EmpleadosSelect, -1);





        }

        private void rdInfo_CheckedChanged(object sender, EventArgs e)
        {
            //cuando info esta seleccionado desactiva el grupbox de datos para evitar su modificacion
            //y lo activa cuando este ya no esta seleccionado
            gbEmpleados.Enabled = !rdInfo.Checked;
            gbBotones.Enabled = !rdInfo.Checked;
        }

        private void rdBorrar_CheckedChanged(object sender, EventArgs e)
        {
            //apaga todos los campos y enciende el boton borrar
            gbEmpleados.Enabled = !rdBorrar.Checked;
            btnGuardar.Enabled = !rdBorrar.Checked;
            btnBorrar.Enabled = rdBorrar.Checked;

        }

        private void rdNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNuevo.Checked)
            {
                //quita la imagen del picturebox
                pbFoto.Image = null;

                //borra todo los campos de los textbox
                Utilidades.LimpiarCampos(gbEmpleados.Controls);
                tbIdEmpleado.Text = Utilidades.SiguienteID(queriesTableAdapter1, "Empleados");

            }
            else
            {
                this.sp_EmpleadosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_EmpleadosSelect, -1);
            }


            //vuelve activar el datagrid
            empleadosDataGridView.Enabled = !rdNuevo.Checked;
            btnGuardar.Enabled = rdNuevo.Checked;
            fillToolStrip.Enabled = !rdNuevo.Checked;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (empleadosDataGridView.Rows.Count <= 0)
            {
                return;
            }
            

            if ((bool)queriesTableAdapter1.ExisteEmpleadoEnRegistros(Convert.ToInt32(tbIdEmpleado.Text)))
            {
                MessageBox.Show("No se puede borrar el Empleado debido a que ya " +
                   "hay registros con este id","Alerta!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }


            //ejecuta un delete y actualiza el datagrid
            queriesTableAdapter1.Sp_EmpleadosDelete(Convert.ToInt32(tbIdEmpleado.Text));
            this.sp_EmpleadosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_EmpleadosSelect, -1);
            MessageBox.Show("Borrado Con Exito", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdActualizar_CheckedChanged(object sender, EventArgs e)
        {
            //activa el boton guadar cuando rdActualizar esta checked y viceversa
            btnGuardar.Enabled = rdActualizar.Checked;
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

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_EmpleadosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_EmpleadosSelect, new System.Nullable<int>(((int)(System.Convert.ChangeType(tbBuscarId.Text, typeof(int))))));
                if (rdNuevo.Checked)
                {
                    Utilidades.LimpiarCampos(gbEmpleados.Controls);
                    tbIdEmpleado.Text = Utilidades.SiguienteID(queriesTableAdapter1, "Empleados");
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.sp_EmpleadosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_EmpleadosSelect, -1);
            tbBuscarId.Text = "";
            
        }

        private void panelDatos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
