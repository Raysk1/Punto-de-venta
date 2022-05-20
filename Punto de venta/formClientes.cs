using System;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class formClientes : Form
    {
        public formClientes()
        {
            InitializeComponent();
        }


        private void formClientes_Load(object sender, System.EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.Sp_ClientesSelectAll' Puede moverla o quitarla según sea necesario.
            this.sp_ClientesSelectAllTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_ClientesSelectAll);

        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (ComprobarCampos())
            {
                //si el rd esta seleccionado para nuevo se aplica un insert
                if (rdNuevo.Checked)
                {
                    //peticion de un sp a la base de datos para insertar un nuevo cliente
                    queriesTableAdapter1.Sp_ClientesInsert(tbNombre.Text.TrimEnd(' '), tbApPaterno.Text.TrimEnd(' '), tbApMaterno.Text.TrimEnd(' '),
                        tbTelefono.Text.TrimEnd(' '), cbSexo.Text.TrimEnd(' '), dtpFecNacimiento.Value);

                    //lanza un mensaje de confirmacion
                    MessageBox.Show("Guardado Con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //si el rd esta seleccionado para actualizar aplica un Update
                else if (rdActualizar.Checked)
                {
                    //peticion de un sp a la base de datos para actualizar un nuevo cliente
                    queriesTableAdapter1.Sp_ClientesUpdate(Convert.ToInt32(tbIdCliente.Text), tbNombre.Text.TrimEnd(' '), tbApPaterno.Text.TrimEnd(' '),
                        tbApMaterno.Text.TrimEnd(' '), tbTelefono.Text.TrimEnd(' '), cbSexo.Text.TrimEnd(' '), dtpFecNacimiento.Value);
                    //lanza un mensaje de confirmacion
                    MessageBox.Show("Actualizado Con Exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //actualiza los datos
                sp_ClientesSelectAllTableAdapter.Fill(puntoDeVentaDataSet.Sp_ClientesSelectAll);
            }
            else
            {
                //lanza un mensaje alertando llenar los campos
                MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }


        private void rdInfo_CheckedChanged(object sender, EventArgs e)
        {
            //cuando info esta seleccionado desactiva el grupbox de datos para evitar su modificacion
            //y lo activa cuando este ya no esta seleccionado
            gbClientes.Enabled = !rdInfo.Checked;
          
            //gbBotones.Enabled = !rdInfo.Checked;
        }

        private bool ComprobarCampos()
        {
            foreach (Control control in gbClientes.Controls)
            {
                if (control.Text == string.Empty && (control.GetType() == typeof(TextBox) |
                    control.GetType() == typeof(ComboBox)) && control != tbIdCliente)
                {
                    return false;
                }
            }
            return true;
        }

        private void rdBorrar_CheckedChanged(object sender, EventArgs e)
        {
            //apaga todos los campos y enciende el boton borrar
            gbClientes.Enabled = !rdBorrar.Checked;
            btnGuardar.Enabled = !rdBorrar.Checked;
          //  btnBorrar.Enabled = rdBorrar.Checked;
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
                foreach (Control item in gbClientes.Controls)
                {
                    item.Text = item.GetType() == typeof(TextBox) ? String.Empty : item.Text = item.Text;
                }

                btnGuardar.Enabled = rdNuevo.Checked;
            }
            else
            {
               sp_ClientesSelectAllTableAdapter.Fill(puntoDeVentaDataSet.Sp_ClientesSelectAll);
            }


            //vuelve activar el datagrid
            dataGridView1.Enabled = !rdNuevo.Checked;
        }
    }
}

