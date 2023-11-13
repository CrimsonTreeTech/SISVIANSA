namespace SISVIANSA_ITI_2023.GUI
{
    partial class HistoricoPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricoPedidos));
            lblNroPedido = new Label();
            lblliente = new Label();
            lblMenu = new Label();
            lblZona = new Label();
            lblFechaRealizado = new Label();
            dgvHistorico = new DataGridView();
            colEstado = new DataGridViewTextBoxColumn();
            colFechaInicio = new DataGridViewTextBoxColumn();
            colFechaAct = new DataGridViewTextBoxColumn();
            txtNroPedido = new TextBox();
            txtIdCliente = new TextBox();
            txtMenu = new TextBox();
            txtZona = new TextBox();
            txtFechaRealizado = new TextBox();
            btnMenu = new Button();
            btnListado = new Button();
            btnModificar = new Button();
            btnActualizarEstado = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // lblNroPedido
            // 
            lblNroPedido.AutoSize = true;
            lblNroPedido.Location = new Point(12, 21);
            lblNroPedido.Name = "lblNroPedido";
            lblNroPedido.Size = new Size(61, 15);
            lblNroPedido.TabIndex = 0;
            lblNroPedido.Text = "N° Pedido";
            // 
            // lblliente
            // 
            lblliente.AutoSize = true;
            lblliente.Location = new Point(12, 50);
            lblliente.Name = "lblliente";
            lblliente.Size = new Size(61, 15);
            lblliente.TabIndex = 1;
            lblliente.Text = "N° Cliente";
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(12, 79);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(38, 15);
            lblMenu.TabIndex = 2;
            lblMenu.Text = "Menu";
            // 
            // lblZona
            // 
            lblZona.AutoSize = true;
            lblZona.Location = new Point(12, 108);
            lblZona.Name = "lblZona";
            lblZona.Size = new Size(34, 15);
            lblZona.TabIndex = 4;
            lblZona.Text = "Zona";
            // 
            // lblFechaRealizado
            // 
            lblFechaRealizado.AutoSize = true;
            lblFechaRealizado.Location = new Point(12, 137);
            lblFechaRealizado.Name = "lblFechaRealizado";
            lblFechaRealizado.Size = new Size(88, 15);
            lblFechaRealizado.TabIndex = 5;
            lblFechaRealizado.Text = "Fecha realizado";
            // 
            // dgvHistorico
            // 
            dgvHistorico.AccessibleRole = AccessibleRole.None;
            dgvHistorico.AllowUserToAddRows = false;
            dgvHistorico.AllowUserToDeleteRows = false;
            dgvHistorico.AllowUserToResizeColumns = false;
            dgvHistorico.AllowUserToResizeRows = false;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvHistorico.Columns.AddRange(new DataGridViewColumn[] { colEstado, colFechaInicio, colFechaAct });
            dgvHistorico.Location = new Point(316, 21);
            dgvHistorico.MultiSelect = false;
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.RowHeadersVisible = false;
            dgvHistorico.RowHeadersWidth = 20;
            dgvHistorico.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvHistorico.RowTemplate.Height = 25;
            dgvHistorico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorico.Size = new Size(393, 139);
            dgvHistorico.TabIndex = 6;
            // 
            // colEstado
            // 
            colEstado.Frozen = true;
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 150;
            // 
            // colFechaInicio
            // 
            colFechaInicio.Frozen = true;
            colFechaInicio.HeaderText = "Inicio";
            colFechaInicio.Name = "colFechaInicio";
            colFechaInicio.ReadOnly = true;
            colFechaInicio.Width = 120;
            // 
            // colFechaAct
            // 
            colFechaAct.Frozen = true;
            colFechaAct.HeaderText = "Ultima actualizacion";
            colFechaAct.Name = "colFechaAct";
            colFechaAct.ReadOnly = true;
            colFechaAct.Width = 120;
            // 
            // txtNroPedido
            // 
            txtNroPedido.Location = new Point(135, 18);
            txtNroPedido.Name = "txtNroPedido";
            txtNroPedido.ReadOnly = true;
            txtNroPedido.Size = new Size(129, 23);
            txtNroPedido.TabIndex = 7;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(135, 47);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.ReadOnly = true;
            txtIdCliente.Size = new Size(129, 23);
            txtIdCliente.TabIndex = 8;
            // 
            // txtMenu
            // 
            txtMenu.Location = new Point(135, 76);
            txtMenu.Name = "txtMenu";
            txtMenu.ReadOnly = true;
            txtMenu.Size = new Size(129, 23);
            txtMenu.TabIndex = 9;
            // 
            // txtZona
            // 
            txtZona.Location = new Point(135, 105);
            txtZona.Name = "txtZona";
            txtZona.ReadOnly = true;
            txtZona.Size = new Size(129, 23);
            txtZona.TabIndex = 10;
            // 
            // txtFechaRealizado
            // 
            txtFechaRealizado.Location = new Point(135, 134);
            txtFechaRealizado.Name = "txtFechaRealizado";
            txtFechaRealizado.ReadOnly = true;
            txtFechaRealizado.Size = new Size(129, 23);
            txtFechaRealizado.TabIndex = 11;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(12, 211);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(169, 37);
            btnMenu.TabIndex = 12;
            btnMenu.Text = "Regresar al menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnListado
            // 
            btnListado.Location = new Point(187, 211);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(169, 37);
            btnListado.TabIndex = 13;
            btnListado.Text = "Regresar al listado";
            btnListado.UseVisualStyleBackColor = true;
            btnListado.Click += btnListado_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(540, 211);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(169, 37);
            btnModificar.TabIndex = 14;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnActualizarEstado
            // 
            btnActualizarEstado.Location = new Point(365, 211);
            btnActualizarEstado.Name = "btnActualizarEstado";
            btnActualizarEstado.Size = new Size(169, 37);
            btnActualizarEstado.TabIndex = 15;
            btnActualizarEstado.Text = "Actualizar estado";
            btnActualizarEstado.UseVisualStyleBackColor = true;
            btnActualizarEstado.Click += btnActualizarEstado_Click;
            // 
            // HistoricoPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 260);
            Controls.Add(btnActualizarEstado);
            Controls.Add(btnModificar);
            Controls.Add(btnListado);
            Controls.Add(btnMenu);
            Controls.Add(txtFechaRealizado);
            Controls.Add(txtZona);
            Controls.Add(txtMenu);
            Controls.Add(txtIdCliente);
            Controls.Add(txtNroPedido);
            Controls.Add(dgvHistorico);
            Controls.Add(lblFechaRealizado);
            Controls.Add(lblZona);
            Controls.Add(lblMenu);
            Controls.Add(lblliente);
            Controls.Add(lblNroPedido);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HistoricoPedidos";
            Text = "HistoricoPedidos";
            Load += HistoricoPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNroPedido;
        private Label lblliente;
        private Label lblMenu;
        private Label lblZona;
        private Label lblFechaRealizado;
        private DataGridView dgvHistorico;
        private DataGridViewTextBoxColumn colEstado;
        private DataGridViewTextBoxColumn colFechaInicio;
        private DataGridViewTextBoxColumn colFechaAct;
        private TextBox txtNroPedido;
        private TextBox txtIdCliente;
        private TextBox txtMenu;
        private TextBox txtZona;
        private TextBox txtFechaRealizado;
        private Button btnMenu;
        private Button btnListado;
        private Button btnModificar;
        private Button btnActualizarEstado;
    }
}