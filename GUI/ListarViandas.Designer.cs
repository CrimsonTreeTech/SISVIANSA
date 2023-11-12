namespace SISVIANSA_ITI_2023.GUI
{
    partial class ListarViandas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarViandas));
            gbxFiltros = new GroupBox();
            btnBuscar = new Button();
            txtVencimiento = new TextBox();
            txtMenu = new TextBox();
            cboSucursal = new ComboBox();
            rbtnSucursal = new RadioButton();
            rbtnVencimiento = new RadioButton();
            rbtnMenu = new RadioButton();
            rbtnTodo = new RadioButton();
            dataGridView1 = new DataGridView();
            colIdVianda = new DataGridViewTextBoxColumn();
            colMenu = new DataGridViewTextBoxColumn();
            colEnvasado = new DataGridViewTextBoxColumn();
            colVencimiento = new DataGridViewTextBoxColumn();
            colSucursal = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            btnDesechar = new Button();
            gbxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbxFiltros
            // 
            gbxFiltros.Controls.Add(btnBuscar);
            gbxFiltros.Controls.Add(txtVencimiento);
            gbxFiltros.Controls.Add(txtMenu);
            gbxFiltros.Controls.Add(cboSucursal);
            gbxFiltros.Controls.Add(rbtnSucursal);
            gbxFiltros.Controls.Add(rbtnVencimiento);
            gbxFiltros.Controls.Add(rbtnMenu);
            gbxFiltros.Controls.Add(rbtnTodo);
            gbxFiltros.Location = new Point(12, 12);
            gbxFiltros.Name = "gbxFiltros";
            gbxFiltros.Size = new Size(776, 73);
            gbxFiltros.TabIndex = 0;
            gbxFiltros.TabStop = false;
            gbxFiltros.Text = "Filtros";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(622, 25);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(136, 32);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtVencimiento
            // 
            txtVencimiento.Location = new Point(485, 31);
            txtVencimiento.Name = "txtVencimiento";
            txtVencimiento.Size = new Size(80, 23);
            txtVencimiento.TabIndex = 6;
            // 
            // txtMenu
            // 
            txtMenu.Location = new Point(310, 31);
            txtMenu.Name = "txtMenu";
            txtMenu.Size = new Size(54, 23);
            txtMenu.TabIndex = 5;
            // 
            // cboSucursal
            // 
            cboSucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(159, 31);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(62, 23);
            cboSucursal.TabIndex = 4;
            // 
            // rbtnSucursal
            // 
            rbtnSucursal.AutoSize = true;
            rbtnSucursal.Location = new Point(84, 32);
            rbtnSucursal.Name = "rbtnSucursal";
            rbtnSucursal.Size = new Size(69, 19);
            rbtnSucursal.TabIndex = 3;
            rbtnSucursal.TabStop = true;
            rbtnSucursal.Text = "Sucursal";
            rbtnSucursal.UseVisualStyleBackColor = true;
            rbtnSucursal.Click += rbtnSucursal_Click;
            // 
            // rbtnVencimiento
            // 
            rbtnVencimiento.AutoSize = true;
            rbtnVencimiento.Location = new Point(388, 32);
            rbtnVencimiento.Name = "rbtnVencimiento";
            rbtnVencimiento.Size = new Size(91, 19);
            rbtnVencimiento.TabIndex = 2;
            rbtnVencimiento.TabStop = true;
            rbtnVencimiento.Text = "Vencimiento";
            rbtnVencimiento.UseVisualStyleBackColor = true;
            rbtnVencimiento.Click += rbtnVencimiento_Click;
            // 
            // rbtnMenu
            // 
            rbtnMenu.AutoSize = true;
            rbtnMenu.Location = new Point(248, 32);
            rbtnMenu.Name = "rbtnMenu";
            rbtnMenu.Size = new Size(56, 19);
            rbtnMenu.TabIndex = 1;
            rbtnMenu.TabStop = true;
            rbtnMenu.Text = "Menu";
            rbtnMenu.UseVisualStyleBackColor = true;
            rbtnMenu.Click += rbtnMenu_Click;
            // 
            // rbtnTodo
            // 
            rbtnTodo.AutoSize = true;
            rbtnTodo.Location = new Point(6, 32);
            rbtnTodo.Name = "rbtnTodo";
            rbtnTodo.Size = new Size(51, 19);
            rbtnTodo.TabIndex = 0;
            rbtnTodo.TabStop = true;
            rbtnTodo.Text = "Todo";
            rbtnTodo.UseVisualStyleBackColor = true;
            rbtnTodo.Click += rbtnTodo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colIdVianda, colMenu, colEnvasado, colVencimiento, colSucursal });
            dataGridView1.Location = new Point(12, 91);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 334);
            dataGridView1.TabIndex = 1;
            // 
            // colIdVianda
            // 
            colIdVianda.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colIdVianda.HeaderText = "Nª Vianda";
            colIdVianda.Name = "colIdVianda";
            colIdVianda.ReadOnly = true;
            // 
            // colMenu
            // 
            colMenu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMenu.HeaderText = "Menu";
            colMenu.Name = "colMenu";
            colMenu.ReadOnly = true;
            // 
            // colEnvasado
            // 
            colEnvasado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEnvasado.HeaderText = "Fecha de envasado";
            colEnvasado.Name = "colEnvasado";
            colEnvasado.ReadOnly = true;
            // 
            // colVencimiento
            // 
            colVencimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colVencimiento.HeaderText = "Fecha de vencimiento";
            colVencimiento.Name = "colVencimiento";
            colVencimiento.ReadOnly = true;
            // 
            // colSucursal
            // 
            colSucursal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSucursal.HeaderText = "Sucursal";
            colSucursal.Name = "colSucursal";
            colSucursal.ReadOnly = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 444);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(179, 36);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnDesechar
            // 
            btnDesechar.Location = new Point(609, 444);
            btnDesechar.Name = "btnDesechar";
            btnDesechar.Size = new Size(179, 36);
            btnDesechar.TabIndex = 3;
            btnDesechar.Text = "Descechar vencidos";
            btnDesechar.UseVisualStyleBackColor = true;
            btnDesechar.Click += btnDesechar_Click;
            // 
            // ListarViandas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(btnDesechar);
            Controls.Add(btnRegresar);
            Controls.Add(dataGridView1);
            Controls.Add(gbxFiltros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListarViandas";
            Text = "Listar viandas";
            Load += ListarViandas_Load;
            gbxFiltros.ResumeLayout(false);
            gbxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxFiltros;
        private ComboBox cboSucursal;
        private RadioButton rbtnSucursal;
        private RadioButton rbtnVencimiento;
        private RadioButton rbtnMenu;
        private RadioButton rbtnTodo;
        private Button btnBuscar;
        private TextBox txtVencimiento;
        private TextBox txtMenu;
        private DataGridView dataGridView1;
        private Button btnRegresar;
        private Button btnDesechar;
        private DataGridViewTextBoxColumn colIdVianda;
        private DataGridViewTextBoxColumn colMenu;
        private DataGridViewTextBoxColumn colEnvasado;
        private DataGridViewTextBoxColumn colVencimiento;
        private DataGridViewTextBoxColumn colSucursal;
    }
}