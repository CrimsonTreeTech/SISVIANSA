namespace ventana3
{
    partial class AsignarZonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarZonas));
            btnGuardar = new Button();
            lstZonasSeleccionadas = new ListBox();
            btnDeseleccionar = new Button();
            btnSeleccionar = new Button();
            btnCancelar = new Button();
            lstZonasDisponibles = new ListBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(275, 299);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(84, 25);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnguardar_Click;
            // 
            // lstZonasSeleccionadas
            // 
            lstZonasSeleccionadas.FormattingEnabled = true;
            lstZonasSeleccionadas.ItemHeight = 15;
            lstZonasSeleccionadas.Location = new Point(195, 37);
            lstZonasSeleccionadas.Margin = new Padding(3, 2, 3, 2);
            lstZonasSeleccionadas.Name = "lstZonasSeleccionadas";
            lstZonasSeleccionadas.Size = new Size(164, 229);
            lstZonasSeleccionadas.TabIndex = 2;
            // 
            // btnDeseleccionar
            // 
            btnDeseleccionar.Location = new Point(195, 11);
            btnDeseleccionar.Margin = new Padding(3, 2, 3, 2);
            btnDeseleccionar.Name = "btnDeseleccionar";
            btnDeseleccionar.Size = new Size(164, 22);
            btnDeseleccionar.TabIndex = 3;
            btnDeseleccionar.Text = "DESELECCIONAR";
            btnDeseleccionar.UseVisualStyleBackColor = true;
            btnDeseleccionar.Click += btnDeseleccionar_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(12, 11);
            btnSeleccionar.Margin = new Padding(3, 2, 3, 2);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(161, 22);
            btnSeleccionar.TabIndex = 8;
            btnSeleccionar.Text = "ASIGNAR ZONA";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 299);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 25);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lstZonasDisponibles
            // 
            lstZonasDisponibles.FormattingEnabled = true;
            lstZonasDisponibles.ItemHeight = 15;
            lstZonasDisponibles.Location = new Point(12, 37);
            lstZonasDisponibles.Margin = new Padding(3, 2, 3, 2);
            lstZonasDisponibles.Name = "lstZonasDisponibles";
            lstZonasDisponibles.Size = new Size(161, 229);
            lstZonasDisponibles.TabIndex = 0;
            // 
            // AsignarZonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 342);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnDeseleccionar);
            Controls.Add(lstZonasSeleccionadas);
            Controls.Add(btnGuardar);
            Controls.Add(lstZonasDisponibles);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AsignarZonas";
            Text = "Asignar zonas a vehiculos";
            Load += AsignarZonas_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnGuardar;
        private ListBox lstZonasSeleccionadas;
        private Button btnDeseleccionar;
        private Button btnBuscar;
        private TextBox txtMatricula;
        private DataGridView dttVehiculo;
        private Button btnSeleccionar;
        private Button btnCancelar;
        private ListBox lstZonasDisponibles;
    }
}