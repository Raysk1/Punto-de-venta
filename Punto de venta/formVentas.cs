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
            this.view_VentaCabeceraTableAdapter.Fill(this.puntoDeVentaDataSet.View_VentaCabecera);

        }
    }
}
