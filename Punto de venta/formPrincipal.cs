using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class FormPrincipal : Form
    {
        FormEmpleados empleados;
        FormProductos productos;
        FormClientes clientes;
        public FormVentas ventas;
        FormUsuarios usuarios;
        FormGenerarVenta generarVenta;
        FormReloj reloj;
        public FormPrincipal()
        {
            InitializeComponent();
            empleados = new FormEmpleados();
            productos = new FormProductos();
            clientes = new FormClientes();
            ventas = new FormVentas();
            usuarios = new FormUsuarios();
            generarVenta = new FormGenerarVenta();
            reloj = new FormReloj();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null, e);
            Utilidades.principal = this;
            AbrirFormEnPanel(reloj);

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
           
        }

        

        public void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(reloj);
            SeleccionarBoton((Button)sender);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(empleados);
            SeleccionarBoton((Button)sender);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Utilidades.login.Visible = true;
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(productos);
            SeleccionarBoton((Button)sender);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(clientes);
            SeleccionarBoton((Button)sender);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(ventas);
            SeleccionarBoton((Button)sender);
        }

        private void btnCtrUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(usuarios);
            SeleccionarBoton((Button)sender);

        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            generarVenta.BarraTitulo.Size = System.Drawing.Size.Empty;
            AbrirFormEnPanel(generarVenta);
            SeleccionarBoton((Button)sender);
        }

        private void SeleccionarBoton(Button button)
        {
            foreach (Control control in MenuVertical.Controls)
            {
                if(control.GetType() == typeof(Button))
                {
                    if(button == control)
                    {
                        control.BackColor = Color.FromArgb(0, 80, 200);
                    }
                    else
                    {
                        control.BackColor = Color.FromArgb(26, 32, 40);
                    }
                }
            }
        }
    }
}
