﻿using System;
using System.Windows.Forms;

namespace Punto_de_venta
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();

        }



        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.sp_usuariosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_usuariosSelect, "-1");

        }


        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
           
            if (!Utilidades.ComprobarCampos(gbUsuarios.Controls))
            {
                //lanza un mensaje alertando llenar los campos
                MessageBox.Show("Debe llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (sp_EmpleadosSelectTableAdapter1.GetData(Convert.ToInt32(tbIdEmpleado.Text)).Rows.Count == 0)
            {
                MessageBox.Show("El id de empleado no existe, por favor verifique el id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            int nivel = cbNivel.Text == "Admin" ? 1 : 2;
            int filaActual = 0;
            //si el rd esta seleccionado para nuevo se aplica un insert
            if (rdNuevo.Checked)
            {

                try
                {
                    //peticion de un sp a la base de datos para insertar un nuevo cliente
                    queriesTableAdapter1.Sp_usuariosInsert(tbUsuario.Text.TrimEnd(' '), tbClave.Text.TrimEnd(' '),
                      nivel, Convert.ToInt32(tbIdEmpleado.Text));


                    //actualiza los datos
                    filaActual = usuariosDataGridView.Rows.Count;
                    this.sp_usuariosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_usuariosSelect, "-1");
                    usuariosDataGridView.CurrentCell = usuariosDataGridView.Rows[filaActual].Cells[0];

                    Utilidades.LimpiarCampos(gbUsuarios.Controls);
                    //lanza un mensaje de confirmacion
                    MessageBox.Show("Guardado Con Exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            //si el rd esta seleccionado para actualizar aplica un Update
            else if (rdActualizar.Checked)
            {
                try
                {

                    //peticion de un sp a la base de datos para actualizar un nuevo cliente
                    queriesTableAdapter1.Sp_usuariosUpdate(tbUsuario.Text.TrimEnd(' '), tbClave.Text.TrimEnd(' '),
                      nivel, Convert.ToInt32(tbIdEmpleado.Text));

                    //lanza un mensaje de confirmacion
                    MessageBox.Show("Actualizado Con Exito", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filaActual = usuariosDataGridView.Rows.IndexOf(usuariosDataGridView.CurrentRow);
                    this.sp_usuariosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_usuariosSelect, "-1");
                    usuariosDataGridView.CurrentCell = usuariosDataGridView.Rows[filaActual].Cells[0];

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.sp_usuariosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_usuariosSelect, "-1");
            usuariosDataGridView.CurrentCell = usuariosDataGridView.Rows[filaActual].Cells[0];
            Utilidades.LimpiarCampos(gbUsuarios.Controls);



        }


        private void rdInfo_CheckedChanged(object sender, EventArgs e)
        {
            //cuando info esta seleccionado desactiva el grupbox de datos para evitar su modificacion
            //y lo activa cuando este ya no esta seleccionado
            gbUsuarios.Enabled = !rdInfo.Checked;

            gbBotones.Enabled = !rdInfo.Checked;
        }



        private void rdBorrar_CheckedChanged(object sender, EventArgs e)
        {
            //apaga todos los campos y enciende el boton borrar
            gbUsuarios.Enabled = !rdBorrar.Checked;
            btnGuardar.Enabled = !rdBorrar.Checked;
            btnBorrar.Enabled = rdBorrar.Checked;
        }

        private void rdActualizar_CheckedChanged(object sender, EventArgs e)
        {
            //activa el boton guadar cuando rdActualizar esta checked y viceversa
            btnGuardar.Enabled = rdActualizar.Checked;
        }

        private void rdNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNuevo.Checked)
            {


                //borra todo los campos de los textbox
                Utilidades.LimpiarCampos(gbUsuarios.Controls);


                btnGuardar.Enabled = rdNuevo.Checked;
                


            }
            else
            {
                this.sp_usuariosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_usuariosSelect, "-1"); 
            }


            //vuelve activar el datagrid
            usuariosDataGridView.Enabled = !rdNuevo.Checked;
            fillToolStrip.Enabled = !rdNuevo.Checked;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(usuariosDataGridView.Rows.Count <= 0)
            {
                return;
            }
            queriesTableAdapter1.Sp_usuariosDelete(tbUsuario.Text);
            this.sp_usuariosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_usuariosSelect, "-1");
            MessageBox.Show("Borrado Con Exito", "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_usuariosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_usuariosSelect, tbBuscarId.Text);
                if (rdNuevo.Checked)
                {
                    Utilidades.LimpiarCampos(gbUsuarios.Controls);
                  
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.sp_usuariosSelectTableAdapter.Fill(this.puntoDeVentaDataSet.Sp_usuariosSelect, "-1");
            tbBuscarId.Text = "";
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            String nivel = "";
            if (usuariosDataGridView.CurrentRow == null)
            {
                return;
            }
            switch ((int)usuariosDataGridView.CurrentRow.Cells[2].Value)
            {
                case 1:
                    nivel = "Admin";
                    break;
                case 2:
                    nivel = "Empleado";
                    break;
                case 3:
                    nivel = "Cliente";
                    break;
            }
        }
    }
}

