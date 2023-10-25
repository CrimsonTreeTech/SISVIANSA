namespace SISVIANSA_ITI_2023.GUI
{
    partial class GestionarPedido
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            gbxCliente = new GroupBox();
            rbtnAutorizadosYActivosCliente = new RadioButton();
            rbtnTodoCliente = new RadioButton();
            btnBuscarCliente = new Button();
            dgvCliente = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDoc = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTel = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            colAutorizado = new DataGridViewTextBoxColumn();
            txtNombreCliente = new TextBox();
            rbtnNombreCliente = new RadioButton();
            txtDocCliente = new TextBox();
            rbtnDocCliente = new RadioButton();
            gbxMenu = new GroupBox();
            rbtnTodoMenu = new RadioButton();
            btnBuscarMenu = new Button();
            txtNombreMenu = new TextBox();
            rbtnNombreMenu = new RadioButton();
            cboDietaMenu = new ComboBox();
            cboTipoMenu = new ComboBox();
            dgvMenu = new DataGridView();
            colMenu = new DataGridViewTextBoxColumn();
            colTipoMenu = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colDieta = new DataGridViewTextBoxColumn();
            rbtnTipoMenu = new RadioButton();
            rbtnDietaMenu = new RadioButton();
            txtMenuDatos = new TextBox();
            txtTotalPrecioMenu = new TextBox();
            nudCantidadMenu = new NumericUpDown();
            gpbDatosPedido = new GroupBox();
            rtxtDir = new RichTextBox();
            cboZona = new ComboBox();
            txtUltimaAct = new TextBox();
            txtEstado = new TextBox();
            txtNombreClienteDatos = new TextBox();
            txtNroDocDatos = new TextBox();
            txtNroClienteDatos = new TextBox();
            txtNroPedidoDatos = new TextBox();
            lblPrecioTotal = new Label();
            lblCantidad = new Label();
            lblZona = new Label();
            lblTipoDocDatos = new Label();
            lblDir = new Label();
            lblUltimaActualizacion = new Label();
            lblEstado = new Label();
            lblNombreDatos = new Label();
            lblNroClienteDatos = new Label();
            lblMeuDatos = new Label();
            lblNroPedidoDatos = new Label();
            gbxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            gbxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadMenu).BeginInit();
            gpbDatosPedido.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(1229, 561);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(146, 35);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Realizar pedido";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1051, 561);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 31);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gbxCliente
            // 
            gbxCliente.BackColor = Color.FromArgb(255, 235, 235);
            gbxCliente.Controls.Add(rbtnAutorizadosYActivosCliente);
            gbxCliente.Controls.Add(rbtnTodoCliente);
            gbxCliente.Controls.Add(btnBuscarCliente);
            gbxCliente.Controls.Add(dgvCliente);
            gbxCliente.Controls.Add(txtNombreCliente);
            gbxCliente.Controls.Add(rbtnNombreCliente);
            gbxCliente.Controls.Add(txtDocCliente);
            gbxCliente.Controls.Add(rbtnDocCliente);
            gbxCliente.Location = new Point(12, 11);
            gbxCliente.Margin = new Padding(3, 2, 3, 2);
            gbxCliente.Name = "gbxCliente";
            gbxCliente.Padding = new Padding(3, 2, 3, 2);
            gbxCliente.Size = new Size(1033, 291);
            gbxCliente.TabIndex = 15;
            gbxCliente.TabStop = false;
            gbxCliente.Text = "Cliente";
            // 
            // rbtnAutorizadosYActivosCliente
            // 
            rbtnAutorizadosYActivosCliente.AutoSize = true;
            rbtnAutorizadosYActivosCliente.Location = new Point(593, 33);
            rbtnAutorizadosYActivosCliente.Name = "rbtnAutorizadosYActivosCliente";
            rbtnAutorizadosYActivosCliente.Size = new Size(137, 19);
            rbtnAutorizadosYActivosCliente.TabIndex = 7;
            rbtnAutorizadosYActivosCliente.TabStop = true;
            rbtnAutorizadosYActivosCliente.Text = "Autorizados y activos";
            rbtnAutorizadosYActivosCliente.UseVisualStyleBackColor = true;
            rbtnAutorizadosYActivosCliente.Click += rbtnAutorizadosYActivosCliente_Click;
            // 
            // rbtnTodoCliente
            // 
            rbtnTodoCliente.AutoSize = true;
            rbtnTodoCliente.Location = new Point(17, 29);
            rbtnTodoCliente.Margin = new Padding(3, 2, 3, 2);
            rbtnTodoCliente.Name = "rbtnTodoCliente";
            rbtnTodoCliente.Size = new Size(56, 19);
            rbtnTodoCliente.TabIndex = 6;
            rbtnTodoCliente.TabStop = true;
            rbtnTodoCliente.Text = "Todos";
            rbtnTodoCliente.UseVisualStyleBackColor = true;
            rbtnTodoCliente.CheckedChanged += rbtnTodoCliente_CheckedChanged;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(805, 22);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(222, 32);
            btnBuscarCliente.TabIndex = 5;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.AllowUserToOrderColumns = true;
            dgvCliente.AllowUserToResizeRows = false;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { colId, colDoc, colNombre, colTel, colCorreo, colActivo, colAutorizado });
            dgvCliente.Location = new Point(6, 66);
            dgvCliente.Margin = new Padding(3, 2, 3, 2);
            dgvCliente.MultiSelect = false;
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersVisible = false;
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.RowTemplate.Height = 29;
            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.Size = new Size(1021, 221);
            dgvCliente.TabIndex = 4;
            dgvCliente.MouseDoubleClick += dgvCliente_MouseDoubleClick;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colId.FillWeight = 33.9012222F;
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colDoc
            // 
            colDoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDoc.FillWeight = 104.0143F;
            colDoc.HeaderText = "N° Doc.";
            colDoc.MinimumWidth = 6;
            colDoc.Name = "colDoc";
            colDoc.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.FillWeight = 145.6154F;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colTel
            // 
            colTel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTel.FillWeight = 96.54103F;
            colTel.HeaderText = "Teléfono";
            colTel.MinimumWidth = 6;
            colTel.Name = "colTel";
            colTel.ReadOnly = true;
            // 
            // colCorreo
            // 
            colCorreo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCorreo.FillWeight = 145.6154F;
            colCorreo.HeaderText = "Correo";
            colCorreo.MinimumWidth = 6;
            colCorreo.Name = "colCorreo";
            colCorreo.ReadOnly = true;
            // 
            // colActivo
            // 
            colActivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colActivo.FillWeight = 78.3096161F;
            colActivo.HeaderText = "Activo";
            colActivo.MinimumWidth = 6;
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // colAutorizado
            // 
            colAutorizado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAutorizado.FillWeight = 63.85703F;
            colAutorizado.HeaderText = "Autorizado";
            colAutorizado.MinimumWidth = 6;
            colAutorizado.Name = "colAutorizado";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(368, 29);
            txtNombreCliente.Margin = new Padding(3, 2, 3, 2);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(201, 23);
            txtNombreCliente.TabIndex = 3;
            // 
            // rbtnNombreCliente
            // 
            rbtnNombreCliente.AutoSize = true;
            rbtnNombreCliente.Location = new Point(294, 29);
            rbtnNombreCliente.Margin = new Padding(3, 2, 3, 2);
            rbtnNombreCliente.Name = "rbtnNombreCliente";
            rbtnNombreCliente.Size = new Size(69, 19);
            rbtnNombreCliente.TabIndex = 2;
            rbtnNombreCliente.TabStop = true;
            rbtnNombreCliente.Text = "Nombre";
            rbtnNombreCliente.UseVisualStyleBackColor = true;
            rbtnNombreCliente.Click += rbtnNombreCliente_Click;
            // 
            // txtDocCliente
            // 
            txtDocCliente.Location = new Point(173, 28);
            txtDocCliente.Margin = new Padding(3, 2, 3, 2);
            txtDocCliente.Name = "txtDocCliente";
            txtDocCliente.Size = new Size(109, 23);
            txtDocCliente.TabIndex = 1;
            // 
            // rbtnDocCliente
            // 
            rbtnDocCliente.AutoSize = true;
            rbtnDocCliente.Location = new Point(101, 29);
            rbtnDocCliente.Margin = new Padding(3, 2, 3, 2);
            rbtnDocCliente.Name = "rbtnDocCliente";
            rbtnDocCliente.Size = new Size(66, 19);
            rbtnDocCliente.TabIndex = 0;
            rbtnDocCliente.TabStop = true;
            rbtnDocCliente.Text = "N° Doc.";
            rbtnDocCliente.UseVisualStyleBackColor = true;
            rbtnDocCliente.Click += rbtnDocCliente_Click;
            // 
            // gbxMenu
            // 
            gbxMenu.BackColor = Color.FromArgb(255, 235, 235);
            gbxMenu.Controls.Add(rbtnTodoMenu);
            gbxMenu.Controls.Add(btnBuscarMenu);
            gbxMenu.Controls.Add(txtNombreMenu);
            gbxMenu.Controls.Add(rbtnNombreMenu);
            gbxMenu.Controls.Add(cboDietaMenu);
            gbxMenu.Controls.Add(cboTipoMenu);
            gbxMenu.Controls.Add(dgvMenu);
            gbxMenu.Controls.Add(rbtnTipoMenu);
            gbxMenu.Controls.Add(rbtnDietaMenu);
            gbxMenu.Location = new Point(12, 317);
            gbxMenu.Margin = new Padding(3, 2, 3, 2);
            gbxMenu.Name = "gbxMenu";
            gbxMenu.Padding = new Padding(3, 2, 3, 2);
            gbxMenu.Size = new Size(1033, 279);
            gbxMenu.TabIndex = 16;
            gbxMenu.TabStop = false;
            gbxMenu.Text = "Menu";
            // 
            // rbtnTodoMenu
            // 
            rbtnTodoMenu.AutoSize = true;
            rbtnTodoMenu.Location = new Point(17, 23);
            rbtnTodoMenu.Margin = new Padding(3, 2, 3, 2);
            rbtnTodoMenu.Name = "rbtnTodoMenu";
            rbtnTodoMenu.Size = new Size(56, 19);
            rbtnTodoMenu.TabIndex = 7;
            rbtnTodoMenu.TabStop = true;
            rbtnTodoMenu.Text = "Todos";
            rbtnTodoMenu.UseVisualStyleBackColor = true;
            rbtnTodoMenu.Click += rbtnTodoMenu_Click;
            // 
            // btnBuscarMenu
            // 
            btnBuscarMenu.Location = new Point(805, 14);
            btnBuscarMenu.Name = "btnBuscarMenu";
            btnBuscarMenu.Size = new Size(222, 32);
            btnBuscarMenu.TabIndex = 6;
            btnBuscarMenu.Text = "Buscar";
            btnBuscarMenu.UseVisualStyleBackColor = true;
            btnBuscarMenu.Click += btnBuscarMenu_Click;
            // 
            // txtNombreMenu
            // 
            txtNombreMenu.Location = new Point(187, 20);
            txtNombreMenu.Margin = new Padding(3, 2, 3, 2);
            txtNombreMenu.Name = "txtNombreMenu";
            txtNombreMenu.Size = new Size(95, 23);
            txtNombreMenu.TabIndex = 6;
            // 
            // rbtnNombreMenu
            // 
            rbtnNombreMenu.AutoSize = true;
            rbtnNombreMenu.Location = new Point(112, 23);
            rbtnNombreMenu.Margin = new Padding(3, 2, 3, 2);
            rbtnNombreMenu.Name = "rbtnNombreMenu";
            rbtnNombreMenu.Size = new Size(69, 19);
            rbtnNombreMenu.TabIndex = 7;
            rbtnNombreMenu.TabStop = true;
            rbtnNombreMenu.Text = "Nombre";
            rbtnNombreMenu.UseVisualStyleBackColor = true;
            rbtnNombreMenu.Click += rbtnNombreMenu_Click;
            // 
            // cboDietaMenu
            // 
            cboDietaMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDietaMenu.FormattingEnabled = true;
            cboDietaMenu.Location = new Point(369, 19);
            cboDietaMenu.Margin = new Padding(3, 2, 3, 2);
            cboDietaMenu.Name = "cboDietaMenu";
            cboDietaMenu.Size = new Size(129, 23);
            cboDietaMenu.TabIndex = 6;
            // 
            // cboTipoMenu
            // 
            cboTipoMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoMenu.FormattingEnabled = true;
            cboTipoMenu.Items.AddRange(new object[] { "Semanal", "Quincenal", "Mensual" });
            cboTipoMenu.Location = new Point(577, 19);
            cboTipoMenu.Margin = new Padding(3, 2, 3, 2);
            cboTipoMenu.Name = "cboTipoMenu";
            cboTipoMenu.Size = new Size(146, 23);
            cboTipoMenu.TabIndex = 5;
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AllowUserToDeleteRows = false;
            dgvMenu.AllowUserToOrderColumns = true;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Columns.AddRange(new DataGridViewColumn[] { colMenu, colTipoMenu, colPrecio, colDieta });
            dgvMenu.Location = new Point(6, 51);
            dgvMenu.Margin = new Padding(3, 2, 3, 2);
            dgvMenu.MultiSelect = false;
            dgvMenu.Name = "dgvMenu";
            dgvMenu.RowHeadersVisible = false;
            dgvMenu.RowHeadersWidth = 51;
            dgvMenu.RowTemplate.Height = 29;
            dgvMenu.Size = new Size(1021, 224);
            dgvMenu.TabIndex = 4;
            // 
            // colMenu
            // 
            colMenu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMenu.FillWeight = 65.34058F;
            colMenu.HeaderText = "Menu";
            colMenu.MinimumWidth = 6;
            colMenu.Name = "colMenu";
            colMenu.ReadOnly = true;
            // 
            // colTipoMenu
            // 
            colTipoMenu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTipoMenu.FillWeight = 80.9910049F;
            colTipoMenu.HeaderText = "Tipo de Menu";
            colTipoMenu.MinimumWidth = 6;
            colTipoMenu.Name = "colTipoMenu";
            colTipoMenu.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrecio.FillWeight = 60.9137039F;
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colDieta
            // 
            colDieta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDieta.FillWeight = 192.7547F;
            colDieta.HeaderText = "Dieta";
            colDieta.MinimumWidth = 6;
            colDieta.Name = "colDieta";
            colDieta.ReadOnly = true;
            // 
            // rbtnTipoMenu
            // 
            rbtnTipoMenu.AutoSize = true;
            rbtnTipoMenu.Location = new Point(523, 20);
            rbtnTipoMenu.Margin = new Padding(3, 2, 3, 2);
            rbtnTipoMenu.Name = "rbtnTipoMenu";
            rbtnTipoMenu.Size = new Size(48, 19);
            rbtnTipoMenu.TabIndex = 1;
            rbtnTipoMenu.TabStop = true;
            rbtnTipoMenu.Text = "Tipo";
            rbtnTipoMenu.UseVisualStyleBackColor = true;
            rbtnTipoMenu.Click += rbtnTipoMenu_Click;
            // 
            // rbtnDietaMenu
            // 
            rbtnDietaMenu.AutoSize = true;
            rbtnDietaMenu.Location = new Point(311, 21);
            rbtnDietaMenu.Margin = new Padding(3, 2, 3, 2);
            rbtnDietaMenu.Name = "rbtnDietaMenu";
            rbtnDietaMenu.Size = new Size(52, 19);
            rbtnDietaMenu.TabIndex = 0;
            rbtnDietaMenu.TabStop = true;
            rbtnDietaMenu.Text = "Dieta";
            rbtnDietaMenu.UseVisualStyleBackColor = true;
            rbtnDietaMenu.Click += rbtnDietaMenu_Click;
            // 
            // txtMenuDatos
            // 
            txtMenuDatos.Location = new Point(88, 316);
            txtMenuDatos.Margin = new Padding(3, 2, 3, 2);
            txtMenuDatos.Name = "txtMenuDatos";
            txtMenuDatos.ReadOnly = true;
            txtMenuDatos.Size = new Size(216, 23);
            txtMenuDatos.TabIndex = 6;
            // 
            // txtTotalPrecioMenu
            // 
            txtTotalPrecioMenu.Location = new Point(103, 467);
            txtTotalPrecioMenu.Margin = new Padding(3, 2, 3, 2);
            txtTotalPrecioMenu.Name = "txtTotalPrecioMenu";
            txtTotalPrecioMenu.ReadOnly = true;
            txtTotalPrecioMenu.Size = new Size(201, 23);
            txtTotalPrecioMenu.TabIndex = 25;
            // 
            // nudCantidadMenu
            // 
            nudCantidadMenu.Location = new Point(88, 353);
            nudCantidadMenu.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudCantidadMenu.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidadMenu.Name = "nudCantidadMenu";
            nudCantidadMenu.ReadOnly = true;
            nudCantidadMenu.Size = new Size(216, 23);
            nudCantidadMenu.TabIndex = 26;
            nudCantidadMenu.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // gpbDatosPedido
            // 
            gpbDatosPedido.BackColor = Color.FromArgb(255, 235, 235);
            gpbDatosPedido.Controls.Add(rtxtDir);
            gpbDatosPedido.Controls.Add(cboZona);
            gpbDatosPedido.Controls.Add(txtUltimaAct);
            gpbDatosPedido.Controls.Add(txtEstado);
            gpbDatosPedido.Controls.Add(txtNombreClienteDatos);
            gpbDatosPedido.Controls.Add(txtNroDocDatos);
            gpbDatosPedido.Controls.Add(txtNroClienteDatos);
            gpbDatosPedido.Controls.Add(txtNroPedidoDatos);
            gpbDatosPedido.Controls.Add(lblPrecioTotal);
            gpbDatosPedido.Controls.Add(nudCantidadMenu);
            gpbDatosPedido.Controls.Add(lblCantidad);
            gpbDatosPedido.Controls.Add(txtMenuDatos);
            gpbDatosPedido.Controls.Add(lblZona);
            gpbDatosPedido.Controls.Add(txtTotalPrecioMenu);
            gpbDatosPedido.Controls.Add(lblTipoDocDatos);
            gpbDatosPedido.Controls.Add(lblDir);
            gpbDatosPedido.Controls.Add(lblUltimaActualizacion);
            gpbDatosPedido.Controls.Add(lblEstado);
            gpbDatosPedido.Controls.Add(lblNombreDatos);
            gpbDatosPedido.Controls.Add(lblNroClienteDatos);
            gpbDatosPedido.Controls.Add(lblMeuDatos);
            gpbDatosPedido.Controls.Add(lblNroPedidoDatos);
            gpbDatosPedido.Location = new Point(1051, 12);
            gpbDatosPedido.Name = "gpbDatosPedido";
            gpbDatosPedido.Size = new Size(324, 513);
            gpbDatosPedido.TabIndex = 27;
            gpbDatosPedido.TabStop = false;
            gpbDatosPedido.Text = "Datos del pedido";
            // 
            // rtxtDir
            // 
            rtxtDir.BackColor = SystemColors.ButtonFace;
            rtxtDir.Location = new Point(17, 193);
            rtxtDir.Name = "rtxtDir";
            rtxtDir.ReadOnly = true;
            rtxtDir.Size = new Size(287, 67);
            rtxtDir.TabIndex = 35;
            rtxtDir.Text = "";
            // 
            // cboZona
            // 
            cboZona.BackColor = SystemColors.Control;
            cboZona.DropDownStyle = ComboBoxStyle.DropDownList;
            cboZona.FormattingEnabled = true;
            cboZona.Location = new Point(88, 285);
            cboZona.Name = "cboZona";
            cboZona.Size = new Size(216, 23);
            cboZona.TabIndex = 34;
            // 
            // txtUltimaAct
            // 
            txtUltimaAct.Location = new Point(136, 429);
            txtUltimaAct.Name = "txtUltimaAct";
            txtUltimaAct.ReadOnly = true;
            txtUltimaAct.Size = new Size(168, 23);
            txtUltimaAct.TabIndex = 33;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(87, 389);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(217, 23);
            txtEstado.TabIndex = 32;
            // 
            // txtNombreClienteDatos
            // 
            txtNombreClienteDatos.Location = new Point(105, 133);
            txtNombreClienteDatos.Name = "txtNombreClienteDatos";
            txtNombreClienteDatos.ReadOnly = true;
            txtNombreClienteDatos.ShortcutsEnabled = false;
            txtNombreClienteDatos.Size = new Size(199, 23);
            txtNombreClienteDatos.TabIndex = 31;
            // 
            // txtNroDocDatos
            // 
            txtNroDocDatos.Location = new Point(105, 96);
            txtNroDocDatos.Name = "txtNroDocDatos";
            txtNroDocDatos.ReadOnly = true;
            txtNroDocDatos.Size = new Size(199, 23);
            txtNroDocDatos.TabIndex = 30;
            // 
            // txtNroClienteDatos
            // 
            txtNroClienteDatos.Location = new Point(104, 62);
            txtNroClienteDatos.Name = "txtNroClienteDatos";
            txtNroClienteDatos.ReadOnly = true;
            txtNroClienteDatos.Size = new Size(200, 23);
            txtNroClienteDatos.TabIndex = 29;
            // 
            // txtNroPedidoDatos
            // 
            txtNroPedidoDatos.Location = new Point(105, 25);
            txtNroPedidoDatos.Name = "txtNroPedidoDatos";
            txtNroPedidoDatos.ReadOnly = true;
            txtNroPedidoDatos.Size = new Size(199, 23);
            txtNroPedidoDatos.TabIndex = 28;
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.AutoSize = true;
            lblPrecioTotal.Location = new Point(17, 470);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(67, 15);
            lblPrecioTotal.TabIndex = 10;
            lblPrecioTotal.Text = "Precio total";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(16, 355);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 9;
            lblCantidad.Text = "Cantidad";
            // 
            // lblZona
            // 
            lblZona.AutoSize = true;
            lblZona.Location = new Point(17, 288);
            lblZona.Name = "lblZona";
            lblZona.Size = new Size(34, 15);
            lblZona.TabIndex = 8;
            lblZona.Text = "Zona";
            // 
            // lblTipoDocDatos
            // 
            lblTipoDocDatos.AutoSize = true;
            lblTipoDocDatos.Location = new Point(17, 99);
            lblTipoDocDatos.Name = "lblTipoDocDatos";
            lblTipoDocDatos.Size = new Size(51, 15);
            lblTipoDocDatos.TabIndex = 7;
            lblTipoDocDatos.Text = "TipoDoc";
            // 
            // lblDir
            // 
            lblDir.AutoSize = true;
            lblDir.Location = new Point(17, 175);
            lblDir.Name = "lblDir";
            lblDir.Size = new Size(57, 15);
            lblDir.TabIndex = 6;
            lblDir.Text = "Dirección";
            // 
            // lblUltimaActualizacion
            // 
            lblUltimaActualizacion.AutoSize = true;
            lblUltimaActualizacion.Location = new Point(16, 432);
            lblUltimaActualizacion.Name = "lblUltimaActualizacion";
            lblUltimaActualizacion.Size = new Size(114, 15);
            lblUltimaActualizacion.TabIndex = 5;
            lblUltimaActualizacion.Text = "Última actualización";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(16, 392);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado";
            // 
            // lblNombreDatos
            // 
            lblNombreDatos.AutoSize = true;
            lblNombreDatos.Location = new Point(17, 136);
            lblNombreDatos.Name = "lblNombreDatos";
            lblNombreDatos.Size = new Size(51, 15);
            lblNombreDatos.TabIndex = 3;
            lblNombreDatos.Text = "Nombre";
            // 
            // lblNroClienteDatos
            // 
            lblNroClienteDatos.AutoSize = true;
            lblNroClienteDatos.Location = new Point(17, 65);
            lblNroClienteDatos.Name = "lblNroClienteDatos";
            lblNroClienteDatos.Size = new Size(61, 15);
            lblNroClienteDatos.TabIndex = 2;
            lblNroClienteDatos.Text = "N° Cliente";
            // 
            // lblMeuDatos
            // 
            lblMeuDatos.AutoSize = true;
            lblMeuDatos.Location = new Point(17, 319);
            lblMeuDatos.Name = "lblMeuDatos";
            lblMeuDatos.Size = new Size(38, 15);
            lblMeuDatos.TabIndex = 1;
            lblMeuDatos.Text = "Menu";
            // 
            // lblNroPedidoDatos
            // 
            lblNroPedidoDatos.AutoSize = true;
            lblNroPedidoDatos.Location = new Point(17, 30);
            lblNroPedidoDatos.Name = "lblNroPedidoDatos";
            lblNroPedidoDatos.Size = new Size(61, 15);
            lblNroPedidoDatos.TabIndex = 0;
            lblNroPedidoDatos.Text = "N° pedido";
            // 
            // GestionarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 604);
            Controls.Add(gpbDatosPedido);
            Controls.Add(gbxMenu);
            Controls.Add(gbxCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "GestionarPedido";
            Text = "RealizarPedido";
            Load += GestionarPedido_Load;
            gbxCliente.ResumeLayout(false);
            gbxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            gbxMenu.ResumeLayout(false);
            gbxMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadMenu).EndInit();
            gpbDatosPedido.ResumeLayout(false);
            gpbDatosPedido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAceptar;
        private Button btnCancelar;
        private GroupBox gbxCliente;
        private RadioButton rbtnDocCliente;
        private GroupBox gbxMenu;
        private DataGridView dgvCliente;
        private TextBox txtNombreCliente;
        private RadioButton rbtnNombreCliente;
        private TextBox txtDocCliente;
        private RadioButton rbtnTipoMenu;
        private RadioButton rbtnDietaMenu;
        private DataGridView dgvMenu;
        private DataGridViewTextBoxColumn columna;
        private DataGridViewTextBoxColumn columna1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn column4;
        private DataGridViewTextBoxColumn columna5;
        private DataGridViewTextBoxColumn Columna6;
        private ComboBox cboTipoMenu;
        private DataGridViewTextBoxColumn Column6;
        private ComboBox cboDietaMenu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Button btnBuscarCliente;
        private Button btnBuscarMenu;
        private TextBox txtNombreMenu;
        private RadioButton rbtnNombreMenu;
        private TextBox txtMenuDatos;
        private TextBox txtTotalPrecioMenu;
        private NumericUpDown nudCantidadMenu;
        private GroupBox gpbDatosPedido;
        private Label lblNroPedidoDatos;
        private Label lblMeuDatos;
        private Label lblZona;
        private Label lblTipoDocDatos;
        private Label lblDir;
        private Label lblUltimaActualizacion;
        private Label lblEstado;
        private Label lblNombreDatos;
        private Label lblNroClienteDatos;
        private Label lblPrecioTotal;
        private Label lblCantidad;
        private ComboBox cboZona;
        private TextBox txtUltimaAct;
        private TextBox txtEstado;
        private TextBox txtNombreClienteDatos;
        private TextBox txtNroDocDatos;
        private TextBox txtNroClienteDatos;
        private TextBox txtNroPedidoDatos;
        private RichTextBox rtxtDir;
        private DataGridViewTextBoxColumn colCi;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colMenu;
        private DataGridViewTextBoxColumn colTipoMenu;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colDieta;
        private RadioButton rbtnTodoCliente;
        private RadioButton rbtnTodoMenu;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDoc;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTel;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colActivo;
        private DataGridViewTextBoxColumn colAutorizado;
        private RadioButton rbtnAutorizadosYActivosCliente;
    }
}