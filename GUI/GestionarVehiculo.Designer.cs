namespace ventana3
{
    partial class GestionarVehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarVehiculo));
            lblCapacidad = new Label();
            lblMatricula = new Label();
            btnGuardar = new Button();
            txtMatricula = new TextBox();
            btnCancelar = new Button();
            txtCapacidad = new TextBox();
            lblIndicacionCapacidad = new Label();
            lblInformacionMatricula = new Label();
            SuspendLayout();
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(34, 36);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(88, 15);
            lblCapacidad.TabIndex = 0;
            lblCapacidad.Text = "Capacidad (Kg)";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(34, 107);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(57, 15);
            lblMatricula.TabIndex = 1;
            lblMatricula.Text = "Matricula";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(260, 190);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(140, 107);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(214, 23);
            txtMatricula.TabIndex = 2;
            txtMatricula.TextChanged += txtMatricula_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(34, 190);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(140, 33);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(214, 23);
            txtCapacidad.TabIndex = 1;
            // 
            // lblIndicacionCapacidad
            // 
            lblIndicacionCapacidad.AutoSize = true;
            lblIndicacionCapacidad.Location = new Point(140, 59);
            lblIndicacionCapacidad.Name = "lblIndicacionCapacidad";
            lblIndicacionCapacidad.Size = new Size(131, 15);
            lblIndicacionCapacidad.TabIndex = 7;
            lblIndicacionCapacidad.Text = "* Número mayor a cero";
            // 
            // lblInformacionMatricula
            // 
            lblInformacionMatricula.AutoSize = true;
            lblInformacionMatricula.Location = new Point(140, 133);
            lblInformacionMatricula.Name = "lblInformacionMatricula";
            lblInformacionMatricula.Size = new Size(77, 15);
            lblInformacionMatricula.TabIndex = 8;
            lblInformacionMatricula.Text = "* Ej: ABC1234";
            // 
            // GestionarVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 242);
            Controls.Add(lblInformacionMatricula);
            Controls.Add(lblIndicacionCapacidad);
            Controls.Add(txtCapacidad);
            Controls.Add(btnCancelar);
            Controls.Add(lblCapacidad);
            Controls.Add(lblMatricula);
            Controls.Add(btnGuardar);
            Controls.Add(txtMatricula);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionarVehiculo";
            Text = "Ingresar vehiculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCapacidad;
        private Label lblMatricula;
        private Button btnGuardar;
        private TextBox txtMatricula;
        private Button btnCancelar;
        private TextBox txtCapacidad;
        private Label lblIndicacionCapacidad;
        private Label lblInformacionMatricula;
    }
}