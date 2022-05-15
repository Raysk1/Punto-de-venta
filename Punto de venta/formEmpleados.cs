using System;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.IO;
using System.Drawing;

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
            //si el rd esta seleccionado para nuevo se aplica un isert
            if (rdNuevo.Checked)
            {
                //se transforma la imagen en un array de bits para su posterior insercion en la base de datos y controla los nulos
                byte[] image = pbFoto.Image == null ? null : Utilidades.imageToByteArray(pbFoto.Image, pbFoto.Image.RawFormat);
                //peticion de un sp a la base de datos para insertar un nuevo cliente
                queriesTableAdapter1.Sp_EmpleadosInsert(tbApPaterno.Text, tbApMaterno.Text, tbNombre.Text, dtpFecNacimiento.Value,
                    dtpFecContratacion.Value, tbTelefono.Text, image, tbNotas.Text, cbSexo.Text);
            }
            //si el rd esta seleccionado para actualizar aplica un Update
            else if (rdActualizar.Checked)
            {
                //se transforma la imagen en un array de bits para su posterior insercion en la base de datos y controla los nulos
                byte[] image = pbFoto.Image == null ? null : Utilidades.imageToByteArray(pbFoto.Image, pbFoto.Image.RawFormat);
                //peticion de un sp a la base de datos para actualizar un nuevo cliente
                queriesTableAdapter1.Sp_EmpleadosUpdate(Convert.ToInt32(tbIdEmpleado.Text),tbApPaterno.Text, tbApMaterno.Text, tbNombre.Text, dtpFecNacimiento.Value,
                    dtpFecContratacion.Value, tbTelefono.Text, image, tbNotas.Text, cbSexo.Text);
            }

            sp_EmpleadosSelectAllTableAdapter.Fill(puntoDeVentaDataSet.Sp_EmpleadosSelectAll);
            if(tbPage.Text != String.Empty)
                sp_EmpleadosSelectTableAdapter.Fill(puntoDeVentaDataSet.Sp_EmpleadosSelect,Convert.ToInt32(tbPage.Text));
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

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //al seleccionar una fila en el datagrid los datos de este seran copiados al formulario
            pbFoto.Image = Utilidades.ObjectToImage(dataGridView.Rows[e.RowIndex].Cells[7].Value);
            tbNombre.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
           tbApPaterno.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbApMaterno.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbSexo.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpFecNacimiento.Value = (DateTime)dataGridView.Rows[e.RowIndex].Cells[5].Value;
            dtpFecContratacion.Value = (DateTime)dataGridView.Rows[e.RowIndex].Cells[6].Value;
            tbNotas.Text = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            tbTelefono.Text = dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            tbIdEmpleado.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void rdInfo_CheckedChanged(object sender, EventArgs e)
        {
            //cuando info esta seleccionado desactiva el grupbox de datos para evitar su modificacion
            //y lo activa cuando este ya no esta seleccionado
            gbEmpleados.Enabled = !rdInfo.Checked;
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.DataSource = sp_EmpleadosSelectBindingSource;
                this.sp_EmpleadosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_EmpleadosSelect, new System.Nullable<int>(((int)(System.Convert.ChangeType(tbBuscarId.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            tbBuscarId.Text = String.Empty;
            dataGridView.DataSource = sp_EmpleadosSelectAllBindingSource;
        }

        private void rdBorrar_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
