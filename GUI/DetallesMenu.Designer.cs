namespace SISVIANSA_ITI_2023.GUI
{
    partial class DetallesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallesMenu));
            lstComidas = new ListBox();
            lblComidasMenu = new Label();
            lblDieta = new Label();
            lblTipo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtMinStock = new TextBox();
            lblMinStock = new Label();
            txtMaxStock = new TextBox();
            lblMaxStock = new Label();
            txtCongelable = new TextBox();
            lblCongelable = new Label();
            lblSugerencias = new Label();
            rtxtSugerencias = new RichTextBox();
            btnModificar = new Button();
            btnListado = new Button();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtTipo = new TextBox();
            chkAutorizado = new CheckBox();
            txtElaboracion = new TextBox();
            lblElaboracion = new Label();
            lstDietas = new ListBox();
            chkActivo = new CheckBox();
            SuspendLayout();
            // 
            // lstComidas
            // 
            lstComidas.FormattingEnabled = true;
            lstComidas.ItemHeight = 15;
            lstComidas.Location = new Point(358, 56);
            lstComidas.Name = "lstComidas";
            lstComidas.Size = new Size(210, 199);
            lstComidas.TabIndex = 8;
            // 
            // lblComidasMenu
            // 
            lblComidasMenu.AutoSize = true;
            lblComidasMenu.Location = new Point(358, 37);
            lblComidasMenu.Name = "lblComidasMenu";
            lblComidasMenu.Size = new Size(95, 15);
            lblComidasMenu.TabIndex = 7;
            lblComidasMenu.Text = "Lista de comidas";
            // 
            // lblDieta
            // 
            lblDieta.AutoSize = true;
            lblDieta.Location = new Point(604, 37);
            lblDieta.Name = "lblDieta";
            lblDieta.Size = new Size(34, 15);
            lblDieta.TabIndex = 13;
            lblDieta.Text = "Dieta";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(38, 90);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(80, 15);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "Tipo de menú";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 62);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 17;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(164, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(144, 23);
            txtNombre.TabIndex = 18;
            // 
            // txtMinStock
            // 
            txtMinStock.Location = new Point(164, 145);
            txtMinStock.Name = "txtMinStock";
            txtMinStock.ReadOnly = true;
            txtMinStock.Size = new Size(144, 23);
            txtMinStock.TabIndex = 20;
            // 
            // lblMinStock
            // 
            lblMinStock.AutoSize = true;
            lblMinStock.Location = new Point(37, 148);
            lblMinStock.Name = "lblMinStock";
            lblMinStock.Size = new Size(81, 15);
            lblMinStock.TabIndex = 19;
            lblMinStock.Text = "Stock mínimo";
            // 
            // txtMaxStock
            // 
            txtMaxStock.Location = new Point(164, 174);
            txtMaxStock.Name = "txtMaxStock";
            txtMaxStock.ReadOnly = true;
            txtMaxStock.Size = new Size(144, 23);
            txtMaxStock.TabIndex = 22;
            // 
            // lblMaxStock
            // 
            lblMaxStock.AutoSize = true;
            lblMaxStock.Location = new Point(38, 177);
            lblMaxStock.Name = "lblMaxStock";
            lblMaxStock.Size = new Size(83, 15);
            lblMaxStock.TabIndex = 21;
            lblMaxStock.Text = "Stock máximo";
            // 
            // txtCongelable
            // 
            txtCongelable.Location = new Point(164, 203);
            txtCongelable.Name = "txtCongelable";
            txtCongelable.ReadOnly = true;
            txtCongelable.Size = new Size(144, 23);
            txtCongelable.TabIndex = 24;
            // 
            // lblCongelable
            // 
            lblCongelable.AutoSize = true;
            lblCongelable.Location = new Point(37, 206);
            lblCongelable.Name = "lblCongelable";
            lblCongelable.Size = new Size(108, 15);
            lblCongelable.TabIndex = 23;
            lblCongelable.Text = "Tiempo congelable";
            // 
            // lblSugerencias
            // 
            lblSugerencias.AutoSize = true;
            lblSugerencias.Location = new Point(37, 294);
            lblSugerencias.Name = "lblSugerencias";
            lblSugerencias.Size = new Size(70, 15);
            lblSugerencias.TabIndex = 25;
            lblSugerencias.Text = "Sugerencias";
            // 
            // rtxtSugerencias
            // 
            rtxtSugerencias.Location = new Point(38, 312);
            rtxtSugerencias.Name = "rtxtSugerencias";
            rtxtSugerencias.ReadOnly = true;
            rtxtSugerencias.Size = new Size(741, 100);
            rtxtSugerencias.TabIndex = 26;
            rtxtSugerencias.Text = "";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(558, 445);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(221, 40);
            btnModificar.TabIndex = 27;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnListado
            // 
            btnListado.Location = new Point(38, 445);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(221, 40);
            btnListado.TabIndex = 28;
            btnListado.Text = "Listado";
            btnListado.UseVisualStyleBackColor = true;
            btnListado.Click += btnAceptar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(164, 116);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(144, 23);
            txtPrecio.TabIndex = 30;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(38, 119);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(93, 15);
            lblPrecio.TabIndex = 29;
            lblPrecio.Text = "Precio del menú";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(164, 87);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(144, 23);
            txtTipo.TabIndex = 32;
            // 
            // chkAutorizado
            // 
            chkAutorizado.AutoSize = true;
            chkAutorizado.Enabled = false;
            chkAutorizado.Location = new Point(38, 33);
            chkAutorizado.Name = "chkAutorizado";
            chkAutorizado.Size = new Size(84, 19);
            chkAutorizado.TabIndex = 34;
            chkAutorizado.Text = "Autorizado";
            chkAutorizado.UseVisualStyleBackColor = true;
            // 
            // txtElaboracion
            // 
            txtElaboracion.Location = new Point(164, 232);
            txtElaboracion.Name = "txtElaboracion";
            txtElaboracion.ReadOnly = true;
            txtElaboracion.Size = new Size(144, 23);
            txtElaboracion.TabIndex = 36;
            // 
            // lblElaboracion
            // 
            lblElaboracion.AutoSize = true;
            lblElaboracion.Location = new Point(37, 235);
            lblElaboracion.Name = "lblElaboracion";
            lblElaboracion.Size = new Size(112, 15);
            lblElaboracion.TabIndex = 35;
            lblElaboracion.Text = "Tiempo elaboración";
            // 
            // lstDietas
            // 
            lstDietas.FormattingEnabled = true;
            lstDietas.ItemHeight = 15;
            lstDietas.Location = new Point(604, 56);
            lstDietas.Name = "lstDietas";
            lstDietas.Size = new Size(175, 199);
            lstDietas.TabIndex = 37;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Enabled = false;
            chkActivo.Location = new Point(174, 33);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 38;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // DetallesMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 513);
            Controls.Add(chkActivo);
            Controls.Add(lstDietas);
            Controls.Add(txtElaboracion);
            Controls.Add(lblElaboracion);
            Controls.Add(chkAutorizado);
            Controls.Add(txtTipo);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(btnListado);
            Controls.Add(btnModificar);
            Controls.Add(rtxtSugerencias);
            Controls.Add(lblSugerencias);
            Controls.Add(txtCongelable);
            Controls.Add(lblCongelable);
            Controls.Add(txtMaxStock);
            Controls.Add(lblMaxStock);
            Controls.Add(txtMinStock);
            Controls.Add(lblMinStock);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTipo);
            Controls.Add(lblDieta);
            Controls.Add(lstComidas);
            Controls.Add(lblComidasMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DetallesMenu";
            Text = "DetallesMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstComidas;
        private Label lblComidasMenu;
        private Label lblDieta;
        private Label lblTipo;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtMinStock;
        private Label lblMinStock;
        private TextBox txtMaxStock;
        private Label lblMaxStock;
        private TextBox txtCongelable;
        private Label lblCongelable;
        private Label lblSugerencias;
        private RichTextBox rtxtSugerencias;
        private Button btnModificar;
        private Button btnListado;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtTipo;
        private CheckBox chkAutorizado;
        private TextBox txtElaboracion;
        private Label lblElaboracion;
        private ListBox lstDietas;
        private CheckBox chkActivo;
    }
}