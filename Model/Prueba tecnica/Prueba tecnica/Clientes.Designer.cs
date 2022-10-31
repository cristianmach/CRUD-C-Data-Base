namespace Prueba_tecnica
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.pClientes = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refresh2 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Direccion2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Apellidos2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Nombres2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.select = new System.Windows.Forms.Button();
            this.inicio = new System.Windows.Forms.Button();
            this.IdCliente2 = new System.Windows.Forms.TextBox();
            this.IdCliente12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empresa = new System.Windows.Forms.Label();
            this.pClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pClientes
            // 
            this.pClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pClientes.Controls.Add(this.dataGridView1);
            this.pClientes.Controls.Add(this.panel3);
            this.pClientes.Controls.Add(this.panel2);
            this.pClientes.Controls.Add(this.panel1);
            this.pClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pClientes.Location = new System.Drawing.Point(33, 28);
            this.pClientes.Name = "pClientes";
            this.pClientes.Size = new System.Drawing.Size(731, 452);
            this.pClientes.TabIndex = 0;
            this.pClientes.TabStop = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(420, 203);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(15, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 203);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Prueba_tecnica.Properties.Resources.fondo2;
            this.pictureBox1.ErrorImage = global::Prueba_tecnica.Properties.Resources.fondo2;
            this.pictureBox1.InitialImage = global::Prueba_tecnica.Properties.Resources.fondo2;
            this.pictureBox1.Location = new System.Drawing.Point(16, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.refresh2);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.delete);
            this.panel2.Controls.Add(this.Direccion2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Apellidos2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Nombres2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(387, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 197);
            this.panel2.TabIndex = 1;
            // 
            // refresh2
            // 
            this.refresh2.AccessibleName = "refresh";
            this.refresh2.BackColor = System.Drawing.Color.SteelBlue;
            this.refresh2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh2.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.refresh2.Location = new System.Drawing.Point(50, 161);
            this.refresh2.Name = "refresh2";
            this.refresh2.Size = new System.Drawing.Size(239, 26);
            this.refresh2.TabIndex = 15;
            this.refresh2.Text = "ACTUALIZAR";
            this.refresh2.UseVisualStyleBackColor = false;
            this.refresh2.Click += new System.EventHandler(this.refresh2_Click);
            // 
            // save
            // 
            this.save.AccessibleName = "save";
            this.save.BackColor = System.Drawing.Color.Green;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.save.Location = new System.Drawing.Point(192, 129);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(97, 26);
            this.save.TabIndex = 14;
            this.save.Text = "GUARDAR";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.AccessibleName = "delete";
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Ivory;
            this.delete.Location = new System.Drawing.Point(50, 129);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(97, 26);
            this.delete.TabIndex = 13;
            this.delete.Text = "ELIMINAR";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Direccion2
            // 
            this.Direccion2.AccessibleName = "Direccion2";
            this.Direccion2.Location = new System.Drawing.Point(117, 92);
            this.Direccion2.Name = "Direccion2";
            this.Direccion2.Size = new System.Drawing.Size(192, 25);
            this.Direccion2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AccessibleName = "nombres2";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "DIRECCIÓN";
            // 
            // Apellidos2
            // 
            this.Apellidos2.AccessibleName = "Apellidos2";
            this.Apellidos2.Location = new System.Drawing.Point(117, 57);
            this.Apellidos2.Name = "Apellidos2";
            this.Apellidos2.Size = new System.Drawing.Size(192, 25);
            this.Apellidos2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AccessibleName = "IdCliente12";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(14, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "APELLIDOS:";
            // 
            // Nombres2
            // 
            this.Nombres2.AccessibleName = "Nombres2";
            this.Nombres2.Location = new System.Drawing.Point(117, 24);
            this.Nombres2.Name = "Nombres2";
            this.Nombres2.Size = new System.Drawing.Size(192, 25);
            this.Nombres2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AccessibleName = "nombres2";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "NOMBRES: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.select);
            this.panel1.Controls.Add(this.inicio);
            this.panel1.Controls.Add(this.IdCliente2);
            this.panel1.Controls.Add(this.IdCliente12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 197);
            this.panel1.TabIndex = 0;
            // 
            // select
            // 
            this.select.AccessibleName = "select";
            this.select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select.ForeColor = System.Drawing.Color.Ivory;
            this.select.Location = new System.Drawing.Point(192, 109);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(116, 23);
            this.select.TabIndex = 6;
            this.select.Text = "SELECCIONAR";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.button1_Click);
            // 
            // inicio
            // 
            this.inicio.AccessibleName = "inicio";
            this.inicio.BackColor = System.Drawing.Color.Green;
            this.inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inicio.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio.ForeColor = System.Drawing.Color.Ivory;
            this.inicio.Location = new System.Drawing.Point(39, 109);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(116, 23);
            this.inicio.TabIndex = 5;
            this.inicio.Text = "INICIO";
            this.inicio.UseVisualStyleBackColor = false;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // IdCliente2
            // 
            this.IdCliente2.AccessibleName = "IdCliente2";
            this.IdCliente2.Location = new System.Drawing.Point(156, 62);
            this.IdCliente2.Name = "IdCliente2";
            this.IdCliente2.Size = new System.Drawing.Size(131, 25);
            this.IdCliente2.TabIndex = 4;
            this.IdCliente2.TextChanged += new System.EventHandler(this.IdCliente2_TextChanged);
            this.IdCliente2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdCliente2_KeyPress);
            // 
            // IdCliente12
            // 
            this.IdCliente12.AccessibleName = "IdCliente12";
            this.IdCliente12.AutoSize = true;
            this.IdCliente12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCliente12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IdCliente12.Location = new System.Drawing.Point(53, 65);
            this.IdCliente12.Name = "IdCliente12";
            this.IdCliente12.Size = new System.Drawing.Size(84, 17);
            this.IdCliente12.TabIndex = 3;
            this.IdCliente12.Text = "ID CLIENTE: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(95, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCAR CLIENTE";
            // 
            // empresa
            // 
            this.empresa.AutoSize = true;
            this.empresa.BackColor = System.Drawing.Color.Transparent;
            this.empresa.Cursor = System.Windows.Forms.Cursors.Default;
            this.empresa.Font = new System.Drawing.Font("Microsoft JhengHei UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresa.ForeColor = System.Drawing.Color.White;
            this.empresa.Location = new System.Drawing.Point(655, 488);
            this.empresa.Name = "empresa";
            this.empresa.Size = new System.Drawing.Size(145, 13);
            this.empresa.TabIndex = 2;
            this.empresa.Text = "Ziur Software Colombia SAS";
            // 
            // Clientes
            // 
            this.AccessibleName = "Clientes";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Prueba_tecnica.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 511);
            this.Controls.Add(this.empresa);
            this.Controls.Add(this.pClientes);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.pClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pClientes;
        private System.Windows.Forms.Label empresa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.TextBox IdCliente2;
        private System.Windows.Forms.Label IdCliente12;
        private System.Windows.Forms.TextBox Direccion2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Apellidos2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Nombres2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh2;
    }
}