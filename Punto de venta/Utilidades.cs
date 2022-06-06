using Punto_de_venta.PuntoDeVentaDataSetTableAdapters;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

using static System.Windows.Forms.Control;

namespace Punto_de_venta
{
    public static class Utilidades
    {
       public static FormPrincipal principal;
        public static byte[] imageToByteArray(Image imageIn, ImageFormat imageFormat)
        {
            if (imageIn != null)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, imageFormat);
                return ms.ToArray();
            }

            return null;
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn != null)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            return null;
        }

        //Abre una ventana de busqueda de archivos
        public static Image ElegirImagen()
        {
            Image image = null;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {


                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();
                    image = Image.FromStream(fileStream);

                }
                return image;
            }
        }

        //vacia todo texto de las textboxes
        public static void LimpiarCampos(ControlCollection controls)
        {
            foreach (Control item in controls)
            {
                item.Text = item.GetType() == typeof(TextBox) ? String.Empty : item.Text = item.Text;
            }

        }

        //Comprueba que no haya campos vacios
        public static bool ComprobarCampos(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Text == string.Empty && (control.GetType() == typeof(TextBox) |
                    control.GetType() == typeof(ComboBox)))
                {
                    return false;
                }
            }
            return true;
        }

        //devuelve el siguiente ID de la tabla seleccionada de acuerdo al identity
        public static string SiguienteID(QueriesTableAdapter query, String tabla)
        {
            return "" + (query.ObtenerIdentity(tabla) + 1);
        }

        private static void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esta linea hace que el textbox solo acepte numeros
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private static void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

    }
}
