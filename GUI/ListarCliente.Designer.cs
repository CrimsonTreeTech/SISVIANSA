namespace SISVIANSA_ITI_2023.GUI
{
    partial class ListarCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarCliente));
            dgvClientes = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTipoDoc = new DataGridViewTextBoxColumn();
            colDoc = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colDir = new DataGridViewTextBoxColumn();
            colAutorizado = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            rbtnId = new RadioButton();
            rbtnDoc = new RadioButton();
            rbtnNombre = new RadioButton();
            rbtnTipoDoc = new RadioButton();
            txtDoc = new TextBox();
            btnDarBaja = new Button();
            btnAutorizar = new Button();
            btnDetalles = new Button();
            txtNombre = new TextBox();
            cboTipo = new ComboBox();
            txtId = new TextBox();
            btnBuscar = new Button();
            gbxFiltros = new GroupBox();
            rbtnActivosYAutorizados = new RadioButton();
            rbtnNoAutorizados = new RadioButton();
            rbtnAutorizados = new RadioButton();
            rbtnInactivos = new RadioButton();
            rbtnActivos = new RadioButton();
            rbtnTodos = new RadioButton();
            btnAlta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbxFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colTipoDoc, colDoc, colTipo, colNombre, colDir, colAutorizado, colActivo });
            dgvClientes.Location = new Point(12, 134);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1069, 442);
            dgvClientes.TabIndex = 0;
            // 
            // colId
            // 
            colId.FillWeight = 57.9888763F;
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 60;
            // 
            // colTipoDoc
            // 
            colTipoDoc.FillWeight = 84.48268F;
            colTipoDoc.HeaderText = "Tipo doc.";
            colTipoDoc.Name = "colTipoDoc";
            colTipoDoc.ReadOnly = true;
            colTipoDoc.Width = 80;
            // 
            // colDoc
            // 
            colDoc.FillWeight = 369.138855F;
            colDoc.HeaderText = "Doc";
            colDoc.Name = "colDoc";
            colDoc.ReadOnly = true;
            colDoc.Width = 110;
            // 
            // colTipo
            // 
            colTipo.FillWeight = 41.0392761F;
            colTipo.HeaderText = "Tipo cliente";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.FillWeight = 86.85427F;
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 220;
            // 
            // colDir
            // 
            colDir.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDir.FillWeight = 86.85427F;
            colDir.HeaderText = "Direccion";
            colDir.Name = "colDir";
            // 
            // colAutorizado
            // 
            colAutorizado.FillWeight = 35.21946F;
            colAutorizado.HeaderText = "Autorizado";
            colAutorizado.Name = "colAutorizado";
            colAutorizado.ReadOnly = true;
            colAutorizado.Width = 90;
            // 
            // colActivo
            // 
            colActivo.FillWeight = 38.42244F;
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            colActivo.Width = 90;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 591);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(209, 43);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // rbtnId
            // 
            rbtnId.AutoSize = true;
            rbtnId.Location = new Point(9, 22);
            rbtnId.Margin = new Padding(3, 2, 3, 2);
            rbtnId.Name = "rbtnId";
            rbtnId.Size = new Size(73, 19);
            rbtnId.TabIndex = 2;
            rbtnId.TabStop = true;
            rbtnId.Text = "Id cliente";
            rbtnId.UseVisualStyleBackColor = true;
            rbtnId.Click += rbtnId_Click;
            // 
            // rbtnDoc
            // 
            rbtnDoc.AutoSize = true;
            rbtnDoc.Location = new Point(257, 20);
            rbtnDoc.Margin = new Padding(3, 2, 3, 2);
            rbtnDoc.Name = "rbtnDoc";
            rbtnDoc.Size = new Size(49, 19);
            rbtnDoc.TabIndex = 3;
            rbtnDoc.TabStop = true;
            rbtnDoc.Text = "Doc.";
            rbtnDoc.UseVisualStyleBackColor = true;
            rbtnDoc.Click += rbtnDoc_Click;
            // 
            // rbtnNombre
            // 
            rbtnNombre.AutoSize = true;
            rbtnNombre.Location = new Point(768, 22);
            rbtnNombre.Margin = new Padding(3, 2, 3, 2);
            rbtnNombre.Name = "rbtnNombre";
            rbtnNombre.Size = new Size(69, 19);
            rbtnNombre.TabIndex = 4;
            rbtnNombre.TabStop = true;
            rbtnNombre.Text = "Nombre";
            rbtnNombre.UseVisualStyleBackColor = true;
            rbtnNombre.Click += rbtnNombre_Click;
            // 
            // rbtnTipoDoc
            // 
            rbtnTipoDoc.AutoSize = true;
            rbtnTipoDoc.Location = new Point(494, 21);
            rbtnTipoDoc.Margin = new Padding(3, 2, 3, 2);
            rbtnTipoDoc.Name = "rbtnTipoDoc";
            rbtnTipoDoc.Size = new Size(86, 19);
            rbtnTipoDoc.TabIndex = 5;
            rbtnTipoDoc.TabStop = true;
            rbtnTipoDoc.Text = "Tipo cliente";
            rbtnTipoDoc.UseVisualStyleBackColor = true;
            rbtnTipoDoc.Click += rbtnTipo_Click;
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(312, 18);
            txtDoc.Margin = new Padding(3, 2, 3, 2);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(105, 23);
            txtDoc.TabIndex = 7;
            // 
            // btnDarBaja
            // 
            btnDarBaja.Location = new Point(227, 591);
            btnDarBaja.Margin = new Padding(3, 2, 3, 2);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(209, 43);
            btnDarBaja.TabIndex = 8;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.UseVisualStyleBackColor = true;
            btnDarBaja.Click += btnDarBaja_Click;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Location = new Point(657, 591);
            btnAutorizar.Margin = new Padding(3, 2, 3, 2);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(209, 43);
            btnAutorizar.TabIndex = 9;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = true;
            btnAutorizar.Click += btnAutorizar_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(872, 591);
            btnDetalles.Margin = new Padding(3, 2, 3, 2);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(209, 43);
            btnDetalles.TabIndex = 10;
            btnDetalles.Text = "Ver detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(843, 18);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(196, 23);
            txtNombre.TabIndex = 12;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Particular", "Empresa" });
            cboTipo.Location = new Point(584, 19);
            cboTipo.Margin = new Padding(3, 2, 3, 2);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(138, 23);
            cboTipo.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.Location = new Point(88, 22);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(67, 23);
            txtId.TabIndex = 14;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(776, 54);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(263, 28);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // gbxFiltros
            // 
            gbxFiltros.Controls.Add(rbtnActivosYAutorizados);
            gbxFiltros.Controls.Add(btnBuscar);
            gbxFiltros.Controls.Add(rbtnNoAutorizados);
            gbxFiltros.Controls.Add(rbtnAutorizados);
            gbxFiltros.Controls.Add(rbtnInactivos);
            gbxFiltros.Controls.Add(rbtnActivos);
            gbxFiltros.Controls.Add(rbtnTodos);
            gbxFiltros.Controls.Add(txtId);
            gbxFiltros.Controls.Add(cboTipo);
            gbxFiltros.Controls.Add(txtNombre);
            gbxFiltros.Controls.Add(txtDoc);
            gbxFiltros.Controls.Add(rbtnTipoDoc);
            gbxFiltros.Controls.Add(rbtnNombre);
            gbxFiltros.Controls.Add(rbtnDoc);
            gbxFiltros.Controls.Add(rbtnId);
            gbxFiltros.Location = new Point(12, 24);
            gbxFiltros.Margin = new Padding(3, 2, 3, 2);
            gbxFiltros.Name = "gbxFiltros";
            gbxFiltros.Padding = new Padding(3, 2, 3, 2);
            gbxFiltros.Size = new Size(1069, 94);
            gbxFiltros.TabIndex = 25;
            gbxFiltros.TabStop = false;
            gbxFiltros.Text = "Filtrar";
            // 
            // rbtnActivosYAutorizados
            // 
            rbtnActivosYAutorizados.AutoSize = true;
            rbtnActivosYAutorizados.Location = new Point(576, 63);
            rbtnActivosYAutorizados.Margin = new Padding(3, 2, 3, 2);
            rbtnActivosYAutorizados.Name = "rbtnActivosYAutorizados";
            rbtnActivosYAutorizados.Size = new Size(139, 19);
            rbtnActivosYAutorizados.TabIndex = 20;
            rbtnActivosYAutorizados.TabStop = true;
            rbtnActivosYAutorizados.Text = "Activos y Autorizados";
            rbtnActivosYAutorizados.UseVisualStyleBackColor = true;
            rbtnActivosYAutorizados.Click += rbtnActivosYAutorizados_Click;
            // 
            // rbtnNoAutorizados
            // 
            rbtnNoAutorizados.AutoSize = true;
            rbtnNoAutorizados.Location = new Point(428, 59);
            rbtnNoAutorizados.Margin = new Padding(3, 2, 3, 2);
            rbtnNoAutorizados.Name = "rbtnNoAutorizados";
            rbtnNoAutorizados.Size = new Size(105, 19);
            rbtnNoAutorizados.TabIndex = 19;
            rbtnNoAutorizados.TabStop = true;
            rbtnNoAutorizados.Text = "No autorizados";
            rbtnNoAutorizados.UseVisualStyleBackColor = true;
            rbtnNoAutorizados.Click += rbtnNoAutorizados_Click;
            // 
            // rbtnAutorizados
            // 
            rbtnAutorizados.AutoSize = true;
            rbtnAutorizados.Location = new Point(314, 59);
            rbtnAutorizados.Margin = new Padding(3, 2, 3, 2);
            rbtnAutorizados.Name = "rbtnAutorizados";
            rbtnAutorizados.Size = new Size(88, 19);
            rbtnAutorizados.TabIndex = 18;
            rbtnAutorizados.TabStop = true;
            rbtnAutorizados.Text = "Autorizados";
            rbtnAutorizados.UseVisualStyleBackColor = true;
            rbtnAutorizados.Click += rbtnAutorizados_Click;
            // 
            // rbtnInactivos
            // 
            rbtnInactivos.AutoSize = true;
            rbtnInactivos.Location = new Point(200, 59);
            rbtnInactivos.Margin = new Padding(3, 2, 3, 2);
            rbtnInactivos.Name = "rbtnInactivos";
            rbtnInactivos.Size = new Size(72, 19);
            rbtnInactivos.TabIndex = 17;
            rbtnInactivos.TabStop = true;
            rbtnInactivos.Text = "Inactivos";
            rbtnInactivos.UseVisualStyleBackColor = true;
            rbtnInactivos.Click += rbtnInactivos_Click;
            // 
            // rbtnActivos
            // 
            rbtnActivos.AutoSize = true;
            rbtnActivos.Location = new Point(116, 59);
            rbtnActivos.Margin = new Padding(3, 2, 3, 2);
            rbtnActivos.Name = "rbtnActivos";
            rbtnActivos.Size = new Size(64, 19);
            rbtnActivos.TabIndex = 16;
            rbtnActivos.TabStop = true;
            rbtnActivos.Text = "Activos";
            rbtnActivos.UseVisualStyleBackColor = true;
            rbtnActivos.Click += rbtnActivos_Click;
            // 
            // rbtnTodos
            // 
            rbtnTodos.AutoSize = true;
            rbtnTodos.Location = new Point(9, 59);
            rbtnTodos.Margin = new Padding(3, 2, 3, 2);
            rbtnTodos.Name = "rbtnTodos";
            rbtnTodos.Size = new Size(56, 19);
            rbtnTodos.TabIndex = 15;
            rbtnTodos.TabStop = true;
            rbtnTodos.Text = "Todos";
            rbtnTodos.UseVisualStyleBackColor = true;
            rbtnTodos.Click += rbtnTodos_Click;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(442, 591);
            btnAlta.Margin = new Padding(3, 2, 3, 2);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(209, 43);
            btnAlta.TabIndex = 26;
            btnAlta.Text = "Dar de alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // ListarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 645);
            Controls.Add(btnAlta);
            Controls.Add(gbxFiltros);
            Controls.Add(btnDetalles);
            Controls.Add(btnAutorizar);
            Controls.Add(btnDarBaja);
            Controls.Add(btnRegresar);
            Controls.Add(dgvClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListarCliente";
            Text = "Listar clientes";
            Load += VisualizarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbxFiltros.ResumeLayout(false);
            gbxFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnRegresar;
        private RadioButton rbtnId;
        private RadioButton rbtnDoc;
        private RadioButton rbtnNombre;
        private RadioButton rbtnTipoDoc;
        private TextBox txtDoc;
        private Button btnDarBaja;
        private Button btnAutorizar;
        private Button btnDetalles;
        private TextBox txtNombre;
        private ComboBox cboTipo;
        private TextBox txtId;
        private Button btnBuscar;
        private GroupBox gbxFiltros;
        private RadioButton rbtnActivos;
        private RadioButton rbtnTodos;
        private RadioButton rbtnActivosYAutorizados;
        private RadioButton rbtnNoAutorizados;
        private RadioButton rbtnAutorizados;
        private RadioButton rbtnInactivos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTipoDoc;
        private DataGridViewTextBoxColumn colDoc;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDir;
        private DataGridViewTextBoxColumn colAutorizado;
        private DataGridViewTextBoxColumn colActivo;
        private Button btnAlta;
    }
}