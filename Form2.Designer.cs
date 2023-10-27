namespace lavadero2
{
    partial class Form2
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
            label2 = new Label();
            label3 = new Label();
            cboservicio = new ComboBox();
            cboprecio = new ComboBox();
            btnregis = new Button();
            label5 = new Label();
            cbopago = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnactua = new Button();
            txtbuscar = new TextBox();
            tbplaca = new DataGridView();
            cbolava = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbplaca).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Indigo;
            label2.Location = new Point(9, 80);
            label2.Name = "label2";
            label2.Size = new Size(208, 34);
            label2.TabIndex = 1;
            label2.Text = "Tipo Servicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Indigo;
            label3.Location = new Point(9, 160);
            label3.Name = "label3";
            label3.Size = new Size(108, 34);
            label3.TabIndex = 2;
            label3.Text = "Precio";
            // 
            // cboservicio
            // 
            cboservicio.BackColor = Color.White;
            cboservicio.FlatStyle = FlatStyle.Flat;
            cboservicio.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboservicio.ForeColor = Color.Indigo;
            cboservicio.FormattingEnabled = true;
            cboservicio.Location = new Point(222, 80);
            cboservicio.Name = "cboservicio";
            cboservicio.Size = new Size(180, 31);
            cboservicio.TabIndex = 4;
            cboservicio.SelectedIndexChanged += cboservicio_SelectedIndexChanged;
            // 
            // cboprecio
            // 
            cboprecio.BackColor = Color.White;
            cboprecio.FlatStyle = FlatStyle.Flat;
            cboprecio.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboprecio.ForeColor = Color.Indigo;
            cboprecio.FormattingEnabled = true;
            cboprecio.Location = new Point(232, 160);
            cboprecio.Name = "cboprecio";
            cboprecio.Size = new Size(170, 31);
            cboprecio.TabIndex = 5;
            // 
            // btnregis
            // 
            btnregis.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnregis.Font = new Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnregis.Location = new Point(45, 427);
            btnregis.Name = "btnregis";
            btnregis.Size = new Size(122, 33);
            btnregis.TabIndex = 7;
            btnregis.Text = "REGISTRAR";
            btnregis.UseVisualStyleBackColor = true;
            btnregis.Click += btnregis_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Indigo;
            label5.Location = new Point(9, 240);
            label5.Name = "label5";
            label5.Size = new Size(158, 34);
            label5.TabIndex = 20;
            label5.Text = "Tipo Pago";
            // 
            // cbopago
            // 
            cbopago.BackColor = Color.White;
            cbopago.FlatStyle = FlatStyle.Flat;
            cbopago.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbopago.ForeColor = Color.Indigo;
            cbopago.FormattingEnabled = true;
            cbopago.Location = new Point(232, 240);
            cbopago.Name = "cbopago";
            cbopago.Size = new Size(170, 31);
            cbopago.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(282, 2);
            label1.Name = "label1";
            label1.Size = new Size(267, 55);
            label1.TabIndex = 0;
            label1.Text = "WASH 2.0";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 60);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnactua);
            panel2.Controls.Add(btnregis);
            panel2.Controls.Add(txtbuscar);
            panel2.Controls.Add(tbplaca);
            panel2.Controls.Add(cbolava);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(cbopago);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cboprecio);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cboservicio);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 472);
            panel2.TabIndex = 24;
            // 
            // btnactua
            // 
            btnactua.Font = new Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnactua.Location = new Point(436, 417);
            btnactua.Name = "btnactua";
            btnactua.Size = new Size(123, 33);
            btnactua.TabIndex = 32;
            btnactua.Text = "Actualizar";
            btnactua.UseVisualStyleBackColor = true;
            btnactua.Click += btnactua_Click;
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Candara", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtbuscar.Location = new Point(412, 311);
            txtbuscar.MaxLength = 10;
            txtbuscar.Name = "txtbuscar";
            txtbuscar.PlaceholderText = "Buscar Placa...";
            txtbuscar.Size = new Size(170, 33);
            txtbuscar.TabIndex = 31;
            txtbuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // tbplaca
            // 
            tbplaca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbplaca.Location = new Point(412, 80);
            tbplaca.Name = "tbplaca";
            tbplaca.ReadOnly = true;
            tbplaca.RowTemplate.Height = 25;
            tbplaca.Size = new Size(170, 225);
            tbplaca.TabIndex = 30;
            tbplaca.CellContentClick += tbplaca_CellContentClick;
            // 
            // cbolava
            // 
            cbolava.BackColor = Color.White;
            cbolava.FlatStyle = FlatStyle.Flat;
            cbolava.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbolava.ForeColor = Color.Indigo;
            cbolava.FormattingEnabled = true;
            cbolava.Location = new Point(232, 313);
            cbolava.Name = "cbolava";
            cbolava.Size = new Size(170, 31);
            cbolava.TabIndex = 29;
            cbolava.SelectedIndexChanged += cbolava_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Indigo;
            label4.Location = new Point(9, 313);
            label4.Name = "label4";
            label4.Size = new Size(135, 34);
            label4.TabIndex = 28;
            label4.Text = "Lavador";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Indigo;
            label6.Location = new Point(574, 43);
            label6.Name = "label6";
            label6.Size = new Size(225, 34);
            label6.TabIndex = 27;
            label6.Text = "Observaciones";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Indigo;
            textBox1.Location = new Point(588, 81);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(207, 263);
            textBox1.TabIndex = 26;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Indigo;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.CharacterCasing = CharacterCasing.Upper;
            textBox3.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(588, 151);
            textBox3.Margin = new Padding(0);
            textBox3.MaxLength = 3;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(0, 107);
            textBox3.TabIndex = 24;
            textBox3.Text = "-";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(802, 532);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbplaca).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private ComboBox cboservicio;
        private ComboBox cboprecio;
        private Button btnregis;
        private Label label5;
        private ComboBox cbopago;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label6;
        private Label label4;
        private ComboBox cbolava;
        private DataGridView tbplaca;
        private TextBox txtbuscar;
        private Button btnactua;
    }
}