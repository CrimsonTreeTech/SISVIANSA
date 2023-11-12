namespace SISVIANSA_ITI_2023.GUI
{
    partial class MenuInformatico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInformatico));
            btnListarSucursales = new Button();
            btnListarPersonal = new Button();
            btnSalir = new Button();
            btnAdministrarMenu = new Button();
            SuspendLayout();
            // 
            // btnListarSucursales
            // 
            btnListarSucursales.Location = new Point(164, 37);
            btnListarSucursales.Margin = new Padding(3, 2, 3, 2);
            btnListarSucursales.Name = "btnListarSucursales";
            btnListarSucursales.Size = new Size(155, 37);
            btnListarSucursales.TabIndex = 9;
            btnListarSucursales.Text = "Ingresar Personal";
            btnListarSucursales.UseVisualStyleBackColor = true;
            btnListarSucursales.Click += btnListarSucursales_Click;
            // 
            // btnListarPersonal
            // 
            btnListarPersonal.Location = new Point(164, 78);
            btnListarPersonal.Margin = new Padding(3, 2, 3, 2);
            btnListarPersonal.Name = "btnListarPersonal";
            btnListarPersonal.Size = new Size(155, 37);
            btnListarPersonal.TabIndex = 10;
            btnListarPersonal.Text = "Listar Personal";
            btnListarPersonal.UseVisualStyleBackColor = true;
            btnListarPersonal.Click += btnListarPersonal_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(164, 190);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 37);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAdministrarMenu
            // 
            btnAdministrarMenu.Location = new Point(164, 120);
            btnAdministrarMenu.Margin = new Padding(3, 2, 3, 2);
            btnAdministrarMenu.Name = "btnAdministrarMenu";
            btnAdministrarMenu.Size = new Size(155, 37);
            btnAdministrarMenu.TabIndex = 12;
            btnAdministrarMenu.Text = "Administrar Menu";
            btnAdministrarMenu.UseVisualStyleBackColor = true;
            btnAdministrarMenu.Click += btnAdministrarMenu_Click;
            // 
            // MenuInformatico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 271);
            Controls.Add(btnAdministrarMenu);
            Controls.Add(btnListarSucursales);
            Controls.Add(btnSalir);
            Controls.Add(btnListarPersonal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuInformatico";
            Text = "Menu de informatico";
            ResumeLayout(false);
        }

        #endregion

        private Button btnListarSucursales;
        private Button btnListarPersonal;
        private Button btnSalir;
        private Button btnMenuCocina;
        private Button btnAdministrarMenu;
    }
}