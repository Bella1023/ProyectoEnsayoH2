namespace PPDes
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mujeresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hombresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niñosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacerUnPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodosLosPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opinionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danosTuOpinionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verOpinionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnatr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.catalogoToolStripMenuItem, this.pedidosToolStripMenuItem, this.trabajadoresToolStripMenuItem, this.opinionesToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.mujeresToolStripMenuItem, this.hombresToolStripMenuItem, this.niñosToolStripMenuItem });
            this.catalogoToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(87, 27);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // mujeresToolStripMenuItem
            // 
            this.mujeresToolStripMenuItem.Name = "mujeresToolStripMenuItem";
            this.mujeresToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.mujeresToolStripMenuItem.Text = "Mujeres";
            this.mujeresToolStripMenuItem.Click += new System.EventHandler(this.mujeresToolStripMenuItem_Click);
            // 
            // hombresToolStripMenuItem
            // 
            this.hombresToolStripMenuItem.Name = "hombresToolStripMenuItem";
            this.hombresToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.hombresToolStripMenuItem.Text = "Hombres";
            // 
            // niñosToolStripMenuItem
            // 
            this.niñosToolStripMenuItem.Name = "niñosToolStripMenuItem";
            this.niñosToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.niñosToolStripMenuItem.Text = "Niños";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.hacerUnPedidoToolStripMenuItem, this.verTodosLosPedidosToolStripMenuItem });
            this.pedidosToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // hacerUnPedidoToolStripMenuItem
            // 
            this.hacerUnPedidoToolStripMenuItem.Name = "hacerUnPedidoToolStripMenuItem";
            this.hacerUnPedidoToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.hacerUnPedidoToolStripMenuItem.Text = "Hacer un pedido";
            this.hacerUnPedidoToolStripMenuItem.Click += new System.EventHandler(this.hacerUnPedidoToolStripMenuItem_Click);
            // 
            // verTodosLosPedidosToolStripMenuItem
            // 
            this.verTodosLosPedidosToolStripMenuItem.Name = "verTodosLosPedidosToolStripMenuItem";
            this.verTodosLosPedidosToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.verTodosLosPedidosToolStripMenuItem.Text = "Ver todos los pedidos";
            this.verTodosLosPedidosToolStripMenuItem.Click += new System.EventHandler(this.verTodosLosPedidosToolStripMenuItem_Click);
            // 
            // trabajadoresToolStripMenuItem
            // 
            this.trabajadoresToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.trabajadoresToolStripMenuItem.Name = "trabajadoresToolStripMenuItem";
            this.trabajadoresToolStripMenuItem.Size = new System.Drawing.Size(119, 27);
            this.trabajadoresToolStripMenuItem.Text = "Trabajadores";
            // 
            // opinionesToolStripMenuItem
            // 
            this.opinionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.danosTuOpinionToolStripMenuItem, this.verOpinionesToolStripMenuItem });
            this.opinionesToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.opinionesToolStripMenuItem.Name = "opinionesToolStripMenuItem";
            this.opinionesToolStripMenuItem.Size = new System.Drawing.Size(95, 27);
            this.opinionesToolStripMenuItem.Text = "Opiniones";
            // 
            // danosTuOpinionToolStripMenuItem
            // 
            this.danosTuOpinionToolStripMenuItem.Name = "danosTuOpinionToolStripMenuItem";
            this.danosTuOpinionToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.danosTuOpinionToolStripMenuItem.Text = "Danos tu opinion";
            // 
            // verOpinionesToolStripMenuItem
            // 
            this.verOpinionesToolStripMenuItem.Name = "verOpinionesToolStripMenuItem";
            this.verOpinionesToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.verOpinionesToolStripMenuItem.Text = "Ver opiniones";
            // 
            // btnatr
            // 
            this.btnatr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnatr.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnatr.Location = new System.Drawing.Point(23, 388);
            this.btnatr.Name = "btnatr";
            this.btnatr.Size = new System.Drawing.Size(143, 39);
            this.btnatr.TabIndex = 1;
            this.btnatr.Text = "Atras";
            this.btnatr.UseVisualStyleBackColor = true;
            this.btnatr.Click += new System.EventHandler(this.btnatr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido a nuestra tienda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPDes.Properties.Resources.TIENDAROPA;
            this.pictureBox1.Location = new System.Drawing.Point(42, 119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 234);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnatr);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Pagina principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mujeresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hombresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niñosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacerUnPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodosLosPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opinionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danosTuOpinionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verOpinionesToolStripMenuItem;
        private System.Windows.Forms.Button btnatr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}