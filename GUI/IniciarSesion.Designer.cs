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
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            pnlCarita = new Panel();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUser.Location = new Point(371, 53);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario";
            txtUser.Size = new Size(340, 32);
            txtUser.TabIndex = 0;
            txtUser.Text = "cocina";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(371, 121);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(340, 27);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "1234";
            // 
            // btnIngresar
            // 
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Location = new Point(371, 194);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(341, 61);
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
            pnlCarita.Location = new Point(12, 12);
            pnlCarita.Name = "pnlCarita";
            pnlCarita.Size = new Size(284, 404);
            pnlCarita.TabIndex = 3;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(760, 428);
            Controls.Add(pnlCarita);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "IniciarSesion";
            Text = "IniciarSesion";
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