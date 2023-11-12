namespace SISVIANSA_ITI_2023.GUI
{
    partial class ListarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarUsuario));
            dgvUsuarios = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            btnBaja = new Button();
            btnModificar = new Button();
            btnRegresar = new Button();
            btnAlta = new Button();
            gbxFiltros = new GroupBox();
            rbtnTodo = new RadioButton();
            cboRol = new ComboBox();
            txtUsuario = new TextBox();
            rbtnInactivo = new RadioButton();
            rbtnActivo = new RadioButton();
            rbtnRol = new RadioButton();
            rbtnUsuario = new RadioButton();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            gbxFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { colId, colUsuario, colRol, colActivo });
            dgvUsuarios.Location = new Point(12, 171);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(592, 278);
            dgvUsuarios.TabIndex = 0;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colUsuario
            // 
            colUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUsuario.HeaderText = "Usuario";
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            // 
            // colRol
            // 
            colRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRol.HeaderText = "Rol";
            colRol.Name = "colRol";
            colRol.ReadOnly = true;
            // 
            // colActivo
            // 
            colActivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(323, 481);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(128, 29);
            btnBaja.TabIndex = 1;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(476, 481);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(128, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 481);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(128, 29);
            btnRegresar.TabIndex = 3;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(167, 481);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(128, 29);
            btnAlta.TabIndex = 4;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // gbxFiltros
            // 
            gbxFiltros.Controls.Add(rbtnTodo);
            gbxFiltros.Controls.Add(cboRol);
            gbxFiltros.Controls.Add(txtUsuario);
            gbxFiltros.Controls.Add(rbtnInactivo);
            gbxFiltros.Controls.Add(rbtnActivo);
            gbxFiltros.Controls.Add(rbtnRol);
            gbxFiltros.Controls.Add(rbtnUsuario);
            gbxFiltros.Location = new Point(12, 12);
            gbxFiltros.Name = "gbxFiltros";
            gbxFiltros.Size = new Size(264, 142);
            gbxFiltros.TabIndex = 5;
            gbxFiltros.TabStop = false;
            gbxFiltros.Text = "Filtros";
            // 
            // rbtnTodo
            // 
            rbtnTodo.AutoSize = true;
            rbtnTodo.Location = new Point(200, 104);
            rbtnTodo.Name = "rbtnTodo";
            rbtnTodo.Size = new Size(51, 19);
            rbtnTodo.TabIndex = 6;
            rbtnTodo.TabStop = true;
            rbtnTodo.Text = "Todo";
            rbtnTodo.UseVisualStyleBackColor = true;
            rbtnTodo.CheckedChanged += rbtnTodo_Click;
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.Enabled = false;
            cboRol.FormattingEnabled = true;
            cboRol.Items.AddRange(new object[] { "Gerente", "Informatico", "Jefe de cocina", "Administrativo", "Atencion al cliente", "Transporte" });
            cboRol.Location = new Point(77, 67);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(174, 23);
            cboRol.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(77, 24);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(174, 23);
            txtUsuario.TabIndex = 4;
            // 
            // rbtnInactivo
            // 
            rbtnInactivo.AutoSize = true;
            rbtnInactivo.Location = new Point(100, 104);
            rbtnInactivo.Name = "rbtnInactivo";
            rbtnInactivo.Size = new Size(67, 19);
            rbtnInactivo.TabIndex = 3;
            rbtnInactivo.TabStop = true;
            rbtnInactivo.Text = "Inactivo";
            rbtnInactivo.UseVisualStyleBackColor = true;
            rbtnInactivo.CheckedChanged += rbtnInactivo_Click;
            // 
            // rbtnActivo
            // 
            rbtnActivo.AutoSize = true;
            rbtnActivo.Location = new Point(6, 104);
            rbtnActivo.Name = "rbtnActivo";
            rbtnActivo.Size = new Size(59, 19);
            rbtnActivo.TabIndex = 2;
            rbtnActivo.TabStop = true;
            rbtnActivo.Text = "Activo";
            rbtnActivo.UseVisualStyleBackColor = true;
            rbtnActivo.CheckedChanged += rbtnActivo_Click;
            // 
            // rbtnRol
            // 
            rbtnRol.AutoSize = true;
            rbtnRol.Location = new Point(6, 68);
            rbtnRol.Name = "rbtnRol";
            rbtnRol.Size = new Size(42, 19);
            rbtnRol.TabIndex = 1;
            rbtnRol.TabStop = true;
            rbtnRol.Text = "Rol";
            rbtnRol.UseVisualStyleBackColor = true;
            rbtnRol.CheckedChanged += rbtnRol_Click;
            // 
            // rbtnUsuario
            // 
            rbtnUsuario.AutoSize = true;
            rbtnUsuario.Location = new Point(6, 25);
            rbtnUsuario.Name = "rbtnUsuario";
            rbtnUsuario.Size = new Size(65, 19);
            rbtnUsuario.TabIndex = 0;
            rbtnUsuario.TabStop = true;
            rbtnUsuario.Text = "Usuario";
            rbtnUsuario.UseVisualStyleBackColor = true;
            rbtnUsuario.CheckedChanged += rbtnUsuario_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(365, 59);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(208, 61);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ListarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 522);
            Controls.Add(btnBuscar);
            Controls.Add(gbxFiltros);
            Controls.Add(btnAlta);
            Controls.Add(btnRegresar);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(dgvUsuarios);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListarUsuario";
            Text = "Listar personal";
            Load += ListarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            gbxFiltros.ResumeLayout(false);
            gbxFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Button btnBaja;
        private Button btnModificar;
        private Button btnRegresar;
        private Button btnAlta;
        private GroupBox gbxFiltros;
        private RadioButton rbtnUsuario;
        private ComboBox cboRol;
        private TextBox txtUsuario;
        private RadioButton rbtnInactivo;
        private RadioButton rbtnActivo;
        private RadioButton rbtnRol;
        private RadioButton rbtnTodo;
        private Button btnBuscar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colRol;
        private DataGridViewTextBoxColumn colActivo;
    }
}