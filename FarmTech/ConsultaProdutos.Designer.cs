namespace FarmTech
{
    partial class ConsultaProdutos
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.resulBuscaProduto = new System.Windows.Forms.DataGridView();
            this.txtBuscaProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resulBuscaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(74)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(599, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(74)))));
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(14, 39);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(93, 44);
            this.btnCadastrarProduto.TabIndex = 15;
            this.btnCadastrarProduto.Text = "Cadastrar novo produto";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // resulBuscaProduto
            // 
            this.resulBuscaProduto.AllowUserToAddRows = false;
            this.resulBuscaProduto.AllowUserToDeleteRows = false;
            this.resulBuscaProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resulBuscaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resulBuscaProduto.Location = new System.Drawing.Point(14, 89);
            this.resulBuscaProduto.Name = "resulBuscaProduto";
            this.resulBuscaProduto.ReadOnly = true;
            this.resulBuscaProduto.Size = new System.Drawing.Size(660, 480);
            this.resulBuscaProduto.TabIndex = 14;
            // 
            // txtBuscaProduto
            // 
            this.txtBuscaProduto.AcceptsReturn = true;
            this.txtBuscaProduto.Location = new System.Drawing.Point(14, 13);
            this.txtBuscaProduto.MaxLength = 200;
            this.txtBuscaProduto.Name = "txtBuscaProduto";
            this.txtBuscaProduto.Size = new System.Drawing.Size(579, 20);
            this.txtBuscaProduto.TabIndex = 13;
            // 
            // ConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 581);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.resulBuscaProduto);
            this.Controls.Add(this.txtBuscaProduto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaProdutos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.resulBuscaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.DataGridView resulBuscaProduto;
        private System.Windows.Forms.TextBox txtBuscaProduto;
    }
}