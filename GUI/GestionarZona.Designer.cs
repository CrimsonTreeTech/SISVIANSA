namespace SISVIANSA_ITI_2023.GUI
{
    partial class GestionarZona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarZona));
            lblListaBarrios = new Label();
            lstBarrios = new ListBox();
            btnQuitar = new Button();
            lblNombreBarrio = new Label();
            txtNombreBarrio = new TextBox();
            btnAgregar = new Button();
            btnRegresar = new Button();
            btnAceptar = new Button();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            SuspendLayout();
            // 
            // lblListaBarrios
            // 
            lblListaBarrios.AutoSize = true;
            lblListaBarrios.Location = new Point(12, 131);
            lblListaBarrios.Name = "lblListaBarrios";
            lblListaBarrios.Size = new Size(94, 15);
            lblListaBarrios.TabIndex = 1;
            lblListaBarrios.Text = "Barrios incluidos";
            // 
            // lstBarrios
            // 
            lstBarrios.FormattingEnabled = true;
            lstBarrios.ItemHeight = 15;
            lstBarrios.Location = new Point(12, 156);
            lstBarrios.Name = "lstBarrios";
            lstBarrios.Size = new Size(281, 154);
            lstBarrios.TabIndex = 2;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(229, 127);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(64, 23);
            btnQuitar.TabIndex = 3;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // lblNombreBarrio
            // 
            lblNombreBarrio.AutoSize = true;
            lblNombreBarrio.Location = new Point(12, 16);
            lblNombreBarrio.Name = "lblNombreBarrio";
            lblNombreBarrio.Size = new Size(44, 15);
            lblNombreBarrio.TabIndex = 4;
            lblNombreBarrio.Text = "Barrio: ";
            // 
            // txtNombreBarrio
            // 
            txtNombreBarrio.Location = new Point(69, 13);
            txtNombreBarrio.Name = "txtNombreBarrio";
            txtNombreBarrio.Size = new Size(224, 23);
            txtNombreBarrio.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 71);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(281, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 316);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(64, 23);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(231, 316);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(64, 23);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(69, 42);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(224, 23);
            txtPrecio.TabIndex = 3;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(12, 45);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 9;
            lblPrecio.Text = "Precio:";
            // 
            // GestionarZona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 348);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(btnAceptar);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombreBarrio);
            Controls.Add(lblNombreBarrio);
            Controls.Add(btnQuitar);
            Controls.Add(lstBarrios);
            Controls.Add(lblListaBarrios);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionarZona";
            Text = "IngresarZona";
            Load += IngresarZona_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblListaBarrios;
        private ListBox lstBarrios;
        private Button btnQuitar;
        private Label lblNombreBarrio;
        private TextBox txtNombreBarrio;
        private Button btnAgregar;
        private Button btnRegresar;
        private Button btnAceptar;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Label lblNombreZona;
        private TextBox txtNombre;
    }
}