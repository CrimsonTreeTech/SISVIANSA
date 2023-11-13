namespace SISVIANSA_ITI_2023.GUI
{
    partial class SeguimientoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeguimientoPedido));
            lblEstado = new Label();
            cboEstado = new ComboBox();
            btnListado = new Button();
            btnHistorico = new Button();
            btnModificar = new Button();
            txtNombre = new TextBox();
            txtNroCliente = new TextBox();
            txtNroPedido = new TextBox();
            lblNroClienteDatos = new Label();
            lblNroPedidoDatos = new Label();
            lblCantidad = new Label();
            txtMenu = new TextBox();
            lblMeuDatos = new Label();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(572, 65);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 37;
            lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(633, 62);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(190, 23);
            cboEstado.TabIndex = 38;
            // 
            // btnListado
            // 
            btnListado.Location = new Point(20, 182);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(216, 49);
            btnListado.TabIndex = 39;
            btnListado.Text = "Listado";
            btnListado.UseVisualStyleBackColor = true;
            btnListado.Click += btnListado_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.Location = new Point(335, 182);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(216, 49);
            btnHistorico.TabIndex = 40;
            btnHistorico.Text = "Historico";
            btnHistorico.UseVisualStyleBackColor = true;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(633, 182);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(216, 49);
            btnModificar.TabIndex = 41;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.ButtonHighlight;
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(190, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.ShortcutsEnabled = false;
            txtNombre.Size = new Size(281, 23);
            txtNombre.TabIndex = 49;
            // 
            // txtNroCliente
            // 
            txtNroCliente.BackColor = SystemColors.ButtonHighlight;
            txtNroCliente.Enabled = false;
            txtNroCliente.Location = new Point(93, 62);
            txtNroCliente.Name = "txtNroCliente";
            txtNroCliente.ReadOnly = true;
            txtNroCliente.Size = new Size(71, 23);
            txtNroCliente.TabIndex = 47;
            // 
            // txtNroPedido
            // 
            txtNroPedido.BackColor = SystemColors.ButtonHighlight;
            txtNroPedido.Enabled = false;
            txtNroPedido.Location = new Point(94, 24);
            txtNroPedido.Name = "txtNroPedido";
            txtNroPedido.ReadOnly = true;
            txtNroPedido.Size = new Size(71, 23);
            txtNroPedido.TabIndex = 46;
            // 
            // lblNroClienteDatos
            // 
            lblNroClienteDatos.AutoSize = true;
            lblNroClienteDatos.Location = new Point(22, 65);
            lblNroClienteDatos.Name = "lblNroClienteDatos";
            lblNroClienteDatos.Size = new Size(44, 15);
            lblNroClienteDatos.TabIndex = 43;
            lblNroClienteDatos.Text = "Cliente";
            // 
            // lblNroPedidoDatos
            // 
            lblNroPedidoDatos.AutoSize = true;
            lblNroPedidoDatos.Location = new Point(22, 27);
            lblNroPedidoDatos.Name = "lblNroPedidoDatos";
            lblNroPedidoDatos.Size = new Size(61, 15);
            lblNroPedidoDatos.TabIndex = 42;
            lblNroPedidoDatos.Text = "N° pedido";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(191, 104);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 52;
            lblCantidad.Text = "Cantidad";
            // 
            // txtMenu
            // 
            txtMenu.BackColor = SystemColors.ButtonHighlight;
            txtMenu.Enabled = false;
            txtMenu.Location = new Point(94, 96);
            txtMenu.Margin = new Padding(3, 2, 3, 2);
            txtMenu.Name = "txtMenu";
            txtMenu.ReadOnly = true;
            txtMenu.Size = new Size(58, 23);
            txtMenu.TabIndex = 51;
            // 
            // lblMeuDatos
            // 
            lblMeuDatos.AutoSize = true;
            lblMeuDatos.Location = new Point(22, 99);
            lblMeuDatos.Name = "lblMeuDatos";
            lblMeuDatos.Size = new Size(38, 15);
            lblMeuDatos.TabIndex = 50;
            lblMeuDatos.Text = "Menu";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = SystemColors.ButtonHighlight;
            txtCantidad.Enabled = false;
            txtCantidad.Location = new Point(261, 96);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(58, 23);
            txtCantidad.TabIndex = 53;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.ButtonHighlight;
            txtPrecio.Enabled = false;
            txtPrecio.Location = new Point(391, 99);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(81, 23);
            txtPrecio.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 104);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 54;
            label1.Text = "Precio";
            // 
            // SeguimientoPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 260);
            Controls.Add(txtPrecio);
            Controls.Add(label1);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtMenu);
            Controls.Add(lblMeuDatos);
            Controls.Add(txtNombre);
            Controls.Add(txtNroCliente);
            Controls.Add(txtNroPedido);
            Controls.Add(lblNroClienteDatos);
            Controls.Add(lblNroPedidoDatos);
            Controls.Add(btnModificar);
            Controls.Add(btnHistorico);
            Controls.Add(btnListado);
            Controls.Add(cboEstado);
            Controls.Add(lblEstado);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SeguimientoPedido";
            Text = "Seguimiento pedido";
            Load += SeguimientoPedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEstado;
        private ComboBox cboEstado;
        private Button btnListado;
        private Button btnHistorico;
        private Button btnModificar;
        private TextBox txtNombre;
        private TextBox txtNroCliente;
        private TextBox txtNroPedido;
        private Label lblNroClienteDatos;
        private Label lblNroPedidoDatos;
        private Label lblCantidad;
        private TextBox txtMenu;
        private Label lblMeuDatos;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Label label1;
    }
}