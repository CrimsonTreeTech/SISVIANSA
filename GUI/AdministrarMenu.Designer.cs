namespace SISVIANSA_ITI_2023.GUI
{
    partial class AdministrarMenu
    {
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarMenu));
            btnRegresar = new Button();
            btnGerencia = new Button();
            btnCocina = new Button();
            btnAdmin = new Button();
            btnATC = new Button();
            btnTransporte = new Button();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(512, 238);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(176, 44);
            btnRegresar.TabIndex = 0;
            btnRegresar.TabStop = false;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGerencia
            // 
            btnGerencia.Location = new Point(223, 43);
            btnGerencia.Margin = new Padding(3, 2, 3, 2);
            btnGerencia.Name = "btnGerencia";
            btnGerencia.Size = new Size(176, 44);
            btnGerencia.TabIndex = 1;
            btnGerencia.TabStop = false;
            btnGerencia.Text = "Gerencia";
            btnGerencia.UseVisualStyleBackColor = true;
            btnGerencia.Click += btnGerencia_Click;
            // 
            // btnCocina
            // 
            btnCocina.Location = new Point(223, 91);
            btnCocina.Margin = new Padding(3, 2, 3, 2);
            btnCocina.Name = "btnCocina";
            btnCocina.Size = new Size(176, 44);
            btnCocina.TabIndex = 2;
            btnCocina.TabStop = false;
            btnCocina.Text = "Cocina";
            btnCocina.UseVisualStyleBackColor = true;
            btnCocina.Click += btnCocina_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(223, 139);
            btnAdmin.Margin = new Padding(3, 2, 3, 2);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(176, 44);
            btnAdmin.TabIndex = 3;
            btnAdmin.TabStop = false;
            btnAdmin.Text = "Administrativo";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnATC
            // 
            btnATC.Location = new Point(223, 187);
            btnATC.Margin = new Padding(3, 2, 3, 2);
            btnATC.Name = "btnATC";
            btnATC.Size = new Size(176, 44);
            btnATC.TabIndex = 4;
            btnATC.TabStop = false;
            btnATC.Text = "Atención al cliente";
            btnATC.UseVisualStyleBackColor = true;
            btnATC.Click += btnATC_Click;
            // 
            // btnTransporte
            // 
            btnTransporte.Location = new Point(223, 235);
            btnTransporte.Margin = new Padding(3, 2, 3, 2);
            btnTransporte.Name = "btnTransporte";
            btnTransporte.Size = new Size(176, 44);
            btnTransporte.TabIndex = 5;
            btnTransporte.TabStop = false;
            btnTransporte.Text = "Transporte";
            btnTransporte.UseVisualStyleBackColor = true;
            btnTransporte.Click += btnTransporte_Click;
            // 
            // AdministrarMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnTransporte);
            Controls.Add(btnATC);
            Controls.Add(btnAdmin);
            Controls.Add(btnCocina);
            Controls.Add(btnGerencia);
            Controls.Add(btnRegresar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdministrarMenu";
            Text = "AdministrarMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnRegresar;
        private Button btnGerencia;
        private Button btnCocina;
        private Button btnAdmin;
        private Button btnATC;
        private Button btnTransporte;
    }
}