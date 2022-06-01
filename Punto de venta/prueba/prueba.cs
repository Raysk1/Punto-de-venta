using System;
using System.Windows.Forms;

namespace Punto_de_venta.prueba
{
    public partial class prueba : Form
    {

        public int d;
        public prueba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //generar busqueda y actualizar datagrid


            Form f = new prueba();


        }

        private void prueba_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.Sp_EmpleadosSelectAll' Puede moverla o quitarla según sea necesario.
            this.sp_EmpleadosSelectAllTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_EmpleadosSelectAll);
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.Sp_EmpleadosSelectAll' Puede moverla o quitarla según sea necesario.




        }

        private void sp_EmpleadosSelectAllDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void sp_EmpleadosSelectAllDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //devuelve los datos de la fila seleccionada

        }




    }
}
