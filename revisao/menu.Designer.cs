namespace revisao
{
    partial class menu
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
            this.bt_divisao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_divisao
            // 
            this.bt_divisao.Location = new System.Drawing.Point(157, 205);
            this.bt_divisao.Name = "bt_divisao";
            this.bt_divisao.Size = new System.Drawing.Size(75, 62);
            this.bt_divisao.TabIndex = 0;
            this.bt_divisao.Text = "divisao";
            this.bt_divisao.UseVisualStyleBackColor = true;
            this.bt_divisao.Click += new System.EventHandler(this.bt_divisao_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_divisao);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_divisao;
    }
}

