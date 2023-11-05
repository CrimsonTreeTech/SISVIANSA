namespace SISVIANSA_ITI_2023.GUI
{
    partial class GestionarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarUsuario));
            lblUser = new Label();
            lblPass = new Label();
            lblRol = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            cboRol = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtRepPwd = new TextBox();
            lblRepPwd = new Label();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(12, 9);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(47, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "Usuario";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(12, 38);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(67, 15);
            lblPass.TabIndex = 1;
            lblPass.Text = "Contraseña";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(12, 96);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(24, 15);
            lblRol.TabIndex = 2;
            lblRol.Text = "Rol";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(90, 6);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(173, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(90, 35);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(173, 23);
            txtPassword.TabIndex = 2;
            // 
            // cboRol
            // 
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRol.FormattingEnabled = true;
            cboRol.Items.AddRange(new object[] { "Gerente", "Administrativo", "Jefe de cocina", "Encargado de transporte", "Atención al público", "Informático" });
            cboRol.Location = new Point(90, 93);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(173, 23);
            cboRol.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 147);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(251, 28);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 181);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(251, 28);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtRepPwd
            // 
            txtRepPwd.Location = new Point(90, 64);
            txtRepPwd.Name = "txtRepPwd";
            txtRepPwd.PasswordChar = '●';
            txtRepPwd.Size = new Size(173, 23);
            txtRepPwd.TabIndex = 3;
            // 
            // lblRepPwd
            // 
            lblRepPwd.AutoSize = true;
            lblRepPwd.Location = new Point(12, 67);
            lblRepPwd.Name = "lblRepPwd";
            lblRepPwd.Size = new Size(47, 15);
            lblRepPwd.TabIndex = 9;
            lblRepPwd.Text = "Repetir:";
            // 
            // GestionarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 218);
            Controls.Add(txtRepPwd);
            Controls.Add(lblRepPwd);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cboRol);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblRol);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GestionarUsuario";
            Text = "IngresarPersonal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPass;
        private Label lblRol;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private ComboBox cboRol;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtRepPwd;
        private Label lblRepPwd;
    }
}