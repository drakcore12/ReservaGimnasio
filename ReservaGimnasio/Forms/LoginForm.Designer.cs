namespace ReservaGimnasio.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben desecharse; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblCorreo = new Label();
            lblContraseña = new Label();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            btnIniciarSesion = new Button();
            linkRegistro = new LinkLabel();
            SuspendLayout();
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(30, 30);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(161, 25);
            lblCorreo.TabIndex = 0;
            lblCorreo.Text = "Correo electrónico:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(30, 80);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(105, 25);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(197, 27);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(200, 31);
            txtCorreo.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(197, 77);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(200, 31);
            txtContraseña.TabIndex = 3;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(183, 137);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(100, 30);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // linkRegistro
            // 
            linkRegistro.AutoSize = true;
            linkRegistro.Location = new Point(160, 170);
            linkRegistro.Name = "linkRegistro";
            linkRegistro.Size = new Size(144, 25);
            linkRegistro.TabIndex = 5;
            linkRegistro.TabStop = true;
            linkRegistro.Text = "Crear una cuenta";
            linkRegistro.LinkClicked += linkRegistro_LinkClicked;
            // 
            // LoginForm
            // 
            AcceptButton = btnIniciarSesion;
            ClientSize = new Size(462, 220);
            Controls.Add(linkRegistro);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(lblContraseña);
            Controls.Add(lblCorreo);
            Name = "LoginForm";
            Text = "Inicio de Sesión - Reserva Gimnasio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.LinkLabel linkRegistro;
    }
}
