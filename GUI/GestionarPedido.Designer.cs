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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
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
            groupBox2 = new GroupBox();
            cboDietaMenu = new ComboBox();
            cboTipoMenu = new ComboBox();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            rbtnTipoMenu = new RadioButton();
            rbtnDietaMenu = new RadioButton();
            btnBuscarCliente = new Button();
            rbtnNombreMenu = new RadioButton();
            txtNombreMenu = new TextBox();
            btnBuscarMenu = new Button();
            lblDatos = new Label();
            lblDatosCliente = new Label();
            txtNombreMenuDatos = new TextBox();
            txtDirClienteDatos = new TextBox();
            txtTotalPrecioMenu = new TextBox();
            txtIdMenuDatos = new TextBox();
            lblDatosMenu = new Label();
            nudCantidadMenu = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadMenu).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(1075, 569);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(170, 40);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Realizar pedido";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(26, 569);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(170, 40);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarCliente);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Controls.Add(rbtnNombreCliente);
            groupBox1.Controls.Add(txtDocCliente);
            groupBox1.Controls.Add(rbtnDocCliente);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(539, 308);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columna, columna1, Column2, column4, columna5, Columna6, Column6 });
            dataGridView1.Location = new Point(14, 116);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(507, 180);
            dataGridView1.TabIndex = 4;
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
            txtNombreCliente.Location = new Point(308, 28);
            txtNombreCliente.Margin = new Padding(3, 2, 3, 2);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(213, 23);
            txtNombreCliente.TabIndex = 3;
            // 
            // rbtnNombreCliente
            // 
            rbtnNombreCliente.AutoSize = true;
            rbtnNombreCliente.Location = new Point(234, 28);
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
            txtDocCliente.Location = new Point(86, 27);
            txtDocCliente.Margin = new Padding(3, 2, 3, 2);
            txtDocCliente.Name = "txtDocCliente";
            txtDocCliente.Size = new Size(135, 23);
            txtDocCliente.TabIndex = 1;
            // 
            // rbtnDocCliente
            // 
            rbtnDocCliente.AutoSize = true;
            rbtnDocCliente.Location = new Point(14, 28);
            rbtnDocCliente.Margin = new Padding(3, 2, 3, 2);
            rbtnDocCliente.Name = "rbtnDocCliente";
            rbtnDocCliente.Size = new Size(66, 19);
            rbtnDocCliente.TabIndex = 0;
            rbtnDocCliente.TabStop = true;
            rbtnDocCliente.Text = "N° Doc.";
            rbtnDocCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscarMenu);
            groupBox2.Controls.Add(txtNombreMenu);
            groupBox2.Controls.Add(rbtnNombreMenu);
            groupBox2.Controls.Add(cboDietaMenu);
            groupBox2.Controls.Add(cboTipoMenu);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(rbtnTipoMenu);
            groupBox2.Controls.Add(rbtnDietaMenu);
            groupBox2.Location = new Point(593, 23);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(652, 296);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // cboDietaMenu
            // 
            cboDietaMenu.FormattingEnabled = true;
            cboDietaMenu.Location = new Point(271, 20);
            cboDietaMenu.Margin = new Padding(3, 2, 3, 2);
            cboDietaMenu.Name = "cboDietaMenu";
            cboDietaMenu.Size = new Size(129, 23);
            cboDietaMenu.TabIndex = 6;
            // 
            // cboTipoMenu
            // 
            cboTipoMenu.FormattingEnabled = true;
            cboTipoMenu.Location = new Point(487, 20);
            cboTipoMenu.Margin = new Padding(3, 2, 3, 2);
            cboTipoMenu.Name = "cboTipoMenu";
            cboTipoMenu.Size = new Size(146, 23);
            cboTipoMenu.TabIndex = 5;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column5, Column7, Column8 });
            dataGridView2.Location = new Point(20, 111);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(613, 173);
            dataGridView2.TabIndex = 4;
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
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(14, 67);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(507, 32);
            btnBuscarCliente.TabIndex = 5;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // rbtnNombreMenu
            // 
            rbtnNombreMenu.AutoSize = true;
            rbtnNombreMenu.Location = new Point(20, 19);
            rbtnNombreMenu.Margin = new Padding(3, 2, 3, 2);
            rbtnNombreMenu.Name = "rbtnNombreMenu";
            rbtnNombreMenu.Size = new Size(69, 19);
            rbtnNombreMenu.TabIndex = 7;
            rbtnNombreMenu.TabStop = true;
            rbtnNombreMenu.Text = "Nombre";
            rbtnNombreMenu.UseVisualStyleBackColor = true;
            // 
            // txtNombreMenu
            // 
            txtNombreMenu.Location = new Point(95, 18);
            txtNombreMenu.Margin = new Padding(3, 2, 3, 2);
            txtNombreMenu.Name = "txtNombreMenu";
            txtNombreMenu.Size = new Size(95, 23);
            txtNombreMenu.TabIndex = 6;
            // 
            // btnBuscarMenu
            // 
            btnBuscarMenu.Location = new Point(20, 57);
            btnBuscarMenu.Name = "btnBuscarMenu";
            btnBuscarMenu.Size = new Size(613, 32);
            btnBuscarMenu.TabIndex = 6;
            btnBuscarMenu.Text = "Buscar";
            btnBuscarMenu.UseVisualStyleBackColor = true;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Location = new Point(70, 344);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(96, 15);
            lblDatos.TabIndex = 20;
            lblDatos.Text = "Datos del pedido";
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Location = new Point(26, 394);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(126, 15);
            lblDatosCliente.TabIndex = 21;
            lblDatosCliente.Text = "Información de cliente";
            // 
            // txtNombreMenuDatos
            // 
            txtNombreMenuDatos.Location = new Point(179, 391);
            txtNombreMenuDatos.Margin = new Padding(3, 2, 3, 2);
            txtNombreMenuDatos.Name = "txtNombreMenuDatos";
            txtNombreMenuDatos.ReadOnly = true;
            txtNombreMenuDatos.Size = new Size(243, 23);
            txtNombreMenuDatos.TabIndex = 6;
            // 
            // txtDirClienteDatos
            // 
            txtDirClienteDatos.Location = new Point(439, 391);
            txtDirClienteDatos.Margin = new Padding(3, 2, 3, 2);
            txtDirClienteDatos.Name = "txtDirClienteDatos";
            txtDirClienteDatos.ReadOnly = true;
            txtDirClienteDatos.Size = new Size(477, 23);
            txtDirClienteDatos.TabIndex = 22;
            // 
            // txtTotalPrecioMenu
            // 
            txtTotalPrecioMenu.Location = new Point(356, 445);
            txtTotalPrecioMenu.Margin = new Padding(3, 2, 3, 2);
            txtTotalPrecioMenu.Name = "txtTotalPrecioMenu";
            txtTotalPrecioMenu.ReadOnly = true;
            txtTotalPrecioMenu.Size = new Size(156, 23);
            txtTotalPrecioMenu.TabIndex = 25;
            // 
            // txtIdMenuDatos
            // 
            txtIdMenuDatos.Location = new Point(179, 442);
            txtIdMenuDatos.Margin = new Padding(3, 2, 3, 2);
            txtIdMenuDatos.Name = "txtIdMenuDatos";
            txtIdMenuDatos.ReadOnly = true;
            txtIdMenuDatos.Size = new Size(54, 23);
            txtIdMenuDatos.TabIndex = 23;
            // 
            // lblDatosMenu
            // 
            lblDatosMenu.AutoSize = true;
            lblDatosMenu.Location = new Point(26, 445);
            lblDatosMenu.Name = "lblDatosMenu";
            lblDatosMenu.Size = new Size(122, 15);
            lblDatosMenu.TabIndex = 24;
            lblDatosMenu.Text = "Información de menu";
            // 
            // nudCantidadMenu
            // 
            nudCantidadMenu.Location = new Point(267, 445);
            nudCantidadMenu.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            nudCantidadMenu.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidadMenu.Name = "nudCantidadMenu";
            nudCantidadMenu.ReadOnly = true;
            nudCantidadMenu.Size = new Size(64, 23);
            nudCantidadMenu.TabIndex = 26;
            nudCantidadMenu.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // GestionarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 624);
            Controls.Add(nudCantidadMenu);
            Controls.Add(txtTotalPrecioMenu);
            Controls.Add(txtIdMenuDatos);
            Controls.Add(lblDatosMenu);
            Controls.Add(txtDirClienteDatos);
            Controls.Add(txtNombreMenuDatos);
            Controls.Add(lblDatosCliente);
            Controls.Add(lblDatos);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "GestionarPedido";
            Text = "RealizarPedido";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbtnDocCliente;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox txtNombreCliente;
        private RadioButton rbtnNombreCliente;
        private TextBox txtDocCliente;
        private RadioButton rbtnTipoMenu;
        private RadioButton rbtnDietaMenu;
        private DataGridView dataGridView2;
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
        private Label lblDatos;
        private Label lblDatosCliente;
        private TextBox txtNombreMenuDatos;
        private TextBox txtDirClienteDatos;
        private TextBox txtTotalPrecioMenu;
        private TextBox txtIdMenuDatos;
        private Label lblDatosMenu;
        private NumericUpDown nudCantidadMenu;
    }
}