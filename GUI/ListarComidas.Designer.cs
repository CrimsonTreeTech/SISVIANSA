namespace SISVIANSA_ITI_2023.GUI
{
    partial class ListarComidas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvComidas = new DataGridView();
            btnRegresar = new Button();
            btnModificar = new Button();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCoccion = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            colAutorizado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvComidas).BeginInit();
            SuspendLayout();
            // 
            // dgvComidas
            // 
            dgvComidas.AllowUserToAddRows = false;
            dgvComidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComidas.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colCoccion, colActivo, colAutorizado });
            dgvComidas.Location = new Point(28, 16);
            dgvComidas.MultiSelect = false;
            dgvComidas.Name = "dgvComidas";
            dgvComidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComidas.Size = new Size(613, 322);
            dgvComidas.TabIndex = 0;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(28, 344);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(178, 28);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(463, 344);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(178, 28);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 200;
            // 
            // colCoccion
            // 
            colCoccion.HeaderText = "Coccion (min)";
            colCoccion.Name = "colCoccion";
            colCoccion.ReadOnly = true;
            colCoccion.Width = 110;
            // 
            // colActivo
            // 
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // colAutorizado
            // 
            colAutorizado.HeaderText = "Autorizado";
            colAutorizado.Name = "colAutorizado";
            colAutorizado.ReadOnly = true;
            // 
            // ListarComidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 384);
            Controls.Add(btnModificar);
            Controls.Add(btnRegresar);
            Controls.Add(dgvComidas);
            Name = "ListarComidas";
            Text = "ListarComidas";
            ((System.ComponentModel.ISupportInitialize)dgvComidas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvComidas;
        private Button btnRegresar;
        private Button btnModificar;
        private DataGridViewTextBoxColumn colTiempoProd;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCoccion;
        private DataGridViewTextBoxColumn colActivo;
        private DataGridViewTextBoxColumn colAutorizado;
    }
}