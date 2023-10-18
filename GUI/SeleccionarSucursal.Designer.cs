namespace SISVIANSA_ITI_2023.GUI
{
    partial class SeleccionarSucursal
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
            lblSeleccioinarSucursal = new Label();
            cboSucursales = new ComboBox();
            btnAceptar = new Button();
            lblSucursal = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblSeleccioinarSucursal
            // 
            lblSeleccioinarSucursal.AutoSize = true;
            lblSeleccioinarSucursal.Location = new Point(27, 39);
            lblSeleccioinarSucursal.Name = "lblSeleccioinarSucursal";
            lblSeleccioinarSucursal.Size = new Size(152, 20);
            lblSeleccioinarSucursal.TabIndex = 0;
            lblSeleccioinarSucursal.Text = "Selecciona la sucursal";
            // 
            // cboSucursales
            // 
            cboSucursales.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursales.FormattingEnabled = true;
            cboSucursales.Location = new Point(232, 109);
            cboSucursales.Margin = new Padding(3, 4, 3, 4);
            cboSucursales.Name = "cboSucursales";
            cboSucursales.Size = new Size(92, 28);
            cboSucursales.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(148, 191);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(262, 45);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(50, 109);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(63, 20);
            lblSucursal.TabIndex = 3;
            lblSucursal.Text = "Sucursal";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(148, 276);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(262, 43);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // SeleccionarSucursal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 413);
            Controls.Add(btnSalir);
            Controls.Add(lblSucursal);
            Controls.Add(btnAceptar);
            Controls.Add(cboSucursales);
            Controls.Add(lblSeleccioinarSucursal);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SeleccionarSucursal";
            Text = "SeleccionarSucursal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSeleccioinarSucursal;
        private ComboBox cboSucursales;
        private Button btnAceptar;
        private Label lblSucursal;
        private Button btnSalir;
    }
}