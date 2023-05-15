
namespace RedeserviceFinal
{
    partial class UCEx8
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtfBase64 = new System.Windows.Forms.RichTextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtfBase64
            // 
            this.rtfBase64.Location = new System.Drawing.Point(197, 91);
            this.rtfBase64.Name = "rtfBase64";
            this.rtfBase64.Size = new System.Drawing.Size(472, 304);
            this.rtfBase64.TabIndex = 3;
            this.rtfBase64.Text = "";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(232, 41);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(378, 40);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download e Conversão da Imagem";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click_1);
            // 
            // UCEx8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtfBase64);
            this.Controls.Add(this.btnDownload);
            this.Name = "UCEx8";
            this.Size = new System.Drawing.Size(866, 436);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfBase64;
        private System.Windows.Forms.Button btnDownload;
    }
}
