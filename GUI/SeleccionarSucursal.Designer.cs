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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarSucursal));
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
            lblSeleccioinarSucursal.Location = new Point(24, 29);
            lblSeleccioinarSucursal.Name = "lblSeleccioinarSucursal";
            lblSeleccioinarSucursal.Size = new Size(121, 15);
            lblSeleccioinarSucursal.TabIndex = 0;
            lblSeleccioinarSucursal.Text = "Selecciona la sucursal";
            // 
            // cboSucursales
            // 
            cboSucursales.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSucursales.FormattingEnabled = true;
            cboSucursales.Location = new Point(203, 82);
            cboSucursales.Name = "cboSucursales";
            cboSucursales.Size = new Size(81, 23);
            cboSucursales.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(130, 143);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(229, 34);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(44, 82);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(51, 15);
            lblSucursal.TabIndex = 3;
            lblSucursal.Text = "Sucursal";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(130, 207);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(229, 32);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // SeleccionarSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 310);
            Controls.Add(btnSalir);
            Controls.Add(lblSucursal);
            Controls.Add(btnAceptar);
            Controls.Add(cboSucursales);
            Controls.Add(lblSeleccioinarSucursal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SeleccionarSucursal";
            Text = "Seleccionar sucursal";
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