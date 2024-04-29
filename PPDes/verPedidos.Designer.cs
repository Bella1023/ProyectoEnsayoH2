using System.ComponentModel;

namespace PPDes
{
    partial class verPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verPedidos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsal = new System.Windows.Forms.Button();
            this.btnmos = new System.Windows.Forms.Button();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbus = new System.Windows.Forms.Button();
            this.btned = new System.Windows.Forms.Button();
            this.btnel = new System.Windows.Forms.Button();
            this.btneld = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(814, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnsal
            // 
            this.btnsal.BackColor = System.Drawing.Color.Khaki;
            this.btnsal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsal.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnsal.Location = new System.Drawing.Point(54, 375);
            this.btnsal.Name = "btnsal";
            this.btnsal.Size = new System.Drawing.Size(152, 44);
            this.btnsal.TabIndex = 1;
            this.btnsal.Text = "Salir";
            this.btnsal.UseVisualStyleBackColor = false;
            this.btnsal.Click += new System.EventHandler(this.btnsal_Click);
            // 
            // btnmos
            // 
            this.btnmos.BackColor = System.Drawing.Color.Khaki;
            this.btnmos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmos.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnmos.Location = new System.Drawing.Point(229, 375);
            this.btnmos.Name = "btnmos";
            this.btnmos.Size = new System.Drawing.Size(152, 44);
            this.btnmos.TabIndex = 2;
            this.btnmos.Text = "Mostrar datos";
            this.btnmos.UseVisualStyleBackColor = false;
            this.btnmos.Click += new System.EventHandler(this.btnmos_Click);
            // 
            // txtusu
            // 
            this.txtusu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusu.Location = new System.Drawing.Point(69, 67);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(227, 19);
            this.txtusu.TabIndex = 3;
            // 
            // txttel
            // 
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttel.Location = new System.Drawing.Point(69, 142);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(227, 19);
            this.txttel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label1.Location = new System.Drawing.Point(136, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label2.Location = new System.Drawing.Point(136, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefono";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnbus
            // 
            this.btnbus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbus.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnbus.Location = new System.Drawing.Point(40, 204);
            this.btnbus.Name = "btnbus";
            this.btnbus.Size = new System.Drawing.Size(165, 40);
            this.btnbus.TabIndex = 7;
            this.btnbus.Text = "Buscar";
            this.btnbus.UseVisualStyleBackColor = true;
            // 
            // btned
            // 
            this.btned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btned.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btned.Location = new System.Drawing.Point(40, 250);
            this.btned.Name = "btned";
            this.btned.Size = new System.Drawing.Size(166, 40);
            this.btned.TabIndex = 8;
            this.btned.Text = "Editar";
            this.btned.UseVisualStyleBackColor = true;
            // 
            // btnel
            // 
            this.btnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnel.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnel.Location = new System.Drawing.Point(40, 296);
            this.btnel.Name = "btnel";
            this.btnel.Size = new System.Drawing.Size(165, 38);
            this.btnel.TabIndex = 9;
            this.btnel.Text = "Eliminar";
            this.btnel.UseVisualStyleBackColor = true;
            this.btnel.Click += new System.EventHandler(this.btnel_Click);
            // 
            // btneld
            // 
            this.btneld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneld.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btneld.Location = new System.Drawing.Point(229, 230);
            this.btneld.Name = "btneld";
            this.btneld.Size = new System.Drawing.Size(152, 60);
            this.btneld.TabIndex = 10;
            this.btneld.Text = "Eliminar todos los datos";
            this.btneld.UseVisualStyleBackColor = true;
            // 
            // verPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1400, 450);
            this.Controls.Add(this.btneld);
            this.Controls.Add(this.btnel);
            this.Controls.Add(this.btned);
            this.Controls.Add(this.btnbus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.btnmos);
            this.Controls.Add(this.btnsal);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "verPedidos";
            this.Text = "verPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbus;
        private System.Windows.Forms.Button btned;
        private System.Windows.Forms.Button btnel;
        private System.Windows.Forms.Button btneld;

        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.TextBox txttel;

        private System.Windows.Forms.Button btnsal;
        private System.Windows.Forms.Button btnmos;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}