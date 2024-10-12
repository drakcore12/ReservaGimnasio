namespace ReservaGimnasio.Forms
{
    public partial class ClaseForm : Form
    {
        // Declarar controles necesarios
        private ComboBox cmbTipoClase;
        private ComboBox cmbInstructor;
        private ComboBox cmbDuracionClase;  // Nuevo ComboBox para la duración de la clase
        private DateTimePicker dateTimePickerFechaHora;
        private NumericUpDown numCupoMaximo;
        private Label lblTipoClase;
        private Label lblInstructor;
        private Label lblFechaHora;
        private Label lblDuracionClase;  // Nuevo Label para la duración
        private Label lblCupoMaximo;
        private Button btnGuardar;
        private Button btnCancelar;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbTipoClase = new ComboBox();
            cmbInstructor = new ComboBox();
            cmbDuracionClase = new ComboBox();
            dateTimePickerFechaHora = new DateTimePicker();
            numCupoMaximo = new NumericUpDown();
            lblTipoClase = new Label();
            lblInstructor = new Label();
            lblFechaHora = new Label();
            lblDuracionClase = new Label();
            lblCupoMaximo = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCupoMaximo).BeginInit();
            SuspendLayout();
            // 
            // cmbTipoClase
            // 
            cmbTipoClase.FormattingEnabled = true;
            cmbTipoClase.Location = new Point(150, 30);
            cmbTipoClase.Name = "cmbTipoClase";
            cmbTipoClase.Size = new Size(200, 28);
            cmbTipoClase.TabIndex = 0;
            // 
            // cmbInstructor
            // 
            cmbInstructor.FormattingEnabled = true;
            cmbInstructor.Location = new Point(150, 70);
            cmbInstructor.Name = "cmbInstructor";
            cmbInstructor.Size = new Size(200, 28);
            cmbInstructor.TabIndex = 1;
            // 
            // cmbDuracionClase
            // 
            cmbDuracionClase.FormattingEnabled = true;
            cmbDuracionClase.Items.AddRange(new object[] { "30", "45", "60", "90" });
            cmbDuracionClase.Location = new Point(150, 150);
            cmbDuracionClase.Name = "cmbDuracionClase";
            cmbDuracionClase.Size = new Size(200, 28);
            cmbDuracionClase.TabIndex = 3;
            // 
            // dateTimePickerFechaHora
            // 
            dateTimePickerFechaHora.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerFechaHora.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaHora.Location = new Point(150, 110);
            dateTimePickerFechaHora.Name = "dateTimePickerFechaHora";
            dateTimePickerFechaHora.ShowUpDown = true;
            dateTimePickerFechaHora.Size = new Size(200, 27);
            dateTimePickerFechaHora.TabIndex = 2;
            // 
            // numCupoMaximo
            // 
            numCupoMaximo.Location = new Point(150, 190);
            numCupoMaximo.Name = "numCupoMaximo";
            numCupoMaximo.Size = new Size(200, 27);
            numCupoMaximo.TabIndex = 4;
            // 
            // lblTipoClase
            // 
            lblTipoClase.Location = new Point(30, 30);
            lblTipoClase.Name = "lblTipoClase";
            lblTipoClase.Size = new Size(100, 23);
            lblTipoClase.TabIndex = 0;
            lblTipoClase.Text = "Tipo de Clase:";
            // 
            // lblInstructor
            // 
            lblInstructor.Location = new Point(30, 70);
            lblInstructor.Name = "lblInstructor";
            lblInstructor.Size = new Size(100, 23);
            lblInstructor.TabIndex = 1;
            lblInstructor.Text = "Instructor:";
            // 
            // lblFechaHora
            // 
            lblFechaHora.Location = new Point(30, 110);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(100, 23);
            lblFechaHora.TabIndex = 2;
            lblFechaHora.Text = "Fecha y Hora:";
            // 
            // lblDuracionClase
            // 
            lblDuracionClase.Location = new Point(30, 150);
            lblDuracionClase.Name = "lblDuracionClase";
            lblDuracionClase.Size = new Size(100, 23);
            lblDuracionClase.TabIndex = 3;
            lblDuracionClase.Text = "Duración (minutos):";
            // 
            // lblCupoMaximo
            // 
            lblCupoMaximo.Location = new Point(30, 190);
            lblCupoMaximo.Name = "lblCupoMaximo";
            lblCupoMaximo.Size = new Size(100, 23);
            lblCupoMaximo.TabIndex = 4;
            lblCupoMaximo.Text = "Cupo Máximo:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(100, 230);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 28);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // ClaseForm
            // 
            ClientSize = new Size(400, 300);
            Controls.Add(lblTipoClase);
            Controls.Add(lblInstructor);
            Controls.Add(lblFechaHora);
            Controls.Add(lblDuracionClase);
            Controls.Add(lblCupoMaximo);
            Controls.Add(cmbTipoClase);
            Controls.Add(cmbInstructor);
            Controls.Add(dateTimePickerFechaHora);
            Controls.Add(cmbDuracionClase);
            Controls.Add(numCupoMaximo);
            Controls.Add(btnGuardar);
            Name = "ClaseForm";
            Text = "Formulario de Clase";
            ((System.ComponentModel.ISupportInitialize)numCupoMaximo).EndInit();
            ResumeLayout(false);
        }
    }
}



