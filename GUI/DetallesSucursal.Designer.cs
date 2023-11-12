namespace SISVIANSA_ITI_2023.GUI
{
    partial class DetallesSucursal
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallesSucursal));
            lblCapProd = new Label();
            txtCapProd = new TextBox();
            lblMetas = new Label();
            rtxtMetas = new RichTextBox();
            lblZonasCubiertas = new Label();
            lstZonasCubiertas = new ListBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // lblCapProd
            // 
            lblCapProd.AutoSize = true;
            lblCapProd.Location = new Point(20, 62);
            lblCapProd.Name = "lblCapProd";
            lblCapProd.Size = new Size(143, 15);
            lblCapProd.TabIndex = 0;
            lblCapProd.Text = "Capacidad de produccion";
            // 
            // txtCapProd
            // 
            txtCapProd.Location = new Point(187, 54);
            txtCapProd.Margin = new Padding(3, 2, 3, 2);
            txtCapProd.Name = "txtCapProd";
            txtCapProd.ReadOnly = true;
            txtCapProd.Size = new Size(94, 23);
            txtCapProd.TabIndex = 1;
            // 
            // lblMetas
            // 
            lblMetas.AutoSize = true;
            lblMetas.Location = new Point(21, 98);
            lblMetas.Name = "lblMetas";
            lblMetas.Size = new Size(113, 15);
            lblMetas.TabIndex = 2;
            lblMetas.Text = "Metas de la sucursal";
            // 
            // rtxtMetas
            // 
            rtxtMetas.Location = new Point(21, 124);
            rtxtMetas.Margin = new Padding(3, 2, 3, 2);
            rtxtMetas.Name = "rtxtMetas";
            rtxtMetas.ReadOnly = true;
            rtxtMetas.Size = new Size(260, 167);
            rtxtMetas.TabIndex = 3;
            rtxtMetas.Text = "";
            // 
            // lblZonasCubiertas
            // 
            lblZonasCubiertas.AutoSize = true;
            lblZonasCubiertas.Location = new Point(312, 27);
            lblZonasCubiertas.Name = "lblZonasCubiertas";
            lblZonasCubiertas.Size = new Size(153, 15);
            lblZonasCubiertas.TabIndex = 5;
            lblZonasCubiertas.Text = "Zonas que cubre la sucursal";
            // 
            // lstZonasCubiertas
            // 
            lstZonasCubiertas.FormattingEnabled = true;
            lstZonasCubiertas.ItemHeight = 15;
            lstZonasCubiertas.Location = new Point(312, 62);
            lstZonasCubiertas.Name = "lstZonasCubiertas";
            lstZonasCubiertas.Size = new Size(215, 229);
            lstZonasCubiertas.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(21, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(207, 37);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(320, 312);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(207, 37);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(77, 27);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(204, 23);
            txtNombre.TabIndex = 14;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // DetallesSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 361);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lstZonasCubiertas);
            Controls.Add(lblZonasCubiertas);
            Controls.Add(rtxtMetas);
            Controls.Add(lblMetas);
            Controls.Add(txtCapProd);
            Controls.Add(lblCapProd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetallesSucursal";
            Text = "Detalles de la sucursal";
            Load += DetallesSucursal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCapProd;
        private TextBox txtCapProd;
        private Label lblMetas;
        private RichTextBox rtxtMetas;
        private Label lblZonasCubiertas;
        private ListBox lstZonasCubiertas;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}