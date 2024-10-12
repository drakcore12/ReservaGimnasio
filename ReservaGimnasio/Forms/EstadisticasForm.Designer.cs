namespace ReservaGimnasio.Forms
{
    partial class EstadisticasForm
    {
        private System.Windows.Forms.Label lblTotalReservas;
        private System.Windows.Forms.ListBox lstReservasPorClase;
        private System.Windows.Forms.ListBox lstTop5Clases;
        private System.Windows.Forms.ListBox lstReservasPorInstructor;
        private System.Windows.Forms.Button btnCerrar;

        private void InitializeComponent()
        {
            this.lblTotalReservas = new System.Windows.Forms.Label();
            this.lstReservasPorClase = new System.Windows.Forms.ListBox();
            this.lstTop5Clases = new System.Windows.Forms.ListBox();
            this.lstReservasPorInstructor = new System.Windows.Forms.ListBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTotalReservas
            this.lblTotalReservas.AutoSize = true;
            this.lblTotalReservas.Location = new System.Drawing.Point(50, 30);
            this.lblTotalReservas.Name = "lblTotalReservas";
            this.lblTotalReservas.Size = new System.Drawing.Size(150, 20);
            this.lblTotalReservas.Text = "Total de Reservas:";

            // lstReservasPorClase
            this.lstReservasPorClase.Location = new System.Drawing.Point(50, 60);
            this.lstReservasPorClase.Name = "lstReservasPorClase";
            this.lstReservasPorClase.Size = new System.Drawing.Size(300, 100);

            // lstTop5Clases
            this.lstTop5Clases.Location = new System.Drawing.Point(50, 180);
            this.lstTop5Clases.Name = "lstTop5Clases";
            this.lstTop5Clases.Size = new System.Drawing.Size(300, 100);

            // lstReservasPorInstructor
            this.lstReservasPorInstructor.Location = new System.Drawing.Point(50, 300);
            this.lstReservasPorInstructor.Name = "lstReservasPorInstructor";
            this.lstReservasPorInstructor.Size = new System.Drawing.Size(300, 100);

            // btnCerrar
            this.btnCerrar.Location = new System.Drawing.Point(150, 420);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // EstadisticasForm
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.lblTotalReservas);
            this.Controls.Add(this.lstReservasPorClase);
            this.Controls.Add(this.lstTop5Clases);
            this.Controls.Add(this.lstReservasPorInstructor);
            this.Controls.Add(this.btnCerrar);
            this.Name = "EstadisticasForm";
            this.Text = "Estadísticas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
