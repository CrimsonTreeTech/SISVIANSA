namespace SISVIANSA_ITI_2023.GUI
{
    partial class GestionarPedido
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton2 = new RadioButton();
            dataGridView1 = new DataGridView();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            dataGridView2 = new DataGridView();
            columna = new DataGridViewTextBoxColumn();
            columna1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            column4 = new DataGridViewTextBoxColumn();
            columna5 = new DataGridViewTextBoxColumn();
            Columna6 = new DataGridViewTextBoxColumn();
            lblObservaciones = new Label();
            textBox5 = new TextBox();
            btnRegresar = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(622, 593);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(194, 53);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(356, 593);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(194, 53);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 80);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 14;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(58, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(743, 160);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(56, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(745, 133);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(31, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(43, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "CI";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(115, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(31, 80);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nombre";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columna, columna1, Column2, column4, columna5, Columna6, Column6 });
            dataGridView1.Location = new Point(298, 34);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(411, 70);
            dataGridView1.TabIndex = 4;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(33, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(66, 24);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Dieta";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(33, 71);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(60, 24);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Tipo";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column5, Column7, Column8 });
            dataGridView2.Location = new Point(286, 25);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(438, 86);
            dataGridView2.TabIndex = 4;
            // 
            // columna
            // 
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columna.HeaderText = "CI";
            columna.MinimumWidth = 6;
            columna.Name = "columna";
            columna.ReadOnly = true;
            // 
            // columna1
            // 
            columna1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columna1.HeaderText = "Nombre";
            columna1.MinimumWidth = 6;
            columna1.Name = "columna1";
            columna1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Apellido";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // column4
            // 
            column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column4.HeaderText = "Teléfono";
            column4.MinimumWidth = 6;
            column4.Name = "column4";
            column4.ReadOnly = true;
            // 
            // columna5
            // 
            columna5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columna5.HeaderText = "Correo";
            columna5.MinimumWidth = 6;
            columna5.Name = "columna5";
            columna5.ReadOnly = true;
            // 
            // Columna6
            // 
            Columna6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Columna6.HeaderText = "Estado";
            Columna6.MinimumWidth = 6;
            Columna6.Name = "Columna6";
            Columna6.ReadOnly = true;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Location = new Point(58, 446);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(105, 20);
            lblObservaciones.TabIndex = 17;
            lblObservaciones.Text = "Observaciones";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(173, 446);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(269, 107);
            textBox5.TabIndex = 18;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(76, 593);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(211, 53);
            btnRegresar.TabIndex = 19;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(117, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(117, 26);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 28);
            comboBox2.TabIndex = 6;
            // 
            // Column6
            // 
            Column6.HeaderText = "Autorizado";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "iDMenu";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Tipo de Menu";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Dieta";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Precio";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "Autorizado";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // GestionarPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 732);
            Controls.Add(btnRegresar);
            Controls.Add(textBox5);
            Controls.Add(lblObservaciones);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionarPedido";
            Text = "RealizarPedido";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn columna;
        private DataGridViewTextBoxColumn columna1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn column4;
        private DataGridViewTextBoxColumn columna5;
        private DataGridViewTextBoxColumn Columna6;
        private Label lblObservaciones;
        private TextBox textBox5;
        private Button btnRegresar;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn Column6;
        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}