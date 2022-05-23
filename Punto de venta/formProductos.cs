using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class formProductos : Form
    {
        public formProductos()
        {
            InitializeComponent();
        }

        private void formProductos_Load(object sender, System.EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.Sp_ProductosSelectAll' Puede moverla o quitarla según sea necesario.
            this.sp_ProductosSelectAllTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_ProductosSelectAll);

        }
    }
}
