namespace ReservaGimnasio.Forms
{
    partial class GestionClasesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewClases;
        private System.Windows.Forms.Button btnAgregarClase;
        private System.Windows.Forms.Button btnEditarClase;
        private System.Windows.Forms.Button btnEliminarClase;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewClases = new System.Windows.Forms.DataGridView();
            this.btnAgregarClase = new System.Windows.Forms.Button();
            this.btnEditarClase = new System.Windows.Forms.Button();
            this.btnEliminarClase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClases)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClases
            // 
            this.dataGridViewClases.AllowUserToAddRows = false;
            this.dataGridViewClases.AllowUserToDeleteRows = false;
            this.dataGridViewClases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClases.Location = new System.Drawing.Point(30, 30);
            this.dataGridViewClases.MultiSelect = false;
            this.dataGridViewClases.Name = "dataGridViewClases";
            this.dataGridViewClases.ReadOnly = true;
            this.dataGridViewClases.RowHeadersVisible = false;
            this.dataGridViewClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClases.Size = new System.Drawing.Size(600, 300);
            this.dataGridViewClases.TabIndex = 0;
            // 
            // btnAgregarClase
            // 
            this.btnAgregarClase.Location = new System.Drawing.Point(30, 350);
            this.btnAgregarClase.Name = "btnAgregarClase";
            this.btnAgregarClase.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarClase.TabIndex = 1;
            this.btnAgregarClase.Text = "Agregar Clase";
            this.btnAgregarClase.UseVisualStyleBackColor = true;
            this.btnAgregarClase.Click += new System.EventHandler(this.btnAgregarClase_Click);
            // 
            // btnEditarClase
            // 
            this.btnEditarClase.Location = new System.Drawing.Point(140, 350);
            this.btnEditarClase.Name = "btnEditarClase";
            this.btnEditarClase.Size = new System.Drawing.Size(100, 30);
            this.btnEditarClase.TabIndex = 2;
            this.btnEditarClase.Text = "Editar Clase";
            this.btnEditarClase.UseVisualStyleBackColor = true;
            this.btnEditarClase.Click += new System.EventHandler(this.btnEditarClase_Click);
            // 
            // btnEliminarClase
            // 
            this.btnEliminarClase.Location = new System.Drawing.Point(250, 350);
            this.btnEliminarClase.Name = "btnEliminarClase";
            this.btnEliminarClase.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarClase.TabIndex = 3;
            this.btnEliminarClase.Text = "Eliminar Clase";
            this.btnEliminarClase.UseVisualStyleBackColor = true;
            this.btnEliminarClase.Click += new System.EventHandler(this.btnEliminarClase_Click);
            // 
            // GestionClasesForm
            // 
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.btnEliminarClase);
            this.Controls.Add(this.btnEditarClase);
            this.Controls.Add(this.btnAgregarClase);
            this.Controls.Add(this.dataGridViewClases);
            this.Name = "GestionClasesForm";
            this.Text = "Gestionar Clases";
            this.Load += new System.EventHandler(this.GestionClasesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClases)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
