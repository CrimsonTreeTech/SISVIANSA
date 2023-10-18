namespace SISVIANSA_ITI_2023.GUI
{
    partial class MenuCocina
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
            btnProduccionDiaria = new Button();
            btnIngresarMenu = new Button();
            btnListarMenu = new Button();
            btnListarDietas = new Button();
            btnListarComida = new Button();
            btnListarPedidos = new Button();
            btnIngresarComida = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnProduccionDiaria
            // 
            btnProduccionDiaria.Location = new Point(178, 18);
            btnProduccionDiaria.Margin = new Padding(3, 2, 3, 2);
            btnProduccionDiaria.Name = "btnProduccionDiaria";
            btnProduccionDiaria.Size = new Size(155, 37);
            btnProduccionDiaria.TabIndex = 2;
            btnProduccionDiaria.Text = "Produccion por dia";
            btnProduccionDiaria.UseVisualStyleBackColor = true;
            btnProduccionDiaria.Click += btnProduccionDiaria_Click;
            // 
            // btnIngresarMenu
            // 
            btnIngresarMenu.Location = new Point(178, 59);
            btnIngresarMenu.Margin = new Padding(3, 2, 3, 2);
            btnIngresarMenu.Name = "btnIngresarMenu";
            btnIngresarMenu.Size = new Size(155, 37);
            btnIngresarMenu.TabIndex = 4;
            btnIngresarMenu.Text = "Ingresar menu";
            btnIngresarMenu.UseVisualStyleBackColor = true;
            btnIngresarMenu.Click += btnIngresarMenu_Click;
            // 
            // btnListarMenu
            // 
            btnListarMenu.Location = new Point(17, 59);
            btnListarMenu.Margin = new Padding(3, 2, 3, 2);
            btnListarMenu.Name = "btnListarMenu";
            btnListarMenu.Size = new Size(155, 37);
            btnListarMenu.TabIndex = 3;
            btnListarMenu.Text = "Listar menu";
            btnListarMenu.UseVisualStyleBackColor = true;
            btnListarMenu.Click += btnListarMenu_Click;
            // 
            // btnListarDietas
            // 
            btnListarDietas.Location = new Point(17, 141);
            btnListarDietas.Margin = new Padding(3, 2, 3, 2);
            btnListarDietas.Name = "btnListarDietas";
            btnListarDietas.Size = new Size(155, 37);
            btnListarDietas.TabIndex = 7;
            btnListarDietas.Text = "Listar dietas";
            btnListarDietas.UseVisualStyleBackColor = true;
            btnListarDietas.Click += btnListarDietas_Click;
            // 
            // btnListarComida
            // 
            btnListarComida.Location = new Point(17, 100);
            btnListarComida.Margin = new Padding(3, 2, 3, 2);
            btnListarComida.Name = "btnListarComida";
            btnListarComida.Size = new Size(155, 37);
            btnListarComida.TabIndex = 5;
            btnListarComida.Text = "Listar comida";
            btnListarComida.UseVisualStyleBackColor = true;
            btnListarComida.Click += btnListarComida_Click;
            // 
            // btnListarPedidos
            // 
            btnListarPedidos.Location = new Point(17, 18);
            btnListarPedidos.Margin = new Padding(3, 2, 3, 2);
            btnListarPedidos.Name = "btnListarPedidos";
            btnListarPedidos.Size = new Size(155, 37);
            btnListarPedidos.TabIndex = 1;
            btnListarPedidos.Text = "Listar pedidos";
            btnListarPedidos.UseVisualStyleBackColor = true;
            btnListarPedidos.Click += btnListarPedidos_Click;
            // 
            // btnIngresarComida
            // 
            btnIngresarComida.Location = new Point(178, 100);
            btnIngresarComida.Margin = new Padding(3, 2, 3, 2);
            btnIngresarComida.Name = "btnIngresarComida";
            btnIngresarComida.Size = new Size(155, 37);
            btnIngresarComida.TabIndex = 6;
            btnIngresarComida.Text = "Ingresar comida";
            btnIngresarComida.UseVisualStyleBackColor = true;
            btnIngresarComida.Click += btnIngresarComida_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(178, 141);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 37);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // MenuCocina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 191);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresarComida);
            Controls.Add(btnListarDietas);
            Controls.Add(btnListarComida);
            Controls.Add(btnListarPedidos);
            Controls.Add(btnProduccionDiaria);
            Controls.Add(btnIngresarMenu);
            Controls.Add(btnListarMenu);
            Name = "MenuCocina";
            Text = "MenuJefeCocina";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProduccionDiaria;
        private Button btnIngresarMenu;
        private Button btnListarMenu;
        private Button btnListarDietas;
        private Button btnListarComida;
        private Button btnListarPedidos;
        private Button btnIngresarComida;
        private Button btnSalir;
    }
}