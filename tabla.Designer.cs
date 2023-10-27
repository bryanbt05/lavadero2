namespace lavadero2
{
    partial class tabla
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
            this.tbregistro = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btndelet = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmod = new System.Windows.Forms.TextBox();
            this.txtvers = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.txtserv = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbregistro)).BeginInit();
            this.SuspendLayout();
            // 
            // tbregistro
            // 
            this.tbregistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbregistro.Location = new System.Drawing.Point(0, 136);
            this.tbregistro.Name = "tbregistro";
            this.tbregistro.ReadOnly = true;
            this.tbregistro.RowTemplate.Height = 25;
            this.tbregistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbregistro.Size = new System.Drawing.Size(802, 396);
            this.tbregistro.TabIndex = 16;
            this.tbregistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbregistro_CellContentClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbuscar.Location = new System.Drawing.Point(678, 7);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(112, 33);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btndelet
            // 
            this.btndelet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndelet.Location = new System.Drawing.Point(506, 97);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(112, 33);
            this.btndelet.TabIndex = 10;
            this.btndelet.Text = "ELIMINAR";
            this.btndelet.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnupdate.Location = new System.Drawing.Point(660, 97);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(122, 33);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "MODIFICAR";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(203, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Placa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(203, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "Servicio";
            // 
            // txtmod
            // 
            this.txtmod.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmod.Location = new System.Drawing.Point(12, 35);
            this.txtmod.Name = "txtmod";
            this.txtmod.Size = new System.Drawing.Size(130, 29);
            this.txtmod.TabIndex = 25;
            // 
            // txtvers
            // 
            this.txtvers.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtvers.Location = new System.Drawing.Point(12, 101);
            this.txtvers.Name = "txtvers";
            this.txtvers.Size = new System.Drawing.Size(130, 29);
            this.txtvers.TabIndex = 26;
            // 
            // txtplaca
            // 
            this.txtplaca.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtplaca.Location = new System.Drawing.Point(203, 35);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(130, 29);
            this.txtplaca.TabIndex = 27;
            // 
            // txtserv
            // 
            this.txtserv.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtserv.Location = new System.Drawing.Point(203, 101);
            this.txtserv.Name = "txtserv";
            this.txtserv.Size = new System.Drawing.Size(130, 29);
            this.txtserv.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 29;
            // 
            // tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 532);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtserv);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtvers);
            this.Controls.Add(this.txtmod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.tbregistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tabla";
            this.Text = "tabla";
            ((System.ComponentModel.ISupportInitialize)(this.tbregistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tbregistro;
        private Button btnbuscar;
        private Button btndelet;
        private Button btnupdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtmod;
        private TextBox txtvers;
        private TextBox txtplaca;
        private TextBox txtserv;
        private TextBox textBox1;
    }
}