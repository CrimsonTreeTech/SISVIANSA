using System.Collections;

namespace SISVIANSA_ITI_2023.GUI
{
    partial class GestionarMenu
    {

        private System.ComponentModel.IContainer components = null;
        private Logica.Dieta dietas;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarMenu));
            btnQuitarComida = new Button();
            lstComidasMenu = new ListBox();
            lblComidasMenu = new Label();
            btnAgregarComida = new Button();
            lblListaComidas = new Label();
            lblDieta = new Label();
            lblTipo = new Label();
            cboTipo = new ComboBox();
            lblSugerencias = new Label();
            rtxtSugerencias = new RichTextBox();
            btnMenu = new Button();
            btnAceptar = new Button();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtCongelable = new TextBox();
            lblCongelable = new Label();
            txtMaxStock = new TextBox();
            lblMaxStock = new Label();
            txtMinStock = new TextBox();
            lblMinStock = new Label();
            chkPersonalizado = new CheckBox();
            chkAutorizado = new CheckBox();
            chkLstDietas = new CheckedListBox();
            chkActivo = new CheckBox();
            lblId = new Label();
            txtId = new TextBox();
            txtStockActual = new TextBox();
            lblStockActual = new Label();
            btnListado = new Button();
            lstComidasDisponibles = new ListBox();
            SuspendLayout();
            // 
            // btnQuitarComida
            // 
            btnQuitarComida.Enabled = false;
            btnQuitarComida.Location = new Point(873, 14);
            btnQuitarComida.Name = "btnQuitarComida";
            btnQuitarComida.Size = new Size(29, 25);
            btnQuitarComida.TabIndex = 9;
            btnQuitarComida.Text = "-";
            btnQuitarComida.UseVisualStyleBackColor = true;
            btnQuitarComida.Click += btnQuitarComida_Click;
            // 
            // lstComidasMenu
            // 
            lstComidasMenu.Enabled = false;
            lstComidasMenu.FormattingEnabled = true;
            lstComidasMenu.ItemHeight = 15;
            lstComidasMenu.Location = new Point(695, 46);
            lstComidasMenu.Name = "lstComidasMenu";
            lstComidasMenu.Size = new Size(207, 364);
            lstComidasMenu.TabIndex = 8;
            // 
            // lblComidasMenu
            // 
            lblComidasMenu.AutoSize = true;
            lblComidasMenu.Location = new Point(695, 24);
            lblComidasMenu.Name = "lblComidasMenu";
            lblComidasMenu.Size = new Size(116, 15);
            lblComidasMenu.TabIndex = 7;
            lblComidasMenu.Text = "Comidas en el Menu";
            // 
            // btnAgregarComida
            // 
            btnAgregarComida.Enabled = false;
            btnAgregarComida.Location = new Point(643, 18);
            btnAgregarComida.Name = "btnAgregarComida";
            btnAgregarComida.Size = new Size(29, 25);
            btnAgregarComida.TabIndex = 12;
            btnAgregarComida.Text = "+";
            btnAgregarComida.UseVisualStyleBackColor = true;
            btnAgregarComida.Click += btnAgregarComida_Click;
            // 
            // lblListaComidas
            // 
            lblListaComidas.AutoSize = true;
            lblListaComidas.Location = new Point(465, 24);
            lblListaComidas.Name = "lblListaComidas";
            lblListaComidas.Size = new Size(95, 15);
            lblListaComidas.TabIndex = 10;
            lblListaComidas.Text = "Lista de comidas";
            // 
            // lblDieta
            // 
            lblDieta.AutoSize = true;
            lblDieta.Location = new Point(231, 66);
            lblDieta.Name = "lblDieta";
            lblDieta.Size = new Size(34, 15);
            lblDieta.TabIndex = 13;
            lblDieta.Text = "Dieta";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(21, 99);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "Tipo";
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Semanal", "Quincenal", "Mensual" });
            cboTipo.Location = new Point(57, 96);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(150, 23);
            cboTipo.TabIndex = 16;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            cboTipo.Click += cboTipo_Click;
            // 
            // lblSugerencias
            // 
            lblSugerencias.AutoSize = true;
            lblSugerencias.Location = new Point(21, 287);
            lblSugerencias.Name = "lblSugerencias";
            lblSugerencias.Size = new Size(70, 15);
            lblSugerencias.TabIndex = 25;
            lblSugerencias.Text = "Sugerencias";
            // 
            // rtxtSugerencias
            // 
            rtxtSugerencias.Location = new Point(20, 305);
            rtxtSugerencias.Name = "rtxtSugerencias";
            rtxtSugerencias.Size = new Size(394, 105);
            rtxtSugerencias.TabIndex = 26;
            rtxtSugerencias.Text = "";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(20, 434);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(220, 40);
            btnMenu.TabIndex = 27;
            btnMenu.Text = "Regresar al menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(680, 432);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(220, 40);
            btnAceptar.TabIndex = 28;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(137, 125);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(70, 23);
            txtPrecio.TabIndex = 38;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(21, 128);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 37;
            lblPrecio.Text = "Precio";
            // 
            // txtCongelable
            // 
            txtCongelable.Location = new Point(137, 244);
            txtCongelable.Name = "txtCongelable";
            txtCongelable.Size = new Size(70, 23);
            txtCongelable.TabIndex = 36;
            // 
            // lblCongelable
            // 
            lblCongelable.AutoSize = true;
            lblCongelable.Location = new Point(21, 247);
            lblCongelable.Name = "lblCongelable";
            lblCongelable.Size = new Size(108, 15);
            lblCongelable.TabIndex = 35;
            lblCongelable.Text = "Tiempo congelable";
            // 
            // txtMaxStock
            // 
            txtMaxStock.Location = new Point(137, 215);
            txtMaxStock.Name = "txtMaxStock";
            txtMaxStock.Size = new Size(70, 23);
            txtMaxStock.TabIndex = 34;
            // 
            // lblMaxStock
            // 
            lblMaxStock.AutoSize = true;
            lblMaxStock.Location = new Point(21, 218);
            lblMaxStock.Name = "lblMaxStock";
            lblMaxStock.Size = new Size(83, 15);
            lblMaxStock.TabIndex = 33;
            lblMaxStock.Text = "Stock máximo";
            // 
            // txtMinStock
            // 
            txtMinStock.Location = new Point(137, 186);
            txtMinStock.Name = "txtMinStock";
            txtMinStock.Size = new Size(70, 23);
            txtMinStock.TabIndex = 32;
            // 
            // lblMinStock
            // 
            lblMinStock.AutoSize = true;
            lblMinStock.Location = new Point(21, 189);
            lblMinStock.Name = "lblMinStock";
            lblMinStock.Size = new Size(81, 15);
            lblMinStock.TabIndex = 31;
            lblMinStock.Text = "Stock mínimo";
            // 
            // chkPersonalizado
            // 
            chkPersonalizado.AutoSize = true;
            chkPersonalizado.Location = new Point(21, 66);
            chkPersonalizado.Name = "chkPersonalizado";
            chkPersonalizado.Size = new Size(99, 19);
            chkPersonalizado.TabIndex = 39;
            chkPersonalizado.Text = "Personalizado";
            chkPersonalizado.UseVisualStyleBackColor = true;
            // 
            // chkAutorizado
            // 
            chkAutorizado.AutoSize = true;
            chkAutorizado.Location = new Point(239, 25);
            chkAutorizado.Name = "chkAutorizado";
            chkAutorizado.Size = new Size(84, 19);
            chkAutorizado.TabIndex = 40;
            chkAutorizado.Text = "Autorizado";
            chkAutorizado.UseVisualStyleBackColor = true;
            // 
            // chkLstDietas
            // 
            chkLstDietas.CheckOnClick = true;
            chkLstDietas.FormattingEnabled = true;
            chkLstDietas.Location = new Point(231, 86);
            chkLstDietas.Name = "chkLstDietas";
            chkLstDietas.Size = new Size(186, 184);
            chkLstDietas.TabIndex = 41;
            chkLstDietas.ItemCheck += chkLstDietas_ItemCheck;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(357, 25);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 42;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(61, 15);
            lblId.TabIndex = 43;
            lblId.Text = "Nro Menu";
            // 
            // txtId
            // 
            txtId.Location = new Point(88, 21);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(119, 23);
            txtId.TabIndex = 44;
            // 
            // txtStockActual
            // 
            txtStockActual.Location = new Point(137, 157);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(70, 23);
            txtStockActual.TabIndex = 46;
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Location = new Point(21, 160);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new Size(71, 15);
            lblStockActual.TabIndex = 45;
            lblStockActual.Text = "Stock actual";
            // 
            // btnListado
            // 
            btnListado.Location = new Point(350, 434);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(220, 40);
            btnListado.TabIndex = 47;
            btnListado.Text = "Regresar al listado";
            btnListado.UseVisualStyleBackColor = true;
            btnListado.Click += btnListado_Click;
            // 
            // lstComidasDisponibles
            // 
            lstComidasDisponibles.Enabled = false;
            lstComidasDisponibles.FormattingEnabled = true;
            lstComidasDisponibles.ItemHeight = 15;
            lstComidasDisponibles.Location = new Point(465, 46);
            lstComidasDisponibles.Name = "lstComidasDisponibles";
            lstComidasDisponibles.Size = new Size(207, 364);
            lstComidasDisponibles.TabIndex = 11;
            // 
            // GestionarMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 484);
            Controls.Add(btnListado);
            Controls.Add(txtStockActual);
            Controls.Add(lblStockActual);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(chkActivo);
            Controls.Add(chkLstDietas);
            Controls.Add(chkAutorizado);
            Controls.Add(chkPersonalizado);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtCongelable);
            Controls.Add(lblCongelable);
            Controls.Add(txtMaxStock);
            Controls.Add(lblMaxStock);
            Controls.Add(txtMinStock);
            Controls.Add(lblMinStock);
            Controls.Add(btnAceptar);
            Controls.Add(btnMenu);
            Controls.Add(rtxtSugerencias);
            Controls.Add(lblSugerencias);
            Controls.Add(cboTipo);
            Controls.Add(lblTipo);
            Controls.Add(lblDieta);
            Controls.Add(btnAgregarComida);
            Controls.Add(lstComidasDisponibles);
            Controls.Add(lblListaComidas);
            Controls.Add(btnQuitarComida);
            Controls.Add(lstComidasMenu);
            Controls.Add(lblComidasMenu);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GestionarMenu";
            Text = "IngresarMenu";
            Load += IngresarMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuitarComida;
        private ListBox lstComidasMenu;
        private Label lblComidasMenu;
        private Button btnAgregarComida;
        private Label lblListaComidas;
        private Label lblDieta;
        private Label lblTipo;
        private ComboBox cboTipo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblSugerencias;
        private RichTextBox rtxtSugerencias;
        private Button btnMenu;
        private Button btnAceptar;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtCongelable;
        private Label lblCongelable;
        private TextBox txtMaxStock;
        private Label lblMaxStock;
        private TextBox txtMinStock;
        private Label lblMinStock;
        private CheckBox chkPersonalizado;
        private CheckBox chkAutorizado;
        private CheckedListBox checkedListBox1;
        private CheckBox chkActivo;
        private CheckedListBox chkLstDietas;
        private Label lblId;
        private TextBox txtId;
        private TextBox txtStockActual;
        private Label lblStockActual;
        private Button btnListado;
        private ListBox lstComidasDisponibles;
    }
}