using System;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.View_VentaCabecera' Puede moverla o quitarla según sea necesario.
            this.sp_VentaSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_VentaSelect, -1);

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if(ventaDataGridView.Rows.Count > 0)
            {
                int id = (int)ventaDataGridView.CurrentRow.Cells[0].Value;
                Utilidades.principal.AbrirFormEnPanel(new FormDetallesVentas(id));
            } 

        }

        private void FormVentas_ParentChanged(object sender, EventArgs e)
        {
            this.sp_VentaSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_VentaSelect, -1);

        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_VentaSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_VentaSelect, new System.Nullable<int>(((int)(System.Convert.ChangeType(tbBuscarId.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.sp_VentaSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_VentaSelect, -1);
            tbBuscarId.Text = "";
           
        }
    }
}
