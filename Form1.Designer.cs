namespace lavadero2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cbomarca = new ComboBox();
            cbomodelo = new ComboBox();
            cboempresa = new ComboBox();
            cbotpveh = new ComboBox();
            cbover = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label8 = new Label();
            btnselec = new Button();
            txtp = new TextBox();
            pictureBox2 = new PictureBox();
            txtp1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbomarca
            // 
            cbomarca.BackColor = Color.White;
            cbomarca.FlatStyle = FlatStyle.Flat;
            cbomarca.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbomarca.ForeColor = Color.Teal;
            cbomarca.FormattingEnabled = true;
            cbomarca.Location = new Point(179, 122);
            cbomarca.Name = "cbomarca";
            cbomarca.Size = new Size(180, 31);
            cbomarca.TabIndex = 6;
            cbomarca.SelectedIndexChanged += cbomarca_SelectedIndexChanged;
            // 
            // cbomodelo
            // 
            cbomodelo.BackColor = Color.White;
            cbomodelo.FlatStyle = FlatStyle.Flat;
            cbomodelo.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbomodelo.ForeColor = Color.Teal;
            cbomodelo.FormattingEnabled = true;
            cbomodelo.Location = new Point(179, 196);
            cbomodelo.Name = "cbomodelo";
            cbomodelo.Size = new Size(180, 31);
            cbomodelo.TabIndex = 7;
            cbomodelo.SelectedIndexChanged += cbomodelo_SelectedIndexChanged;
            // 
            // cboempresa
            // 
            cboempresa.BackColor = Color.White;
            cboempresa.FlatStyle = FlatStyle.Flat;
            cboempresa.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboempresa.ForeColor = Color.Teal;
            cboempresa.FormattingEnabled = true;
            cboempresa.Location = new Point(179, 355);
            cboempresa.Name = "cboempresa";
            cboempresa.Size = new Size(180, 31);
            cboempresa.TabIndex = 8;
            // 
            // cbotpveh
            // 
            cbotpveh.BackColor = Color.White;
            cbotpveh.FlatStyle = FlatStyle.Flat;
            cbotpveh.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbotpveh.ForeColor = Color.Teal;
            cbotpveh.FormattingEnabled = true;
            cbotpveh.Location = new Point(247, 435);
            cbotpveh.Name = "cbotpveh";
            cbotpveh.Size = new Size(180, 31);
            cbotpveh.TabIndex = 14;
            cbotpveh.SelectedIndexChanged += cbotpveh_SelectedIndexChanged;
            // 
            // cbover
            // 
            cbover.BackColor = Color.White;
            cbover.FlatStyle = FlatStyle.Flat;
            cbover.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbover.ForeColor = Color.Teal;
            cbover.FormattingEnabled = true;
            cbover.Location = new Point(179, 275);
            cbover.Name = "cbover";
            cbover.Size = new Size(180, 31);
            cbover.TabIndex = 15;
            cbover.SelectedIndexChanged += cbover_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 192, 192);
            label3.Location = new Point(12, 435);
            label3.Name = "label3";
            label3.Size = new Size(218, 34);
            label3.TabIndex = 2;
            label3.Text = "Tipo Vehiculo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 192, 192);
            label5.Location = new Point(12, 351);
            label5.Name = "label5";
            label5.Size = new Size(143, 34);
            label5.TabIndex = 4;
            label5.Text = "Empresa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Cooper Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 55);
            label1.TabIndex = 0;
            label1.Text = "WASH 2.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 192, 192);
            label4.Location = new Point(12, 189);
            label4.Name = "label4";
            label4.Size = new Size(119, 34);
            label4.TabIndex = 3;
            label4.Text = "Modelo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 192, 192);
            label7.Location = new Point(12, 271);
            label7.Name = "label7";
            label7.Size = new Size(129, 34);
            label7.TabIndex = 13;
            label7.Text = "Version";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(104, 34);
            label2.TabIndex = 1;
            label2.Text = "Marca";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnselec);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbomarca);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtp);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtp1);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 532);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(542, 469);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 4);
            panel2.TabIndex = 31;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 192, 192);
            label8.Location = new Point(551, 108);
            label8.Name = "label8";
            label8.Size = new Size(122, 34);
            label8.TabIndex = 30;
            label8.Text = "PLACA";
            // 
            // btnselec
            // 
            btnselec.FlatAppearance.BorderSize = 0;
            btnselec.FlatAppearance.MouseOverBackColor = Color.White;
            btnselec.FlatStyle = FlatStyle.Flat;
            btnselec.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnselec.ForeColor = Color.FromArgb(0, 192, 192);
            btnselec.Location = new Point(542, 440);
            btnselec.Name = "btnselec";
            btnselec.Size = new Size(130, 30);
            btnselec.TabIndex = 14;
            btnselec.Text = "Guardar";
            btnselec.UseVisualStyleBackColor = true;
            btnselec.Click += btnselec_Click;
            // 
            // txtp
            // 
            txtp.BackColor = Color.FromArgb(0, 192, 192);
            txtp.BorderStyle = BorderStyle.None;
            txtp.CharacterCasing = CharacterCasing.Upper;
            txtp.Font = new Font("Gill Sans Ultra Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtp.Location = new Point(475, 244);
            txtp.MaxLength = 3;
            txtp.Name = "txtp";
            txtp.Size = new Size(110, 44);
            txtp.TabIndex = 26;
            txtp.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(0, 192, 192);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(585, 244);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // txtp1
            // 
            txtp1.BackColor = Color.FromArgb(0, 192, 192);
            txtp1.BorderStyle = BorderStyle.None;
            txtp1.CharacterCasing = CharacterCasing.Upper;
            txtp1.Font = new Font("Gill Sans Ultra Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtp1.Location = new Point(642, 244);
            txtp1.MaxLength = 3;
            txtp1.Name = "txtp1";
            txtp1.Size = new Size(110, 44);
            txtp1.TabIndex = 27;
            txtp1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(410, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(802, 532);
            Controls.Add(cbover);
            Controls.Add(cbotpveh);
            Controls.Add(cboempresa);
            Controls.Add(cbomodelo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0D;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbomarca;
        private ComboBox cbomodelo;
        private ComboBox cboempresa;
        private ComboBox cbotpveh;
        private ComboBox cbover;
        private Label label3;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label7;
        private Label label2;
        private Panel panel1;
        private Button btnselec;
        private TextBox txtp;
        private PictureBox pictureBox2;
        private TextBox txtp1;
        private PictureBox pictureBox1;
        private Label label8;
        private Panel panel2;
    }
}