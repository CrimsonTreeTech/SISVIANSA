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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarMenus));
            rbtnTodo = new RadioButton();
            chkLstDietas = new CheckedListBox();
            rbtnDieta = new RadioButton();
            rbtnActivo = new RadioButton();
            rbtnInactivo = new RadioButton();
            rbtnAutorizado = new RadioButton();
            cboTipo = new ComboBox();
            rbtnTipo = new RadioButton();
            txtMenu = new TextBox();
            rbtnNoAutorizados = new RadioButton();
            rbtnMenu = new RadioButton();
            dgvMenu = new DataGridView();
            colMenu = new DataGridViewTextBoxColumn();
            colTipoMenu = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colAutorizado = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            colDietas = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            btnDetalles = new Button();
            btnModificar = new Button();
            btnBaja = new Button();
            btnAutorizar = new Button();
            btnBuscar = new Button();
            btnAlta = new Button();
            gbxFiltrar = new GroupBox();
            gbxFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            SuspendLayout();
            // 
            // gbxFiltrar
            // 
            gbxFiltrar.Controls.Add(rbtnTodo);
            gbxFiltrar.Controls.Add(chkLstDietas);
            gbxFiltrar.Controls.Add(rbtnDieta);
            gbxFiltrar.Controls.Add(rbtnActivo);
            gbxFiltrar.Controls.Add(rbtnInactivo);
            gbxFiltrar.Controls.Add(rbtnAutorizado);
            gbxFiltrar.Controls.Add(cboTipo);
            gbxFiltrar.Controls.Add(rbtnTipo);
            gbxFiltrar.Controls.Add(txtMenu);
            gbxFiltrar.Controls.Add(rbtnNoAutorizados);
            gbxFiltrar.Controls.Add(rbtnMenu);
            gbxFiltrar.Location = new Point(12, 12);
            gbxFiltrar.Name = "gbxFiltrar";
            gbxFiltrar.Size = new Size(803, 100);
            gbxFiltrar.TabIndex = 1;
            gbxFiltrar.TabStop = false;
            gbxFiltrar.Text = "Filtrar";
            // 
            // rbtnTodo
            // 
            rbtnTodo.AutoSize = true;
            rbtnTodo.Location = new Point(6, 31);
            rbtnTodo.Name = "rbtnTodo";
            rbtnTodo.Size = new Size(51, 19);
            rbtnTodo.TabIndex = 12;
            rbtnTodo.TabStop = true;
            rbtnTodo.Text = "Todo";
            rbtnTodo.UseVisualStyleBackColor = true;
            rbtnTodo.Click += rbtnTodo_Click;
            // 
            // chkLstDietas
            // 
            chkLstDietas.FormattingEnabled = true;
            chkLstDietas.Location = new Point(646, 29);
            chkLstDietas.Name = "chkLstDietas";
            chkLstDietas.Size = new Size(149, 58);
            chkLstDietas.TabIndex = 11;
            // 
            // rbtnDieta
            // 
            rbtnDieta.AutoSize = true;
            rbtnDieta.Location = new Point(588, 29);
            rbtnDieta.Name = "rbtnDieta";
            rbtnDieta.Size = new Size(52, 19);
            rbtnDieta.TabIndex = 10;
            rbtnDieta.TabStop = true;
            rbtnDieta.Text = "Dieta";
            rbtnDieta.UseVisualStyleBackColor = true;
            rbtnDieta.Click += rbtnDieta_Click;
            // 
            // rbtnActivo
            // 
            rbtnActivo.AutoSize = true;
            rbtnActivo.Location = new Point(487, 30);
            rbtnActivo.Name = "rbtnActivo";
            rbtnActivo.Size = new Size(59, 19);
            rbtnActivo.TabIndex = 9;
            rbtnActivo.TabStop = true;
            rbtnActivo.Text = "Activo";
            rbtnActivo.UseVisualStyleBackColor = true;
            rbtnActivo.Click += rbtnActivo_Click;
            // 
            // rbtnInactivo
            // 
            rbtnInactivo.AutoSize = true;
            rbtnInactivo.Location = new Point(487, 63);
            rbtnInactivo.Name = "rbtnInactivo";
            rbtnInactivo.Size = new Size(67, 19);
            rbtnInactivo.TabIndex = 8;
            rbtnInactivo.TabStop = true;
            rbtnInactivo.Text = "Inactivo";
            rbtnInactivo.UseVisualStyleBackColor = true;
            rbtnInactivo.Click += rbtnInactivo_Click;
            // 
            // rbtnAutorizado
            // 
            rbtnAutorizado.AutoSize = true;
            rbtnAutorizado.Location = new Point(350, 31);
            rbtnAutorizado.Name = "rbtnAutorizado";
            rbtnAutorizado.Size = new Size(88, 19);
            rbtnAutorizado.TabIndex = 7;
            rbtnAutorizado.TabStop = true;
            rbtnAutorizado.Text = "Autorizados";
            rbtnAutorizado.UseVisualStyleBackColor = true;
            rbtnAutorizado.Click += rbtnAutorizado_Click;
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Semanal", "Quincenal", "Mensual" });
            cboTipo.Location = new Point(165, 62);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(146, 23);
            cboTipo.TabIndex = 6;
            // 
            // rbtnTipo
            // 
            rbtnTipo.AutoSize = true;
            rbtnTipo.Location = new Point(90, 63);
            rbtnTipo.Name = "rbtnTipo";
            rbtnTipo.Size = new Size(48, 19);
            rbtnTipo.TabIndex = 5;
            rbtnTipo.TabStop = true;
            rbtnTipo.Text = "Tipo";
            rbtnTipo.UseVisualStyleBackColor = true;
            rbtnTipo.Click += rbtnTipo_Click;
            // 
            // txtMenu
            // 
            txtMenu.Location = new Point(165, 29);
            txtMenu.Name = "txtMenu";
            txtMenu.Size = new Size(146, 23);
            txtMenu.TabIndex = 3;
            // 
            // rbtnNoAutorizados
            // 
            rbtnNoAutorizados.AutoSize = true;
            rbtnNoAutorizados.Location = new Point(350, 63);
            rbtnNoAutorizados.Name = "rbtnNoAutorizados";
            rbtnNoAutorizados.Size = new Size(105, 19);
            rbtnNoAutorizados.TabIndex = 2;
            rbtnNoAutorizados.TabStop = true;
            rbtnNoAutorizados.Text = "No autorizados";
            rbtnNoAutorizados.UseVisualStyleBackColor = true;
            rbtnNoAutorizados.Click += rbtnNoAutorizados_Click;
            // 
            // rbtnMenu
            // 
            rbtnMenu.AutoSize = true;
            rbtnMenu.Location = new Point(90, 31);
            rbtnMenu.Name = "rbtnMenu";
            rbtnMenu.Size = new Size(56, 19);
            rbtnMenu.TabIndex = 0;
            rbtnMenu.TabStop = true;
            rbtnMenu.Text = "Menu";
            rbtnMenu.UseVisualStyleBackColor = true;
            rbtnMenu.Click += rbtnMenu_Click;
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AllowUserToDeleteRows = false;
            dgvMenu.AllowUserToResizeColumns = false;
            dgvMenu.AllowUserToResizeRows = false;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Columns.AddRange(new DataGridViewColumn[] { colMenu, colTipoMenu, colPrecio, colAutorizado, colActivo, colDietas });
            dgvMenu.Location = new Point(12, 118);
            dgvMenu.MultiSelect = false;
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowTemplate.Height = 25;
            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.Size = new Size(978, 359);
            dgvMenu.TabIndex = 0;
            // 
            // colMenu
            // 
            colMenu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMenu.FillWeight = 45.68528F;
            colMenu.HeaderText = "Menu";
            colMenu.Name = "colMenu";
            colMenu.ReadOnly = true;
            // 
            // colTipoMenu
            // 
            colTipoMenu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipoMenu.FillWeight = 67.38897F;
            colTipoMenu.HeaderText = "Tipo menu";
            colTipoMenu.Name = "colTipoMenu";
            colTipoMenu.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrecio.FillWeight = 88.74207F;
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colAutorizado
            // 
            colAutorizado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAutorizado.FillWeight = 74.16263F;
            colAutorizado.HeaderText = "Autorizado";
            colAutorizado.Name = "colAutorizado";
            colAutorizado.ReadOnly = true;
            // 
            // colActivo
            // 
            colActivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colActivo.FillWeight = 58.381588F;
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // colDietas
            // 
            colDietas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDietas.FillWeight = 265.639374F;
            colDietas.HeaderText = "Dieta";
            colDietas.Name = "colDietas";
            colDietas.ReadOnly = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 494);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(158, 33);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(668, 494);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(158, 33);
            btnDetalles.TabIndex = 4;
            btnDetalles.Text = "Ver detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(832, 494);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(158, 33);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(176, 494);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(158, 33);
            btnBaja.TabIndex = 6;
            btnBaja.Text = "Dar de Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Location = new Point(504, 494);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(158, 33);
            btnAutorizar.TabIndex = 7;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = true;
            btnAutorizar.Click += btnAutorizar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(821, 41);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(169, 50);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(340, 494);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(158, 33);
            btnAlta.TabIndex = 10;
            btnAlta.Text = "Dar de Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // ListarMenus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 539);
            Controls.Add(btnAlta);
            Controls.Add(btnBuscar);
            Controls.Add(btnAutorizar);
            Controls.Add(btnBaja);
            Controls.Add(btnModificar);
            Controls.Add(btnDetalles);
            Controls.Add(btnRegresar);
            Controls.Add(gbxFiltrar);
            Controls.Add(dgvMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListarMenus";
            Text = "Listar menus";
            Load += ListarMenus_Load;
            gbxFiltrar.ResumeLayout(false);
            gbxFiltrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMenu;
        private ComboBox cboTipo;
        private RadioButton rbtnTipo;
        private TextBox txtMenu;
        private RadioButton rbtnNoAutorizados;
        private RadioButton rbtnMenu;
        private RadioButton rbtnOrdenDieta;
        private ComboBox cboOrdenDieta;
        private Button btnRegresar;
        private Button btnDetalles;
        private Button btnModificar;
        private Button btnBaja;
        private Button btnAutorizar;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn colDieta;
        private RadioButton rbtnActivo;
        private RadioButton rbtnInactivo;
        private RadioButton rbtnAutorizado;
        private CheckedListBox chkLstDietas;
        private RadioButton rbtnDieta;
        private RadioButton rbtnTodo;
        private DataGridViewTextBoxColumn colMenu;
        private DataGridViewTextBoxColumn colTipoMenu;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colAutorizado;
        private DataGridViewTextBoxColumn colActivo;
        private DataGridViewTextBoxColumn colDietas;
        private Button btnAlta;
    }
}