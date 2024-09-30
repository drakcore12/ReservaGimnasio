namespace ReservaGimnasio.Forms
{
    partial class MainForm
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
            this.btnReservarClase = new System.Windows.Forms.Button();
            this.btnMisReservas = new System.Windows.Forms.Button();
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
            // btnReservarClase
            // 
            this.btnReservarClase.Location = new System.Drawing.Point(35, 80);
            this.btnReservarClase.Name = "btnReservarClase";
            this.btnReservarClase.Size = new System.Drawing.Size(150, 40);
            this.btnReservarClase.TabIndex = 1;
            this.btnReservarClase.Text = "Reservar Clase";
            this.btnReservarClase.UseVisualStyleBackColor = true;
            this.btnReservarClase.Click += new System.EventHandler(this.btnReservarClase_Click);
            // 
            // btnMisReservas
            // 
            this.btnMisReservas.Location = new System.Drawing.Point(35, 140);
            this.btnMisReservas.Name = "btnMisReservas";
            this.btnMisReservas.Size = new System.Drawing.Size(150, 40);
            this.btnMisReservas.TabIndex = 2;
            this.btnMisReservas.Text = "Mis Reservas";
            this.btnMisReservas.UseVisualStyleBackColor = true;
            this.btnMisReservas.Click += new System.EventHandler(this.btnMisReservas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(35, 200);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(150, 40);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 270);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnMisReservas);
            this.Controls.Add(this.btnReservarClase);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "MainForm";
            this.Text = "Menú Principal - Reserva Gimnasio";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnReservarClase;
        private System.Windows.Forms.Button btnMisReservas;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
