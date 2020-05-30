namespace ExcWinForms
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
            this.btnCriar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAbrir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConcatenar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAlterar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExcluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriar.Depth = 0;
            this.btnCriar.Location = new System.Drawing.Point(71, 100);
            this.btnCriar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Primary = true;
            this.btnCriar.Size = new System.Drawing.Size(257, 47);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar Arquivo";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrir.Depth = 0;
            this.btnAbrir.Location = new System.Drawing.Point(71, 153);
            this.btnAbrir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Primary = true;
            this.btnAbrir.Size = new System.Drawing.Size(257, 47);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Arquivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnConcatenar
            // 
            this.btnConcatenar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConcatenar.Depth = 0;
            this.btnConcatenar.Location = new System.Drawing.Point(71, 206);
            this.btnConcatenar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConcatenar.Name = "btnConcatenar";
            this.btnConcatenar.Primary = true;
            this.btnConcatenar.Size = new System.Drawing.Size(257, 47);
            this.btnConcatenar.TabIndex = 2;
            this.btnConcatenar.Text = "Concatenar Arquivo";
            this.btnConcatenar.UseVisualStyleBackColor = true;
            this.btnConcatenar.Click += new System.EventHandler(this.btnConcatenar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Depth = 0;
            this.btnAlterar.Location = new System.Drawing.Point(71, 259);
            this.btnAlterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Primary = true;
            this.btnAlterar.Size = new System.Drawing.Size(257, 47);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "Alterar Arquivo";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Depth = 0;
            this.btnExcluir.Location = new System.Drawing.Point(71, 312);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Primary = true;
            this.btnExcluir.Size = new System.Drawing.Size(257, 47);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir Arquivo";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 412);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConcatenar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnCriar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnCriar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAbrir;
        private MaterialSkin.Controls.MaterialRaisedButton btnConcatenar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAlterar;
        private MaterialSkin.Controls.MaterialRaisedButton btnExcluir;
    }
}

