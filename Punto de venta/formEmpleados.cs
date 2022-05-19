using System;
using System.Drawing;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class formEmpleados : Form
    {
        public formEmpleados()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //comprueba que los campos esten llenos
            if (ComprobarCampos())
            {
                //si el rd esta seleccionado para nuevo se aplica un insert
                if (rdNuevo.Checked)
                {
                    //se transforma la imagen en un array de bits para su posterior insercion en la base de datos y controla los nulos
                    byte[] image = pbFoto.Image == null ? null : Utilidades.imageToByteArray(pbFoto.Image, pbFoto.Image.RawFormat);
                    //peticion de un sp a la base de datos para insertar un nuevo cliente
                    queriesTableAdapter1.Sp_EmpleadosInsert(tbApPaterno.Text, tbApMaterno.Text, tbNombre.Text, dtpFecNacimiento.Value,
                        dtpFecContratacion.Value, tbTelefono.Text, image, tbNotas.Text, cbSexo.Text);
                    MessageBox.Show("Guardado Con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //si el rd esta seleccionado para actualizar aplica un Update
                else if (rdActualizar.Checked)
                {
                    //se transforma la imagen en un array de bits para su posterior insercion en la base de datos y controla los nulos
                    byte[] image = pbFoto.Image == null ? null : Utilidades.imageToByteArray(pbFoto.Image, pbFoto.Image.RawFormat);
                    //peticion de un sp a la base de datos para actualizar un nuevo cliente
                    queriesTableAdapter1.Sp_EmpleadosUpdate(Convert.ToInt32(tbIdEmpleado.Text), tbApPaterno.Text, tbApMaterno.Text, tbNombre.Text, dtpFecNacimiento.Value,
                        dtpFecContratacion.Value, tbTelefono.Text, image, tbNotas.Text, cbSexo.Text);
                    MessageBox.Show("Actualizado Con Exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //actualiza los datos
                sp_EmpleadosSelectAllTableAdapter.Fill(puntoDeVentaDataSet.Sp_EmpleadosSelectAll);
            }
            else
            {
                //lanza un mensaje alertando llenar los campos
                MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            //abre una ventana de busqueda de archivos,devuelve la imagen seleccionada y se le asigna al pbFoto
            Image image = Utilidades.PickAImage();
            if (image != null)
                pbFoto.Image = image;

        }

        private void formEmpleados_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.Sp_EmpleadosSelectAll' Puede moverla o quitarla según sea necesario.
            this.sp_EmpleadosSelectAllTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_EmpleadosSelectAll);


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
                //borra todo los campos de los textbox
                foreach (Control item in gbEmpleados.Controls)
                {
                    item.Text = item.GetType() == typeof(TextBox) ? String.Empty : item.Text;
                }
                btnGuardar.Enabled = rdNuevo.Checked;
            }
            else
            {
                sp_EmpleadosSelectAllTableAdapter.Fill(puntoDeVentaDataSet.Sp_EmpleadosSelectAll);
            }

            //vuelve activar el datagrid
            dataGridView.Enabled = !rdNuevo.Checked;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //ejecuta un delete y actualiza el datagrid
            queriesTableAdapter1.Sp_EmpleadosDelete(Convert.ToInt32(tbIdEmpleado.Text));
            sp_EmpleadosSelectAllTableAdapter.Fill(puntoDeVentaDataSet.Sp_EmpleadosSelectAll);
            MessageBox.Show("Borrado Con Exito", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdActualizar_CheckedChanged(object sender, EventArgs e)
        {
            //activa el boton guadar cuando rdActualizar esta checked y viceversa
            btnGuardar.Enabled = rdActualizar.Checked;
        }

        //comprueba que los campos esten llenos
        private bool ComprobarCampos()
        {
            foreach (Control control in gbEmpleados.Controls)
            {
                if(control.Text == string.Empty && (control.GetType() == typeof(TextBox) | 
                    control.GetType() == typeof(ComboBox)) && control != tbIdEmpleado)
                {
                    return false;
                }
            }
            return true;
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esta linea hace que el textbox solo acepte numeros
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
