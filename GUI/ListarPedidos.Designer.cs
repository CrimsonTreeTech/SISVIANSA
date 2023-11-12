namespace SISVIANSA_ITI_2023.GUI
{
    partial class ListarPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarPedidos));
            dgvPedidos = new DataGridView();
            colNro = new DataGridViewTextBoxColumn();
            colMenu = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            colZona = new DataGridViewTextBoxColumn();
            colDir = new DataGridViewTextBoxColumn();
            gbxFiltrar = new GroupBox();
            cboZona = new ComboBox();
            rbtnZona = new RadioButton();
            rbtnTodo = new RadioButton();
            cboEstado = new ComboBox();
            rbtnEstado = new RadioButton();
            txtCliente = new TextBox();
            txtNroPedido = new TextBox();
            rbtnCliente = new RadioButton();
            rbtnNroPedido = new RadioButton();
            btnRegresar = new Button();
            btnModificar = new Button();
            btnBuscar = new Button();
            btnHistorico = new Button();
            btnActualizarEstado = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            gbxFiltrar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AllowUserToResizeColumns = false;
            dgvPedidos.AllowUserToResizeRows = false;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { colNro, colMenu, colCliente, colFecha, colCantidad, colEstado, colZona, colDir });
            dgvPedidos.Location = new Point(12, 108);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowTemplate.Height = 25;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(931, 341);
            dgvPedidos.TabIndex = 0;
            // 
            // colNro
            // 
            colNro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNro.FillWeight = 59.9045258F;
            colNro.HeaderText = "Nro.";
            colNro.Name = "colNro";
            colNro.ReadOnly = true;
            // 
            // colMenu
            // 
            colMenu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMenu.FillWeight = 65.16104F;
            colMenu.HeaderText = "Menu";
            colMenu.Name = "colMenu";
            colMenu.ReadOnly = true;
            // 
            // colCliente
            // 
            colCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCliente.FillWeight = 130.441116F;
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colFecha
            // 
            colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFecha.FillWeight = 107.027885F;
            colFecha.HeaderText = "Fecha solicitado";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCantidad.FillWeight = 59.6018028F;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colEstado
            // 
            colEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEstado.FillWeight = 120.211327F;
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            // 
            // colZona
            // 
            colZona.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colZona.FillWeight = 54.60651F;
            colZona.HeaderText = "Zona";
            colZona.Name = "colZona";
            colZona.ReadOnly = true;
            // 
            // colDir
            // 
            colDir.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDir.FillWeight = 203.045639F;
            colDir.HeaderText = "Direccion";
            colDir.Name = "colDir";
            colDir.ReadOnly = true;
            // 
            // gbxFiltrar
            // 
            gbxFiltrar.Controls.Add(cboZona);
            gbxFiltrar.Controls.Add(rbtnZona);
            gbxFiltrar.Controls.Add(rbtnTodo);
            gbxFiltrar.Controls.Add(cboEstado);
            gbxFiltrar.Controls.Add(rbtnEstado);
            gbxFiltrar.Controls.Add(txtCliente);
            gbxFiltrar.Controls.Add(txtNroPedido);
            gbxFiltrar.Controls.Add(rbtnCliente);
            gbxFiltrar.Controls.Add(rbtnNroPedido);
            gbxFiltrar.Location = new Point(12, 12);
            gbxFiltrar.Name = "gbxFiltrar";
            gbxFiltrar.Size = new Size(931, 60);
            gbxFiltrar.TabIndex = 1;
            gbxFiltrar.TabStop = false;
            gbxFiltrar.Text = "Filtrar";
            // 
            // cboZona
            // 
            cboZona.DropDownStyle = ComboBoxStyle.DropDownList;
            cboZona.Enabled = false;
            cboZona.FormattingEnabled = true;
            cboZona.Location = new Point(820, 23);
            cboZona.Name = "cboZona";
            cboZona.Size = new Size(96, 23);
            cboZona.TabIndex = 8;
            // 
            // rbtnZona
            // 
            rbtnZona.AutoSize = true;
            rbtnZona.Location = new Point(762, 25);
            rbtnZona.Name = "rbtnZona";
            rbtnZona.Size = new Size(52, 19);
            rbtnZona.TabIndex = 7;
            rbtnZona.Text = "Zona";
            rbtnZona.UseVisualStyleBackColor = true;
            rbtnZona.Click += rbtnZona_Click;
            // 
            // rbtnTodo
            // 
            rbtnTodo.AutoSize = true;
            rbtnTodo.Location = new Point(6, 24);
            rbtnTodo.Name = "rbtnTodo";
            rbtnTodo.Size = new Size(51, 19);
            rbtnTodo.TabIndex = 6;
            rbtnTodo.Text = "Todo";
            rbtnTodo.UseVisualStyleBackColor = true;
            rbtnTodo.Click += rbtnTodo_Click;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Solicitado", "Confirmado", "Enviado", "Rechazado" });
            cboEstado.Location = new Point(625, 24);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(116, 23);
            cboEstado.TabIndex = 5;
            // 
            // rbtnEstado
            // 
            rbtnEstado.AutoSize = true;
            rbtnEstado.Location = new Point(559, 25);
            rbtnEstado.Name = "rbtnEstado";
            rbtnEstado.Size = new Size(60, 19);
            rbtnEstado.TabIndex = 4;
            rbtnEstado.Text = "Estado";
            rbtnEstado.UseVisualStyleBackColor = true;
            rbtnEstado.Click += rbtnEstado_Click;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(384, 24);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(137, 23);
            txtCliente.TabIndex = 3;
            // 
            // txtNroPedido
            // 
            txtNroPedido.Location = new Point(193, 23);
            txtNroPedido.Name = "txtNroPedido";
            txtNroPedido.Size = new Size(64, 23);
            txtNroPedido.TabIndex = 2;
            // 
            // rbtnCliente
            // 
            rbtnCliente.AutoSize = true;
            rbtnCliente.Location = new Point(316, 25);
            rbtnCliente.Name = "rbtnCliente";
            rbtnCliente.Size = new Size(62, 19);
            rbtnCliente.TabIndex = 1;
            rbtnCliente.Text = "Cliente";
            rbtnCliente.UseVisualStyleBackColor = true;
            rbtnCliente.Click += rbtnCliente_Click;
            // 
            // rbtnNroPedido
            // 
            rbtnNroPedido.AutoSize = true;
            rbtnNroPedido.Location = new Point(99, 25);
            rbtnNroPedido.Name = "rbtnNroPedido";
            rbtnNroPedido.Size = new Size(88, 19);
            rbtnNroPedido.TabIndex = 0;
            rbtnNroPedido.Text = "Nro. Pedido";
            rbtnNroPedido.UseVisualStyleBackColor = true;
            rbtnNroPedido.Click += rbtnNroPedido_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 455);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(213, 35);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(730, 455);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(213, 35);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 78);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(931, 24);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.Location = new Point(253, 455);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(213, 35);
            btnHistorico.TabIndex = 9;
            btnHistorico.Text = "Ver historico";
            btnHistorico.UseVisualStyleBackColor = true;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // btnActualizarEstado
            // 
            btnActualizarEstado.Location = new Point(491, 455);
            btnActualizarEstado.Name = "btnActualizarEstado";
            btnActualizarEstado.Size = new Size(213, 35);
            btnActualizarEstado.TabIndex = 10;
            btnActualizarEstado.Text = "Actualizar estado";
            btnActualizarEstado.UseVisualStyleBackColor = true;
            btnActualizarEstado.Click += btnActualizarEstado_Click;
            // 
            // ListarPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 502);
            Controls.Add(btnActualizarEstado);
            Controls.Add(btnHistorico);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnRegresar);
            Controls.Add(gbxFiltrar);
            Controls.Add(dgvPedidos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListarPedidos";
            Text = "Listar pedidos";
            Load += ListarPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            gbxFiltrar.ResumeLayout(false);
            gbxFiltrar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private GroupBox gbxFiltrar;
        private RadioButton rbtnNroPedido;
        private RadioButton rbtnEstado;
        private RadioButton rbtnCliente;
        private RadioButton rbtnTodo;
        private RadioButton rbtnZona;
        private ComboBox cboEstado;
        private ComboBox cboZona;
        private TextBox txtEstado;
        private TextBox txtCliente;
        private TextBox txtNroPedido;
        private Button btnRegresar;
        private Button btnModificar;
        private Button btnBuscar;
        private DataGridView dgvPedidos;
        private DataGridViewTextBoxColumn colNro;
        private DataGridViewTextBoxColumn colMenu;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colZona;
        private DataGridViewTextBoxColumn colDir;
        private Button btnHistorico;
        private Button btnActualizarEstado;
    }
}