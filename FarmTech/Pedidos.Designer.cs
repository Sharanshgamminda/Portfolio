namespace FarmTech
{
    partial class Pedidos
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
            this.btnCadastrarPedido = new System.Windows.Forms.Button();
            this.resulBuscaPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resulBuscaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarPedido
            // 
            this.btnCadastrarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(74)))));
            this.btnCadastrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarPedido.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarPedido.Name = "btnCadastrarPedido";
            this.btnCadastrarPedido.Size = new System.Drawing.Size(93, 44);
            this.btnCadastrarPedido.TabIndex = 11;
            this.btnCadastrarPedido.Text = "Cadastrar novo pedido";
            this.btnCadastrarPedido.UseVisualStyleBackColor = false;
            this.btnCadastrarPedido.Click += new System.EventHandler(this.btnCadastrarPedido_Click);
            // 
            // resulBuscaPedidos
            // 
            this.resulBuscaPedidos.AllowUserToAddRows = false;
            this.resulBuscaPedidos.AllowUserToDeleteRows = false;
            this.resulBuscaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resulBuscaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resulBuscaPedidos.Location = new System.Drawing.Point(12, 62);
            this.resulBuscaPedidos.Name = "resulBuscaPedidos";
            this.resulBuscaPedidos.ReadOnly = true;
            this.resulBuscaPedidos.Size = new System.Drawing.Size(926, 506);
            this.resulBuscaPedidos.TabIndex = 10;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 580);
            this.Controls.Add(this.btnCadastrarPedido);
            this.Controls.Add(this.resulBuscaPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pedidos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.resulBuscaPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarPedido;
        private System.Windows.Forms.DataGridView resulBuscaPedidos;
    }
}