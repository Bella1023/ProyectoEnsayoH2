namespace PPDes
{
    partial class frminiciosesion
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminiciosesion));
            this.label1 = new System.Windows.Forms.Label();
            this.btnsal = new System.Windows.Forms.Button();
            this.btnini = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de sesion";
            // 
            // btnsal
            // 
            this.btnsal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsal.Location = new System.Drawing.Point(30, 380);
            this.btnsal.Name = "btnsal";
            this.btnsal.Size = new System.Drawing.Size(115, 48);
            this.btnsal.TabIndex = 4;
            this.btnsal.Text = "Salir";
            this.btnsal.UseVisualStyleBackColor = true;
            this.btnsal.Click += new System.EventHandler(this.btnsal_Click);
            // 
            // btnini
            // 
            this.btnini.BackColor = System.Drawing.Color.Khaki;
            this.btnini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnini.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnini.Location = new System.Drawing.Point(331, 323);
            this.btnini.Name = "btnini";
            this.btnini.Size = new System.Drawing.Size(126, 53);
            this.btnini.TabIndex = 3;
            this.btnini.Text = "Iniciar sesion";
            this.btnini.UseVisualStyleBackColor = false;
            this.btnini.Click += new System.EventHandler(this.btnini_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label2.Location = new System.Drawing.Point(272, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 9F);
            this.label3.Location = new System.Drawing.Point(272, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // txtusu
            // 
            this.txtusu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusu.Location = new System.Drawing.Point(276, 173);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(242, 19);
            this.txtusu.TabIndex = 1;
            // 
            // txtcon
            // 
            this.txtcon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcon.Location = new System.Drawing.Point(276, 265);
            this.txtcon.Name = "txtcon";
            this.txtcon.PasswordChar = '*';
            this.txtcon.Size = new System.Drawing.Size(242, 19);
            this.txtcon.TabIndex = 2;
            // 
            // frminiciosesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcon);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnini);
            this.Controls.Add(this.btnsal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frminiciosesion";
            this.Text = "Bienvenido";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsal;
        private System.Windows.Forms.Button btnini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.TextBox txtcon;
    }
}

