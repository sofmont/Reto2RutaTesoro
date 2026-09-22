namespace Reto2RutaTesoro
{
    partial class FrmRutaTesoro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            lblId = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            lblPista = new System.Windows.Forms.Label();
            lblPeligro = new System.Windows.Forms.Label();
            numId = new System.Windows.Forms.NumericUpDown();
            txtNombre = new System.Windows.Forms.TextBox();
            txtPista = new System.Windows.Forms.TextBox();
            numPeligro = new System.Windows.Forms.NumericUpDown();
            btnInsertar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            btnModificar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            dgvNodos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeligro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNodos).BeginInit();
            SuspendLayout();

            // lblId
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(21, 15);
            lblId.Text = "ID:";

            // numId
            numId.Location = new System.Drawing.Point(120, 18);
            numId.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numId.Name = "numId";
            numId.Size = new System.Drawing.Size(120, 23);
            numId.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // lblNombre
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(20, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(63, 15);
            lblNombre.Text = "Ubicación:";

            // txtNombre
            txtNombre.Location = new System.Drawing.Point(120, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(200, 23);

            // lblPista
            lblPista.AutoSize = true;
            lblPista.Location = new System.Drawing.Point(20, 90);
            lblPista.Name = "lblPista";
            lblPista.Size = new System.Drawing.Size(35, 15);
            lblPista.Text = "Pista:";

            // txtPista
            txtPista.Location = new System.Drawing.Point(120, 87);
            txtPista.Name = "txtPista";
            txtPista.Size = new System.Drawing.Size(200, 23);

            // lblPeligro
            lblPeligro.AutoSize = true;
            lblPeligro.Location = new System.Drawing.Point(20, 125);
            lblPeligro.Name = "lblPeligro";
            lblPeligro.Size = new System.Drawing.Size(94, 15);
            lblPeligro.Text = "Nivel de Peligro:";

            // numPeligro
            numPeligro.Location = new System.Drawing.Point(120, 123);
            numPeligro.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numPeligro.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPeligro.Name = "numPeligro";
            numPeligro.Size = new System.Drawing.Size(120, 23);
            numPeligro.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // btnInsertar
            btnInsertar.Location = new System.Drawing.Point(340, 18);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new System.Drawing.Size(90, 25);
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;

            // btnBuscar
            btnBuscar.Location = new System.Drawing.Point(340, 52);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(90, 25);
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;

            // btnModificar
            btnModificar.Location = new System.Drawing.Point(340, 86);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(90, 25);
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;

            // btnEliminar
            btnEliminar.Location = new System.Drawing.Point(340, 121);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(90, 25);
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;

            // dgvNodos
            dgvNodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNodos.Location = new System.Drawing.Point(20, 165);
            dgvNodos.Name = "dgvNodos";
            dgvNodos.Size = new System.Drawing.Size(410, 200);

            // FrmRutaTesoro
            ClientSize = new System.Drawing.Size(450, 385);
            Controls.Add(dgvNodos);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(btnInsertar);
            Controls.Add(numPeligro);
            Controls.Add(lblPeligro);
            Controls.Add(txtPista);
            Controls.Add(lblPista);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(numId);
            Controls.Add(lblId);
            Name = "FrmRutaTesoro";
            Text = "La Ruta del Tesoro Perdido";
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeligro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNodos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPista;
        private System.Windows.Forms.Label lblPeligro;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPista;
        private System.Windows.Forms.NumericUpDown numPeligro;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvNodos;
    }
}

