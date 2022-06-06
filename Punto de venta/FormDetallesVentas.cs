using System;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class FormDetallesVentas : Form
    {
        int id = -1;
        public FormDetallesVentas()
        {
            InitializeComponent();
        }

        public FormDetallesVentas(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void formVentas_Load(object sender, EventArgs e)
        {
            this.sp_VentaCuerpoSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_VentaCuerpoSelect, id);
            float total = 0;
            foreach (DataGridViewRow row in sp_VentaCuerpoSelectDataGridView.Rows)
            {
                total += Convert.ToInt64(row.Cells[4].Value);
            }
            tbTotal.Text = "" + total;

        }


        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sp_VentaCuerpoSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_VentaCuerpoSelect, id);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Utilidades.principal.AbrirFormEnPanel(Utilidades.principal.ventas);
        }
    }
}
