
namespace RedeserviceFinal
{
    partial class UCEx4_5
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
            this.grdJson = new System.Windows.Forms.DataGridView();
            this.btnLerJson = new System.Windows.Forms.Button();
            this.btnJson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdJson)).BeginInit();
            this.SuspendLayout();
            // 
            // grdJson
            // 
            this.grdJson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdJson.GridColor = System.Drawing.SystemColors.Window;
            this.grdJson.Location = new System.Drawing.Point(114, 92);
            this.grdJson.Name = "grdJson";
            this.grdJson.RowHeadersWidth = 51;
            this.grdJson.RowTemplate.Height = 24;
            this.grdJson.Size = new System.Drawing.Size(470, 276);
            this.grdJson.TabIndex = 5;
            // 
            // btnLerJson
            // 
            this.btnLerJson.Location = new System.Drawing.Point(412, 32);
            this.btnLerJson.Name = "btnLerJson";
            this.btnLerJson.Size = new System.Drawing.Size(102, 23);
            this.btnLerJson.TabIndex = 4;
            this.btnLerJson.Text = "Ler Json";
            this.btnLerJson.UseVisualStyleBackColor = true;
            this.btnLerJson.Click += new System.EventHandler(this.btnLerJson_Click);
            // 
            // btnJson
            // 
            this.btnJson.Location = new System.Drawing.Point(189, 32);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(102, 23);
            this.btnJson.TabIndex = 3;
            this.btnJson.Text = "Gerar Json";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // UCEx4_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdJson);
            this.Controls.Add(this.btnLerJson);
            this.Controls.Add(this.btnJson);
            this.Name = "UCEx4_5";
            this.Size = new System.Drawing.Size(699, 401);
            ((System.ComponentModel.ISupportInitialize)(this.grdJson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdJson;
        private System.Windows.Forms.Button btnLerJson;
        private System.Windows.Forms.Button btnJson;
    }
}
