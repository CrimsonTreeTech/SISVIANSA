﻿namespace SISVIANSA_ITI_2023.GUI
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCocina));
            btnProduccionDiaria = new Button();
            btnIngresarMenu = new Button();
            btnListarMenu = new Button();
            btnListarDietas = new Button();
            btnListarComida = new Button();
            btnListarPedidos = new Button();
            btnIngresarComida = new Button();
            btnSalir = new Button();
            btnIngresasrDieta = new Button();
            btnListarViandas = new Button();
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
            btnListarDietas.Location = new Point(17, 142);
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
            btnSalir.Location = new Point(17, 264);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(316, 37);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnIngresasrDieta
            // 
            btnIngresasrDieta.Location = new Point(178, 142);
            btnIngresasrDieta.Name = "btnIngresasrDieta";
            btnIngresasrDieta.Size = new Size(155, 37);
            btnIngresasrDieta.TabIndex = 9;
            btnIngresasrDieta.Text = "Ingresasr dieta";
            btnIngresasrDieta.UseVisualStyleBackColor = true;
            btnIngresasrDieta.Click += btnIngresarDieta_Click;
            // 
            // btnListarViandas
            // 
            btnListarViandas.Location = new Point(17, 183);
            btnListarViandas.Margin = new Padding(3, 2, 3, 2);
            btnListarViandas.Name = "btnListarViandas";
            btnListarViandas.Size = new Size(155, 37);
            btnListarViandas.TabIndex = 10;
            btnListarViandas.Text = "Listar viandas";
            btnListarViandas.UseVisualStyleBackColor = true;
            btnListarViandas.Click += btnListarViandas_Click;
            // 
            // MenuCocina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 331);
            Controls.Add(btnListarViandas);
            Controls.Add(btnIngresasrDieta);
            Controls.Add(btnSalir);
            Controls.Add(btnIngresarComida);
            Controls.Add(btnListarDietas);
            Controls.Add(btnListarComida);
            Controls.Add(btnListarPedidos);
            Controls.Add(btnProduccionDiaria);
            Controls.Add(btnIngresarMenu);
            Controls.Add(btnListarMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuCocina";
            Text = "Menu jefe de cocina";
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
        private Button btnIngresasrDieta;
        private Button btnListarViandas;
    }
}