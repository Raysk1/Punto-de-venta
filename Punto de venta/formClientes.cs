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

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //al seleccionar una fila en el datagrid los datos de este seran copiados al formulario
            tbNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbApPaterno.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbApMaterno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbSexo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpFecNacimiento.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
            tbTelefono.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            tbIdCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void rdInfo_CheckedChanged(object sender, EventArgs e)
        {
            //cuando info esta seleccionado desactiva el grupbox de datos para evitar su modificacion
            //y lo activa cuando este ya no esta seleccionado
            gbClientes.Enabled = !rdInfo.Checked;
        }

        private void fillToolStrip_Click(object sender, EventArgs e)
        {

        }


        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sp_ClientesSelectBindingSource;
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            tbBuscarId.Text = String.Empty;
            dataGridView1.DataSource = sp_ClientesSelectAllBindingSource;
        }
    }
}

