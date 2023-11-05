namespace SISVIANSA_ITI_2023.GUI
{
    partial class MenuTransporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuTransporte));
            btnListarVehiculo = new Button();
            IngresarVehiculo = new Button();
            btnListarZona = new Button();
            btnIngresarZona = new Button();
            btnListarPedidos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnListarVehiculo
            // 
            btnListarVehiculo.Location = new Point(24, 26);
            btnListarVehiculo.Margin = new Padding(3, 2, 3, 2);
            btnListarVehiculo.Name = "btnListarVehiculo";
            btnListarVehiculo.Size = new Size(155, 37);
            btnListarVehiculo.TabIndex = 1;
            btnListarVehiculo.Text = "Listar Vehiculo";
            btnListarVehiculo.UseVisualStyleBackColor = true;
            btnListarVehiculo.Click += btnListarVehiculo_Click;
            // 
            // IngresarVehiculo
            // 
            IngresarVehiculo.Location = new Point(200, 26);
            IngresarVehiculo.Margin = new Padding(3, 2, 3, 2);
            IngresarVehiculo.Name = "IngresarVehiculo";
            IngresarVehiculo.Size = new Size(155, 37);
            IngresarVehiculo.TabIndex = 2;
            IngresarVehiculo.Text = "Ingresar Vehiculo";
            IngresarVehiculo.UseVisualStyleBackColor = true;
            IngresarVehiculo.Click += IngresarVehiculo_Click;
            // 
            // btnListarZona
            // 
            btnListarZona.Location = new Point(24, 78);
            btnListarZona.Margin = new Padding(3, 2, 3, 2);
            btnListarZona.Name = "btnListarZona";
            btnListarZona.Size = new Size(155, 37);
            btnListarZona.TabIndex = 3;
            btnListarZona.Text = "Listar Zonas";
            btnListarZona.UseVisualStyleBackColor = true;
            btnListarZona.Click += btnListarZona_Click;
            // 
            // btnIngresarZona
            // 
            btnIngresarZona.Location = new Point(200, 78);
            btnIngresarZona.Margin = new Padding(3, 2, 3, 2);
            btnIngresarZona.Name = "btnIngresarZona";
            btnIngresarZona.Size = new Size(155, 37);
            btnIngresarZona.TabIndex = 4;
            btnIngresarZona.Text = "Ingresar Zona";
            btnIngresarZona.UseVisualStyleBackColor = true;
            btnIngresarZona.Click += btnIngresarZona_Click;
            // 
            // btnListarPedidos
            // 
            btnListarPedidos.Location = new Point(24, 130);
            btnListarPedidos.Margin = new Padding(3, 2, 3, 2);
            btnListarPedidos.Name = "btnListarPedidos";
            btnListarPedidos.Size = new Size(155, 37);
            btnListarPedidos.TabIndex = 5;
            btnListarPedidos.Text = "Listar pedidos";
            btnListarPedidos.UseVisualStyleBackColor = true;
            btnListarPedidos.Click += btnListarPedidos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(200, 130);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 37);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // MenuTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 206);
            Controls.Add(btnSalir);
            Controls.Add(btnListarPedidos);
            Controls.Add(btnListarZona);
            Controls.Add(btnIngresarZona);
            Controls.Add(btnListarVehiculo);
            Controls.Add(IngresarVehiculo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuTransporte";
            Text = "MenuTransporte";
            ResumeLayout(false);
        }

        #endregion
        private Button btnListarVehiculo;
        private Button IngresarVehiculo;
        private Button btnListarZona;
        private Button btnIngresarZona;
        private Button btnListarPedidos;
        private Button btnSalir;
    }
}