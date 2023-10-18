namespace SISVIANSA_ITI_2023.GUI
{
    partial class ListarMenus
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
            GroupBox gbxFiltrar;
            GroupBox gbxOrdenar;
            chLstDieta = new CheckedListBox();
            rbtnFiltroDieta = new RadioButton();
            rbtnFiltroActivo = new RadioButton();
            rbtnFiltroInactivo = new RadioButton();
            rbtnFiltroAutorizado = new RadioButton();
            cboFiltroTipo = new ComboBox();
            rbtnFiltrarTipo = new RadioButton();
            txtFiltroNombre = new TextBox();
            rbtnFiltroNoAutorizados = new RadioButton();
            rbtnFiltroNombre = new RadioButton();
            cboOrdenPrecio = new ComboBox();
            rbtnOrdenPrecio = new RadioButton();
            cboOrdenTipo = new ComboBox();
            cboOrdenNombre = new ComboBox();
            rbtnOrdenTipo = new RadioButton();
            rbtnOrdenNombre = new RadioButton();
            dgvMenu = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTipoMenu = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colAutorizado = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            btnDetalles = new Button();
            btnModificar = new Button();
            btnBaja = new Button();
            btnAutorizar = new Button();
            btnReiniciar = new Button();
            btnBuscar = new Button();
            gbxFiltrar = new GroupBox();
            gbxOrdenar = new GroupBox();
            gbxFiltrar.SuspendLayout();
            gbxOrdenar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            SuspendLayout();
            // 
            // gbxFiltrar
            // 
            gbxFiltrar.Controls.Add(chLstDieta);
            gbxFiltrar.Controls.Add(rbtnFiltroDieta);
            gbxFiltrar.Controls.Add(rbtnFiltroActivo);
            gbxFiltrar.Controls.Add(rbtnFiltroInactivo);
            gbxFiltrar.Controls.Add(rbtnFiltroAutorizado);
            gbxFiltrar.Controls.Add(cboFiltroTipo);
            gbxFiltrar.Controls.Add(rbtnFiltrarTipo);
            gbxFiltrar.Controls.Add(txtFiltroNombre);
            gbxFiltrar.Controls.Add(rbtnFiltroNoAutorizados);
            gbxFiltrar.Controls.Add(rbtnFiltroNombre);
            gbxFiltrar.Location = new Point(618, 122);
            gbxFiltrar.Name = "gbxFiltrar";
            gbxFiltrar.Size = new Size(269, 279);
            gbxFiltrar.TabIndex = 1;
            gbxFiltrar.TabStop = false;
            gbxFiltrar.Text = "Filtrar";
            // 
            // chLstDieta
            // 
            chLstDieta.FormattingEnabled = true;
            chLstDieta.Location = new Point(81, 154);
            chLstDieta.Name = "chLstDieta";
            chLstDieta.Size = new Size(174, 112);
            chLstDieta.TabIndex = 11;
            // 
            // rbtnFiltroDieta
            // 
            rbtnFiltroDieta.AutoSize = true;
            rbtnFiltroDieta.Location = new Point(6, 154);
            rbtnFiltroDieta.Name = "rbtnFiltroDieta";
            rbtnFiltroDieta.Size = new Size(52, 19);
            rbtnFiltroDieta.TabIndex = 10;
            rbtnFiltroDieta.TabStop = true;
            rbtnFiltroDieta.Text = "Dieta";
            rbtnFiltroDieta.UseVisualStyleBackColor = true;
            // 
            // rbtnFiltroActivo
            // 
            rbtnFiltroActivo.AutoSize = true;
            rbtnFiltroActivo.Location = new Point(6, 115);
            rbtnFiltroActivo.Name = "rbtnFiltroActivo";
            rbtnFiltroActivo.Size = new Size(59, 19);
            rbtnFiltroActivo.TabIndex = 9;
            rbtnFiltroActivo.TabStop = true;
            rbtnFiltroActivo.Text = "Activo";
            rbtnFiltroActivo.UseVisualStyleBackColor = true;
            // 
            // rbtnFiltroInactivo
            // 
            rbtnFiltroInactivo.AutoSize = true;
            rbtnFiltroInactivo.Location = new Point(113, 115);
            rbtnFiltroInactivo.Name = "rbtnFiltroInactivo";
            rbtnFiltroInactivo.Size = new Size(67, 19);
            rbtnFiltroInactivo.TabIndex = 8;
            rbtnFiltroInactivo.TabStop = true;
            rbtnFiltroInactivo.Text = "Inactivo";
            rbtnFiltroInactivo.UseVisualStyleBackColor = true;
            // 
            // rbtnFiltroAutorizado
            // 
            rbtnFiltroAutorizado.AutoSize = true;
            rbtnFiltroAutorizado.Location = new Point(6, 90);
            rbtnFiltroAutorizado.Name = "rbtnFiltroAutorizado";
            rbtnFiltroAutorizado.Size = new Size(88, 19);
            rbtnFiltroAutorizado.TabIndex = 7;
            rbtnFiltroAutorizado.TabStop = true;
            rbtnFiltroAutorizado.Text = "Autorizados";
            rbtnFiltroAutorizado.UseVisualStyleBackColor = true;
            // 
            // cboFiltroTipo
            // 
            cboFiltroTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroTipo.FormattingEnabled = true;
            cboFiltroTipo.Items.AddRange(new object[] { "Semanal", "Quincenal", "Mensual" });
            cboFiltroTipo.Location = new Point(81, 60);
            cboFiltroTipo.Name = "cboFiltroTipo";
            cboFiltroTipo.Size = new Size(174, 23);
            cboFiltroTipo.TabIndex = 6;
            // 
            // rbtnFiltrarTipo
            // 
            rbtnFiltrarTipo.AutoSize = true;
            rbtnFiltrarTipo.Location = new Point(6, 61);
            rbtnFiltrarTipo.Name = "rbtnFiltrarTipo";
            rbtnFiltrarTipo.Size = new Size(48, 19);
            rbtnFiltrarTipo.TabIndex = 5;
            rbtnFiltrarTipo.TabStop = true;
            rbtnFiltrarTipo.Text = "Tipo";
            rbtnFiltrarTipo.UseVisualStyleBackColor = true;
            rbtnFiltrarTipo.Click += rbtnFiltrarTipo_Click;
            // 
            // txtFiltroNombre
            // 
            txtFiltroNombre.Location = new Point(81, 28);
            txtFiltroNombre.Name = "txtFiltroNombre";
            txtFiltroNombre.Size = new Size(174, 23);
            txtFiltroNombre.TabIndex = 3;
            // 
            // rbtnFiltroNoAutorizados
            // 
            rbtnFiltroNoAutorizados.AutoSize = true;
            rbtnFiltroNoAutorizados.Location = new Point(113, 90);
            rbtnFiltroNoAutorizados.Name = "rbtnFiltroNoAutorizados";
            rbtnFiltroNoAutorizados.Size = new Size(105, 19);
            rbtnFiltroNoAutorizados.TabIndex = 2;
            rbtnFiltroNoAutorizados.TabStop = true;
            rbtnFiltroNoAutorizados.Text = "No autorizados";
            rbtnFiltroNoAutorizados.UseVisualStyleBackColor = true;
            rbtnFiltroNoAutorizados.Click += rbtnNoAutorizados_Click;
            // 
            // rbtnFiltroNombre
            // 
            rbtnFiltroNombre.AutoSize = true;
            rbtnFiltroNombre.Location = new Point(6, 32);
            rbtnFiltroNombre.Name = "rbtnFiltroNombre";
            rbtnFiltroNombre.Size = new Size(69, 19);
            rbtnFiltroNombre.TabIndex = 0;
            rbtnFiltroNombre.TabStop = true;
            rbtnFiltroNombre.Text = "Nombre";
            rbtnFiltroNombre.UseVisualStyleBackColor = true;
            rbtnFiltroNombre.Click += rbtnFiltroNombre_Click;
            // 
            // gbxOrdenar
            // 
            gbxOrdenar.Controls.Add(cboOrdenPrecio);
            gbxOrdenar.Controls.Add(rbtnOrdenPrecio);
            gbxOrdenar.Controls.Add(cboOrdenTipo);
            gbxOrdenar.Controls.Add(cboOrdenNombre);
            gbxOrdenar.Controls.Add(rbtnOrdenTipo);
            gbxOrdenar.Controls.Add(rbtnOrdenNombre);
            gbxOrdenar.Location = new Point(618, 423);
            gbxOrdenar.Name = "gbxOrdenar";
            gbxOrdenar.Size = new Size(269, 132);
            gbxOrdenar.TabIndex = 2;
            gbxOrdenar.TabStop = false;
            gbxOrdenar.Text = "Ordenar";
            // 
            // cboOrdenPrecio
            // 
            cboOrdenPrecio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrdenPrecio.FormattingEnabled = true;
            cboOrdenPrecio.Items.AddRange(new object[] { "A-Z", "Z-A" });
            cboOrdenPrecio.Location = new Point(101, 91);
            cboOrdenPrecio.Name = "cboOrdenPrecio";
            cboOrdenPrecio.Size = new Size(141, 23);
            cboOrdenPrecio.TabIndex = 12;
            // 
            // rbtnOrdenPrecio
            // 
            rbtnOrdenPrecio.AutoSize = true;
            rbtnOrdenPrecio.Location = new Point(6, 95);
            rbtnOrdenPrecio.Name = "rbtnOrdenPrecio";
            rbtnOrdenPrecio.Size = new Size(58, 19);
            rbtnOrdenPrecio.TabIndex = 11;
            rbtnOrdenPrecio.TabStop = true;
            rbtnOrdenPrecio.Text = "Precio";
            rbtnOrdenPrecio.UseVisualStyleBackColor = true;
            // 
            // cboOrdenTipo
            // 
            cboOrdenTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrdenTipo.FormattingEnabled = true;
            cboOrdenTipo.Items.AddRange(new object[] { "A-Z", "Z-A" });
            cboOrdenTipo.Location = new Point(101, 57);
            cboOrdenTipo.Name = "cboOrdenTipo";
            cboOrdenTipo.Size = new Size(141, 23);
            cboOrdenTipo.TabIndex = 10;
            // 
            // cboOrdenNombre
            // 
            cboOrdenNombre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrdenNombre.FormattingEnabled = true;
            cboOrdenNombre.Items.AddRange(new object[] { "A-Z", "Z-A" });
            cboOrdenNombre.Location = new Point(101, 28);
            cboOrdenNombre.Name = "cboOrdenNombre";
            cboOrdenNombre.Size = new Size(141, 23);
            cboOrdenNombre.TabIndex = 7;
            // 
            // rbtnOrdenTipo
            // 
            rbtnOrdenTipo.AutoSize = true;
            rbtnOrdenTipo.Location = new Point(6, 61);
            rbtnOrdenTipo.Name = "rbtnOrdenTipo";
            rbtnOrdenTipo.Size = new Size(48, 19);
            rbtnOrdenTipo.TabIndex = 5;
            rbtnOrdenTipo.TabStop = true;
            rbtnOrdenTipo.Text = "Tipo";
            rbtnOrdenTipo.UseVisualStyleBackColor = true;
            rbtnOrdenTipo.Click += rbtnOrdenTipo_Click;
            // 
            // rbtnOrdenNombre
            // 
            rbtnOrdenNombre.AutoSize = true;
            rbtnOrdenNombre.Location = new Point(6, 32);
            rbtnOrdenNombre.Name = "rbtnOrdenNombre";
            rbtnOrdenNombre.Size = new Size(69, 19);
            rbtnOrdenNombre.TabIndex = 0;
            rbtnOrdenNombre.TabStop = true;
            rbtnOrdenNombre.Text = "Nombre";
            rbtnOrdenNombre.UseVisualStyleBackColor = true;
            rbtnOrdenNombre.Click += rbtnOrdenNombre_Click;
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Columns.AddRange(new DataGridViewColumn[] { colId, colTipoMenu, colPrecio, colAutorizado, colActivo });
            dgvMenu.Location = new Point(23, 21);
            dgvMenu.MultiSelect = false;
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowTemplate.Height = 25;
            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.Size = new Size(564, 534);
            dgvMenu.TabIndex = 0;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 80;
            // 
            // colTipoMenu
            // 
            colTipoMenu.HeaderText = "Tipo menu";
            colTipoMenu.Name = "colTipoMenu";
            colTipoMenu.ReadOnly = true;
            colTipoMenu.Width = 140;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colAutorizado
            // 
            colAutorizado.HeaderText = "Autorizado";
            colAutorizado.Name = "colAutorizado";
            colAutorizado.ReadOnly = true;
            // 
            // colActivo
            // 
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(23, 582);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(168, 33);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(197, 582);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(168, 33);
            btnDetalles.TabIndex = 4;
            btnDetalles.Text = "Ver detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(719, 582);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(168, 33);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(545, 582);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(168, 33);
            btnBaja.TabIndex = 6;
            btnBaja.Text = "Dar de Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Location = new Point(371, 582);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(168, 33);
            btnAutorizar.TabIndex = 7;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(618, 72);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(269, 29);
            btnReiniciar.TabIndex = 8;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(618, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(269, 29);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ListarMenus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 627);
            Controls.Add(btnBuscar);
            Controls.Add(btnReiniciar);
            Controls.Add(btnAutorizar);
            Controls.Add(btnBaja);
            Controls.Add(btnModificar);
            Controls.Add(btnDetalles);
            Controls.Add(btnRegresar);
            Controls.Add(gbxOrdenar);
            Controls.Add(gbxFiltrar);
            Controls.Add(dgvMenu);
            Name = "ListarMenus";
            Text = "ListarMenus";
            Load += ListarMenus_Load;
            gbxFiltrar.ResumeLayout(false);
            gbxFiltrar.PerformLayout();
            gbxOrdenar.ResumeLayout(false);
            gbxOrdenar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMenu;
        private ComboBox cboFiltroTipo;
        private RadioButton rbtnFiltrarTipo;
        private TextBox txtFiltroNombre;
        private RadioButton rbtnFiltroNoAutorizados;
        private RadioButton rbtnFiltroNombre;
        private ComboBox cboOrdenNombre;
        private RadioButton rbtnOrdenTipo;
        private RadioButton rbtnOrdenDieta;
        private RadioButton rbtnOrdenNombre;
        private ComboBox cboOrdenTipo;
        private ComboBox cboOrdenDieta;
        private Button btnRegresar;
        private Button btnDetalles;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnAutorizar;
        private Button btnReiniciar;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn colDieta;
        private RadioButton rbtnFiltroActivo;
        private RadioButton rbtnFiltroInactivo;
        private RadioButton rbtnFiltroAutorizado;
        private ComboBox cboOrdenPrecio;
        private RadioButton rbtnOrdenPrecio;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTipoMenu;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colAutorizado;
        private DataGridViewTextBoxColumn colActivo;
        private CheckedListBox chLstDieta;
        private RadioButton rbtnFiltroDieta;
    }
}