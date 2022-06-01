using System.Windows.Forms;
using static Punto_de_venta.PuntoDeVentaDataSet;

namespace Punto_de_venta
{
    public partial class FormLogin : Form
    {
        loginDataTable datos;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {

            datos = loginTableAdapter.GetData(tbUsuario.Text, tbPassword.Text);
            if (ComprobarLogin())
            {
                Usuario.usuario = (string)datos.Rows[0][0];
                Usuario.nivel = (int)datos.Rows[0][2];
                Usuario.idEmpleado = (int)datos.Rows[0][3];

                if (Usuario.nivel == 1)
                {
                    FormPrincipal Principal1 = new FormPrincipal();
                    Principal1.Show();
                }
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                tbPassword.Text = "";

            }
        }

        private bool ComprobarLogin()
        {

            return datos.Rows.Count > 0;

        }

        private void fillToolStripButton_Click(object sender, System.EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, System.EventArgs e)
        {
            try
            {
                // this.loginTableAdapter.Fill(this.puntoDeVentaDataSet.login, usuarioToolStripTextBox.Text, claveToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
