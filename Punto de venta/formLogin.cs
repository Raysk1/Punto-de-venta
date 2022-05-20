using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            if (tbUsuario.Text == "admin" && tbPassword.Text == "123")
            {
                Principal Principal1 = new Principal();
                Principal1.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                tbPassword.Text = "";

            }
        }
    }
}
