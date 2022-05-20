using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class formVentas : Form
    {
        public formVentas()
        {
            InitializeComponent();
        }

        private void formVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.View_VentaCabecera' Puede moverla o quitarla según sea necesario.
            this.view_VentaCabeceraTableAdapter.Fill(this.puntoDeVentaDataSet.View_VentaCabecera);
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.view_PedidoCuerpo' Puede moverla o quitarla según sea necesario.
            this.view_PedidoCuerpoTableAdapter.Fill(this.puntoDeVentaDataSet.view_PedidoCuerpo);

        }
    }
}
