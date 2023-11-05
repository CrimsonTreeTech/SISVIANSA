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
            pnlCarita = new Panel();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUser.Location = new Point(325, 40);
            txtUser.Margin = new Padding(3, 2, 3, 2);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario";
            txtUser.Size = new Size(298, 26);
            txtUser.TabIndex = 0;
            txtUser.Text = "informatico";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(325, 91);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(298, 23);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "1234";
            // 
            // btnIngresar
            // 
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Location = new Point(325, 146);
            btnIngresar.Margin = new Padding(3, 2, 3, 2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(298, 46);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // pnlCarita
            // 
            pnlCarita.BackColor = Color.LightCoral;
            pnlCarita.BackgroundImage = Properties.Resources.png_transparent_user_profile_computer_icons_login_user_avatars_thumbnail;
            pnlCarita.BackgroundImageLayout = ImageLayout.Center;
            pnlCarita.Cursor = Cursors.Help;
            pnlCarita.Location = new Point(10, 9);
            pnlCarita.Margin = new Padding(3, 2, 3, 2);
            pnlCarita.Name = "pnlCarita";
            pnlCarita.Size = new Size(248, 303);
            pnlCarita.TabIndex = 3;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(665, 321);
            Controls.Add(pnlCarita);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
        private Panel pnlCarita;
    }
}