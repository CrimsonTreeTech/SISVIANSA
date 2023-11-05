namespace SISVIANSA_ITI_2023.GUI
{
    partial class MenuAtencionCliente
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
            btnListarPedidos = new Button();
            btnListarMenu = new Button();
            btnListarClientes = new Button();
            btnIngresarClienteComun = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnListarPedidos
            // 
            btnListarPedidos.Location = new Point(45, 32);
            btnListarPedidos.Margin = new Padding(3, 2, 3, 2);
            btnListarPedidos.Name = "btnListarPedidos";
            btnListarPedidos.Size = new Size(155, 37);
            btnListarPedidos.TabIndex = 24;
            btnListarPedidos.Text = "Listar pedidos";
            btnListarPedidos.UseVisualStyleBackColor = true;
            btnListarPedidos.Click += btnListarPedidos_Click;
            // 
            // btnListarMenu
            // 
            btnListarMenu.Location = new Point(45, 87);
            btnListarMenu.Margin = new Padding(3, 2, 3, 2);
            btnListarMenu.Name = "btnListarMenu";
            btnListarMenu.Size = new Size(155, 37);
            btnListarMenu.TabIndex = 23;
            btnListarMenu.Text = "Listar menu";
            btnListarMenu.UseVisualStyleBackColor = true;
            btnListarMenu.Click += btnListarMenu_Click;
            // 
            // btnListarClientes
            // 
            btnListarClientes.Location = new Point(222, 32);
            btnListarClientes.Margin = new Padding(3, 2, 3, 2);
            btnListarClientes.Name = "btnListarClientes";
            btnListarClientes.Size = new Size(155, 37);
            btnListarClientes.TabIndex = 21;
            btnListarClientes.Text = "Listar Clientes";
            btnListarClientes.UseVisualStyleBackColor = true;
            btnListarClientes.Click += btnListarClientes_Click;
            // 
            // btnIngresarClienteComun
            // 
            btnIngresarClienteComun.Location = new Point(222, 87);
            btnIngresarClienteComun.Margin = new Padding(3, 2, 3, 2);
            btnIngresarClienteComun.Name = "btnIngresarClienteComun";
            btnIngresarClienteComun.Size = new Size(155, 37);
            btnIngresarClienteComun.TabIndex = 20;
            btnIngresarClienteComun.Text = "Ingresar Cliente";
            btnIngresarClienteComun.UseVisualStyleBackColor = true;
            btnIngresarClienteComun.Click += btnIngresarClienteComun_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(45, 142);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(332, 37);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // MenuAtencionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 208);
            Controls.Add(btnSalir);
            Controls.Add(btnListarPedidos);
            Controls.Add(btnListarMenu);
            Controls.Add(btnListarClientes);
            Controls.Add(btnIngresarClienteComun);
            Name = "MenuAtencionCliente";
            Text = "MenuAtencionCliente";
            ResumeLayout(false);
        }

        #endregion

        private Button btnListarPedidos;
        private Button btnListarMenu;
        private Button btnListarClientes;
        private Button btnIngresarClienteComun;
        private Button btnSalir;
    }
}