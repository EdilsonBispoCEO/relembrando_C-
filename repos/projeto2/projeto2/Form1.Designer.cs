namespace projeto2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_f = new System.Windows.Forms.Button();
            this.textUser = new System.Windows.Forms.TextBox();
            this.btn_c = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_f
            // 
            this.btn_f.Location = new System.Drawing.Point(12, 135);
            this.btn_f.Name = "btn_f";
            this.btn_f.Size = new System.Drawing.Size(80, 28);
            this.btn_f.TabIndex = 1;
            this.btn_f.Text = "F\r\n";
            this.btn_f.UseVisualStyleBackColor = true;
            this.btn_f.Click += new System.EventHandler(this.btn_f_Click);
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(52, 80);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(129, 20);
            this.textUser.TabIndex = 3;
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(148, 135);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(80, 28);
            this.btn_c.TabIndex = 4;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escala de celsius";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.btn_f);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_f;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Label label1;
    }
}

