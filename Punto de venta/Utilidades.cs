using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public static class Utilidades
    {
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
           if(byteArrayIn != null)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            return null;
        }

        public static Image PickAImage()
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

        public static Image ObjectToImage(object o)
        {
            var ob = o as byte[];
           return byteArrayToImage(ob);
        }
    }
}
