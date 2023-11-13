namespace ventana3
{
    partial class DetallesVehiculo
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


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallesVehiculo));
            btnListadoVehiculos = new Button();
            btnAsignarZonas = new Button();
            txtCapacidad = new TextBox();
            lblCapacidad = new Label();
            lblMatricula = new Label();
            txtMatricula = new TextBox();
            lblZonas = new Label();
            lstZonas = new ListBox();
            SuspendLayout();
            // 
            // btnListadoVehiculos
            // 
            btnListadoVehiculos.Location = new Point(12, 288);
            btnListadoVehiculos.Margin = new Padding(3, 2, 3, 2);
            btnListadoVehiculos.Name = "btnListadoVehiculos";
            btnListadoVehiculos.Size = new Size(106, 31);
            btnListadoVehiculos.TabIndex = 3;
            btnListadoVehiculos.Text = "Listado";
            btnListadoVehiculos.UseVisualStyleBackColor = true;
            btnListadoVehiculos.Click += btnListadoVehiculos_Click;
            // 
            // btnAsignarZonas
            // 
            btnAsignarZonas.Location = new Point(144, 288);
            btnAsignarZonas.Margin = new Padding(3, 2, 3, 2);
            btnAsignarZonas.Name = "btnAsignarZonas";
            btnAsignarZonas.Size = new Size(106, 31);
            btnAsignarZonas.TabIndex = 4;
            btnAsignarZonas.Text = "Asignar Zonas";
            btnAsignarZonas.UseVisualStyleBackColor = true;
            btnAsignarZonas.Click += btnAsignarZonas_Click;
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(128, 58);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.ReadOnly = true;
            txtCapacidad.Size = new Size(122, 23);
            txtCapacidad.TabIndex = 10;
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(22, 61);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(88, 15);
            lblCapacidad.TabIndex = 9;
            lblCapacidad.Text = "Capacidad (Kg)";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(22, 29);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(57, 15);
            lblMatricula.TabIndex = 11;
            lblMatricula.Text = "Matricula";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(128, 26);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.ReadOnly = true;
            txtMatricula.Size = new Size(122, 23);
            txtMatricula.TabIndex = 12;
            // 
            // lblZonas
            // 
            lblZonas.AutoSize = true;
            lblZonas.Location = new Point(22, 109);
            lblZonas.Name = "lblZonas";
            lblZonas.Size = new Size(39, 15);
            lblZonas.TabIndex = 13;
            lblZonas.Text = "Zonas";
            // 
            // lstZonas
            // 
            lstZonas.FormattingEnabled = true;
            lstZonas.ItemHeight = 15;
            lstZonas.Location = new Point(22, 135);
            lstZonas.Name = "lstZonas";
            lstZonas.SelectionMode = SelectionMode.None;
            lstZonas.Size = new Size(228, 124);
            lstZonas.TabIndex = 14;
            // 
            // DetallesVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 330);
            Controls.Add(lstZonas);
            Controls.Add(lblZonas);
            Controls.Add(txtCapacidad);
            Controls.Add(lblCapacidad);
            Controls.Add(lblMatricula);
            Controls.Add(txtMatricula);
            Controls.Add(btnAsignarZonas);
            Controls.Add(btnListadoVehiculos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetallesVehiculo";
            Text = "Detalles de vehiculo";
            Load += DetallesVehiculo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmatricula;
        private Button btnListadoVehiculos;
        private Button btnAsignarZonas;
        private Button btnguardar;
        private TextBox txtCapacidad;
        private Label lblCapacidad;
        private Label lblMatricula;
        private TextBox txtMatricula;
        private Label lblZonas;
        private ListBox lstZonas;
    }
}