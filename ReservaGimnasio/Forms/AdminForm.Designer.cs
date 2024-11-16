namespace ReservaGimnasio.Forms
{
    partial class AdminForm
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

        private void InitializeComponent()
        {
            lblBienvenida = new Label();
            btnGestionarClases = new Button();
            btnGestionarUsuarios = new Button();
            btnVerEstadisticas = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(30, 30);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(158, 29);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "¡Bienvenido!";
            // 
            // btnGestionarClases
            // 
            btnGestionarClases.Location = new Point(35, 80);
            btnGestionarClases.Name = "btnGestionarClases";
            btnGestionarClases.Size = new Size(150, 40);
            btnGestionarClases.TabIndex = 1;
            btnGestionarClases.Text = "Gestionar Clases";
            btnGestionarClases.UseVisualStyleBackColor = true;
            btnGestionarClases.Click += btnGestionarClases_Click;
            // 
            // btnGestionarUsuarios
            // 
            btnGestionarUsuarios.Location = new Point(35, 140);
            btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            btnGestionarUsuarios.Size = new Size(150, 40);
            btnGestionarUsuarios.TabIndex = 2;
            btnGestionarUsuarios.Text = "Gestionar Usuarios";
            btnGestionarUsuarios.UseVisualStyleBackColor = true;
            btnGestionarUsuarios.Click += btnGestionarUsuarios_Click;
            // 
            // btnVerEstadisticas
            // 
            btnVerEstadisticas.Location = new Point(35, 200);
            btnVerEstadisticas.Name = "btnVerEstadisticas";
            btnVerEstadisticas.Size = new Size(150, 40);
            btnVerEstadisticas.TabIndex = 3;
            btnVerEstadisticas.Text = "Ver Estadísticas";
            btnVerEstadisticas.UseVisualStyleBackColor = true;
            btnVerEstadisticas.Click += btnVerEstadisticas_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(35, 260);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(150, 40);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // AdminForm
            // 
            BackColor = Color.Brown;
            ClientSize = new Size(400, 330);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnVerEstadisticas);
            Controls.Add(btnGestionarUsuarios);
            Controls.Add(btnGestionarClases);
            Controls.Add(lblBienvenida);
            Name = "AdminForm";
            Text = "Panel Administrativo - Reserva Gimnasio";
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnGestionarClases;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Button btnVerEstadisticas;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
