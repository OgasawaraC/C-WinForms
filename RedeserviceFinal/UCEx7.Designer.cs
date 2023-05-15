
namespace RedeserviceFinal
{
    partial class UCEx7
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
            this.grdBancos = new System.Windows.Forms.DataGridView();
            this.btnConsultarBancos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBancos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBancos
            // 
            this.grdBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBancos.Location = new System.Drawing.Point(120, 78);
            this.grdBancos.Name = "grdBancos";
            this.grdBancos.RowHeadersWidth = 51;
            this.grdBancos.RowTemplate.Height = 24;
            this.grdBancos.Size = new System.Drawing.Size(470, 304);
            this.grdBancos.TabIndex = 3;
            // 
            // btnConsultarBancos
            // 
            this.btnConsultarBancos.Location = new System.Drawing.Point(249, 28);
            this.btnConsultarBancos.Name = "btnConsultarBancos";
            this.btnConsultarBancos.Size = new System.Drawing.Size(212, 40);
            this.btnConsultarBancos.TabIndex = 2;
            this.btnConsultarBancos.Text = "Buscar e Exibir Bancos";
            this.btnConsultarBancos.UseVisualStyleBackColor = true;
            this.btnConsultarBancos.Click += new System.EventHandler(this.btnConsultarBancos_Click);
            // 
            // UCEx7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdBancos);
            this.Controls.Add(this.btnConsultarBancos);
            this.Name = "UCEx7";
            this.Size = new System.Drawing.Size(711, 410);
            ((System.ComponentModel.ISupportInitialize)(this.grdBancos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBancos;
        private System.Windows.Forms.Button btnConsultarBancos;
    }
}
