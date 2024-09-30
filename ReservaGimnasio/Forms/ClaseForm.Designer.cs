namespace ReservaGimnasio.Forms
{
    partial class ClaseForm
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblCupoMaximo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbInstructor = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaHora = new System.Windows.Forms.DateTimePicker();
            this.numCupoMaximo = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCupoMaximo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new System.Drawing.Point(30, 70);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(68, 17);
            this.lblInstructor.TabIndex = 1;
            this.lblInstructor.Text = "Instructor:";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(30, 110);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(91, 17);
            this.lblFechaHora.TabIndex = 2;
            this.lblFechaHora.Text = "Fecha y Hora:";
            // 
            // lblCupoMaximo
            // 
            this.lblCupoMaximo.AutoSize = true;
            this.lblCupoMaximo.Location = new System.Drawing.Point(30, 150);
            this.lblCupoMaximo.Name = "lblCupoMaximo";
            this.lblCupoMaximo.Size = new System.Drawing.Size(93, 17);
            this.lblCupoMaximo.TabIndex = 3;
            this.lblCupoMaximo.Text = "Cupo Máximo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.Location = new System.Drawing.Point(150, 67);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Size = new System.Drawing.Size(200, 24);
            this.cmbInstructor.TabIndex = 5;
            // 
            // dateTimePickerFechaHora
            // 
            this.dateTimePickerFechaHora.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateTimePickerFechaHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaHora.Location = new System.Drawing.Point(150, 107);
            this.dateTimePickerFechaHora.Name = "dateTimePickerFechaHora";
            this.dateTimePickerFechaHora.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFechaHora.TabIndex = 6;
            // 
            // numCupoMaximo
            // 
            this.numCupoMaximo.Location = new System.Drawing.Point(150, 148);
            this.numCupoMaximo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCupoMaximo.Name = "numCupoMaximo";
            this.numCupoMaximo.Size = new System.Drawing.Size(200, 22);
            this.numCupoMaximo.TabIndex = 7;
            this.numCupoMaximo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(150, 190);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ClaseForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.numCupoMaximo);
            this.Controls.Add(this.dateTimePickerFechaHora);
            this.Controls.Add(this.cmbInstructor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCupoMaximo);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.lblNombre);
            this.Name = "ClaseForm";
            this.Text = "Clase - Reserva Gimnasio";
            this.Load += new System.EventHandler(this.ClaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCupoMaximo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblCupoMaximo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbInstructor;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHora;
        private System.Windows.Forms.NumericUpDown numCupoMaximo;
        private System.Windows.Forms.Button btnGuardar;
    }
}
