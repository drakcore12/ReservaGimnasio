namespace ReservaGimnasio.Forms
{
    partial class ReservarClaseForm
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
            this.dataGridViewClases = new System.Windows.Forms.DataGridView();
            this.btnReservar = new System.Windows.Forms.Button();
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
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(30, 350);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(100, 30);
            this.btnReservar.TabIndex = 1;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // ReservarClaseForm
            // 
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.dataGridViewClases);
            this.Name = "ReservarClaseForm";
            this.Text = "Reservar Clase - Reserva Gimnasio";
            this.Load += new System.EventHandler(this.ReservarClaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClases;
        private System.Windows.Forms.Button btnReservar;
    }
}
