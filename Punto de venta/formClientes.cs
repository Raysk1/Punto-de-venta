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
            //si el rd esta seleccionado para nuevo se aplica un insert
            if (rdNuevo.Checked)
            {
                //peticion de un sp a la base de datos para insertar un nuevo cliente
                queriesTableAdapter1.Sp_ClientesInsert(Convert.ToInt32(tbIdCliente.Text), tbNombre.Text, tbApPaterno.Text, tbApMaterno.Text, tbTelefono.Text);
            }
            //si el rd esta seleccionado para actualizar aplica un Update
            else if (rdActualizar.Checked)
            {
                //peticion de un sp a la base de datos para actualizar un nuevo cliente
                queriesTableAdapter1.Sp_ClientesUpdate(Convert.ToInt32(tbIdCliente.Text), tbNombre.Text, tbApPaterno.Text, tbApMaterno.Text, tbTelefono.Text);
            }

            sp_ClientesSelectAllTableAdapter.Fill(puntoDeVentaDataSet.Sp_ClientesSelectAll);
        }


        private void rdInfo_CheckedChanged(object sender, EventArgs e)
        {
            //cuando info esta seleccionado desactiva el grupbox de datos para evitar su modificacion
            //y lo activa cuando este ya no esta seleccionado
            gbClientes.Enabled = !rdInfo.Checked;
        }
    }
}

