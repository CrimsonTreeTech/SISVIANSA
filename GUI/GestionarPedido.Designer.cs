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
            lblIdCliente = new Label();
            txtIdCliente = new TextBox();
            txtIdMenu = new TextBox();
            lblIdMenu = new Label();
            lblCantidad = new Label();
            nudCantidad = new NumericUpDown();
            txtNombreCliente = new TextBox();
            txtDirCliente = new TextBox();
            txtNombreMenu = new TextBox();
            txtDietaMenu = new TextBox();
            txtPrecioMenu = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(30, 32);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(57, 15);
            lblIdCliente.TabIndex = 0;
            lblIdCliente.Text = "Id Cliente";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(107, 27);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(71, 23);
            txtIdCliente.TabIndex = 1;
            // 
            // txtIdMenu
            // 
            txtIdMenu.Location = new Point(107, 131);
            txtIdMenu.Name = "txtIdMenu";
            txtIdMenu.Size = new Size(71, 23);
            txtIdMenu.TabIndex = 3;
            // 
            // lblIdMenu
            // 
            lblIdMenu.AutoSize = true;
            lblIdMenu.Location = new Point(30, 136);
            lblIdMenu.Name = "lblIdMenu";
            lblIdMenu.Size = new Size(51, 15);
            lblIdMenu.TabIndex = 2;
            lblIdMenu.Text = "Id Menu";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(516, 177);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(590, 174);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(56, 23);
            nudCantidad.TabIndex = 5;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(30, 67);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.ReadOnly = true;
            txtNombreCliente.Size = new Size(173, 23);
            txtNombreCliente.TabIndex = 6;
            // 
            // txtDirCliente
            // 
            txtDirCliente.Location = new Point(209, 67);
            txtDirCliente.Name = "txtDirCliente";
            txtDirCliente.ReadOnly = true;
            txtDirCliente.Size = new Size(437, 23);
            txtDirCliente.TabIndex = 7;
            // 
            // txtNombreMenu
            // 
            txtNombreMenu.Location = new Point(30, 169);
            txtNombreMenu.Name = "txtNombreMenu";
            txtNombreMenu.ReadOnly = true;
            txtNombreMenu.Size = new Size(173, 23);
            txtNombreMenu.TabIndex = 8;
            // 
            // txtDietaMenu
            // 
            txtDietaMenu.Location = new Point(209, 169);
            txtDietaMenu.Name = "txtDietaMenu";
            txtDietaMenu.ReadOnly = true;
            txtDietaMenu.Size = new Size(184, 23);
            txtDietaMenu.TabIndex = 9;
            // 
            // txtPrecioMenu
            // 
            txtPrecioMenu.Location = new Point(399, 169);
            txtPrecioMenu.Name = "txtPrecioMenu";
            txtPrecioMenu.ReadOnly = true;
            txtPrecioMenu.Size = new Size(111, 23);
            txtPrecioMenu.TabIndex = 10;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(476, 289);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(170, 40);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(30, 289);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(170, 40);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // IngresarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 341);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPrecioMenu);
            Controls.Add(txtDietaMenu);
            Controls.Add(txtNombreMenu);
            Controls.Add(txtDirCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(nudCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtIdMenu);
            Controls.Add(lblIdMenu);
            Controls.Add(txtIdCliente);
            Controls.Add(lblIdCliente);
            Name = "IngresarPedido";
            Text = "RealizarPedido";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdCliente;
        private TextBox txtIdCliente;
        private TextBox txtIdMenu;
        private Label lblIdMenu;
        private Label lblCantidad;
        private NumericUpDown nudCantidad;
        private TextBox txtNombreCliente;
        private TextBox txtDirCliente;
        private TextBox txtNombreMenu;
        private TextBox txtDietaMenu;
        private TextBox txtPrecioMenu;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}