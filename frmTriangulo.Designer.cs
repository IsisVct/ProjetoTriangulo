namespace S12DS_prjTriangulo
{
    partial class frmTriangulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.picTriangulo = new System.Windows.Forms.PictureBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTriangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projeto Triângulo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o tamanho do lado 1:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(50, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite o tamanho do lado 2:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(50, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite o tamanho do lado 3: ";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(260, 78);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(163, 25);
            this.txtLado1.TabIndex = 4;
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(260, 120);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(163, 25);
            this.txtLado2.TabIndex = 5;
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(260, 162);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(163, 25);
            this.txtLado3.TabIndex = 6;
            // 
            // picTriangulo
            // 
            this.picTriangulo.Location = new System.Drawing.Point(50, 216);
            this.picTriangulo.Name = "picTriangulo";
            this.picTriangulo.Size = new System.Drawing.Size(210, 150);
            this.picTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTriangulo.TabIndex = 7;
            this.picTriangulo.TabStop = false;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(287, 216);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(185, 47);
            this.btnProcessar.TabIndex = 8;
            this.btnProcessar.Text = "&Qual triângulo formou?";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AllowDrop = true;
            this.btnNovo.Location = new System.Drawing.Point(287, 275);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(185, 47);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "&Novo Triângulo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(287, 332);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(185, 47);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 407);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.picTriangulo);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTriangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triângulos";
            this.Load += new System.EventHandler(this.frmTriangulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTriangulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.PictureBox picTriangulo;
        private System.Windows.Forms.Button btnProcessar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
    }
}

