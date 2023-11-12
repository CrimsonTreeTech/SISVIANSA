namespace SISVIANSA_ITI_2023.GUI
{
    partial class IniciarSesion
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

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new IniciarSesion());
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            lblUsuario = new Label();
            lblPasswords = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(12, 27);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario";
            txtUser.Size = new Size(298, 23);
            txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(12, 87);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(298, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Location = new Point(12, 133);
            btnIngresar.Margin = new Padding(3, 2, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(298, 46);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(12, 10);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblPasswords
            // 
            lblPasswords.AutoSize = true;
            lblPasswords.Location = new Point(12, 70);
            lblPasswords.Name = "lblPasswords";
            lblPasswords.Size = new Size(67, 15);
            lblPasswords.TabIndex = 4;
            lblPasswords.Text = "Contraseña";
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(326, 192);
            Controls.Add(lblPasswords);
            Controls.Add(lblUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IniciarSesion";
            Text = "IniciarSesion";
            Load += IniciarSesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Label lblUsuario;
        private Label lblPasswords;
    }
}