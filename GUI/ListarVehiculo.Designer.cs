namespace ventana3
{
    partial class ListarVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarVehiculo));
            txtMatricula = new TextBox();
            btnBuscar = new Button();
            dgvVehiculos = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colMatricula = new DataGridViewTextBoxColumn();
            colCapCarga = new DataGridViewTextBoxColumn();
            colActivo = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            btnAsignarZona = new Button();
            btnBaja = new Button();
            btnDetalles = new Button();
            rbtnMatricula = new RadioButton();
            rbtnZona = new RadioButton();
            cboZona = new ComboBox();
            rbtnTodo = new RadioButton();
            btnAlta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(93, 14);
            txtMatricula.Margin = new Padding(3, 2, 3, 2);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(105, 23);
            txtMatricula.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(475, 14);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(71, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.AllowUserToAddRows = false;
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Columns.AddRange(new DataGridViewColumn[] { colId, colMatricula, colCapCarga, colActivo });
            dgvVehiculos.Location = new Point(12, 55);
            dgvVehiculos.Margin = new Padding(3, 2, 3, 2);
            dgvVehiculos.MultiSelect = false;
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.ReadOnly = true;
            dgvVehiculos.RowHeadersWidth = 51;
            dgvVehiculos.RowTemplate.Height = 29;
            dgvVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculos.Size = new Size(534, 259);
            dgvVehiculos.TabIndex = 5;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 80;
            // 
            // colMatricula
            // 
            colMatricula.HeaderText = "Matricula";
            colMatricula.Name = "colMatricula";
            colMatricula.ReadOnly = true;
            colMatricula.Width = 150;
            // 
            // colCapCarga
            // 
            colCapCarga.HeaderText = "Cap. carga";
            colCapCarga.Name = "colCapCarga";
            colCapCarga.ReadOnly = true;
            colCapCarga.Width = 150;
            // 
            // colActivo
            // 
            colActivo.HeaderText = "Activo";
            colActivo.Name = "colActivo";
            colActivo.ReadOnly = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 332);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(102, 29);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAsignarZona
            // 
            btnAsignarZona.Location = new Point(336, 332);
            btnAsignarZona.Margin = new Padding(3, 2, 3, 2);
            btnAsignarZona.Name = "btnAsignarZona";
            btnAsignarZona.Size = new Size(102, 29);
            btnAsignarZona.TabIndex = 7;
            btnAsignarZona.Text = "Asignar Zona";
            btnAsignarZona.UseVisualStyleBackColor = true;
            btnAsignarZona.Click += btnAsignarZona_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(228, 332);
            btnBaja.Margin = new Padding(3, 2, 3, 2);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(102, 29);
            btnBaja.TabIndex = 8;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(444, 332);
            btnDetalles.Margin = new Padding(3, 2, 3, 2);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(102, 29);
            btnDetalles.TabIndex = 9;
            btnDetalles.Text = "Ver detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // rbtnMatricula
            // 
            rbtnMatricula.AutoSize = true;
            rbtnMatricula.Location = new Point(12, 17);
            rbtnMatricula.Name = "rbtnMatricula";
            rbtnMatricula.Size = new Size(75, 19);
            rbtnMatricula.TabIndex = 10;
            rbtnMatricula.TabStop = true;
            rbtnMatricula.Text = "Matricula";
            rbtnMatricula.UseVisualStyleBackColor = true;
            rbtnMatricula.Click += rbtnMatricula_Click;
            // 
            // rbtnZona
            // 
            rbtnZona.AutoSize = true;
            rbtnZona.Location = new Point(227, 17);
            rbtnZona.Name = "rbtnZona";
            rbtnZona.Size = new Size(52, 19);
            rbtnZona.TabIndex = 11;
            rbtnZona.TabStop = true;
            rbtnZona.Text = "Zona";
            rbtnZona.UseVisualStyleBackColor = true;
            rbtnZona.Click += rbtnZona_Click;
            // 
            // cboZona
            // 
            cboZona.DropDownStyle = ComboBoxStyle.DropDownList;
            cboZona.FormattingEnabled = true;
            cboZona.Location = new Point(281, 15);
            cboZona.Name = "cboZona";
            cboZona.Size = new Size(91, 23);
            cboZona.TabIndex = 12;
            // 
            // rbtnTodo
            // 
            rbtnTodo.AutoSize = true;
            rbtnTodo.Location = new Point(409, 18);
            rbtnTodo.Name = "rbtnTodo";
            rbtnTodo.Size = new Size(51, 19);
            rbtnTodo.TabIndex = 13;
            rbtnTodo.TabStop = true;
            rbtnTodo.Text = "Todo";
            rbtnTodo.UseVisualStyleBackColor = true;
            rbtnTodo.Click += rbtnTodo_Click;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(120, 332);
            btnAlta.Margin = new Padding(3, 2, 3, 2);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(102, 29);
            btnAlta.TabIndex = 14;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // ListarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 370);
            Controls.Add(btnAlta);
            Controls.Add(rbtnTodo);
            Controls.Add(cboZona);
            Controls.Add(rbtnZona);
            Controls.Add(rbtnMatricula);
            Controls.Add(btnDetalles);
            Controls.Add(btnBaja);
            Controls.Add(btnAsignarZona);
            Controls.Add(btnRegresar);
            Controls.Add(dgvVehiculos);
            Controls.Add(btnBuscar);
            Controls.Add(txtMatricula);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListarVehiculo";
            Text = "Listar vehiculos";
            Load += ListarVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtMatricula;
        private Button btnBuscar;
        private DataGridView dgvVehiculos;
        private Button btnRegresar;
        private Button btnAsignarZona;
        private Button btnBaja;
        private Button btnDetalles;
        private RadioButton rbtnMatricula;
        private RadioButton rbtnZona;
        private ComboBox cboZona;
        private RadioButton rbtnTodo;
        private Button btnAlta;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colMatricula;
        private DataGridViewTextBoxColumn colCapCarga;
        private DataGridViewTextBoxColumn colActivo;
    }
}