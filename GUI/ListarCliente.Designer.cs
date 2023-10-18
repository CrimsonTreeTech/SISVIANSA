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
            colId = new DataGridViewTextBoxColumn();
            colDocRut = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            rbtnFiltrarID = new RadioButton();
            rbtnFiltrarDoc = new RadioButton();
            rbtnFiltrarNombre = new RadioButton();
            rbtnFiltrarTipo = new RadioButton();
            btnReiniciar = new Button();
            txtDoc = new TextBox();
            btnDarBaja = new Button();
            btnAutorizar = new Button();
            btnDetalles = new Button();
            rbtnOrdenarID = new RadioButton();
            txtNombre = new TextBox();
            cboTipo = new ComboBox();
            txtId = new TextBox();
            cboOrdenId = new ComboBox();
            cboOrdenDoc = new ComboBox();
            rbtnOrdenDoc = new RadioButton();
            cboOrdenNombre = new ComboBox();
            rbtnOrdenNombre = new RadioButton();
            cboOrdenTipo = new ComboBox();
            rbtnOrdenTipo = new RadioButton();
            btnBuscar = new Button();
            gbxFiltros = new GroupBox();
            gbxOrden = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbxFiltros.SuspendLayout();
            gbxOrden.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { colId, colDocRut, colTipo, colNombre });
            dgvClientes.Location = new Point(45, 209);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(639, 262);
            dgvClientes.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 40;
            // 
            // colDocRut
            // 
            colDocRut.HeaderText = "Doc/RUTSss";
            colDocRut.Name = "colDocRut";
            colDocRut.ReadOnly = true;
            colDocRut.Width = 150;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo cliente";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            colTipo.Width = 150;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 245;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(45, 499);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(139, 31);
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
            rbtnFiltrarDoc.Location = new Point(9, 49);
            rbtnFiltrarDoc.Margin = new Padding(3, 2, 3, 2);
            rbtnFiltrarDoc.Name = "rbtnFiltrarDoc";
            rbtnFiltrarDoc.Size = new Size(75, 19);
            rbtnFiltrarDoc.TabIndex = 3;
            rbtnFiltrarDoc.TabStop = true;
            rbtnFiltrarDoc.Text = "Doc./RUT";
            rbtnFiltrarDoc.UseVisualStyleBackColor = true;
            rbtnFiltrarDoc.Click += rbtnFiltrarDoc_Click;
            // 
            // rbtnFiltrarNombre
            // 
            rbtnFiltrarNombre.AutoSize = true;
            rbtnFiltrarNombre.Location = new Point(9, 75);
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
            rbtnFiltrarTipo.Location = new Point(9, 100);
            rbtnFiltrarTipo.Margin = new Padding(3, 2, 3, 2);
            rbtnFiltrarTipo.Name = "rbtnFiltrarTipo";
            rbtnFiltrarTipo.Size = new Size(48, 19);
            rbtnFiltrarTipo.TabIndex = 5;
            rbtnFiltrarTipo.TabStop = true;
            rbtnFiltrarTipo.Text = "Tipo";
            rbtnFiltrarTipo.UseVisualStyleBackColor = true;
            rbtnFiltrarTipo.Click += rbtnFiltrarTipo_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(45, 18);
            btnReiniciar.Margin = new Padding(3, 2, 3, 2);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(273, 22);
            btnReiniciar.TabIndex = 6;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(94, 49);
            txtDoc.Margin = new Padding(3, 2, 3, 2);
            txtDoc.Name = "txtDoc";
            txtDoc.Size = new Size(162, 23);
            txtDoc.TabIndex = 7;
            // 
            // btnDarBaja
            // 
            btnDarBaja.Location = new Point(382, 499);
            btnDarBaja.Margin = new Padding(3, 2, 3, 2);
            btnDarBaja.Name = "btnDarBaja";
            btnDarBaja.Size = new Size(139, 31);
            btnDarBaja.TabIndex = 8;
            btnDarBaja.Text = "Dar de baja";
            btnDarBaja.UseVisualStyleBackColor = true;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Location = new Point(212, 499);
            btnAutorizar.Margin = new Padding(3, 2, 3, 2);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(139, 31);
            btnAutorizar.TabIndex = 9;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = true;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(545, 499);
            btnDetalles.Margin = new Padding(3, 2, 3, 2);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(139, 31);
            btnDetalles.TabIndex = 10;
            btnDetalles.Text = "Ver detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // rbtnOrdenarID
            // 
            rbtnOrdenarID.AutoSize = true;
            rbtnOrdenarID.Location = new Point(19, 22);
            rbtnOrdenarID.Margin = new Padding(3, 2, 3, 2);
            rbtnOrdenarID.Name = "rbtnOrdenarID";
            rbtnOrdenarID.Size = new Size(75, 19);
            rbtnOrdenarID.TabIndex = 11;
            rbtnOrdenarID.TabStop = true;
            rbtnOrdenarID.Text = "Id Cliente";
            rbtnOrdenarID.UseVisualStyleBackColor = true;
            rbtnOrdenarID.Click += rbtnOrdenarID_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(94, 75);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 23);
            txtNombre.TabIndex = 12;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Comun", "Empresa" });
            cboTipo.Location = new Point(94, 102);
            cboTipo.Margin = new Padding(3, 2, 3, 2);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(162, 23);
            cboTipo.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.Location = new Point(94, 22);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(162, 23);
            txtId.TabIndex = 14;
            // 
            // cboOrdenId
            // 
            cboOrdenId.AutoCompleteCustomSource.AddRange(new string[] { "A-Z", "Z-A" });
            cboOrdenId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrdenId.FormattingEnabled = true;
            cboOrdenId.Items.AddRange(new object[] { "A-Z", "Z-A" });
            cboOrdenId.Location = new Point(121, 22);
            cboOrdenId.Margin = new Padding(3, 2, 3, 2);
            cboOrdenId.Name = "cboOrdenId";
            cboOrdenId.Size = new Size(135, 23);
            cboOrdenId.TabIndex = 15;
            // 
            // cboOrdenDoc
            // 
            cboOrdenDoc.AutoCompleteCustomSource.AddRange(new string[] { "A-Z", "Z-A" });
            cboOrdenDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrdenDoc.FormattingEnabled = true;
            cboOrdenDoc.Items.AddRange(new object[] { "A-Z", "Z-A" });
            cboOrdenDoc.Location = new Point(121, 48);
            cboOrdenDoc.Margin = new Padding(3, 2, 3, 2);
            cboOrdenDoc.Name = "cboOrdenDoc";
            cboOrdenDoc.Size = new Size(135, 23);
            cboOrdenDoc.TabIndex = 17;
            // 
            // rbtnOrdenDoc
            // 
            rbtnOrdenDoc.AutoSize = true;
            rbtnOrdenDoc.Location = new Point(19, 51);
            rbtnOrdenDoc.Margin = new Padding(3, 2, 3, 2);
            rbtnOrdenDoc.Name = "rbtnOrdenDoc";
            rbtnOrdenDoc.Size = new Size(75, 19);
            rbtnOrdenDoc.TabIndex = 16;
            rbtnOrdenDoc.TabStop = true;
            rbtnOrdenDoc.Text = "Doc./RUT";
            rbtnOrdenDoc.UseVisualStyleBackColor = true;
            rbtnOrdenDoc.Click += rbtnOrdenDoc_Click;
            // 
            // cboOrdenNombre
            // 
            cboOrdenNombre.AutoCompleteCustomSource.AddRange(new string[] { "A-Z", "Z-A" });
            cboOrdenNombre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrdenNombre.FormattingEnabled = true;
            cboOrdenNombre.Items.AddRange(new object[] { "A-Z", "Z-A" });
            cboOrdenNombre.Location = new Point(121, 75);
            cboOrdenNombre.Margin = new Padding(3, 2, 3, 2);
            cboOrdenNombre.Name = "cboOrdenNombre";
            cboOrdenNombre.Size = new Size(135, 23);
            cboOrdenNombre.TabIndex = 19;
            // 
            // rbtnOrdenNombre
            // 
            rbtnOrdenNombre.AutoSize = true;
            rbtnOrdenNombre.Location = new Point(19, 78);
            rbtnOrdenNombre.Margin = new Padding(3, 2, 3, 2);
            rbtnOrdenNombre.Name = "rbtnOrdenNombre";
            rbtnOrdenNombre.Size = new Size(69, 19);
            rbtnOrdenNombre.TabIndex = 18;
            rbtnOrdenNombre.TabStop = true;
            rbtnOrdenNombre.Text = "Nombre";
            rbtnOrdenNombre.UseVisualStyleBackColor = true;
            rbtnOrdenNombre.Click += rbtnOrdenNombre_Click;
            // 
            // cboOrdenTipo
            // 
            cboOrdenTipo.AutoCompleteCustomSource.AddRange(new string[] { "A-Z", "Z-A" });
            cboOrdenTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrdenTipo.FormattingEnabled = true;
            cboOrdenTipo.Items.AddRange(new object[] { "A-Z", "Z-A" });
            cboOrdenTipo.Location = new Point(121, 102);
            cboOrdenTipo.Margin = new Padding(3, 2, 3, 2);
            cboOrdenTipo.Name = "cboOrdenTipo";
            cboOrdenTipo.Size = new Size(135, 23);
            cboOrdenTipo.TabIndex = 21;
            // 
            // rbtnOrdenTipo
            // 
            rbtnOrdenTipo.AutoSize = true;
            rbtnOrdenTipo.Location = new Point(19, 105);
            rbtnOrdenTipo.Margin = new Padding(3, 2, 3, 2);
            rbtnOrdenTipo.Name = "rbtnOrdenTipo";
            rbtnOrdenTipo.Size = new Size(48, 19);
            rbtnOrdenTipo.TabIndex = 20;
            rbtnOrdenTipo.TabStop = true;
            rbtnOrdenTipo.Text = "Tipo";
            rbtnOrdenTipo.UseVisualStyleBackColor = true;
            rbtnOrdenTipo.Click += rbtnOrdenTipo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(411, 18);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(273, 22);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // gbxFiltros
            // 
            gbxFiltros.Controls.Add(txtId);
            gbxFiltros.Controls.Add(cboTipo);
            gbxFiltros.Controls.Add(txtNombre);
            gbxFiltros.Controls.Add(txtDoc);
            gbxFiltros.Controls.Add(rbtnFiltrarTipo);
            gbxFiltros.Controls.Add(rbtnFiltrarNombre);
            gbxFiltros.Controls.Add(rbtnFiltrarDoc);
            gbxFiltros.Controls.Add(rbtnFiltrarID);
            gbxFiltros.Location = new Point(45, 54);
            gbxFiltros.Margin = new Padding(3, 2, 3, 2);
            gbxFiltros.Name = "gbxFiltros";
            gbxFiltros.Padding = new Padding(3, 2, 3, 2);
            gbxFiltros.Size = new Size(273, 131);
            gbxFiltros.TabIndex = 25;
            gbxFiltros.TabStop = false;
            gbxFiltros.Text = "Filtrar";
            // 
            // gbxOrden
            // 
            gbxOrden.Controls.Add(cboOrdenTipo);
            gbxOrden.Controls.Add(rbtnOrdenTipo);
            gbxOrden.Controls.Add(cboOrdenNombre);
            gbxOrden.Controls.Add(rbtnOrdenNombre);
            gbxOrden.Controls.Add(cboOrdenDoc);
            gbxOrden.Controls.Add(rbtnOrdenDoc);
            gbxOrden.Controls.Add(cboOrdenId);
            gbxOrden.Controls.Add(rbtnOrdenarID);
            gbxOrden.Location = new Point(411, 54);
            gbxOrden.Margin = new Padding(3, 2, 3, 2);
            gbxOrden.Name = "gbxOrden";
            gbxOrden.Padding = new Padding(3, 2, 3, 2);
            gbxOrden.Size = new Size(273, 131);
            gbxOrden.TabIndex = 26;
            gbxOrden.TabStop = false;
            gbxOrden.Text = "Ordenar";
            // 
            // ListarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 548);
            Controls.Add(gbxOrden);
            Controls.Add(gbxFiltros);
            Controls.Add(btnBuscar);
            Controls.Add(btnDetalles);
            Controls.Add(btnAutorizar);
            Controls.Add(btnDarBaja);
            Controls.Add(btnReiniciar);
            Controls.Add(btnRegresar);
            Controls.Add(dgvClientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarCliente";
            Text = "ListarClientes";
            Load += VisualizarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbxFiltros.ResumeLayout(false);
            gbxFiltros.PerformLayout();
            gbxOrden.ResumeLayout(false);
            gbxOrden.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private Button btnRegresar;
        private RadioButton rbtnFiltrarID;
        private RadioButton rbtnFiltrarDoc;
        private RadioButton rbtnFiltrarNombre;
        private RadioButton rbtnFiltrarTipo;
        private Button btnReiniciar;
        private TextBox txtDoc;
        private Button btnDarBaja;
        private Button btnAutorizar;
        private Button btnDetalles;
        private RadioButton rbtnOrdenarID;
        private TextBox txtNombre;
        private ComboBox cboTipo;
        private TextBox txtId;
        private ComboBox cboOrdenId;
        private ComboBox cboOrdenDoc;
        private RadioButton rbtnOrdenDoc;
        private ComboBox cboOrdenNombre;
        private RadioButton rbtnOrdenNombre;
        private ComboBox cboOrdenTipo;
        private RadioButton rbtnOrdenTipo;
        private Button btnBuscar;
        private GroupBox gbxFiltros;
        private GroupBox gbxOrden;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDocRut;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colNombre;
    }
}