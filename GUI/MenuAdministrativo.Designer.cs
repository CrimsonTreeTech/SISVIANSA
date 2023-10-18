namespace SISVIANSA_ITI_2023.GUI
{
    partial class MenuAdministrativo
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
            btnIngresarClienteEmpresa = new Button();
            btnListarClientes = new Button();
            btnIngresarClienteComun = new Button();
            btnListarPedidos = new Button();
            btnIngresarPedido = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnIngresarClienteEmpresa
            // 
            btnIngresarClienteEmpresa.Location = new Point(42, 85);
            btnIngresarClienteEmpresa.Margin = new Padding(3, 2, 3, 2);
            btnIngresarClienteEmpresa.Name = "btnIngresarClienteEmpresa";
            btnIngresarClienteEmpresa.Size = new Size(155, 37);
            btnIngresarClienteEmpresa.TabIndex = 12;
            btnIngresarClienteEmpresa.Text = "Ingresar Cliente Empresa";
            btnIngresarClienteEmpresa.UseVisualStyleBackColor = true;
            btnIngresarClienteEmpresa.Click += btnIngresarClienteEmpresa_Click;
            // 
            // btnListarClientes
            // 
            btnListarClientes.Location = new Point(42, 145);
            btnListarClientes.Margin = new Padding(3, 2, 3, 2);
            btnListarClientes.Name = "btnListarClientes";
            btnListarClientes.Size = new Size(155, 37);
            btnListarClientes.TabIndex = 11;
            btnListarClientes.Text = "Listar Clientes";
            btnListarClientes.UseVisualStyleBackColor = true;
            btnListarClientes.Click += btnListarClientes_Click;
            // 
            // btnIngresarClienteComun
            // 
            btnIngresarClienteComun.Location = new Point(42, 25);
            btnIngresarClienteComun.Margin = new Padding(3, 2, 3, 2);
            btnIngresarClienteComun.Name = "btnIngresarClienteComun";
            btnIngresarClienteComun.Size = new Size(155, 37);
            btnIngresarClienteComun.TabIndex = 8;
            btnIngresarClienteComun.Text = "Ingresar Cliente Comun";
            btnIngresarClienteComun.UseVisualStyleBackColor = true;
            btnIngresarClienteComun.Click += btnIngresarClienteComun_Click;
            // 
            // btnListarPedidos
            // 
            btnListarPedidos.Location = new Point(235, 85);
            btnListarPedidos.Margin = new Padding(3, 2, 3, 2);
            btnListarPedidos.Name = "btnListarPedidos";
            btnListarPedidos.Size = new Size(155, 37);
            btnListarPedidos.TabIndex = 22;
            btnListarPedidos.Text = "Listar pedidos";
            btnListarPedidos.UseVisualStyleBackColor = true;
            btnListarPedidos.Click += btnListarPedidos_Click;
            // 
            // btnIngresarPedido
            // 
            btnIngresarPedido.Location = new Point(235, 25);
            btnIngresarPedido.Margin = new Padding(3, 2, 3, 2);
            btnIngresarPedido.Name = "btnIngresarPedido";
            btnIngresarPedido.Size = new Size(155, 37);
            btnIngresarPedido.TabIndex = 20;
            btnIngresarPedido.Text = "Ingresar pedido";
            btnIngresarPedido.UseVisualStyleBackColor = true;
            btnIngresarPedido.Click += btnIngresarPedido_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(235, 145);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 37);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // MenuAdministrativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 214);
            Controls.Add(btnSalir);
            Controls.Add(btnListarPedidos);
            Controls.Add(btnIngresarPedido);
            Controls.Add(btnIngresarClienteEmpresa);
            Controls.Add(btnListarClientes);
            Controls.Add(btnIngresarClienteComun);
            Name = "MenuAdministrativo";
            Text = "MenuAdministrativo";
            ResumeLayout(false);
        }

        #endregion
        private Button btnIngresarClienteEmpresa;
        private Button btnListarClientes;
        private Button btnIngresarClienteComun;
        private Button btnListarPedidos;
        private Button btnIngresarPedido;
        private Button btnSalir;
    }
}