namespace Punto_de_venta
{
    partial class formLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pLogin = new System.Windows.Forms.Panel();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.lblSysPapeleria = new System.Windows.Forms.Label();
            this.lblNomPrograma = new System.Windows.Forms.Label();
            this.pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(233, 158);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(272, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(233, 108);
            this.tbUsuario.MaxLength = 30;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(272, 20);
            this.tbUsuario.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("News706 BT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(226, 35);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(116, 42);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(233, 92);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(233, 142);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Contraseña";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(430, 194);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pLogin
            // 
            this.pLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pLogin.Controls.Add(this.btnAceptar);
            this.pLogin.Controls.Add(this.lblPassword);
            this.pLogin.Controls.Add(this.lblUsuario);
            this.pLogin.Controls.Add(this.lblLogin);
            this.pLogin.Controls.Add(this.tbUsuario);
            this.pLogin.Controls.Add(this.tbPassword);
            this.pLogin.Controls.Add(this.pbLogin);
            this.pLogin.Location = new System.Drawing.Point(12, 163);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(533, 234);
            this.pLogin.TabIndex = 8;
            // 
            // pbLogin
            // 
            this.pbLogin.BackColor = System.Drawing.SystemColors.Control;
            this.pbLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbLogin.Image")));
            this.pbLogin.Location = new System.Drawing.Point(20, 17);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(200, 200);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogin.TabIndex = 0;
            this.pbLogin.TabStop = false;
            // 
            // lblSysPapeleria
            // 
            this.lblSysPapeleria.AutoSize = true;
            this.lblSysPapeleria.BackColor = System.Drawing.Color.Transparent;
            this.lblSysPapeleria.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysPapeleria.ForeColor = System.Drawing.Color.Transparent;
            this.lblSysPapeleria.Location = new System.Drawing.Point(416, 113);
            this.lblSysPapeleria.Name = "lblSysPapeleria";
            this.lblSysPapeleria.Size = new System.Drawing.Size(129, 28);
            this.lblSysPapeleria.TabIndex = 9;
            this.lblSysPapeleria.Text = "Sistema de Papeleria";
            // 
            // lblNomPrograma
            // 
            this.lblNomPrograma.AutoSize = true;
            this.lblNomPrograma.BackColor = System.Drawing.Color.Transparent;
            this.lblNomPrograma.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPrograma.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomPrograma.Location = new System.Drawing.Point(119, 102);
            this.lblNomPrograma.Name = "lblNomPrograma";
            this.lblNomPrograma.Size = new System.Drawing.Size(291, 36);
            this.lblNomPrograma.TabIndex = 11;
            this.lblNomPrograma.Text = "Nombre del Software  |";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Punto_de_venta.Properties.Resources.papeleria3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lblSysPapeleria);
            this.Controls.Add(this.lblNomPrograma);
            this.Controls.Add(this.pLogin);
            this.Name = "formLogin";
            this.Text = "formLogin";
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Label lblSysPapeleria;
        private System.Windows.Forms.Label lblNomPrograma;
    }
}