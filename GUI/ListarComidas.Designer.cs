namespace SISVIANSA_ITI_2023.GUI
{
    partial class ListarComidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarComidas));
            dgvComidas = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCoccion = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            colAutorizado = new DataGridViewTextBoxColumn();
            colDietas = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            btnModificar = new Button();
            Filtos = new GroupBox();
            chkLstDietas = new CheckedListBox();
            txtNombre = new TextBox();
            rbtnDietas = new RadioButton();
            rbtnInactivo = new RadioButton();
            rbtnActivo = new RadioButton();
            rbtnNoAutorizado = new RadioButton();
            rbtnAutorizado = new RadioButton();
            rbtnNombre = new RadioButton();
            rbtnTodo = new RadioButton();
            bntBuscar = new Button();
            btnBaja = new Button();
            btnAutorizar = new Button();
            btnAlta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvComidas).BeginInit();
            Filtos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvComidas
            // 
            dgvComidas.AllowUserToAddRows = false;
            dgvComidas.AllowUserToDeleteRows = false;
            dgvComidas.AllowUserToResizeColumns = false;
            dgvComidas.AllowUserToResizeRows = false;
            dgvComidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComidas.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colCoccion, colActivo, colAutorizado, colDietas });
            dgvComidas.Location = new Point(12, 133);
            dgvComidas.MultiSelect = false;
            dgvComidas.Name = "dgvComidas";
            dgvComidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComidas.Size = new Size(964, 360);
            dgvComidas.TabIndex = 0;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colId.FillWeight = 30.0277176F;
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.FillWeight = 121.8274F;
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colCoccion
            // 
            colCoccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCoccion.FillWeight = 97.36156F;
            colCoccion.HeaderText = "Coccion (min)";
            colCoccion.Name = "colCoccion";
            colCoccion.ReadOnly = true;
            // 
            // colActivo
            // 
            colActivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colActivo.FillWeight = 61.1655769F;
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // colAutorizado
            // 
            colAutorizado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAutorizado.FillWeight = 59.18973F;
            colAutorizado.HeaderText = "Autorizado";
            colAutorizado.Name = "colAutorizado";
            colAutorizado.ReadOnly = true;
            // 
            // colDietas
            // 
            colDietas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDietas.FillWeight = 230.427933F;
            colDietas.HeaderText = "Dietas";
            colDietas.Name = "colDietas";
            colDietas.ReadOnly = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 499);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(188, 38);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(788, 499);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(188, 38);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Filtos
            // 
            Filtos.Controls.Add(chkLstDietas);
            Filtos.Controls.Add(txtNombre);
            Filtos.Controls.Add(rbtnDietas);
            Filtos.Controls.Add(rbtnInactivo);
            Filtos.Controls.Add(rbtnActivo);
            Filtos.Controls.Add(rbtnNoAutorizado);
            Filtos.Controls.Add(rbtnAutorizado);
            Filtos.Controls.Add(rbtnNombre);
            Filtos.Controls.Add(rbtnTodo);
            Filtos.Location = new Point(12, 12);
            Filtos.Name = "Filtos";
            Filtos.Size = new Size(792, 115);
            Filtos.TabIndex = 3;
            Filtos.TabStop = false;
            Filtos.Text = "gbxFiltros";
            // 
            // chkLstDietas
            // 
            chkLstDietas.Enabled = false;
            chkLstDietas.FormattingEnabled = true;
            chkLstDietas.Location = new Point(582, 23);
            chkLstDietas.Name = "chkLstDietas";
            chkLstDietas.Size = new Size(196, 76);
            chkLstDietas.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(207, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(223, 23);
            txtNombre.TabIndex = 7;
            // 
            // rbtnDietas
            // 
            rbtnDietas.AutoSize = true;
            rbtnDietas.Location = new Point(506, 31);
            rbtnDietas.Name = "rbtnDietas";
            rbtnDietas.Size = new Size(57, 19);
            rbtnDietas.TabIndex = 6;
            rbtnDietas.TabStop = true;
            rbtnDietas.Text = "Dietas";
            rbtnDietas.UseVisualStyleBackColor = true;
            rbtnDietas.Click += rbtnDietas_Click;
            // 
            // rbtnInactivo
            // 
            rbtnInactivo.AutoSize = true;
            rbtnInactivo.Location = new Point(363, 80);
            rbtnInactivo.Name = "rbtnInactivo";
            rbtnInactivo.Size = new Size(67, 19);
            rbtnInactivo.TabIndex = 5;
            rbtnInactivo.TabStop = true;
            rbtnInactivo.Text = "Inactivo";
            rbtnInactivo.UseVisualStyleBackColor = true;
            rbtnInactivo.Click += rbtnInactivo_Click;
            // 
            // rbtnActivo
            // 
            rbtnActivo.AutoSize = true;
            rbtnActivo.Location = new Point(284, 80);
            rbtnActivo.Name = "rbtnActivo";
            rbtnActivo.Size = new Size(59, 19);
            rbtnActivo.TabIndex = 4;
            rbtnActivo.TabStop = true;
            rbtnActivo.Text = "Activo";
            rbtnActivo.UseVisualStyleBackColor = true;
            rbtnActivo.Click += rbtnActivo_Click;
            // 
            // rbtnNoAutorizado
            // 
            rbtnNoAutorizado.AutoSize = true;
            rbtnNoAutorizado.Location = new Point(110, 80);
            rbtnNoAutorizado.Name = "rbtnNoAutorizado";
            rbtnNoAutorizado.Size = new Size(100, 19);
            rbtnNoAutorizado.TabIndex = 3;
            rbtnNoAutorizado.TabStop = true;
            rbtnNoAutorizado.Text = "No autorizado";
            rbtnNoAutorizado.UseVisualStyleBackColor = true;
            rbtnNoAutorizado.Click += rbtnNoAutorizado_Click;
            // 
            // rbtnAutorizado
            // 
            rbtnAutorizado.AutoSize = true;
            rbtnAutorizado.Location = new Point(10, 80);
            rbtnAutorizado.Name = "rbtnAutorizado";
            rbtnAutorizado.Size = new Size(83, 19);
            rbtnAutorizado.TabIndex = 2;
            rbtnAutorizado.TabStop = true;
            rbtnAutorizado.Text = "Autorizado";
            rbtnAutorizado.UseVisualStyleBackColor = true;
            rbtnAutorizado.Click += rbtnAutorizado_Click;
            // 
            // rbtnNombre
            // 
            rbtnNombre.AutoSize = true;
            rbtnNombre.Location = new Point(132, 31);
            rbtnNombre.Name = "rbtnNombre";
            rbtnNombre.Size = new Size(69, 19);
            rbtnNombre.TabIndex = 1;
            rbtnNombre.TabStop = true;
            rbtnNombre.Text = "Nombre";
            rbtnNombre.UseVisualStyleBackColor = true;
            rbtnNombre.Click += rbtnNombre_Click;
            // 
            // rbtnTodo
            // 
            rbtnTodo.AutoSize = true;
            rbtnTodo.Location = new Point(10, 31);
            rbtnTodo.Name = "rbtnTodo";
            rbtnTodo.Size = new Size(51, 19);
            rbtnTodo.TabIndex = 0;
            rbtnTodo.TabStop = true;
            rbtnTodo.Text = "Todo";
            rbtnTodo.UseVisualStyleBackColor = true;
            rbtnTodo.Click += rbtnTodo_Click;
            // 
            // bntBuscar
            // 
            bntBuscar.Location = new Point(810, 33);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(166, 78);
            bntBuscar.TabIndex = 4;
            bntBuscar.Text = "Buscar";
            bntBuscar.UseVisualStyleBackColor = true;
            bntBuscar.Click += bntBuscar_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(206, 499);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(188, 38);
            btnBaja.TabIndex = 5;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnAutorizar
            // 
            btnAutorizar.Location = new Point(594, 499);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(188, 38);
            btnAutorizar.TabIndex = 6;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = true;
            btnAutorizar.Click += btnAutorizar_Click;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(400, 499);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(188, 38);
            btnAlta.TabIndex = 7;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // ListarComidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 549);
            Controls.Add(btnAlta);
            Controls.Add(btnAutorizar);
            Controls.Add(btnBaja);
            Controls.Add(bntBuscar);
            Controls.Add(Filtos);
            Controls.Add(btnModificar);
            Controls.Add(btnRegresar);
            Controls.Add(dgvComidas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListarComidas";
            Text = "Listar comidas";
            Load += ListarComidas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComidas).EndInit();
            Filtos.ResumeLayout(false);
            Filtos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvComidas;
        private Button btnRegresar;
        private Button btnModificar;
        private DataGridViewTextBoxColumn colTiempoProd;
        private GroupBox Filtos;
        private RadioButton rbtnDietas;
        private RadioButton rbtnInactivo;
        private RadioButton rbtnActivo;
        private RadioButton rbtnNoAutorizado;
        private RadioButton rbtnAutorizado;
        private RadioButton rbtnNombre;
        private RadioButton rbtnTodo;
        private TextBox txtNombre;
        private CheckedListBox chkLstDietas;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCoccion;
        private DataGridViewTextBoxColumn colActivo;
        private DataGridViewTextBoxColumn colAutorizado;
        private DataGridViewTextBoxColumn colDietas;
        private Button bntBuscar;
        private Button btnBaja;
        private Button btnAutorizar;
        private Button btnAlta;
    }
}