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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarDietas));
            dgvDieta = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            colAutorizado = new DataGridViewTextBoxColumn();
            btnModificar = new Button();
            btnRegresar = new Button();
            gbxFiltros = new GroupBox();
            rbtnNoAutorizadas = new RadioButton();
            rbtnInactivas = new RadioButton();
            btnBuscar = new Button();
            rbtnActivasYAutorizadas = new RadioButton();
            rbtnTodo = new RadioButton();
            btnAlta = new Button();
            btnBaja = new Button();
            btnAutorizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDieta).BeginInit();
            gbxFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDieta
            // 
            dgvDieta.AllowUserToAddRows = false;
            dgvDieta.AllowUserToDeleteRows = false;
            dgvDieta.AllowUserToResizeColumns = false;
            dgvDieta.AllowUserToResizeRows = false;
            dgvDieta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDieta.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colActivo, colAutorizado });
            dgvDieta.Location = new Point(12, 89);
            dgvDieta.MultiSelect = false;
            dgvDieta.Name = "dgvDieta";
            dgvDieta.ReadOnly = true;
            dgvDieta.RowHeadersVisible = false;
            dgvDieta.RowTemplate.Height = 25;
            dgvDieta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDieta.Size = new Size(774, 231);
            dgvDieta.TabIndex = 0;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colId.FillWeight = 35.9433441F;
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.FillWeight = 243.106216F;
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colActivo
            // 
            colActivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colActivo.FillWeight = 60.03675F;
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // colAutorizado
            // 
            colAutorizado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAutorizado.FillWeight = 60.9137039F;
            colAutorizado.HeaderText = "Autorizado";
            colAutorizado.Name = "colAutorizado";
            colAutorizado.ReadOnly = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(636, 340);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 37);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 340);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(150, 37);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regreasr";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // gbxFiltros
            // 
            gbxFiltros.Controls.Add(rbtnNoAutorizadas);
            gbxFiltros.Controls.Add(rbtnInactivas);
            gbxFiltros.Controls.Add(btnBuscar);
            gbxFiltros.Controls.Add(rbtnActivasYAutorizadas);
            gbxFiltros.Controls.Add(rbtnTodo);
            gbxFiltros.Location = new Point(12, 16);
            gbxFiltros.Name = "gbxFiltros";
            gbxFiltros.Size = new Size(774, 67);
            gbxFiltros.TabIndex = 3;
            gbxFiltros.TabStop = false;
            gbxFiltros.Text = "Filtros";
            // 
            // rbtnNoAutorizadas
            // 
            rbtnNoAutorizadas.AutoSize = true;
            rbtnNoAutorizadas.Location = new Point(377, 31);
            rbtnNoAutorizadas.Name = "rbtnNoAutorizadas";
            rbtnNoAutorizadas.Size = new Size(104, 19);
            rbtnNoAutorizadas.TabIndex = 4;
            rbtnNoAutorizadas.TabStop = true;
            rbtnNoAutorizadas.Text = "No autorizadas";
            rbtnNoAutorizadas.UseVisualStyleBackColor = true;
            rbtnNoAutorizadas.Click += rbtnNoAutorizadas_Click;
            // 
            // rbtnInactivas
            // 
            rbtnInactivas.AutoSize = true;
            rbtnInactivas.Location = new Point(272, 31);
            rbtnInactivas.Name = "rbtnInactivas";
            rbtnInactivas.Size = new Size(71, 19);
            rbtnInactivas.TabIndex = 3;
            rbtnInactivas.TabStop = true;
            rbtnInactivas.Text = "Inactivas";
            rbtnInactivas.UseVisualStyleBackColor = true;
            rbtnInactivas.Click += rbtnInactivas_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(597, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(159, 28);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // rbtnActivasYAutorizadas
            // 
            rbtnActivasYAutorizadas.AutoSize = true;
            rbtnActivasYAutorizadas.Location = new Point(103, 31);
            rbtnActivasYAutorizadas.Name = "rbtnActivasYAutorizadas";
            rbtnActivasYAutorizadas.Size = new Size(135, 19);
            rbtnActivasYAutorizadas.TabIndex = 1;
            rbtnActivasYAutorizadas.TabStop = true;
            rbtnActivasYAutorizadas.Text = "Activas y autorizadas";
            rbtnActivasYAutorizadas.UseVisualStyleBackColor = true;
            rbtnActivasYAutorizadas.Click += rbtnActivasYAutorizadas_Click;
            // 
            // rbtnTodo
            // 
            rbtnTodo.AutoSize = true;
            rbtnTodo.Location = new Point(17, 31);
            rbtnTodo.Name = "rbtnTodo";
            rbtnTodo.Size = new Size(51, 19);
            rbtnTodo.TabIndex = 0;
            rbtnTodo.TabStop = true;
            rbtnTodo.Text = "Todo";
            rbtnTodo.UseVisualStyleBackColor = true;
            rbtnTodo.Click += rbtnTodo_Click;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(324, 340);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(150, 37);
            btnAlta.TabIndex = 4;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(168, 340);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(150, 37);
            btnBaja.TabIndex = 5;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Location = new Point(480, 340);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(150, 37);
            btnAutorizar.TabIndex = 6;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = true;
            btnAutorizar.Click += btnAutorizar_Click;
            // 
            // ListarDietas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 389);
            Controls.Add(btnAutorizar);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            Controls.Add(gbxFiltros);
            Controls.Add(btnRegresar);
            Controls.Add(btnModificar);
            Controls.Add(dgvDieta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListarDietas";
            Text = "Lisar dietas";
            Load += ListarDietas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDieta).EndInit();
            gbxFiltros.ResumeLayout(false);
            gbxFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDieta;
        private Button btnModificar;
        private Button btnRegresar;
        private GroupBox gbxFiltros;
        private Button btnBuscar;
        private RadioButton rbtnActivasYAutorizadas;
        private RadioButton rbtnTodo;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colActivo;
        private DataGridViewTextBoxColumn colAutorizado;
        private Button btnAlta;
        private Button btnBaja;
        private Button btnAutorizar;
        private RadioButton rbtnNoAutorizadas;
        private RadioButton rbtnInactivas;
    }
}