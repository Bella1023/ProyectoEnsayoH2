using System.ComponentModel;

namespace PPDes
{
    partial class pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pedidos));
            this.btnatr = new System.Windows.Forms.Button();
            this.btngua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtar = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.txtciu = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnatr
            // 
            this.btnatr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnatr.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btnatr.Location = new System.Drawing.Point(586, 352);
            this.btnatr.Name = "btnatr";
            this.btnatr.Size = new System.Drawing.Size(156, 43);
            this.btnatr.TabIndex = 0;
            this.btnatr.Text = "Atras";
            this.btnatr.UseVisualStyleBackColor = true;
            this.btnatr.Click += new System.EventHandler(this.btnatr_Click);
            // 
            // btngua
            // 
            this.btngua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngua.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.btngua.Location = new System.Drawing.Point(586, 280);
            this.btngua.Name = "btngua";
            this.btngua.Size = new System.Drawing.Size(156, 43);
            this.btngua.TabIndex = 1;
            this.btngua.Text = "Guardar";
            this.btngua.UseVisualStyleBackColor = true;
            this.btngua.Click += new System.EventHandler(this.btngua_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label2.Location = new System.Drawing.Point(524, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label4.Location = new System.Drawing.Point(277, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Metodo de pago";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label5.Location = new System.Drawing.Point(38, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label6.Location = new System.Drawing.Point(253, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ciudad";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label7.Location = new System.Drawing.Point(497, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Correo";
            // 
            // txtar
            // 
            this.txtar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtar.Location = new System.Drawing.Point(192, 306);
            this.txtar.Name = "txtar";
            this.txtar.Size = new System.Drawing.Size(299, 19);
            this.txtar.TabIndex = 9;
            // 
            // txttel
            // 
            this.txttel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttel.Location = new System.Drawing.Point(38, 212);
            this.txttel.MaxLength = 10;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(160, 19);
            this.txttel.TabIndex = 4;
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel_KeyPress_1);
            // 
            // txtdir
            // 
            this.txtdir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdir.Location = new System.Drawing.Point(476, 212);
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(205, 19);
            this.txtdir.TabIndex = 6;
            // 
            // txtcor
            // 
            this.txtcor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcor.Location = new System.Drawing.Point(476, 94);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(205, 19);
            this.txtcor.TabIndex = 3;
            // 
            // txtciu
            // 
            this.txtciu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtciu.Location = new System.Drawing.Point(253, 94);
            this.txtciu.Name = "txtciu";
            this.txtciu.Size = new System.Drawing.Size(160, 19);
            this.txtciu.TabIndex = 2;
            // 
            // txtnom
            // 
            this.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnom.Location = new System.Drawing.Point(38, 94);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(160, 19);
            this.txtnom.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] { "Efectivo", "Tarjeta de credito", "Nequi", "Trasnsaccion", "PSE" });
            this.comboBox1.Location = new System.Drawing.Point(243, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label3.Location = new System.Drawing.Point(38, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 72);
            this.label3.TabIndex = 16;
            this.label3.Text = "Articulos que desea comprar";
            // 
            // pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtciu);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngua);
            this.Controls.Add(this.btnatr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pedidos";
            this.Text = "Pedidos";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.pedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtar;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.TextBox txtciu;
        private System.Windows.Forms.TextBox txtnom;

        private System.Windows.Forms.Button btnatr;
        private System.Windows.Forms.Button btngua;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}