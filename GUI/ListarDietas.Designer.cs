namespace SISVIANSA_ITI_2023.GUI
{
    partial class ListarDietas
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
            dgvDieta = new DataGridView();
            btnModificar = new Button();
            btnRegresar = new Button();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            colAutorizado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDieta).BeginInit();
            SuspendLayout();
            // 
            // dgvDieta
            // 
            dgvDieta.AllowUserToAddRows = false;
            dgvDieta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDieta.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colActivo, colAutorizado });
            dgvDieta.Location = new Point(12, 12);
            dgvDieta.MultiSelect = false;
            dgvDieta.Name = "dgvDieta";
            dgvDieta.ReadOnly = true;
            dgvDieta.RowTemplate.Height = 25;
            dgvDieta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDieta.Size = new Size(443, 219);
            dgvDieta.TabIndex = 0;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(305, 248);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 37);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 248);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(150, 37);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regreasr";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
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
            colNombre.Width = 150;
            // 
            // colActivo
            // 
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            colActivo.Width = 90;
            // 
            // colAutorizado
            // 
            colAutorizado.HeaderText = "Autorizado";
            colAutorizado.Name = "colAutorizado";
            colAutorizado.ReadOnly = true;
            // 
            // ListarDietas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 295);
            Controls.Add(btnRegresar);
            Controls.Add(btnModificar);
            Controls.Add(dgvDieta);
            Name = "ListarDietas";
            Text = "LisarDietas";
            ((System.ComponentModel.ISupportInitialize)dgvDieta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDieta;
        private Button btnModificar;
        private Button btnRegresar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colActivo;
        private DataGridViewTextBoxColumn colAutorizado;
    }
}