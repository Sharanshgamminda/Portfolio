namespace FarmTech
{
    partial class ConsultaFornecedores
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
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.resulBuscaFornecedor = new System.Windows.Forms.DataGridView();
            this.txtBuscaFornecedores = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resulBuscaFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(74)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Location = new System.Drawing.Point(863, 11);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 12;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(74)))));
            this.btnCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(12, 39);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(93, 44);
            this.btnCadastrarFornecedor.TabIndex = 11;
            this.btnCadastrarFornecedor.Text = "Cadastrar novo fornecedor";
            this.btnCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.btnCadastrarFornecedor.Click += new System.EventHandler(this.btnCadastrarFornecedor_Click);
            // 
            // resulBuscaFornecedor
            // 
            this.resulBuscaFornecedor.AllowUserToAddRows = false;
            this.resulBuscaFornecedor.AllowUserToDeleteRows = false;
            this.resulBuscaFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resulBuscaFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resulBuscaFornecedor.Location = new System.Drawing.Point(12, 89);
            this.resulBuscaFornecedor.Name = "resulBuscaFornecedor";
            this.resulBuscaFornecedor.ReadOnly = true;
            this.resulBuscaFornecedor.Size = new System.Drawing.Size(926, 480);
            this.resulBuscaFornecedor.TabIndex = 10;
            // 
            // txtBuscaFornecedores
            // 
            this.txtBuscaFornecedores.AcceptsReturn = true;
            this.txtBuscaFornecedores.Location = new System.Drawing.Point(12, 13);
            this.txtBuscaFornecedores.MaxLength = 200;
            this.txtBuscaFornecedores.Name = "txtBuscaFornecedores";
            this.txtBuscaFornecedores.Size = new System.Drawing.Size(844, 20);
            this.txtBuscaFornecedores.TabIndex = 9;
            // 
            // ConsultaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnCadastrarFornecedor);
            this.Controls.Add(this.resulBuscaFornecedor);
            this.Controls.Add(this.txtBuscaFornecedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaFornecedores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.resulBuscaFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnCadastrarFornecedor;
        private System.Windows.Forms.DataGridView resulBuscaFornecedor;
        private System.Windows.Forms.TextBox txtBuscaFornecedores;
    }
}