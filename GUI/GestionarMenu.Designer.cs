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
            btnQuitarComida = new Button();
            lstComidasMenu = new ListBox();
            lblComidasMenu = new Label();
            btnAgregarComida = new Button();
            lstComidasDisponibles = new ListBox();
            lblListaComidas = new Label();
            lblDieta = new Label();
            lblTipo = new Label();
            cboTipo = new ComboBox();
            lblSugerencias = new Label();
            rtxtSugerencias = new RichTextBox();
            btnCancelar = new Button();
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
            ckLstDietas = new CheckedListBox();
            chkActivo = new CheckBox();
            SuspendLayout();
            // 
            // btnQuitarComida
            // 
            btnQuitarComida.Enabled = false;
            btnQuitarComida.Location = new Point(860, 14);
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
            lstComidasMenu.Location = new Point(682, 46);
            lstComidasMenu.Name = "lstComidasMenu";
            lstComidasMenu.Size = new Size(207, 289);
            lstComidasMenu.TabIndex = 8;
            // 
            // lblComidasMenu
            // 
            lblComidasMenu.AutoSize = true;
            lblComidasMenu.Location = new Point(682, 24);
            lblComidasMenu.Name = "lblComidasMenu";
            lblComidasMenu.Size = new Size(116, 15);
            lblComidasMenu.TabIndex = 7;
            lblComidasMenu.Text = "Comidas en el Menu";
            // 
            // btnAgregarComida
            // 
            btnAgregarComida.Enabled = false;
            btnAgregarComida.Location = new Point(630, 18);
            btnAgregarComida.Name = "btnAgregarComida";
            btnAgregarComida.Size = new Size(29, 25);
            btnAgregarComida.TabIndex = 12;
            btnAgregarComida.Text = "+";
            btnAgregarComida.UseVisualStyleBackColor = true;
            btnAgregarComida.Click += btnAgregarComida_Click;
            // 
            // lstComidasDisponibles
            // 
            lstComidasDisponibles.Enabled = false;
            lstComidasDisponibles.FormattingEnabled = true;
            lstComidasDisponibles.ItemHeight = 15;
            lstComidasDisponibles.Location = new Point(452, 46);
            lstComidasDisponibles.Name = "lstComidasDisponibles";
            lstComidasDisponibles.Size = new Size(207, 289);
            lstComidasDisponibles.TabIndex = 11;
            // 
            // lblListaComidas
            // 
            lblListaComidas.AutoSize = true;
            lblListaComidas.Location = new Point(452, 24);
            lblListaComidas.Name = "lblListaComidas";
            lblListaComidas.Size = new Size(95, 15);
            lblListaComidas.TabIndex = 10;
            lblListaComidas.Text = "Lista de comidas";
            // 
            // lblDieta
            // 
            lblDieta.AutoSize = true;
            lblDieta.Location = new Point(229, 24);
            lblDieta.Name = "lblDieta";
            lblDieta.Size = new Size(34, 15);
            lblDieta.TabIndex = 13;
            lblDieta.Text = "Dieta";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(19, 62);
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
            cboTipo.Location = new Point(55, 59);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(150, 23);
            cboTipo.TabIndex = 16;
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            cboTipo.Click += cboTipo_Click;
            // 
            // lblSugerencias
            // 
            lblSugerencias.AutoSize = true;
            lblSugerencias.Location = new Point(21, 224);
            lblSugerencias.Name = "lblSugerencias";
            lblSugerencias.Size = new Size(70, 15);
            lblSugerencias.TabIndex = 25;
            lblSugerencias.Text = "Sugerencias";
            // 
            // rtxtSugerencias
            // 
            rtxtSugerencias.Location = new Point(21, 242);
            rtxtSugerencias.Name = "rtxtSugerencias";
            rtxtSugerencias.Size = new Size(394, 93);
            rtxtSugerencias.TabIndex = 26;
            rtxtSugerencias.Text = "";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(21, 369);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(221, 40);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(668, 369);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(221, 40);
            btnAceptar.TabIndex = 28;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(135, 88);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(70, 23);
            txtPrecio.TabIndex = 38;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(21, 94);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 37;
            lblPrecio.Text = "Precio";
            // 
            // txtCongelable
            // 
            txtCongelable.Location = new Point(135, 175);
            txtCongelable.Name = "txtCongelable";
            txtCongelable.Size = new Size(70, 23);
            txtCongelable.TabIndex = 36;
            // 
            // lblCongelable
            // 
            lblCongelable.AutoSize = true;
            lblCongelable.Location = new Point(21, 181);
            lblCongelable.Name = "lblCongelable";
            lblCongelable.Size = new Size(108, 15);
            lblCongelable.TabIndex = 35;
            lblCongelable.Text = "Tiempo congelable";
            // 
            // txtMaxStock
            // 
            txtMaxStock.Location = new Point(135, 146);
            txtMaxStock.Name = "txtMaxStock";
            txtMaxStock.Size = new Size(70, 23);
            txtMaxStock.TabIndex = 34;
            // 
            // lblMaxStock
            // 
            lblMaxStock.AutoSize = true;
            lblMaxStock.Location = new Point(21, 149);
            lblMaxStock.Name = "lblMaxStock";
            lblMaxStock.Size = new Size(83, 15);
            lblMaxStock.TabIndex = 33;
            lblMaxStock.Text = "Stock máximo";
            // 
            // txtMinStock
            // 
            txtMinStock.Location = new Point(135, 117);
            txtMinStock.Name = "txtMinStock";
            txtMinStock.Size = new Size(70, 23);
            txtMinStock.TabIndex = 32;
            // 
            // lblMinStock
            // 
            lblMinStock.AutoSize = true;
            lblMinStock.Location = new Point(21, 123);
            lblMinStock.Name = "lblMinStock";
            lblMinStock.Size = new Size(81, 15);
            lblMinStock.TabIndex = 31;
            lblMinStock.Text = "Stock mínimo";
            // 
            // chkPersonalizado
            // 
            chkPersonalizado.AutoSize = true;
            chkPersonalizado.Location = new Point(21, 23);
            chkPersonalizado.Name = "chkPersonalizado";
            chkPersonalizado.Size = new Size(99, 19);
            chkPersonalizado.TabIndex = 39;
            chkPersonalizado.Text = "Personalizado";
            chkPersonalizado.UseVisualStyleBackColor = true;
            // 
            // chkAutorizado
            // 
            chkAutorizado.AutoSize = true;
            chkAutorizado.Location = new Point(369, 381);
            chkAutorizado.Name = "chkAutorizado";
            chkAutorizado.Size = new Size(84, 19);
            chkAutorizado.TabIndex = 40;
            chkAutorizado.Text = "Autorizado";
            chkAutorizado.UseVisualStyleBackColor = true;
            // 
            // ckLstDietas
            // 
            ckLstDietas.FormattingEnabled = true;
            ckLstDietas.Location = new Point(229, 52);
            ckLstDietas.Name = "ckLstDietas";
            ckLstDietas.Size = new Size(186, 148);
            ckLstDietas.TabIndex = 41;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(487, 381);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 42;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // GestionarMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 424);
            Controls.Add(chkActivo);
            Controls.Add(ckLstDietas);
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
            Controls.Add(btnCancelar);
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
        private ListBox lstComidasDisponibles;
        private Label lblListaComidas;
        private Label lblDieta;
        private Label lblTipo;
        private ComboBox cboTipo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblSugerencias;
        private RichTextBox rtxtSugerencias;
        private Button btnCancelar;
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
        private CheckedListBox ckLstDietas;
    }
}