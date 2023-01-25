namespace ReplaceText_De_Para
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
            this.btnSelecionarArquivo = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDePara = new System.Windows.Forms.Button();
            this.txtDePara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciarReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(695, 58);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarArquivo.TabIndex = 0;
            this.btnSelecionarArquivo.Text = "...";
            this.btnSelecionarArquivo.UseVisualStyleBackColor = true;
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(28, 58);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(661, 22);
            this.txtArquivo.TabIndex = 1;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arquivo que sofrerá as alterações";
            // 
            // btnDePara
            // 
            this.btnDePara.Location = new System.Drawing.Point(695, 125);
            this.btnDePara.Name = "btnDePara";
            this.btnDePara.Size = new System.Drawing.Size(75, 23);
            this.btnDePara.TabIndex = 0;
            this.btnDePara.Text = "...";
            this.btnDePara.UseVisualStyleBackColor = true;
            this.btnDePara.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // txtDePara
            // 
            this.txtDePara.Location = new System.Drawing.Point(28, 125);
            this.txtDePara.Name = "txtDePara";
            this.txtDePara.Size = new System.Drawing.Size(661, 22);
            this.txtDePara.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arquivo De / Para";
            // 
            // btnIniciarReplace
            // 
            this.btnIniciarReplace.Location = new System.Drawing.Point(627, 180);
            this.btnIniciarReplace.Name = "btnIniciarReplace";
            this.btnIniciarReplace.Size = new System.Drawing.Size(143, 23);
            this.btnIniciarReplace.TabIndex = 3;
            this.btnIniciarReplace.Text = "Iniciar Replace";
            this.btnIniciarReplace.UseVisualStyleBackColor = true;
            this.btnIniciarReplace.Click += new System.EventHandler(this.btnIniciarReplace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 233);
            this.Controls.Add(this.btnIniciarReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDePara);
            this.Controls.Add(this.btnDePara);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btnSelecionarArquivo);
            this.Name = "Form1";
            this.Text = "Replace Gera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecionarArquivo;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDePara;
        private System.Windows.Forms.TextBox txtDePara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciarReplace;
    }
}

