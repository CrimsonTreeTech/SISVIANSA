namespace SISVIANSA_ITI_2023.GUI
{
    partial class GestionarDieta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarDieta));
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            rtxtDescripcion = new RichTextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            chkAutorizado = new CheckBox();
            chkActivo = new CheckBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 20);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(23, 64);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(157, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Breve descripcion de la dieta";
            // 
            // rtxtDescripcion
            // 
            rtxtDescripcion.Location = new Point(23, 82);
            rtxtDescripcion.Name = "rtxtDescripcion";
            rtxtDescripcion.Size = new Size(358, 133);
            rtxtDescripcion.TabIndex = 3;
            rtxtDescripcion.Text = "";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(23, 276);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 31);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(255, 276);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(126, 31);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // chkAutorizado
            // 
            chkAutorizado.AutoSize = true;
            chkAutorizado.Location = new Point(23, 233);
            chkAutorizado.Name = "chkAutorizado";
            chkAutorizado.Size = new Size(84, 19);
            chkAutorizado.TabIndex = 6;
            chkAutorizado.Text = "Autorizado";
            chkAutorizado.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(321, 233);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 7;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // GestionarDieta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 320);
            Controls.Add(chkActivo);
            Controls.Add(chkAutorizado);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(rtxtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionarDieta";
            Text = "IngresarDieta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private RichTextBox rtxtDescripcion;
        private Button btnCancelar;
        private Button btnAceptar;
        private CheckBox chkAutorizado;
        private CheckBox chkActivo;
    }
}