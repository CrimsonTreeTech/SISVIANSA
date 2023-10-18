namespace SISVIANSA_ITI_2023.GUI
{
    partial class GestionarComida
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtCoccion = new TextBox();
            lblTiempoCoccion = new Label();
            lblDietasDisponibles = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            chkAutorizado = new CheckBox();
            lstDietasSeleccionadas = new ListBox();
            lstDietasDisponibles = new ListBox();
            lblDietasSeleccionadas = new Label();
            btnAgregar = new Button();
            btnQuitar = new Button();
            chkActivo = new CheckBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 17);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(235, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtCoccion
            // 
            txtCoccion.Location = new Point(184, 65);
            txtCoccion.Name = "txtCoccion";
            txtCoccion.Size = new Size(146, 23);
            txtCoccion.TabIndex = 3;
            // 
            // lblTiempoCoccion
            // 
            lblTiempoCoccion.AutoSize = true;
            lblTiempoCoccion.Location = new Point(18, 68);
            lblTiempoCoccion.Name = "lblTiempoCoccion";
            lblTiempoCoccion.Size = new Size(147, 15);
            lblTiempoCoccion.TabIndex = 2;
            lblTiempoCoccion.Text = "Tiempo coccion (minutos)";
            // 
            // lblDietasDisponibles
            // 
            lblDietasDisponibles.AutoSize = true;
            lblDietasDisponibles.Location = new Point(357, 13);
            lblDietasDisponibles.Name = "lblDietasDisponibles";
            lblDietasDisponibles.Size = new Size(102, 15);
            lblDietasDisponibles.TabIndex = 4;
            lblDietasDisponibles.Text = "Dietas disponibles";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(18, 225);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(312, 27);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(18, 182);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(312, 27);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // chkAutorizado
            // 
            chkAutorizado.AutoSize = true;
            chkAutorizado.Location = new Point(18, 126);
            chkAutorizado.Name = "chkAutorizado";
            chkAutorizado.Size = new Size(84, 19);
            chkAutorizado.TabIndex = 8;
            chkAutorizado.Text = "Autorizado";
            chkAutorizado.UseVisualStyleBackColor = true;
            // 
            // lstDietasSeleccionadas
            // 
            lstDietasSeleccionadas.FormattingEnabled = true;
            lstDietasSeleccionadas.ItemHeight = 15;
            lstDietasSeleccionadas.Location = new Point(587, 43);
            lstDietasSeleccionadas.Name = "lstDietasSeleccionadas";
            lstDietasSeleccionadas.SelectionMode = SelectionMode.MultiSimple;
            lstDietasSeleccionadas.Size = new Size(201, 214);
            lstDietasSeleccionadas.TabIndex = 5;
            // 
            // lstDietasDisponibles
            // 
            lstDietasDisponibles.FormattingEnabled = true;
            lstDietasDisponibles.ItemHeight = 15;
            lstDietasDisponibles.Location = new Point(357, 43);
            lstDietasDisponibles.Name = "lstDietasDisponibles";
            lstDietasDisponibles.SelectionMode = SelectionMode.MultiSimple;
            lstDietasDisponibles.Size = new Size(201, 214);
            lstDietasDisponibles.TabIndex = 10;
            // 
            // lblDietasSeleccionadas
            // 
            lblDietasSeleccionadas.AutoSize = true;
            lblDietasSeleccionadas.Location = new Point(587, 17);
            lblDietasSeleccionadas.Name = "lblDietasSeleccionadas";
            lblDietasSeleccionadas.Size = new Size(143, 15);
            lblDietasSeleccionadas.TabIndex = 9;
            lblDietasSeleccionadas.Text = "Dietas a las que pertenece";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(537, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(21, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(767, 13);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(21, 23);
            btnQuitar.TabIndex = 12;
            btnQuitar.Text = "-";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(130, 126);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 13;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // IngresarComida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 269);
            Controls.Add(chkActivo);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(lstDietasDisponibles);
            Controls.Add(lblDietasSeleccionadas);
            Controls.Add(chkAutorizado);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lstDietasSeleccionadas);
            Controls.Add(lblDietasDisponibles);
            Controls.Add(txtCoccion);
            Controls.Add(lblTiempoCoccion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "IngresarComida";
            Text = "IngresarComida";
            Load += IngresarComida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox textBox1;
        private Label lblTiempoCoccion;
        private Label lblDietasDisponibles;
        private ListBox lstDietas;
        private Button btnCancelar;
        private Button btnAceptar;
        private CheckBox chkAutorizado;
        private ListBox lstDietasQuePertenece;
        private Label label1;
        private Button btnAgregar;
        private Button btnQuitar;
        private ListBox lstDietasDisponibles;
        private ListBox lstDietasSeleccionadas;
        private Label lblDietasSeleccionadas;
        private TextBox txtCoccion;
        private CheckBox chkActivo;
    }
}