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
            dgvClientes = new DataGridView();
            btnRegresar = new Button();
            rbtnFiltrarID = new RadioButton();
            rbtnFiltrarDoc = new RadioButton();
            rbtnFiltrarNombre = new RadioButton();
            rbtnFiltrarTipo = new RadioButton();
            txtDoc = new TextBox();
            btnDarBaja = new Button();
            btnAutorizar = new Button();
            btnDetalles = new Button();
            txtNombre = new TextBox();
            cboTipo = new ComboBox();
            txtId = new TextBox();
            btnBuscar = new Button();
            gbxFiltros = new GroupBox();
            colId = new DataGridViewTextBoxColumn();
            colTipoDoc = new DataGridViewTextBoxColumn();
            colDoc = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colDir = new DataGridViewTextBoxColumn();
            colAutorizado = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            rbtnTodos = new RadioButton();
            rbtnActivos = new RadioButton();
            rbtnInactivos = new RadioButton();
            rbtnAutorizados = new RadioButton();
            rbtnNoAutorizados = new RadioButton();
            rbtnActivosYAutorizados = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbxFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
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
            dgvClientes.Size = new Size(1286, 442);
            dgvClientes.TabIndex = 0;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 591);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(317, 43);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // rbtnFiltrarID
            // 
            rbtnFiltrarID.AutoSize = true;
            rbtnFiltrarID.Location = new Point(9, 22);
            rbtnFiltrarID.Margin = new Padding(3, 2, 3, 2);
            rbtnFiltrarID.Name = "rbtnFiltrarID";
            rbtnFiltrarID.Size = new Size(73, 19);
            rbtnFiltrarID.TabIndex = 2;
            rbtnFiltrarID.TabStop = true;
            rbtnFiltrarID.Text = "Id cliente";
            rbtnFiltrarID.UseVisualStyleBackColor = true;
            rbtnFiltrarID.Click += rbtnFiltrarID_Click;
            // 
            // rbtnFiltrarDoc
            // 
            rbtnFiltrarDoc.AutoSize = true;
            rbtnFiltrarDoc.Location = new Point(196, 23);
            rbtnFiltrarDoc.Margin = new Padding(3, 2, 3, 2);
            rbtnFiltrarDoc.Name = "rbtnFiltrarDoc";
            rbtnFiltrarDoc.Size = new Size(49, 19);
            rbtnFiltrarDoc.TabIndex = 3;
            rbtnFiltrarDoc.TabStop = true;
            rbtnFiltrarDoc.Text = "Doc.";
            rbtnFiltrarDoc.UseVisualStyleBackColor = true;
            rbtnFiltrarDoc.Click += rbtnFiltrarDoc_Click;
            // 
            // rbtnFiltrarNombre
            // 
            rbtnFiltrarNombre.AutoSize = true;
            rbtnFiltrarNombre.Location = new Point(663, 26);
            rbtnFiltrarNombre.Margin = new Padding(3, 2, 3, 2);
            rbtnFiltrarNombre.Name = "rbtnFiltrarNombre";
            rbtnFiltrarNombre.Size = new Size(69, 19);
            rbtnFiltrarNombre.TabIndex = 4;
            rbtnFiltrarNombre.TabStop = true;
            rbtnFiltrarNombre.Text = "Nombre";
            rbtnFiltrarNombre.UseVisualStyleBackColor = true;
            rbtnFiltrarNombre.Click += rbtnFiltrarNombre_Click;
            // 
            // rbtnFiltrarTipo
            // 
            rbtnFiltrarTipo.AutoSize = true;
            rbtnFiltrarTipo.Location = new Point(393, 24);
            rbtnFiltrarTipo.Margin = new Padding(3, 2, 3, 2);
            rbtnFiltrarTipo.Name = "rbtnFiltrarTipo";
            rbtnFiltrarTipo.Size = new Size(86, 19);
            rbtnFiltrarTipo.TabIndex = 5;
            rbtnFiltrarTipo.TabStop = true;
            rbtnFiltrarTipo.Text = "Tipo cliente";
            rbtnFiltrarTipo.UseVisualStyleBackColor = true;
            rbtnFiltrarTipo.Click += rbtnFiltrarTipo_Click;
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(251, 21);
            txtDoc.Margin = new Padding(3, 2, 3, 2);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(105, 23);
            txtDoc.TabIndex = 7;
            // 
            // btnDarBaja
            // 
            btnDarBaja.Location = new Point(335, 591);
            btnDarBaja.Margin = new Padding(3, 2, 3, 2);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(317, 43);
            btnDarBaja.TabIndex = 8;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.UseVisualStyleBackColor = true;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Location = new Point(658, 591);
            btnAutorizar.Margin = new Padding(3, 2, 3, 2);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(317, 43);
            btnAutorizar.TabIndex = 9;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = true;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(981, 591);
            btnDetalles.Margin = new Padding(3, 2, 3, 2);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(317, 43);
            btnDetalles.TabIndex = 10;
            btnDetalles.Text = "Ver detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(738, 22);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 23);
            txtNombre.TabIndex = 12;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Comun", "Empresa" });
            cboTipo.Location = new Point(483, 22);
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
            btnBuscar.Location = new Point(1003, 26);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(263, 52);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
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
            gbxFiltros.Controls.Add(rbtnFiltrarTipo);
            gbxFiltros.Controls.Add(rbtnFiltrarNombre);
            gbxFiltros.Controls.Add(rbtnFiltrarDoc);
            gbxFiltros.Controls.Add(rbtnFiltrarID);
            gbxFiltros.Location = new Point(12, 24);
            gbxFiltros.Margin = new Padding(3, 2, 3, 2);
            gbxFiltros.Name = "gbxFiltros";
            gbxFiltros.Padding = new Padding(3, 2, 3, 2);
            gbxFiltros.Size = new Size(1284, 94);
            gbxFiltros.TabIndex = 25;
            gbxFiltros.TabStop = false;
            gbxFiltros.Text = "Filtrar";
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
            colNombre.Width = 300;
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
            // rbtnActivos
            // 
            rbtnActivos.AutoSize = true;
            rbtnActivos.Location = new Point(200, 59);
            rbtnActivos.Margin = new Padding(3, 2, 3, 2);
            rbtnActivos.Name = "rbtnActivos";
            rbtnActivos.Size = new Size(64, 19);
            rbtnActivos.TabIndex = 16;
            rbtnActivos.TabStop = true;
            rbtnActivos.Text = "Activos";
            rbtnActivos.UseVisualStyleBackColor = true;
            // 
            // rbtnInactivos
            // 
            rbtnInactivos.AutoSize = true;
            rbtnInactivos.Location = new Point(284, 59);
            rbtnInactivos.Margin = new Padding(3, 2, 3, 2);
            rbtnInactivos.Name = "rbtnInactivos";
            rbtnInactivos.Size = new Size(72, 19);
            rbtnInactivos.TabIndex = 17;
            rbtnInactivos.TabStop = true;
            rbtnInactivos.Text = "Inactivos";
            rbtnInactivos.UseVisualStyleBackColor = true;
            // 
            // rbtnAutorizados
            // 
            rbtnAutorizados.AutoSize = true;
            rbtnAutorizados.Location = new Point(483, 59);
            rbtnAutorizados.Margin = new Padding(3, 2, 3, 2);
            rbtnAutorizados.Name = "rbtnAutorizados";
            rbtnAutorizados.Size = new Size(88, 19);
            rbtnAutorizados.TabIndex = 18;
            rbtnAutorizados.TabStop = true;
            rbtnAutorizados.Text = "Autorizados";
            rbtnAutorizados.UseVisualStyleBackColor = true;
            // 
            // rbtnNoAutorizados
            // 
            rbtnNoAutorizados.AutoSize = true;
            rbtnNoAutorizados.Location = new Point(597, 59);
            rbtnNoAutorizados.Margin = new Padding(3, 2, 3, 2);
            rbtnNoAutorizados.Name = "rbtnNoAutorizados";
            rbtnNoAutorizados.Size = new Size(105, 19);
            rbtnNoAutorizados.TabIndex = 19;
            rbtnNoAutorizados.TabStop = true;
            rbtnNoAutorizados.Text = "No autorizados";
            rbtnNoAutorizados.UseVisualStyleBackColor = true;
            // 
            // rbtnActivosYAutorizados
            // 
            rbtnActivosYAutorizados.AutoSize = true;
            rbtnActivosYAutorizados.Location = new Point(824, 59);
            rbtnActivosYAutorizados.Margin = new Padding(3, 2, 3, 2);
            rbtnActivosYAutorizados.Name = "rbtnActivosYAutorizados";
            rbtnActivosYAutorizados.Size = new Size(139, 19);
            rbtnActivosYAutorizados.TabIndex = 20;
            rbtnActivosYAutorizados.TabStop = true;
            rbtnActivosYAutorizados.Text = "Activos y Autorizados";
            rbtnActivosYAutorizados.UseVisualStyleBackColor = true;
            // 
            // ListarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 645);
            Controls.Add(gbxFiltros);
            Controls.Add(btnDetalles);
            Controls.Add(btnAutorizar);
            Controls.Add(btnDarBaja);
            Controls.Add(btnRegresar);
            Controls.Add(dgvClientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarCliente";
            Text = "ListarClientes";
            Load += VisualizarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbxFiltros.ResumeLayout(false);
            gbxFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnRegresar;
        private RadioButton rbtnFiltrarID;
        private RadioButton rbtnFiltrarDoc;
        private RadioButton rbtnFiltrarNombre;
        private RadioButton rbtnFiltrarTipo;
        private TextBox txtDoc;
        private Button btnDarBaja;
        private Button btnAutorizar;
        private Button btnDetalles;
        private TextBox txtNombre;
        private ComboBox cboTipo;
        private TextBox txtId;
        private Button btnBuscar;
        private GroupBox gbxFiltros;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTipoDoc;
        private DataGridViewTextBoxColumn colDoc;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDir;
        private DataGridViewTextBoxColumn colAutorizado;
        private DataGridViewTextBoxColumn colActivo;
        private RadioButton rbtnActivos;
        private RadioButton rbtnTodos;
        private RadioButton rbtnActivosYAutorizados;
        private RadioButton rbtnNoAutorizados;
        private RadioButton rbtnAutorizados;
        private RadioButton rbtnInactivos;
    }
}