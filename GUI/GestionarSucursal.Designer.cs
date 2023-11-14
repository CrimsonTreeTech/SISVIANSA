namespace SISVIANSA_ITI_2023.GUI
{
    partial class GestionarSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarSucursal));
            lblCapProd = new Label();
            txtCapProd = new TextBox();
            lblMetas = new Label();
            rtxtMetas = new RichTextBox();
            lblZonasDisponibles = new Label();
            lblZonasCubiertas = new Label();
            lstZonasCubiertas = new ListBox();
            lstZonsaDisponibles = new ListBox();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblCapProd
            // 
            lblCapProd.AutoSize = true;
            lblCapProd.Location = new Point(21, 26);
            lblCapProd.Name = "lblCapProd";
            lblCapProd.Size = new Size(151, 15);
            lblCapProd.TabIndex = 0;
            lblCapProd.Text = "Capacidad de produccion *";
            // 
            // txtCapProd
            // 
            txtCapProd.Location = new Point(201, 23);
            txtCapProd.Margin = new Padding(3, 2, 3, 2);
            txtCapProd.Name = "txtCapProd";
            txtCapProd.Size = new Size(81, 23);
            txtCapProd.TabIndex = 2;
            // 
            // lblMetas
            // 
            lblMetas.AutoSize = true;
            lblMetas.Location = new Point(21, 69);
            lblMetas.Name = "lblMetas";
            lblMetas.Size = new Size(113, 15);
            lblMetas.TabIndex = 2;
            lblMetas.Text = "Metas de la sucursal";
            // 
            // rtxtMetas
            // 
            rtxtMetas.Location = new Point(21, 86);
            rtxtMetas.Margin = new Padding(3, 2, 3, 2);
            rtxtMetas.Name = "rtxtMetas";
            rtxtMetas.Size = new Size(261, 220);
            rtxtMetas.TabIndex = 3;
            rtxtMetas.Text = "";
            // 
            // lblZonasDisponibles
            // 
            lblZonasDisponibles.AutoSize = true;
            lblZonasDisponibles.Location = new Point(325, 23);
            lblZonasDisponibles.Name = "lblZonasDisponibles";
            lblZonasDisponibles.Size = new Size(102, 15);
            lblZonasDisponibles.TabIndex = 4;
            lblZonasDisponibles.Text = "Zonas disponibles";
            // 
            // lblZonasCubiertas
            // 
            lblZonasCubiertas.AutoSize = true;
            lblZonasCubiertas.Location = new Point(559, 23);
            lblZonasCubiertas.Name = "lblZonasCubiertas";
            lblZonasCubiertas.Size = new Size(161, 15);
            lblZonasCubiertas.TabIndex = 5;
            lblZonasCubiertas.Text = "Zonas que cubre la sucursal *";
            // 
            // lstZonasCubiertas
            // 
            lstZonasCubiertas.FormattingEnabled = true;
            lstZonasCubiertas.ItemHeight = 15;
            lstZonasCubiertas.Location = new Point(559, 47);
            lstZonasCubiertas.Name = "lstZonasCubiertas";
            lstZonasCubiertas.Size = new Size(215, 259);
            lstZonasCubiertas.TabIndex = 6;
            // 
            // lstZonsaDisponibles
            // 
            lstZonsaDisponibles.FormattingEnabled = true;
            lstZonsaDisponibles.ItemHeight = 15;
            lstZonsaDisponibles.Location = new Point(325, 47);
            lstZonsaDisponibles.Name = "lstZonsaDisponibles";
            lstZonsaDisponibles.Size = new Size(215, 259);
            lstZonsaDisponibles.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(506, 16);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(34, 28);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "+";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(740, 16);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(34, 28);
            btnQuitar.TabIndex = 9;
            btnQuitar.Text = "-";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(21, 324);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(207, 37);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(567, 324);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(207, 37);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // GestionarSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 373);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(lstZonsaDisponibles);
            Controls.Add(lstZonasCubiertas);
            Controls.Add(lblZonasCubiertas);
            Controls.Add(lblZonasDisponibles);
            Controls.Add(rtxtMetas);
            Controls.Add(lblMetas);
            Controls.Add(txtCapProd);
            Controls.Add(lblCapProd);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GestionarSucursal";
            Text = "IngresarSucursal";
            Load += IngresarSucursal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCapProd;
        private TextBox txtCapProd;
        private Label lblMetas;
        private RichTextBox rtxtMetas;
        private Label lblZonasDisponibles;
        private Label lblZonasCubiertas;
        private ListBox lstZonasCubiertas;
        private ListBox lstZonsaDisponibles;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}