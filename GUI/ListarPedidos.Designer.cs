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
            dgvPedidos = new DataGridView();
            colNro = new DataGridViewTextBoxColumn();
            colMenu = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            gbxFiltrar = new GroupBox();
            rbtnFiltrarTodo = new RadioButton();
            cboFiltrarEstado = new ComboBox();
            rbtnFiltrarEstado = new RadioButton();
            txtFiltrarIdCliente = new TextBox();
            txtFiltrarNroPedido = new TextBox();
            rbtnFiltrarIdCliente = new RadioButton();
            rbtnFiltrarNroPedido = new RadioButton();
            gbxOrdenar = new GroupBox();
            cboOrdenarEstado = new ComboBox();
            cboOrdenarFecha = new ComboBox();
            cboOrdenarNroPedido = new ComboBox();
            rbtnOrdenarEstado = new RadioButton();
            rbtnOrdenarFecha = new RadioButton();
            rbtnOrdenarNroPedido = new RadioButton();
            btnRegresar = new Button();
            btnModificar = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            gbxFiltrar.SuspendLayout();
            gbxOrdenar.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { colNro, colMenu, colCliente, colFecha, colCantidad, colEstado });
            dgvPedidos.Location = new Point(12, 12);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowTemplate.Height = 25;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(583, 315);
            dgvPedidos.TabIndex = 0;
            // 
            // colNro
            // 
            colNro.HeaderText = "Nro.";
            colNro.Name = "colNro";
            colNro.ReadOnly = true;
            colNro.Width = 70;
            // 
            // colMenu
            // 
            colMenu.HeaderText = "Menu";
            colMenu.Name = "colMenu";
            colMenu.ReadOnly = true;
            colMenu.Width = 70;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Id cliente";
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            colCliente.Width = 80;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha solicitado";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 120;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 80;
            // 
            // colEstado
            // 
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 120;
            // 
            // gbxFiltrar
            // 
            gbxFiltrar.Controls.Add(rbtnFiltrarTodo);
            gbxFiltrar.Controls.Add(cboFiltrarEstado);
            gbxFiltrar.Controls.Add(rbtnFiltrarEstado);
            gbxFiltrar.Controls.Add(txtFiltrarIdCliente);
            gbxFiltrar.Controls.Add(txtFiltrarNroPedido);
            gbxFiltrar.Controls.Add(rbtnFiltrarIdCliente);
            gbxFiltrar.Controls.Add(rbtnFiltrarNroPedido);
            gbxFiltrar.Location = new Point(619, 57);
            gbxFiltrar.Name = "gbxFiltrar";
            gbxFiltrar.Size = new Size(236, 134);
            gbxFiltrar.TabIndex = 1;
            gbxFiltrar.TabStop = false;
            gbxFiltrar.Text = "Filtrar";
            // 
            // rbtnFiltrarTodo
            // 
            rbtnFiltrarTodo.AutoSize = true;
            rbtnFiltrarTodo.Location = new Point(13, 102);
            rbtnFiltrarTodo.Name = "rbtnFiltrarTodo";
            rbtnFiltrarTodo.Size = new Size(51, 19);
            rbtnFiltrarTodo.TabIndex = 6;
            rbtnFiltrarTodo.TabStop = true;
            rbtnFiltrarTodo.Text = "Todo";
            rbtnFiltrarTodo.UseVisualStyleBackColor = true;
            rbtnFiltrarTodo.Click += rbtnFiltrarTodo_Click;
            // 
            // cboFiltrarEstado
            // 
            cboFiltrarEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltrarEstado.FormattingEnabled = true;
            cboFiltrarEstado.Items.AddRange(new object[] { "Solicitado", "En producción", "En stock", "Enviado", "Entregado", "Rechazado", "Desechado" });
            cboFiltrarEstado.Location = new Point(107, 76);
            cboFiltrarEstado.Name = "cboFiltrarEstado";
            cboFiltrarEstado.Size = new Size(116, 23);
            cboFiltrarEstado.TabIndex = 5;
            // 
            // rbtnFiltrarEstado
            // 
            rbtnFiltrarEstado.AutoSize = true;
            rbtnFiltrarEstado.Location = new Point(13, 77);
            rbtnFiltrarEstado.Name = "rbtnFiltrarEstado";
            rbtnFiltrarEstado.Size = new Size(60, 19);
            rbtnFiltrarEstado.TabIndex = 4;
            rbtnFiltrarEstado.TabStop = true;
            rbtnFiltrarEstado.Text = "Estado";
            rbtnFiltrarEstado.UseVisualStyleBackColor = true;
            rbtnFiltrarEstado.Click += rbtnFiltrarEstado_Click;
            // 
            // txtFiltrarIdCliente
            // 
            txtFiltrarIdCliente.Location = new Point(107, 47);
            txtFiltrarIdCliente.Name = "txtFiltrarIdCliente";
            txtFiltrarIdCliente.Size = new Size(116, 23);
            txtFiltrarIdCliente.TabIndex = 3;
            // 
            // txtFiltrarNroPedido
            // 
            txtFiltrarNroPedido.Location = new Point(107, 18);
            txtFiltrarNroPedido.Name = "txtFiltrarNroPedido";
            txtFiltrarNroPedido.Size = new Size(116, 23);
            txtFiltrarNroPedido.TabIndex = 2;
            // 
            // rbtnFiltrarIdCliente
            // 
            rbtnFiltrarIdCliente.AutoSize = true;
            rbtnFiltrarIdCliente.Location = new Point(13, 48);
            rbtnFiltrarIdCliente.Name = "rbtnFiltrarIdCliente";
            rbtnFiltrarIdCliente.Size = new Size(75, 19);
            rbtnFiltrarIdCliente.TabIndex = 1;
            rbtnFiltrarIdCliente.TabStop = true;
            rbtnFiltrarIdCliente.Text = "Id Cliente";
            rbtnFiltrarIdCliente.UseVisualStyleBackColor = true;
            rbtnFiltrarIdCliente.Click += rbtnFiltrarIdCliente_Click;
            // 
            // rbtnFiltrarNroPedido
            // 
            rbtnFiltrarNroPedido.AutoSize = true;
            rbtnFiltrarNroPedido.Location = new Point(13, 22);
            rbtnFiltrarNroPedido.Name = "rbtnFiltrarNroPedido";
            rbtnFiltrarNroPedido.Size = new Size(88, 19);
            rbtnFiltrarNroPedido.TabIndex = 0;
            rbtnFiltrarNroPedido.TabStop = true;
            rbtnFiltrarNroPedido.Text = "Nro. Pedido";
            rbtnFiltrarNroPedido.UseVisualStyleBackColor = true;
            rbtnFiltrarNroPedido.Click += rbtnFiltrarNroPedido_Click;
            // 
            // gbxOrdenar
            // 
            gbxOrdenar.Controls.Add(cboOrdenarEstado);
            gbxOrdenar.Controls.Add(cboOrdenarFecha);
            gbxOrdenar.Controls.Add(cboOrdenarNroPedido);
            gbxOrdenar.Controls.Add(rbtnOrdenarEstado);
            gbxOrdenar.Controls.Add(rbtnOrdenarFecha);
            gbxOrdenar.Controls.Add(rbtnOrdenarNroPedido);
            gbxOrdenar.Location = new Point(619, 217);
            gbxOrdenar.Name = "gbxOrdenar";
            gbxOrdenar.Size = new Size(236, 110);
            gbxOrdenar.TabIndex = 4;
            gbxOrdenar.TabStop = false;
            gbxOrdenar.Text = "Ordenar";
            // 
            // cboOrdenarEstado
            // 
            cboOrdenarEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrdenarEstado.FormattingEnabled = true;
            cboOrdenarEstado.Items.AddRange(new object[] { "ASC", "DESC" });
            cboOrdenarEstado.Location = new Point(128, 80);
            cboOrdenarEstado.Name = "cboOrdenarEstado";
            cboOrdenarEstado.Size = new Size(94, 23);
            cboOrdenarEstado.TabIndex = 6;
            cboOrdenarEstado.SelectedIndexChanged += cboOrdenarEstado_SelectedIndexChanged;
            // 
            // cboOrdenarFecha
            // 
            cboOrdenarFecha.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrdenarFecha.FormattingEnabled = true;
            cboOrdenarFecha.Items.AddRange(new object[] { "ASC", "DESC" });
            cboOrdenarFecha.Location = new Point(128, 51);
            cboOrdenarFecha.Name = "cboOrdenarFecha";
            cboOrdenarFecha.Size = new Size(94, 23);
            cboOrdenarFecha.TabIndex = 5;
            cboOrdenarFecha.SelectedIndexChanged += cboOrdenarFecha_SelectedIndexChanged;
            // 
            // cboOrdenarNroPedido
            // 
            cboOrdenarNroPedido.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrdenarNroPedido.FormattingEnabled = true;
            cboOrdenarNroPedido.Items.AddRange(new object[] { "ASC", "DESC" });
            cboOrdenarNroPedido.Location = new Point(128, 22);
            cboOrdenarNroPedido.Name = "cboOrdenarNroPedido";
            cboOrdenarNroPedido.Size = new Size(94, 23);
            cboOrdenarNroPedido.TabIndex = 4;
            cboOrdenarNroPedido.SelectedIndexChanged += cboOrdenarNroPedido_SelectedIndexChanged;
            // 
            // rbtnOrdenarEstado
            // 
            rbtnOrdenarEstado.AutoSize = true;
            rbtnOrdenarEstado.Location = new Point(12, 81);
            rbtnOrdenarEstado.Name = "rbtnOrdenarEstado";
            rbtnOrdenarEstado.Size = new Size(60, 19);
            rbtnOrdenarEstado.TabIndex = 3;
            rbtnOrdenarEstado.TabStop = true;
            rbtnOrdenarEstado.Text = "Estado";
            rbtnOrdenarEstado.UseVisualStyleBackColor = true;
            rbtnOrdenarEstado.Click += rbtnOrdenarEstado_Click;
            // 
            // rbtnOrdenarFecha
            // 
            rbtnOrdenarFecha.AutoSize = true;
            rbtnOrdenarFecha.Location = new Point(12, 52);
            rbtnOrdenarFecha.Name = "rbtnOrdenarFecha";
            rbtnOrdenarFecha.Size = new Size(110, 19);
            rbtnOrdenarFecha.TabIndex = 2;
            rbtnOrdenarFecha.TabStop = true;
            rbtnOrdenarFecha.Text = "Fecha solicitado";
            rbtnOrdenarFecha.UseVisualStyleBackColor = true;
            rbtnOrdenarFecha.Click += rbtnOrdenarFecha_Click;
            // 
            // rbtnOrdenarNroPedido
            // 
            rbtnOrdenarNroPedido.AutoSize = true;
            rbtnOrdenarNroPedido.Location = new Point(12, 26);
            rbtnOrdenarNroPedido.Name = "rbtnOrdenarNroPedido";
            rbtnOrdenarNroPedido.Size = new Size(88, 19);
            rbtnOrdenarNroPedido.TabIndex = 0;
            rbtnOrdenarNroPedido.TabStop = true;
            rbtnOrdenarNroPedido.Text = "Nro. Pedido";
            rbtnOrdenarNroPedido.UseVisualStyleBackColor = true;
            rbtnOrdenarNroPedido.Click += rbtnOrdenarNroPedido_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 352);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(159, 35);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(695, 352);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(159, 35);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(619, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(235, 27);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ListarPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 402);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnRegresar);
            Controls.Add(gbxOrdenar);
            Controls.Add(gbxFiltrar);
            Controls.Add(dgvPedidos);
            Name = "ListarPedidos";
            Text = "ListarPedidos";
            Load += ListarPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            gbxFiltrar.ResumeLayout(false);
            gbxFiltrar.PerformLayout();
            gbxOrdenar.ResumeLayout(false);
            gbxOrdenar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPedidos;
        private GroupBox gbxFiltrar;
        private RadioButton rbtnFiltrarNroPedido;
        private TextBox txtFiltrarEstado;
        private RadioButton rbtnFiltrarEstado;
        private TextBox txtFiltrarIdCliente;
        private TextBox txtFiltrarNroPedido;
        private RadioButton rbtnFiltrarIdCliente;
        private GroupBox gbxOrdenar;
        private ComboBox cboOrdenarNroPedido;
        private RadioButton rbtnOrdenarEstado;
        private RadioButton rbtnOrdenarFecha;
        private RadioButton rbtnOrdenarNroPedido;
        private ComboBox cboFiltrarEstado;
        private ComboBox cboOrdenarEstado;
        private ComboBox cboOrdenarFecha;
        private Button btnRegresar;
        private Button btnModificar;
        private RadioButton rbtnTodo;
        private RadioButton rbtnFiltrarTodo;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn colNro;
        private DataGridViewTextBoxColumn colMenu;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colEstado;
    }
}