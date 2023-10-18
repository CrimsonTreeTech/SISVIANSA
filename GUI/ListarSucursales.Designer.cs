namespace SISVIANSA_ITI_2023.GUI
{
    partial class ListarSucursales
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
            dgvSucursal = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCapProd = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            btnDetalles = new Button();
            btnModificar = new Button();
            btnDarBaja = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSucursal).BeginInit();
            SuspendLayout();
            // 
            // dgvSucursal
            // 
            dgvSucursal.AllowUserToAddRows = false;
            dgvSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursal.Columns.AddRange(new DataGridViewColumn[] { colId, colCapProd, colActivo });
            dgvSucursal.Location = new Point(29, 30);
            dgvSucursal.MultiSelect = false;
            dgvSucursal.Name = "dgvSucursal";
            dgvSucursal.ReadOnly = true;
            dgvSucursal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSucursal.Size = new Size(283, 293);
            dgvSucursal.TabIndex = 0;
            // 
            // colId
            // 
            colId.FillWeight = 50F;
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 50;
            // 
            // colCapProd
            // 
            colCapProd.HeaderText = "Cap. Prod.";
            colCapProd.Name = "colCapProd";
            colCapProd.ReadOnly = true;
            colCapProd.Width = 90;
            // 
            // colActivo
            // 
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(327, 30);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(237, 43);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(327, 112);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(237, 43);
            btnDetalles.TabIndex = 2;
            btnDetalles.Text = "Ver detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(327, 195);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(237, 43);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnDarBaja
            // 
            btnDarBaja.Location = new Point(327, 280);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(237, 43);
            btnDarBaja.TabIndex = 4;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.UseVisualStyleBackColor = true;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // ListarSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 358);
            Controls.Add(btnDarBaja);
            Controls.Add(btnModificar);
            Controls.Add(btnDetalles);
            Controls.Add(btnRegresar);
            Controls.Add(dgvSucursal);
            Name = "ListarSucursales";
            Text = "VisualizarSucursales";
            ((System.ComponentModel.ISupportInitialize)dgvSucursal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSucursal;
        private Button btnRegresar;
        private Button btnDetalles;
        private Button btnModificar;
        private Button btnDarBaja;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colZona;
        private DataGridViewTextBoxColumn colCapProd;
        private DataGridViewTextBoxColumn colActivo;
    }
}