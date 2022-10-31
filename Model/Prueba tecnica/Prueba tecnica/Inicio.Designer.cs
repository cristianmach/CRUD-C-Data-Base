namespace Prueba_tecnica
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button search;
            System.Windows.Forms.Button add;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.empresa = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.tittle = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Direccion1 = new System.Windows.Forms.Label();
            this.Apellidos1 = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.TextBox();
            this.IdCliente = new System.Windows.Forms.TextBox();
            this.Nombres1 = new System.Windows.Forms.Label();
            this.IdCliente1 = new System.Windows.Forms.Label();
            search = new System.Windows.Forms.Button();
            add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // search
            // 
            search.AccessibleName = "search";
            search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            search.Cursor = System.Windows.Forms.Cursors.Hand;
            search.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            search.ForeColor = System.Drawing.Color.White;
            search.Location = new System.Drawing.Point(276, 313);
            search.Margin = new System.Windows.Forms.Padding(0);
            search.Name = "search";
            search.Size = new System.Drawing.Size(90, 25);
            search.TabIndex = 9;
            search.Text = "BUSCAR";
            search.UseVisualStyleBackColor = false;
            search.Click += new System.EventHandler(this.search_Click);
            // 
            // add
            // 
            add.AccessibleName = "add";
            add.BackColor = System.Drawing.Color.Green;
            add.Cursor = System.Windows.Forms.Cursors.Hand;
            add.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            add.ForeColor = System.Drawing.Color.White;
            add.Location = new System.Drawing.Point(153, 313);
            add.Margin = new System.Windows.Forms.Padding(0);
            add.Name = "add";
            add.Size = new System.Drawing.Size(90, 25);
            add.TabIndex = 10;
            add.Text = "AGREGAR";
            add.UseVisualStyleBackColor = false;
            add.Click += new System.EventHandler(this.add_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Prueba_tecnica.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 482);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // empresa
            // 
            this.empresa.AutoSize = true;
            this.empresa.BackColor = System.Drawing.Color.Transparent;
            this.empresa.Cursor = System.Windows.Forms.Cursors.Default;
            this.empresa.Font = new System.Drawing.Font("Microsoft JhengHei UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresa.ForeColor = System.Drawing.Color.White;
            this.empresa.Location = new System.Drawing.Point(300, 469);
            this.empresa.Name = "empresa";
            this.empresa.Size = new System.Drawing.Size(145, 13);
            this.empresa.TabIndex = 1;
            this.empresa.Text = "Ziur Software Colombia SAS";
            this.empresa.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 481);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.empresa);
            this.panel1.Location = new System.Drawing.Point(357, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 481);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.refresh);
            this.panel2.Controls.Add(add);
            this.panel2.Controls.Add(search);
            this.panel2.Controls.Add(this.tittle);
            this.panel2.Controls.Add(this.Direccion);
            this.panel2.Controls.Add(this.Apellidos);
            this.panel2.Controls.Add(this.Direccion1);
            this.panel2.Controls.Add(this.Apellidos1);
            this.panel2.Controls.Add(this.Nombres);
            this.panel2.Controls.Add(this.IdCliente);
            this.panel2.Controls.Add(this.Nombres1);
            this.panel2.Controls.Add(this.IdCliente1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 454);
            this.panel2.TabIndex = 2;
            // 
            // refresh
            // 
            this.refresh.AccessibleName = "refresh";
            this.refresh.BackColor = System.Drawing.Color.SteelBlue;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.refresh.Location = new System.Drawing.Point(153, 351);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(213, 26);
            this.refresh.TabIndex = 16;
            this.refresh.Text = "ACTUALIZAR";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // tittle
            // 
            this.tittle.AccessibleName = "tittle";
            this.tittle.AutoSize = true;
            this.tittle.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tittle.Location = new System.Drawing.Point(72, 50);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(276, 24);
            this.tittle.TabIndex = 8;
            this.tittle.Text = "DIRECTORIO CLIENTES ZIUR";
            // 
            // Direccion
            // 
            this.Direccion.AccessibleName = "Direccion";
            this.Direccion.Location = new System.Drawing.Point(153, 244);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(213, 25);
            this.Direccion.TabIndex = 7;
            // 
            // Apellidos
            // 
            this.Apellidos.AccessibleName = "Apellidos";
            this.Apellidos.Location = new System.Drawing.Point(153, 204);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(213, 25);
            this.Apellidos.TabIndex = 6;
            // 
            // Direccion1
            // 
            this.Direccion1.AccessibleName = "Direccion1";
            this.Direccion1.AutoSize = true;
            this.Direccion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Direccion1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Direccion1.Location = new System.Drawing.Point(31, 244);
            this.Direccion1.Name = "Direccion1";
            this.Direccion1.Size = new System.Drawing.Size(111, 22);
            this.Direccion1.TabIndex = 5;
            this.Direccion1.Text = "DIRECCIÓN: ";
            // 
            // Apellidos1
            // 
            this.Apellidos1.AccessibleName = "Apellidos1";
            this.Apellidos1.AutoSize = true;
            this.Apellidos1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidos1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Apellidos1.Location = new System.Drawing.Point(31, 203);
            this.Apellidos1.Name = "Apellidos1";
            this.Apellidos1.Size = new System.Drawing.Size(110, 22);
            this.Apellidos1.TabIndex = 4;
            this.Apellidos1.Text = "APELLIDOS: ";
            // 
            // Nombres
            // 
            this.Nombres.AccessibleName = "Nombres";
            this.Nombres.Location = new System.Drawing.Point(153, 162);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(213, 25);
            this.Nombres.TabIndex = 3;
            // 
            // IdCliente
            // 
            this.IdCliente.AccessibleName = "IdCliente";
            this.IdCliente.Location = new System.Drawing.Point(153, 121);
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Size = new System.Drawing.Size(213, 25);
            this.IdCliente.TabIndex = 2;
            this.IdCliente.TextChanged += new System.EventHandler(this.IdCliente_TextChanged);
            this.IdCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdCliente_KeyPress);
            // 
            // Nombres1
            // 
            this.Nombres1.AccessibleName = "Nombres1";
            this.Nombres1.AutoSize = true;
            this.Nombres1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nombres1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombres1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nombres1.Location = new System.Drawing.Point(31, 161);
            this.Nombres1.Name = "Nombres1";
            this.Nombres1.Size = new System.Drawing.Size(104, 22);
            this.Nombres1.TabIndex = 1;
            this.Nombres1.Text = "NOMBRES: ";
            // 
            // IdCliente1
            // 
            this.IdCliente1.AccessibleName = "IdCliente1";
            this.IdCliente1.AutoSize = true;
            this.IdCliente1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCliente1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IdCliente1.Location = new System.Drawing.Point(31, 120);
            this.IdCliente1.Name = "IdCliente1";
            this.IdCliente1.Size = new System.Drawing.Size(107, 22);
            this.IdCliente1.TabIndex = 0;
            this.IdCliente1.Text = "ID CLIENTE: ";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(802, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label empresa;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.Label Direccion1;
        private System.Windows.Forms.Label Apellidos1;
        private System.Windows.Forms.TextBox Nombres;
        private System.Windows.Forms.TextBox IdCliente;
        private System.Windows.Forms.Label Nombres1;
        private System.Windows.Forms.Label IdCliente1;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.Button refresh;
    }
}

