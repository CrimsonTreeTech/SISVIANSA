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
            label1 = new Label();
            gbxCliente = new GroupBox();
            btnBuscarCliente = new Button();
            dgvCliente = new DataGridView();
            columna = new DataGridViewTextBoxColumn();
            columna1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            column4 = new DataGridViewTextBoxColumn();
            columna5 = new DataGridViewTextBoxColumn();
            Columna6 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            txtNombreCliente = new TextBox();
            rbtnNombreCliente = new RadioButton();
            txtDocCliente = new TextBox();
            rbtnDocCliente = new RadioButton();
            gbxMenu = new GroupBox();
            btnBuscarMenu = new Button();
            txtNombreMenu = new TextBox();
            rbtnNombreMenu = new RadioButton();
            cboDietaMenu = new ComboBox();
            cboTipoMenu = new ComboBox();
            dgvMenu = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            rbtnTipoMenu = new RadioButton();
            rbtnDietaMenu = new RadioButton();
            txtMenuDatos = new TextBox();
            txtTotalPrecioMenu = new TextBox();
            nudCantidadMenu = new NumericUpDown();
            gpbDatosPedido = new GroupBox();
            lblZona = new Label();
            lblTipoDocDatos = new Label();
            lblDir = new Label();
            lblUltimaActualizacion = new Label();
            lblEstado = new Label();
            lblNombreDatos = new Label();
            lblNroClienteDatos = new Label();
            lblMeuDatos = new Label();
            lblNroPedidoDatos = new Label();
            lblCantidad = new Label();
            lblPrecioTotal = new Label();
            txtNroPedidoDatos = new TextBox();
            txtNroClienteDatos = new TextBox();
            txtNroDocDatos = new TextBox();
            txtNombreClienteDatos = new TextBox();
            txtEstado = new TextBox();
            txtUltimaAct = new TextBox();
            cboZona = new ComboBox();
            rtxtDir = new RichTextBox();
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
            btnAceptar.Location = new Point(1105, 561);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(146, 35);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Realizar pedido";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(927, 561);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 31);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 60);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 14;
            label1.Click += label1_Click;
            // 
            // gbxCliente
            // 
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
            gbxCliente.Size = new Size(900, 291);
            gbxCliente.TabIndex = 15;
            gbxCliente.TabStop = false;
            gbxCliente.Text = "Cliente";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(672, 21);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(222, 32);
            btnBuscarCliente.TabIndex = 5;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.AllowUserToOrderColumns = true;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { columna, columna1, Column2, column4, columna5, Columna6, Column6 });
            dgvCliente.Location = new Point(6, 66);
            dgvCliente.Margin = new Padding(3, 2, 3, 2);
            dgvCliente.MultiSelect = false;
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 51;
            dgvCliente.RowTemplate.Height = 29;
            dgvCliente.Size = new Size(888, 221);
            dgvCliente.TabIndex = 4;
            // 
            // columna
            // 
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columna.HeaderText = "CI";
            columna.MinimumWidth = 6;
            columna.Name = "columna";
            columna.ReadOnly = true;
            // 
            // columna1
            // 
            columna1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columna1.HeaderText = "Nombre";
            columna1.MinimumWidth = 6;
            columna1.Name = "columna1";
            columna1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Apellido";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // column4
            // 
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column4.HeaderText = "Teléfono";
            column4.MinimumWidth = 6;
            column4.Name = "column4";
            column4.ReadOnly = true;
            // 
            // columna5
            // 
            columna5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columna5.HeaderText = "Correo";
            columna5.MinimumWidth = 6;
            columna5.Name = "columna5";
            columna5.ReadOnly = true;
            // 
            // Columna6
            // 
            Columna6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Columna6.HeaderText = "Estado";
            Columna6.MinimumWidth = 6;
            Columna6.Name = "Columna6";
            Columna6.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Autorizado";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(364, 27);
            txtNombreCliente.Margin = new Padding(3, 2, 3, 2);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(261, 23);
            txtNombreCliente.TabIndex = 3;
            // 
            // rbtnNombreCliente
            // 
            rbtnNombreCliente.AutoSize = true;
            rbtnNombreCliente.Location = new Point(290, 27);
            rbtnNombreCliente.Margin = new Padding(3, 2, 3, 2);
            rbtnNombreCliente.Name = "rbtnNombreCliente";
            rbtnNombreCliente.Size = new Size(69, 19);
            rbtnNombreCliente.TabIndex = 2;
            rbtnNombreCliente.TabStop = true;
            rbtnNombreCliente.Text = "Nombre";
            rbtnNombreCliente.UseVisualStyleBackColor = true;
            // 
            // txtDocCliente
            // 
            txtDocCliente.Location = new Point(78, 27);
            txtDocCliente.Margin = new Padding(3, 2, 3, 2);
            txtDocCliente.Name = "txtDocCliente";
            txtDocCliente.Size = new Size(143, 23);
            txtDocCliente.TabIndex = 1;
            // 
            // rbtnDocCliente
            // 
            rbtnDocCliente.AutoSize = true;
            rbtnDocCliente.Location = new Point(6, 28);
            rbtnDocCliente.Margin = new Padding(3, 2, 3, 2);
            rbtnDocCliente.Name = "rbtnDocCliente";
            rbtnDocCliente.Size = new Size(66, 19);
            rbtnDocCliente.TabIndex = 0;
            rbtnDocCliente.TabStop = true;
            rbtnDocCliente.Text = "N° Doc.";
            rbtnDocCliente.UseVisualStyleBackColor = true;
            // 
            // gbxMenu
            // 
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
            gbxMenu.Size = new Size(900, 279);
            gbxMenu.TabIndex = 16;
            gbxMenu.TabStop = false;
            gbxMenu.Text = "Menu";
            // 
            // btnBuscarMenu
            // 
            btnBuscarMenu.Location = new Point(672, 14);
            btnBuscarMenu.Name = "btnBuscarMenu";
            btnBuscarMenu.Size = new Size(222, 32);
            btnBuscarMenu.TabIndex = 6;
            btnBuscarMenu.Text = "Buscar";
            btnBuscarMenu.UseVisualStyleBackColor = true;
            // 
            // txtNombreMenu
            // 
            txtNombreMenu.Location = new Point(81, 18);
            txtNombreMenu.Margin = new Padding(3, 2, 3, 2);
            txtNombreMenu.Name = "txtNombreMenu";
            txtNombreMenu.Size = new Size(95, 23);
            txtNombreMenu.TabIndex = 6;
            // 
            // rbtnNombreMenu
            // 
            rbtnNombreMenu.AutoSize = true;
            rbtnNombreMenu.Location = new Point(6, 18);
            rbtnNombreMenu.Margin = new Padding(3, 2, 3, 2);
            rbtnNombreMenu.Name = "rbtnNombreMenu";
            rbtnNombreMenu.Size = new Size(69, 19);
            rbtnNombreMenu.TabIndex = 7;
            rbtnNombreMenu.TabStop = true;
            rbtnNombreMenu.Text = "Nombre";
            rbtnNombreMenu.UseVisualStyleBackColor = true;
            // 
            // cboDietaMenu
            // 
            cboDietaMenu.FormattingEnabled = true;
            cboDietaMenu.Location = new Point(271, 18);
            cboDietaMenu.Margin = new Padding(3, 2, 3, 2);
            cboDietaMenu.Name = "cboDietaMenu";
            cboDietaMenu.Size = new Size(129, 23);
            cboDietaMenu.TabIndex = 6;
            // 
            // cboTipoMenu
            // 
            cboTipoMenu.FormattingEnabled = true;
            cboTipoMenu.Location = new Point(487, 19);
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
            dgvMenu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column5, Column7, Column8 });
            dgvMenu.Location = new Point(6, 51);
            dgvMenu.Margin = new Padding(3, 2, 3, 2);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.RowHeadersWidth = 51;
            dgvMenu.RowTemplate.Height = 29;
            dgvMenu.Size = new Size(888, 224);
            dgvMenu.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "iDMenu";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Tipo de Menu";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Dieta";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Precio";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "Autorizado";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // rbtnTipoMenu
            // 
            rbtnTipoMenu.AutoSize = true;
            rbtnTipoMenu.Location = new Point(433, 20);
            rbtnTipoMenu.Margin = new Padding(3, 2, 3, 2);
            rbtnTipoMenu.Name = "rbtnTipoMenu";
            rbtnTipoMenu.Size = new Size(48, 19);
            rbtnTipoMenu.TabIndex = 1;
            rbtnTipoMenu.TabStop = true;
            rbtnTipoMenu.Text = "Tipo";
            rbtnTipoMenu.UseVisualStyleBackColor = true;
            // 
            // rbtnDietaMenu
            // 
            rbtnDietaMenu.AutoSize = true;
            rbtnDietaMenu.Location = new Point(213, 20);
            rbtnDietaMenu.Margin = new Padding(3, 2, 3, 2);
            rbtnDietaMenu.Name = "rbtnDietaMenu";
            rbtnDietaMenu.Size = new Size(52, 19);
            rbtnDietaMenu.TabIndex = 0;
            rbtnDietaMenu.TabStop = true;
            rbtnDietaMenu.Text = "Dieta";
            rbtnDietaMenu.UseVisualStyleBackColor = true;
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
            gpbDatosPedido.Location = new Point(927, 12);
            gpbDatosPedido.Name = "gpbDatosPedido";
            gpbDatosPedido.Size = new Size(324, 513);
            gpbDatosPedido.TabIndex = 27;
            gpbDatosPedido.TabStop = false;
            gpbDatosPedido.Text = "Datos del pedido";
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
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(16, 355);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 9;
            lblCantidad.Text = "Cantidad";
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
            // txtNroPedidoDatos
            // 
            txtNroPedidoDatos.Location = new Point(105, 25);
            txtNroPedidoDatos.Name = "txtNroPedidoDatos";
            txtNroPedidoDatos.ReadOnly = true;
            txtNroPedidoDatos.Size = new Size(199, 23);
            txtNroPedidoDatos.TabIndex = 28;
            // 
            // txtNroClienteDatos
            // 
            txtNroClienteDatos.Location = new Point(104, 62);
            txtNroClienteDatos.Name = "txtNroClienteDatos";
            txtNroClienteDatos.ReadOnly = true;
            txtNroClienteDatos.Size = new Size(200, 23);
            txtNroClienteDatos.TabIndex = 29;
            // 
            // txtNroDocDatos
            // 
            txtNroDocDatos.Location = new Point(105, 96);
            txtNroDocDatos.Name = "txtNroDocDatos";
            txtNroDocDatos.ReadOnly = true;
            txtNroDocDatos.Size = new Size(199, 23);
            txtNroDocDatos.TabIndex = 30;
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
            // txtEstado
            // 
            txtEstado.Location = new Point(87, 389);
            txtEstado.Name = "txtEstado";
            txtEstado.ReadOnly = true;
            txtEstado.Size = new Size(217, 23);
            txtEstado.TabIndex = 32;
            // 
            // txtUltimaAct
            // 
            txtUltimaAct.Location = new Point(136, 429);
            txtUltimaAct.Name = "txtUltimaAct";
            txtUltimaAct.ReadOnly = true;
            txtUltimaAct.Size = new Size(168, 23);
            txtUltimaAct.TabIndex = 33;
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
            // GestionarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 604);
            Controls.Add(gpbDatosPedido);
            Controls.Add(gbxMenu);
            Controls.Add(gbxCliente);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "GestionarPedido";
            Text = "RealizarPedido";
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
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
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
    }
}