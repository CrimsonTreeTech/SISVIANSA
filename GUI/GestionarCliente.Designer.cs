namespace SISVIANSA_ITI_2023.GUI
{
    partial class GestionarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarCliente));
            cboTipoDoc = new ComboBox();
            chkAutorizado = new CheckBox();
            lblCalle = new Label();
            lblNumDoc = new Label();
            lblTipoDoc = new Label();
            lblPrimerNombre = new Label();
            lblSegundoNombre = new Label();
            lblPrimerApellido = new Label();
            lblSegundoApellido = new Label();
            lblTel1 = new Label();
            lblTel2 = new Label();
            lblTel3 = new Label();
            lblMail1 = new Label();
            lblMail2 = new Label();
            lblMail3 = new Label();
            lblEsquina = new Label();
            lblNumeroPuerta = new Label();
            txtNumDoc = new TextBox();
            txtPrimerNombre = new TextBox();
            txtSegundoNombre = new TextBox();
            txtPrimerApellido = new TextBox();
            txtSegundoApellido = new TextBox();
            txtTel1 = new TextBox();
            txtTel2 = new TextBox();
            txtTel3 = new TextBox();
            txtMail1 = new TextBox();
            txtMail2 = new TextBox();
            txtMail3 = new TextBox();
            txtCalle = new TextBox();
            txtEsquina = new TextBox();
            txtNumeroPuerta = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            chkActivo = new CheckBox();
            lblTipoCliente = new Label();
            cboTipoCliente = new ComboBox();
            gbxDatos = new GroupBox();
            gbxContacto = new GroupBox();
            gbxDatos.SuspendLayout();
            gbxContacto.SuspendLayout();
            SuspendLayout();
            // 
            // cboTipoDoc
            // 
            cboTipoDoc.AccessibleRole = AccessibleRole.Document;
            cboTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDoc.FormattingEnabled = true;
            cboTipoDoc.ImeMode = ImeMode.NoControl;
            cboTipoDoc.Location = new Point(144, 24);
            cboTipoDoc.Margin = new Padding(4, 3, 4, 3);
            cboTipoDoc.Name = "cboTipoDoc";
            cboTipoDoc.Size = new Size(89, 23);
            cboTipoDoc.TabIndex = 1;
            // 
            // chkAutorizado
            // 
            chkAutorizado.AutoSize = true;
            chkAutorizado.Location = new Point(265, 29);
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
            lblCalle.Location = new Point(17, 210);
            lblCalle.Margin = new Padding(4, 0, 4, 0);
            lblCalle.Name = "lblCalle";
            lblCalle.Size = new Size(41, 15);
            lblCalle.TabIndex = 25;
            lblCalle.Text = "Calle *";
            // 
            // lblNumDoc
            // 
            lblNumDoc.AutoSize = true;
            lblNumDoc.Location = new Point(259, 28);
            lblNumDoc.Margin = new Padding(4, 0, 4, 0);
            lblNumDoc.Name = "lblNumDoc";
            lblNumDoc.Size = new Size(104, 15);
            lblNumDoc.TabIndex = 2;
            lblNumDoc.Text = "Nro. Documento *";
            // 
            // lblTipoDoc
            // 
            lblTipoDoc.AutoSize = true;
            lblTipoDoc.Location = new Point(17, 28);
            lblTipoDoc.Margin = new Padding(4, 0, 4, 0);
            lblTipoDoc.Name = "lblTipoDoc";
            lblTipoDoc.Size = new Size(119, 15);
            lblTipoDoc.TabIndex = 0;
            lblTipoDoc.Text = "Tipo de documento *";
            // 
            // lblPrimerNombre
            // 
            lblPrimerNombre.AutoSize = true;
            lblPrimerNombre.Location = new Point(17, 79);
            lblPrimerNombre.Margin = new Padding(4, 0, 4, 0);
            lblPrimerNombre.Name = "lblPrimerNombre";
            lblPrimerNombre.Size = new Size(95, 15);
            lblPrimerNombre.TabIndex = 4;
            lblPrimerNombre.Text = "Primer nombre *";
            // 
            // lblSegundoNombre
            // 
            lblSegundoNombre.AutoSize = true;
            lblSegundoNombre.Location = new Point(266, 79);
            lblSegundoNombre.Margin = new Padding(4, 0, 4, 0);
            lblSegundoNombre.Name = "lblSegundoNombre";
            lblSegundoNombre.Size = new Size(99, 15);
            lblSegundoNombre.TabIndex = 6;
            lblSegundoNombre.Text = "Segundo nombre";
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Location = new Point(17, 129);
            lblPrimerApellido.Margin = new Padding(4, 0, 4, 0);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(95, 15);
            lblPrimerApellido.TabIndex = 8;
            lblPrimerApellido.Text = "Primer apellido *";
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Location = new Point(266, 129);
            lblSegundoApellido.Margin = new Padding(4, 0, 4, 0);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(99, 15);
            lblSegundoApellido.TabIndex = 10;
            lblSegundoApellido.Text = "Segundo apellido";
            // 
            // lblTel1
            // 
            lblTel1.AutoSize = true;
            lblTel1.Location = new Point(17, 38);
            lblTel1.Margin = new Padding(4, 0, 4, 0);
            lblTel1.Name = "lblTel1";
            lblTel1.Size = new Size(69, 15);
            lblTel1.TabIndex = 12;
            lblTel1.Text = "Teléfono 1 *";
            // 
            // lblTel2
            // 
            lblTel2.AutoSize = true;
            lblTel2.Location = new Point(17, 68);
            lblTel2.Margin = new Padding(4, 0, 4, 0);
            lblTel2.Name = "lblTel2";
            lblTel2.Size = new Size(61, 15);
            lblTel2.TabIndex = 14;
            lblTel2.Text = "Teléfono 2";
            // 
            // lblTel3
            // 
            lblTel3.AutoSize = true;
            lblTel3.Location = new Point(17, 98);
            lblTel3.Margin = new Padding(4, 0, 4, 0);
            lblTel3.Name = "lblTel3";
            lblTel3.Size = new Size(61, 15);
            lblTel3.TabIndex = 16;
            lblTel3.Text = "Teléfono 3";
            // 
            // lblMail1
            // 
            lblMail1.AutoSize = true;
            lblMail1.Location = new Point(239, 37);
            lblMail1.Margin = new Padding(4, 0, 4, 0);
            lblMail1.Name = "lblMail1";
            lblMail1.Size = new Size(58, 15);
            lblMail1.TabIndex = 18;
            lblMail1.Text = "e-mail 1 *";
            // 
            // lblMail2
            // 
            lblMail2.AutoSize = true;
            lblMail2.Location = new Point(239, 67);
            lblMail2.Margin = new Padding(4, 0, 4, 0);
            lblMail2.Name = "lblMail2";
            lblMail2.Size = new Size(50, 15);
            lblMail2.TabIndex = 20;
            lblMail2.Text = "e-mail 2";
            // 
            // lblMail3
            // 
            lblMail3.AutoSize = true;
            lblMail3.Location = new Point(239, 97);
            lblMail3.Margin = new Padding(4, 0, 4, 0);
            lblMail3.Name = "lblMail3";
            lblMail3.Size = new Size(50, 15);
            lblMail3.TabIndex = 22;
            lblMail3.Text = "e-mail 3";
            // 
            // lblEsquina
            // 
            lblEsquina.AutoSize = true;
            lblEsquina.Location = new Point(17, 239);
            lblEsquina.Margin = new Padding(4, 0, 4, 0);
            lblEsquina.Name = "lblEsquina";
            lblEsquina.Size = new Size(36, 15);
            lblEsquina.TabIndex = 27;
            lblEsquina.Text = "Esq. *";
            // 
            // lblNumeroPuerta
            // 
            lblNumeroPuerta.AutoSize = true;
            lblNumeroPuerta.Location = new Point(356, 211);
            lblNumeroPuerta.Margin = new Padding(4, 0, 4, 0);
            lblNumeroPuerta.Name = "lblNumeroPuerta";
            lblNumeroPuerta.Size = new Size(58, 15);
            lblNumeroPuerta.TabIndex = 29;
            lblNumeroPuerta.Text = "Nº puerta";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(371, 24);
            txtNumDoc.Margin = new Padding(4, 3, 4, 3);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.PlaceholderText = "Ej.: 12345678";
            txtNumDoc.Size = new Size(111, 23);
            txtNumDoc.TabIndex = 3;
            // 
            // txtPrimerNombre
            // 
            txtPrimerNombre.Location = new Point(17, 97);
            txtPrimerNombre.Margin = new Padding(4, 3, 4, 3);
            txtPrimerNombre.Name = "txtPrimerNombre";
            txtPrimerNombre.PlaceholderText = "Nombre";
            txtPrimerNombre.Size = new Size(216, 23);
            txtPrimerNombre.TabIndex = 5;
            // 
            // txtSegundoNombre
            // 
            txtSegundoNombre.Location = new Point(266, 97);
            txtSegundoNombre.Margin = new Padding(4, 3, 4, 3);
            txtSegundoNombre.Name = "txtSegundoNombre";
            txtSegundoNombre.PlaceholderText = "Nombre";
            txtSegundoNombre.Size = new Size(216, 23);
            txtSegundoNombre.TabIndex = 7;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(17, 147);
            txtPrimerApellido.Margin = new Padding(4, 3, 4, 3);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.PlaceholderText = "Apellido";
            txtPrimerApellido.Size = new Size(216, 23);
            txtPrimerApellido.TabIndex = 9;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(266, 147);
            txtSegundoApellido.Margin = new Padding(4, 3, 4, 3);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.PlaceholderText = "Apellido";
            txtSegundoApellido.Size = new Size(216, 23);
            txtSegundoApellido.TabIndex = 11;
            // 
            // txtTel1
            // 
            txtTel1.Location = new Point(94, 34);
            txtTel1.Margin = new Padding(4, 3, 4, 3);
            txtTel1.Name = "txtTel1";
            txtTel1.PlaceholderText = "Ej.: 12345678";
            txtTel1.Size = new Size(119, 23);
            txtTel1.TabIndex = 13;
            // 
            // txtTel2
            // 
            txtTel2.Location = new Point(94, 64);
            txtTel2.Margin = new Padding(4, 3, 4, 3);
            txtTel2.Name = "txtTel2";
            txtTel2.Size = new Size(119, 23);
            txtTel2.TabIndex = 15;
            // 
            // txtTel3
            // 
            txtTel3.Location = new Point(94, 94);
            txtTel3.Margin = new Padding(4, 3, 4, 3);
            txtTel3.Name = "txtTel3";
            txtTel3.Size = new Size(119, 23);
            txtTel3.TabIndex = 17;
            // 
            // txtMail1
            // 
            txtMail1.Location = new Point(305, 34);
            txtMail1.Margin = new Padding(4, 3, 4, 3);
            txtMail1.Name = "txtMail1";
            txtMail1.PlaceholderText = "Ej.: ejemplo@mail.com";
            txtMail1.Size = new Size(177, 23);
            txtMail1.TabIndex = 19;
            // 
            // txtMail2
            // 
            txtMail2.Location = new Point(305, 65);
            txtMail2.Margin = new Padding(4, 3, 4, 3);
            txtMail2.Name = "txtMail2";
            txtMail2.Size = new Size(177, 23);
            txtMail2.TabIndex = 21;
            // 
            // txtMail3
            // 
            txtMail3.Location = new Point(305, 95);
            txtMail3.Margin = new Padding(4, 3, 4, 3);
            txtMail3.Name = "txtMail3";
            txtMail3.Size = new Size(177, 23);
            txtMail3.TabIndex = 23;
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(59, 206);
            txtCalle.Margin = new Padding(4, 3, 4, 3);
            txtCalle.Name = "txtCalle";
            txtCalle.PlaceholderText = "Nombre de la calle";
            txtCalle.Size = new Size(284, 23);
            txtCalle.TabIndex = 26;
            // 
            // txtEsquina
            // 
            txtEsquina.Location = new Point(59, 235);
            txtEsquina.Margin = new Padding(4, 3, 4, 3);
            txtEsquina.Name = "txtEsquina";
            txtEsquina.PlaceholderText = "Nombre de la calle";
            txtEsquina.Size = new Size(423, 23);
            txtEsquina.TabIndex = 28;
            // 
            // txtNumeroPuerta
            // 
            txtNumeroPuerta.Location = new Point(422, 206);
            txtNumeroPuerta.Margin = new Padding(4, 3, 4, 3);
            txtNumeroPuerta.Name = "txtNumeroPuerta";
            txtNumeroPuerta.PlaceholderText = "0000";
            txtNumeroPuerta.Size = new Size(60, 23);
            txtNumeroPuerta.TabIndex = 30;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(22, 526);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(166, 33);
            btnCancelar.TabIndex = 33;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(354, 526);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(166, 33);
            btnAceptar.TabIndex = 34;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(416, 29);
            chkActivo.Margin = new Padding(4, 3, 4, 3);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 35;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(22, 30);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(68, 15);
            lblTipoCliente.TabIndex = 36;
            lblTipoCliente.Text = "Tipo cliente";
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.AccessibleRole = AccessibleRole.Document;
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCliente.FormattingEnabled = true;
            cboTipoCliente.ImeMode = ImeMode.NoControl;
            cboTipoCliente.Items.AddRange(new object[] { "Empresa", "Particular" });
            cboTipoCliente.Location = new Point(97, 27);
            cboTipoCliente.Margin = new Padding(4, 3, 4, 3);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(108, 23);
            cboTipoCliente.TabIndex = 37;
            cboTipoCliente.SelectedIndexChanged += cboTipoCliente_SelectedIndexChanged;
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(lblSegundoNombre);
            gbxDatos.Controls.Add(lblTipoDoc);
            gbxDatos.Controls.Add(cboTipoDoc);
            gbxDatos.Controls.Add(lblNumDoc);
            gbxDatos.Controls.Add(txtNumDoc);
            gbxDatos.Controls.Add(lblPrimerNombre);
            gbxDatos.Controls.Add(txtPrimerNombre);
            gbxDatos.Controls.Add(txtNumeroPuerta);
            gbxDatos.Controls.Add(lblNumeroPuerta);
            gbxDatos.Controls.Add(txtSegundoNombre);
            gbxDatos.Controls.Add(txtEsquina);
            gbxDatos.Controls.Add(lblPrimerApellido);
            gbxDatos.Controls.Add(lblEsquina);
            gbxDatos.Controls.Add(txtPrimerApellido);
            gbxDatos.Controls.Add(txtCalle);
            gbxDatos.Controls.Add(lblSegundoApellido);
            gbxDatos.Controls.Add(lblCalle);
            gbxDatos.Controls.Add(txtSegundoApellido);
            gbxDatos.Location = new Point(22, 69);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(498, 280);
            gbxDatos.TabIndex = 38;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos";
            // 
            // gbxContacto
            // 
            gbxContacto.Controls.Add(txtMail1);
            gbxContacto.Controls.Add(lblTel1);
            gbxContacto.Controls.Add(txtTel1);
            gbxContacto.Controls.Add(lblTel2);
            gbxContacto.Controls.Add(txtTel2);
            gbxContacto.Controls.Add(lblTel3);
            gbxContacto.Controls.Add(txtTel3);
            gbxContacto.Controls.Add(lblMail1);
            gbxContacto.Controls.Add(lblMail2);
            gbxContacto.Controls.Add(txtMail2);
            gbxContacto.Controls.Add(lblMail3);
            gbxContacto.Controls.Add(txtMail3);
            gbxContacto.Location = new Point(22, 369);
            gbxContacto.Name = "gbxContacto";
            gbxContacto.Size = new Size(498, 140);
            gbxContacto.TabIndex = 39;
            gbxContacto.TabStop = false;
            gbxContacto.Text = "Contacto";
            // 
            // GestionarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(555, 581);
            Controls.Add(gbxContacto);
            Controls.Add(gbxDatos);
            Controls.Add(cboTipoCliente);
            Controls.Add(lblTipoCliente);
            Controls.Add(chkActivo);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(chkAutorizado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionarCliente";
            Text = "Ingresar cliente";
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            gbxContacto.ResumeLayout(false);
            gbxContacto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoDoc;
        private ComboBox cboTipoDoc;
        private Label lblNumDoc;
        private TextBox txtNumDoc;
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
        private Button btnCancelar;
        private Button btnAceptar;
        private CheckBox chkActivo;
        private Label lblTipoCliente;
        private ComboBox cboTipoCliente;
        private GroupBox gbxDatos;
        private GroupBox gbxContacto;
    }
}