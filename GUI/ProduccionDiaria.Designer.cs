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
            lblOrden = new Label();
            btnEstablecer = new Button();
            dgvProduccion = new DataGridView();
            colIdMenu = new DataGridViewTextBoxColumn();
            colCantidadViandas = new DataGridViewTextBoxColumn();
            colStockMinimo = new DataGridViewTextBoxColumn();
            colStockMax = new DataGridViewTextBoxColumn();
            colPrioridad = new DataGridViewTextBoxColumn();
            btnRegresar = new Button();
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
            btnEstablecer.Location = new Point(561, 15);
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
            dgvProduccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduccion.Columns.AddRange(new DataGridViewColumn[] { colIdMenu, colCantidadViandas, colStockMinimo, colStockMax, colPrioridad });
            dgvProduccion.Location = new Point(12, 48);
            dgvProduccion.MultiSelect = false;
            dgvProduccion.Name = "dgvProduccion";
            dgvProduccion.RowHeadersWidth = 51;
            dgvProduccion.RowTemplate.Height = 25;
            dgvProduccion.Size = new Size(678, 375);
            dgvProduccion.TabIndex = 3;
            dgvProduccion.CellEndEdit += dgvProduccion_CellEndEdit;
            dgvProduccion.CellFormatting += dgvProduccion_CellFormatting;
            // 
            // colIdMenu
            // 
            colIdMenu.HeaderText = "Id menu";
            colIdMenu.MinimumWidth = 6;
            colIdMenu.Name = "colIdMenu";
            colIdMenu.ReadOnly = true;
            colIdMenu.Width = 125;
            // 
            // colCantidadViandas
            // 
            colCantidadViandas.HeaderText = "Stock Actual";
            colCantidadViandas.MinimumWidth = 6;
            colCantidadViandas.Name = "colCantidadViandas";
            colCantidadViandas.ReadOnly = true;
            colCantidadViandas.Width = 125;
            // 
            // colStockMinimo
            // 
            colStockMinimo.HeaderText = "Stock Min";
            colStockMinimo.MinimumWidth = 6;
            colStockMinimo.Name = "colStockMinimo";
            colStockMinimo.ReadOnly = true;
            colStockMinimo.Width = 125;
            // 
            // colStockMax
            // 
            colStockMax.HeaderText = "Stock Max";
            colStockMax.MinimumWidth = 6;
            colStockMax.Name = "colStockMax";
            colStockMax.ReadOnly = true;
            colStockMax.Width = 125;
            // 
            // colPrioridad
            // 
            colPrioridad.HeaderText = "Prioridad";
            colPrioridad.MinimumWidth = 6;
            colPrioridad.Name = "colPrioridad";
            colPrioridad.Width = 125;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(447, 15);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(91, 28);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // ProduccionDiaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 432);
            Controls.Add(btnRegresar);
            Controls.Add(dgvProduccion);
            Controls.Add(btnEstablecer);
            Controls.Add(lblOrden);
            Name = "ProduccionDiaria";
            Text = "ProduccionDiaria";
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
        private DataGridViewTextBoxColumn colIdMenu;
        private DataGridViewTextBoxColumn colCantidadViandas;
        private DataGridViewTextBoxColumn colStockMinimo;
        private DataGridViewTextBoxColumn colStockMax;
        private DataGridViewTextBoxColumn colPrioridad;
        private Button btnRegresar;
    }
}