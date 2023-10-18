namespace SISVIANSA_ITI_2023.GUI
{
    partial class AdministrarMenu
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(329, 210);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 0;
            btnRegresar.TabStop = false;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // AdministrarMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Name = "AdministrarMenu";
            Text = "AdministrarMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnRegresar;
    }
}