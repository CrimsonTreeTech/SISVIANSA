namespace SISVIANSA_ITI_2023.GUI
{
    partial class DetallesCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallesCliente));
            chkAutorizado = new CheckBox();
            lblCalle = new Label();
            lblId = new Label();
            lblPrimerNombre = new Label();
            lblTel1 = new Label();
            lblTel2 = new Label();
            lblTel3 = new Label();
            lblMail1 = new Label();
            lblMail2 = new Label();
            lblMail3 = new Label();
            lblEsquina = new Label();
            lblNumeroPuerta = new Label();
            txtNombre = new TextBox();
            txtTel1 = new TextBox();
            txtTel2 = new TextBox();
            txtTel3 = new TextBox();
            txtMail1 = new TextBox();
            txtMail2 = new TextBox();
            txtMail3 = new TextBox();
            txtCalle = new TextBox();
            txtEsquina = new TextBox();
            txtNumeroPuerta = new TextBox();
            btnListado = new Button();
            btnModificar = new Button();
            lblDoc = new Label();
            txtDoc = new TextBox();
            cboActivo = new CheckBox();
            lblTipoCliente = new Label();
            txtTipoCliente = new TextBox();
            SuspendLayout();
            // 
            // chkAutorizado
            // 
            chkAutorizado.AutoSize = true;
            chkAutorizado.Enabled = false;
            chkAutorizado.Location = new Point(496, 20);
            chkAutorizado.Margin = new Padding(4, 3, 4, 3);
            chkAutorizado.Name = "chkAutorizado";
            chkAutorizado.Size = new Size(84, 19);
            chkAutorizado.TabIndex = 24;
            chkAutorizado.Text = "Autorizado";
            chkAutorizado.UseVisualStyleBackColor = true;
            // 
            // lblCalle
            // 
            lblCalle.AutoSize = true;
            lblCalle.Location = new Point(14, 120);
            lblCalle.Margin = new Padding(4, 0, 4, 0);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(33, 15);
            lblCalle.TabIndex = 25;
            lblCalle.Text = "Calle";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(15, 21);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(65, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:  # ####";
            // 
            // lblPrimerNombre
            // 
            lblPrimerNombre.AutoSize = true;
            lblPrimerNombre.Location = new Point(14, 66);
            lblPrimerNombre.Margin = new Padding(4, 0, 4, 0);
            lblPrimerNombre.Name = "lblPrimerNombre";
            lblPrimerNombre.Size = new Size(51, 15);
            lblPrimerNombre.TabIndex = 4;
            lblPrimerNombre.Text = "Nombre";
            // 
            // lblTel1
            // 
            lblTel1.AutoSize = true;
            lblTel1.Location = new Point(15, 210);
            lblTel1.Margin = new Padding(4, 0, 4, 0);
            lblTel1.Name = "lblTel1";
            lblTel1.Size = new Size(61, 15);
            lblTel1.TabIndex = 12;
            lblTel1.Text = "Teléfono 1";
            // 
            // lblTel2
            // 
            lblTel2.AutoSize = true;
            lblTel2.Location = new Point(15, 240);
            lblTel2.Margin = new Padding(4, 0, 4, 0);
            lblTel2.Name = "lblTel2";
            lblTel2.Size = new Size(61, 15);
            lblTel2.TabIndex = 14;
            lblTel2.Text = "Teléfono 2";
            // 
            // lblTel3
            // 
            lblTel3.AutoSize = true;
            lblTel3.Location = new Point(15, 270);
            lblTel3.Margin = new Padding(4, 0, 4, 0);
            lblTel3.Name = "lblTel3";
            lblTel3.Size = new Size(61, 15);
            lblTel3.TabIndex = 16;
            lblTel3.Text = "Teléfono 3";
            // 
            // lblMail1
            // 
            lblMail1.AutoSize = true;
            lblMail1.Location = new Point(274, 209);
            lblMail1.Margin = new Padding(4, 0, 4, 0);
            lblMail1.Name = "lblMail1";
            lblMail1.Size = new Size(58, 15);
            lblMail1.TabIndex = 18;
            lblMail1.Text = "e-mail 1 *";
            // 
            // lblMail2
            // 
            lblMail2.AutoSize = true;
            lblMail2.Location = new Point(274, 239);
            lblMail2.Margin = new Padding(4, 0, 4, 0);
            lblMail2.Name = "lblMail2";
            lblMail2.Size = new Size(50, 15);
            lblMail2.TabIndex = 20;
            lblMail2.Text = "e-mail 2";
            // 
            // lblMail3
            // 
            lblMail3.AutoSize = true;
            lblMail3.Location = new Point(274, 269);
            lblMail3.Margin = new Padding(4, 0, 4, 0);
            lblMail3.Name = "lblMail3";
            lblMail3.Size = new Size(50, 15);
            lblMail3.TabIndex = 22;
            lblMail3.Text = "e-mail 3";
            // 
            // lblEsquina
            // 
            lblEsquina.AutoSize = true;
            lblEsquina.Location = new Point(14, 150);
            lblEsquina.Margin = new Padding(4, 0, 4, 0);
            lblEsquina.Name = "lblEsquina";
            lblEsquina.Size = new Size(28, 15);
            lblEsquina.TabIndex = 27;
            lblEsquina.Text = "Esq.";
            // 
            // lblNumeroPuerta
            // 
            lblNumeroPuerta.AutoSize = true;
            lblNumeroPuerta.Location = new Point(448, 119);
            lblNumeroPuerta.Margin = new Padding(4, 0, 4, 0);
            lblNumeroPuerta.Name = "lblNumeroPuerta";
            lblNumeroPuerta.Size = new Size(58, 15);
            lblNumeroPuerta.TabIndex = 29;
            lblNumeroPuerta.Text = "Nª puerta";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(73, 63);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(358, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtTel1
            // 
            txtTel1.Location = new Point(98, 206);
            txtTel1.Margin = new Padding(4, 3, 4, 3);
            txtTel1.Name = "txtTel1";
            txtTel1.ReadOnly = true;
            txtTel1.Size = new Size(147, 23);
            txtTel1.TabIndex = 13;
            // 
            // txtTel2
            // 
            txtTel2.Location = new Point(98, 236);
            txtTel2.Margin = new Padding(4, 3, 4, 3);
            txtTel2.Name = "txtTel2";
            txtTel2.ReadOnly = true;
            txtTel2.Size = new Size(147, 23);
            txtTel2.TabIndex = 15;
            // 
            // txtTel3
            // 
            txtTel3.Location = new Point(98, 266);
            txtTel3.Margin = new Padding(4, 3, 4, 3);
            txtTel3.Name = "txtTel3";
            txtTel3.ReadOnly = true;
            txtTel3.Size = new Size(147, 23);
            txtTel3.TabIndex = 17;
            // 
            // txtMail1
            // 
            txtMail1.Location = new Point(355, 206);
            txtMail1.Margin = new Padding(4, 3, 4, 3);
            txtMail1.Name = "txtMail1";
            txtMail1.ReadOnly = true;
            txtMail1.Size = new Size(227, 23);
            txtMail1.TabIndex = 19;
            // 
            // txtMail2
            // 
            txtMail2.Location = new Point(355, 236);
            txtMail2.Margin = new Padding(4, 3, 4, 3);
            txtMail2.Name = "txtMail2";
            txtMail2.ReadOnly = true;
            txtMail2.Size = new Size(227, 23);
            txtMail2.TabIndex = 21;
            // 
            // txtMail3
            // 
            txtMail3.Location = new Point(355, 266);
            txtMail3.Margin = new Padding(4, 3, 4, 3);
            txtMail3.Name = "txtMail3";
            txtMail3.ReadOnly = true;
            txtMail3.Size = new Size(227, 23);
            txtMail3.TabIndex = 23;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(55, 116);
            txtCalle.Margin = new Padding(4, 3, 4, 3);
            txtCalle.Name = "txtCalle";
            txtCalle.ReadOnly = true;
            txtCalle.Size = new Size(376, 23);
            txtCalle.TabIndex = 26;
            // 
            // txtEsquina
            // 
            txtEsquina.Location = new Point(55, 147);
            txtEsquina.Margin = new Padding(4, 3, 4, 3);
            txtEsquina.Name = "txtEsquina";
            txtEsquina.ReadOnly = true;
            txtEsquina.Size = new Size(525, 23);
            txtEsquina.TabIndex = 28;
            // 
            // txtNumeroPuerta
            // 
            txtNumeroPuerta.Location = new Point(508, 117);
            txtNumeroPuerta.Margin = new Padding(4, 3, 4, 3);
            txtNumeroPuerta.Name = "txtNumeroPuerta";
            txtNumeroPuerta.ReadOnly = true;
            txtNumeroPuerta.Size = new Size(72, 23);
            txtNumeroPuerta.TabIndex = 30;
            // 
            // btnListado
            // 
            btnListado.Location = new Point(13, 315);
            btnListado.Margin = new Padding(4, 3, 4, 3);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(150, 34);
            btnListado.TabIndex = 33;
            btnListado.Text = "Listado";
            btnListado.UseVisualStyleBackColor = true;
            btnListado.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(432, 315);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 34);
            btnModificar.TabIndex = 34;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Location = new Point(450, 66);
            lblDoc.Margin = new Padding(4, 0, 4, 0);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(31, 15);
            lblDoc.TabIndex = 35;
            lblDoc.Text = "Doc.";
            // 
            // txtDoc
            // 
            txtDoc.Location = new Point(489, 66);
            txtDoc.Margin = new Padding(4, 3, 4, 3);
            txtDoc.Name = "txtDoc";
            txtDoc.ReadOnly = true;
            txtDoc.Size = new Size(91, 23);
            txtDoc.TabIndex = 36;
            // 
            // cboActivo
            // 
            cboActivo.AutoSize = true;
            cboActivo.Enabled = false;
            cboActivo.Location = new Point(421, 19);
            cboActivo.Margin = new Padding(4, 3, 4, 3);
            cboActivo.Name = "cboActivo";
            cboActivo.Size = new Size(60, 19);
            cboActivo.TabIndex = 37;
            cboActivo.Text = "Activo";
            cboActivo.UseVisualStyleBackColor = true;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(217, 20);
            lblTipoCliente.Margin = new Padding(4, 0, 4, 0);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(68, 15);
            lblTipoCliente.TabIndex = 38;
            lblTipoCliente.Text = "Tipo cliente";
            // 
            // txtTipoCliente
            // 
            txtTipoCliente.Location = new Point(293, 18);
            txtTipoCliente.Margin = new Padding(4, 3, 4, 3);
            txtTipoCliente.Name = "txtTipoCliente";
            txtTipoCliente.ReadOnly = true;
            txtTipoCliente.Size = new Size(91, 23);
            txtTipoCliente.TabIndex = 39;
            // 
            // DetallesCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(597, 367);
            Controls.Add(txtTipoCliente);
            Controls.Add(lblTipoCliente);
            Controls.Add(cboActivo);
            Controls.Add(txtDoc);
            Controls.Add(lblDoc);
            Controls.Add(btnModificar);
            Controls.Add(btnListado);
            Controls.Add(txtNumeroPuerta);
            Controls.Add(lblNumeroPuerta);
            Controls.Add(txtEsquina);
            Controls.Add(lblEsquina);
            Controls.Add(txtCalle);
            Controls.Add(lblCalle);
            Controls.Add(chkAutorizado);
            Controls.Add(txtMail3);
            Controls.Add(lblMail3);
            Controls.Add(txtMail2);
            Controls.Add(lblMail2);
            Controls.Add(txtMail1);
            Controls.Add(lblMail1);
            Controls.Add(txtTel3);
            Controls.Add(lblTel3);
            Controls.Add(txtTel2);
            Controls.Add(lblTel2);
            Controls.Add(txtTel1);
            Controls.Add(lblTel1);
            Controls.Add(txtNombre);
            Controls.Add(lblPrimerNombre);
            Controls.Add(lblId);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetallesCliente";
            Text = "Detalle del cliente";
            Load += DetallesClienteComun_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblPrimerNombre;
        private TextBox txtPrimerNombre;
        private TextBox txtSegundoNombre;
        private Label lblSegundoNombre;
        private TextBox txtPrimerApellido;
        private Label lblPrimerApellido;
        private TextBox txtSegundoApellido;
        private Label lblSegundoApellido;
        private TextBox txtTel1;
        private Label lblTel1;
        private TextBox txtTel2;
        private Label lblTel2;
        private TextBox txtTel3;
        private Label lblTel3;
        private TextBox txtMail1;
        private Label lblMail1;
        private TextBox txtMail2;
        private Label lblMail2;
        private TextBox txtMail3;
        private Label lblMail3;
        private CheckBox chkAutorizado;
        private Label lblCalle;
        private TextBox txtCalle;
        private TextBox txtEsquina;
        private Label lblEsquina;
        private TextBox txtNumeroPuerta;
        private Label lblNumeroPuerta;
        private TextBox txtBarrio;
        private Label lblBarrio;
        private Button btnListado;
        private Button btnModificar;
        private Label lblDoc;
        private TextBox txtDoc;
        private CheckBox cboActivo;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtTipoCliente;
        private Label lblTipoCliente;
    }
}