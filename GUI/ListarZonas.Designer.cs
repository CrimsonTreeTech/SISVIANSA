namespace SISVIANSA_ITI_2023.GUI
{
    partial class ListarZonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarZonas));
            lstZonas = new ListBox();
            lblZonas = new Label();
            lblBarrios = new Label();
            lstBarrios = new ListBox();
            btnRegresar = new Button();
            btnModificar = new Button();
            SuspendLayout();
            // 
            // lstZonas
            // 
            lstZonas.FormattingEnabled = true;
            lstZonas.ItemHeight = 15;
            lstZonas.Location = new Point(20, 48);
            lstZonas.Name = "lstZonas";
            lstZonas.Size = new Size(166, 229);
            lstZonas.TabIndex = 0;
            lstZonas.SelectedIndexChanged += lstZonas_SelectedIndexChanged;
            // 
            // lblZonas
            // 
            lblZonas.AutoSize = true;
            lblZonas.Location = new Point(20, 17);
            lblZonas.Name = "lblZonas";
            lblZonas.Size = new Size(39, 15);
            lblZonas.TabIndex = 1;
            lblZonas.Text = "Zonas";
            // 
            // lblBarrios
            // 
            lblBarrios.AutoSize = true;
            lblBarrios.Location = new Point(207, 17);
            lblBarrios.Name = "lblBarrios";
            lblBarrios.Size = new Size(43, 15);
            lblBarrios.TabIndex = 2;
            lblBarrios.Text = "Barrios";
            // 
            // lstBarrios
            // 
            lstBarrios.FormattingEnabled = true;
            lstBarrios.ItemHeight = 15;
            lstBarrios.Location = new Point(207, 48);
            lstBarrios.Name = "lstBarrios";
            lstBarrios.Size = new Size(166, 229);
            lstBarrios.Sorted = true;
            lstBarrios.TabIndex = 3;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(20, 298);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(122, 28);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(251, 298);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(122, 28);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // ListarZonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 340);
            Controls.Add(btnModificar);
            Controls.Add(btnRegresar);
            Controls.Add(lstBarrios);
            Controls.Add(lblBarrios);
            Controls.Add(lblZonas);
            Controls.Add(lstZonas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListarZonas";
            Text = "Listar zonas";
            Load += ListarZonas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private ListBox lstZonas;
        private Label lblZonas;
        private Label lblBarrios;
        private ListBox lstBarrios;
        private Button btnRegresar;
        private Button btnModificar;
    }
}