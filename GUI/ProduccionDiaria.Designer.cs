namespace SISVIANSA_ITI_2023.GUI
{
    partial class ProduccionDiaria
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProduccionDiaria));
            lblOrden = new Label();
            btnEstablecer = new Button();
            dgvProduccion = new DataGridView();
            colIdMenu = new DataGridViewTextBoxColumn();
            colStockMinimo = new DataGridViewTextBoxColumn();
            colCantidadViandas = new DataGridViewTextBoxColumn();
            colStockMax = new DataGridViewTextBoxColumn();
            colCoccion = new DataGridViewTextBoxColumn();
            colPrioridad = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
            lblCapProdSuc = new Label();
            txtCapProdSuc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProduccion).BeginInit();
            SuspendLayout();
            // 
            // lblOrden
            // 
            lblOrden.AutoSize = true;
            lblOrden.Location = new Point(12, 21);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(177, 15);
            lblOrden.TabIndex = 1;
            lblOrden.Text = "Seleccione orden de produccion";
            // 
            // btnEstablecer
            // 
            btnEstablecer.Location = new Point(756, 15);
            btnEstablecer.Name = "btnEstablecer";
            btnEstablecer.Size = new Size(129, 27);
            btnEstablecer.TabIndex = 2;
            btnEstablecer.Text = "Establecer orden";
            btnEstablecer.UseVisualStyleBackColor = true;
            btnEstablecer.Click += btnEstablecer_Click;
            // 
            // dgvProduccion
            // 
            dgvProduccion.AllowUserToAddRows = false;
            dgvProduccion.AllowUserToDeleteRows = false;
            dgvProduccion.AllowUserToResizeColumns = false;
            dgvProduccion.AllowUserToResizeRows = false;
            dgvProduccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduccion.Columns.AddRange(new DataGridViewColumn[] { colIdMenu, colStockMinimo, colCantidadViandas, colStockMax, colCoccion, colPrioridad, colCantidad });
            dgvProduccion.Location = new Point(12, 48);
            dgvProduccion.MultiSelect = false;
            dgvProduccion.Name = "dgvProduccion";
            dgvProduccion.RowHeadersWidth = 51;
            dgvProduccion.RowTemplate.Height = 25;
            dgvProduccion.Size = new Size(873, 375);
            dgvProduccion.TabIndex = 3;
            dgvProduccion.CellEndEdit += dgvProduccion_CellEndEdit;
            dgvProduccion.CellFormatting += dgvProduccion_CellFormatting;
            dgvProduccion.Click += dgvProduccion_Click;
            dgvProduccion.KeyDown += dgvProduccion_KeyDown;
            // 
            // colIdMenu
            // 
            colIdMenu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colIdMenu.FillWeight = 99.13979F;
            colIdMenu.HeaderText = "Id menu";
            colIdMenu.MaxInputLength = 100;
            colIdMenu.MinimumWidth = 6;
            colIdMenu.Name = "colIdMenu";
            colIdMenu.ReadOnly = true;
            colIdMenu.Resizable = DataGridViewTriState.False;
            // 
            // colStockMinimo
            // 
            colStockMinimo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStockMinimo.FillWeight = 104.068741F;
            colStockMinimo.HeaderText = "Stock Min";
            colStockMinimo.MaxInputLength = 100;
            colStockMinimo.MinimumWidth = 6;
            colStockMinimo.Name = "colStockMinimo";
            colStockMinimo.ReadOnly = true;
            colStockMinimo.Resizable = DataGridViewTriState.False;
            // 
            // colCantidadViandas
            // 
            colCantidadViandas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCantidadViandas.FillWeight = 108.413025F;
            colCantidadViandas.HeaderText = "Stock Actual";
            colCantidadViandas.MinimumWidth = 6;
            colCantidadViandas.Name = "colCantidadViandas";
            colCantidadViandas.ReadOnly = true;
            colCantidadViandas.Resizable = DataGridViewTriState.False;
            // 
            // colStockMax
            // 
            colStockMax.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStockMax.FillWeight = 110.206848F;
            colStockMax.HeaderText = "Stock Max";
            colStockMax.MinimumWidth = 6;
            colStockMax.Name = "colStockMax";
            colStockMax.ReadOnly = true;
            colStockMax.Resizable = DataGridViewTriState.False;
            // 
            // colCoccion
            // 
            colCoccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCoccion.FillWeight = 103.347542F;
            colCoccion.HeaderText = "Tiempo coccion";
            colCoccion.Name = "colCoccion";
            colCoccion.ReadOnly = true;
            colCoccion.Resizable = DataGridViewTriState.False;
            // 
            // colPrioridad
            // 
            colPrioridad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPrioridad.FillWeight = 85.99152F;
            colPrioridad.HeaderText = "Prioridad";
            colPrioridad.MinimumWidth = 6;
            colPrioridad.Name = "colPrioridad";
            colPrioridad.Resizable = DataGridViewTriState.False;
            // 
            // colCantidad
            // 
            colCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCantidad.FillWeight = 88.8325F;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.Resizable = DataGridViewTriState.False;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(631, 14);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(91, 28);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblCapProdSuc
            // 
            lblCapProdSuc.AutoSize = true;
            lblCapProdSuc.Location = new Point(317, 21);
            lblCapProdSuc.Name = "lblCapProdSuc";
            lblCapProdSuc.Size = new Size(188, 15);
            lblCapProdSuc.TabIndex = 5;
            lblCapProdSuc.Text = "Capacidad de produccion restante";
            // 
            // txtCapProdSuc
            // 
            txtCapProdSuc.Location = new Point(511, 18);
            txtCapProdSuc.Name = "txtCapProdSuc";
            txtCapProdSuc.ReadOnly = true;
            txtCapProdSuc.Size = new Size(91, 23);
            txtCapProdSuc.TabIndex = 6;
            // 
            // ProduccionDiaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 432);
            Controls.Add(txtCapProdSuc);
            Controls.Add(lblCapProdSuc);
            Controls.Add(btnRegresar);
            Controls.Add(dgvProduccion);
            Controls.Add(btnEstablecer);
            Controls.Add(lblOrden);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProduccionDiaria";
            Text = "Produccion diaria";
            Load += ProduccionDiaria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduccion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMenus;
        private Label lblOrden;
        private Button btnEstablecer;
        private DataGridView dgvProduccion;
        private Button btnRegresar;
        private Label lblCapProdSuc;
        private TextBox txtCapProdSuc;
        private DataGridViewTextBoxColumn colIdMenu;
        private DataGridViewTextBoxColumn colStockMinimo;
        private DataGridViewTextBoxColumn colCantidadViandas;
        private DataGridViewTextBoxColumn colStockMax;
        private DataGridViewTextBoxColumn colCoccion;
        private DataGridViewTextBoxColumn colPrioridad;
        private DataGridViewTextBoxColumn colCantidad;
    }
}