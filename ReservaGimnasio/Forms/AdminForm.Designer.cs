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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnGestionarClases = new System.Windows.Forms.Button();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnVerEstadisticas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(30, 30);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(129, 25);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "¡Bienvenido!";
            // 
            // btnGestionarClases
            // 
            this.btnGestionarClases.Location = new System.Drawing.Point(35, 80);
            this.btnGestionarClases.Name = "btnGestionarClases";
            this.btnGestionarClases.Size = new System.Drawing.Size(150, 40);
            this.btnGestionarClases.TabIndex = 1;
            this.btnGestionarClases.Text = "Gestionar Clases";
            this.btnGestionarClases.UseVisualStyleBackColor = true;
            this.btnGestionarClases.Click += new System.EventHandler(this.btnGestionarClases_Click);
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(35, 140);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(150, 40);
            this.btnGestionarUsuarios.TabIndex = 2;
            this.btnGestionarUsuarios.Text = "Gestionar Usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = true;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // btnVerEstadisticas
            // 
            this.btnVerEstadisticas.Location = new System.Drawing.Point(35, 200);
            this.btnVerEstadisticas.Name = "btnVerEstadisticas";
            this.btnVerEstadisticas.Size = new System.Drawing.Size(150, 40);
            this.btnVerEstadisticas.TabIndex = 3;
            this.btnVerEstadisticas.Text = "Ver Estadísticas";
            this.btnVerEstadisticas.UseVisualStyleBackColor = true;
            this.btnVerEstadisticas.Click += new System.EventHandler(this.btnVerEstadisticas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(35, 260);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(150, 40);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // AdminForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 330);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnVerEstadisticas);
            this.Controls.Add(this.btnGestionarUsuarios);
            this.Controls.Add(this.btnGestionarClases);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "AdminForm";
            this.Text = "Panel Administrativo - Reserva Gimnasio";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnGestionarClases;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Button btnVerEstadisticas;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
