namespace FarmTech
{
    partial class CadastroProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.cadastroBox = new System.Windows.Forms.GroupBox();
            this.btnCancelCadastro = new System.Windows.Forms.Button();
            this.btnCadastrarCol = new System.Windows.Forms.Button();
            this.txtTipoEmbalagem = new System.Windows.Forms.TextBox();
            this.lblTipoEmbalagem = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.cadastroBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroBox
            // 
            this.cadastroBox.Controls.Add(this.txtUnidade);
            this.cadastroBox.Controls.Add(this.btnCancelCadastro);
            this.cadastroBox.Controls.Add(this.btnCadastrarCol);
            this.cadastroBox.Controls.Add(this.txtTipoEmbalagem);
            this.cadastroBox.Controls.Add(this.lblTipoEmbalagem);
            this.cadastroBox.Controls.Add(this.lblUnidade);
            this.cadastroBox.Controls.Add(this.lblCusto);
            this.cadastroBox.Controls.Add(this.txtCusto);
            this.cadastroBox.Controls.Add(this.lblProduto);
            this.cadastroBox.Controls.Add(this.txtProduto);
            this.cadastroBox.Location = new System.Drawing.Point(12, 12);
            this.cadastroBox.Name = "cadastroBox";
            this.cadastroBox.Size = new System.Drawing.Size(382, 255);
            this.cadastroBox.TabIndex = 0;
            this.cadastroBox.TabStop = false;
            this.cadastroBox.Text = "Dados";
            // 
            // btnCancelCadastro
            // 
            this.btnCancelCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(74)))));
            this.btnCancelCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelCadastro.Location = new System.Drawing.Point(292, 205);
            this.btnCancelCadastro.Name = "btnCancelCadastro";
            this.btnCancelCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCadastro.TabIndex = 9;
            this.btnCancelCadastro.Text = "Cancelar";
            this.btnCancelCadastro.UseVisualStyleBackColor = false;
            this.btnCancelCadastro.Click += new System.EventHandler(this.btnCancelCadastro_Click);
            // 
            // btnCadastrarCol
            // 
            this.btnCadastrarCol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(74)))));
            this.btnCadastrarCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCol.Location = new System.Drawing.Point(211, 205);
            this.btnCadastrarCol.Name = "btnCadastrarCol";
            this.btnCadastrarCol.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCol.TabIndex = 8;
            this.btnCadastrarCol.Text = "Cadastrar";
            this.btnCadastrarCol.UseVisualStyleBackColor = false;
            this.btnCadastrarCol.Click += new System.EventHandler(this.btnCadastrarCol_Click);
            // 
            // txtTipoEmbalagem
            // 
            this.txtTipoEmbalagem.Location = new System.Drawing.Point(9, 121);
            this.txtTipoEmbalagem.Name = "txtTipoEmbalagem";
            this.txtTipoEmbalagem.Size = new System.Drawing.Size(360, 20);
            this.txtTipoEmbalagem.TabIndex = 5;
            // 
            // lblTipoEmbalagem
            // 
            this.lblTipoEmbalagem.AutoSize = true;
            this.lblTipoEmbalagem.Location = new System.Drawing.Point(9, 105);
            this.lblTipoEmbalagem.Name = "lblTipoEmbalagem";
            this.lblTipoEmbalagem.Size = new System.Drawing.Size(100, 13);
            this.lblTipoEmbalagem.TabIndex = 4;
            this.lblTipoEmbalagem.Text = "Tipo de embalagem";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(9, 66);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(47, 13);
            this.lblUnidade.TabIndex = 2;
            this.lblUnidade.Text = "Unidade";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(9, 146);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(88, 13);
            this.lblCusto.TabIndex = 6;
            this.lblCusto.Text = "Custo do produto";
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(9, 162);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(360, 20);
            this.txtCusto.TabIndex = 7;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(9, 27);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(9, 43);
            this.txtProduto.MaxLength = 200;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(360, 20);
            this.txtProduto.TabIndex = 1;
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(9, 83);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(357, 20);
            this.txtUnidade.TabIndex = 3;
            // 
            // CadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 281);
            this.Controls.Add(this.cadastroBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProduto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroProdutos_FormClosing);
            this.cadastroBox.ResumeLayout(false);
            this.cadastroBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cadastroBox;
        private System.Windows.Forms.Button btnCancelCadastro;
        private System.Windows.Forms.Button btnCadastrarCol;
        private System.Windows.Forms.TextBox txtTipoEmbalagem;
        private System.Windows.Forms.Label lblTipoEmbalagem;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtUnidade;
    }
}