using System;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class FormDetallesVentas : Form
    {
        public FormDetallesVentas()
        {
            InitializeComponent();
        }

        private void formVentas_Load(object sender, EventArgs e)
        {


        }


        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sp_VentaCuerpoSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_VentaCuerpoSelect, new System.Nullable<int>(((int)(System.Convert.ChangeType(idToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
