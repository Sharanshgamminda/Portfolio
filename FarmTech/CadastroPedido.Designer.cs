namespace FarmTech
{
    partial class CadastroPedido
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
            this.txtTotalPedido = new System.Windows.Forms.TextBox();
            this.txtItensPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmQtdProduto = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dtgItensPedido = new System.Windows.Forms.DataGridView();
            this.ColumnProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxFrete = new System.Windows.Forms.ComboBox();
            this.cbxSituPedido = new System.Windows.Forms.ComboBox();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSalvarPedido = new System.Windows.Forms.Button();
            this.lblFretePedido = new System.Windows.Forms.Label();
            this.lblSituPedido = new System.Windows.Forms.Label();
            this.dtPedido = new System.Windows.Forms.DateTimePicker();
            this.lblDtPedido = new System.Windows.Forms.Label();
            this.lblQtdProduto = new System.Windows.Forms.Label();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblProdutoPedido = new System.Windows.Forms.Label();
            this.cadastroBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQtdProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastroBox
            // 
            this.cadastroBox.Controls.Add(this.txtTotalPedido);
            this.cadastroBox.Controls.Add(this.txtItensPedido);
            this.cadastroBox.Controls.Add(this.label2);
            this.cadastroBox.Controls.Add(this.label1);
            this.cadastroBox.Controls.Add(this.nmQtdProduto);
            this.cadastroBox.Controls.Add(this.btnAdicionar);
            this.cadastroBox.Controls.Add(this.dtgItensPedido);
            this.cadastroBox.Controls.Add(this.cbxFrete);
            this.cadastroBox.Controls.Add(this.cbxSituPedido);
            this.cadastroBox.Controls.Add(this.cbxCliente);
            this.cadastroBox.Controls.Add(this.cbxProduto);
            this.cadastroBox.Controls.Add(this.lblNomeCliente);
            this.cadastroBox.Controls.Add(this.btnCancel);
            this.cadastroBox.Controls.Add(this.btnSalvarPedido);
            this.cadastroBox.Controls.Add(this.lblFretePedido);
            this.cadastroBox.Controls.Add(this.lblSituPedido);
            this.cadastroBox.Controls.Add(this.dtPedido);
            this.cadastroBox.Controls.Add(this.lblDtPedido);
            this.cadastroBox.Controls.Add(this.lblQtdProduto);
            this.cadastroBox.Controls.Add(this.txtValorProduto);
            this.cadastroBox.Controls.Add(this.lblValor);
            this.cadastroBox.Controls.Add(this.lblProdutoPedido);
            this.cadastroBox.Location = new System.Drawing.Point(12, 12);
            this.cadastroBox.Name = "cadastroBox";
            this.cadastroBox.Size = new System.Drawing.Size(776, 502);
            this.cadastroBox.TabIndex = 0;
            this.cadastroBox.TabStop = false;
            this.cadastroBox.Text = "Dados";
            // 
            // txtTotalPedido
            // 
            this.txtTotalPedido.Location = new System.Drawing.Point(671, 447);
            this.txtTotalPedido.Name = "txtTotalPedido";
            this.txtTotalPedido.ReadOnly = true;
            this.txtTotalPedido.Size = new System.Drawing.Size(98, 20);
            this.txtTotalPedido.TabIndex = 19;
            this.txtTotalPedido.TabStop = false;
            // 
            // txtItensPedido
            // 
            this.txtItensPedido.Location = new System.Drawing.Point(565, 447);
            this.txtItensPedido.Name = "txtItensPedido";
            this.txtItensPedido.ReadOnly = true;
            this.txtItensPedido.Size = new System.Drawing.Size(100, 20);
            this.txtItensPedido.TabIndex = 17;
            this.txtItensPedido.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Itens";
            // 
            // nmQtdProduto
            // 
            this.nmQtdProduto.Location = new System.Drawing.Point(604, 85);
            this.nmQtdProduto.Name = "nmQtdProduto";
            this.nmQtdProduto.Size = new System.Drawing.Size(83, 20);
            this.nmQtdProduto.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(693, 83);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dtgItensPedido
            // 
            this.dtgItensPedido.AllowUserToAddRows = false;
            this.dtgItensPedido.AllowUserToDeleteRows = false;
            this.dtgItensPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgItensPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItensPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProduto,
            this.ColumnQtd,
            this.ColumnValorUnit,
            this.ColumnValorTotal});
            this.dtgItensPedido.Location = new System.Drawing.Point(6, 115);
            this.dtgItensPedido.Name = "dtgItensPedido";
            this.dtgItensPedido.ReadOnly = true;
            this.dtgItensPedido.Size = new System.Drawing.Size(762, 270);
            this.dtgItensPedido.TabIndex = 11;
            // 
            // ColumnProduto
            // 
            this.ColumnProduto.HeaderText = "Produto";
            this.ColumnProduto.Name = "ColumnProduto";
            this.ColumnProduto.ReadOnly = true;
            // 
            // ColumnQtd
            // 
            this.ColumnQtd.HeaderText = "Quantidade";
            this.ColumnQtd.Name = "ColumnQtd";
            this.ColumnQtd.ReadOnly = true;
            // 
            // ColumnValorUnit
            // 
            this.ColumnValorUnit.HeaderText = "Valor Unitário";
            this.ColumnValorUnit.Name = "ColumnValorUnit";
            this.ColumnValorUnit.ReadOnly = true;
            // 
            // ColumnValorTotal
            // 
            this.ColumnValorTotal.HeaderText = "Valor Total";
            this.ColumnValorTotal.Name = "ColumnValorTotal";
            this.ColumnValorTotal.ReadOnly = true;
            // 
            // cbxFrete
            // 
            this.cbxFrete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFrete.FormattingEnabled = true;
            this.cbxFrete.Items.AddRange(new object[] {
            "Entrega",
            "Retirada"});
            this.cbxFrete.Location = new System.Drawing.Point(6, 446);
            this.cbxFrete.Name = "cbxFrete";
            this.cbxFrete.Size = new System.Drawing.Size(169, 21);
            this.cbxFrete.TabIndex = 15;
            // 
            // cbxSituPedido
            // 
            this.cbxSituPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituPedido.FormattingEnabled = true;
            this.cbxSituPedido.Items.AddRange(new object[] {
            "Aguardando Pagamento",
            "Pago",
            "Entregue"});
            this.cbxSituPedido.Location = new System.Drawing.Point(6, 405);
            this.cbxSituPedido.Name = "cbxSituPedido";
            this.cbxSituPedido.Size = new System.Drawing.Size(169, 21);
            this.cbxSituPedido.TabIndex = 13;
            // 
            // cbxCliente
            // 
            this.cbxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(6, 42);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(537, 21);
            this.cbxCliente.TabIndex = 1;
            // 
            // cbxProduto
            // 
            this.cbxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(6, 85);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(454, 21);
            this.cbxProduto.TabIndex = 5;
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(3, 26);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(39, 13);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Cliente";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(74)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(697, 473);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSalvarPedido
            // 
            this.btnSalvarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(74)))));
            this.btnSalvarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarPedido.Location = new System.Drawing.Point(593, 473);
            this.btnSalvarPedido.Name = "btnSalvarPedido";
            this.btnSalvarPedido.Size = new System.Drawing.Size(98, 23);
            this.btnSalvarPedido.TabIndex = 20;
            this.btnSalvarPedido.Text = "Salvar Pedido";
            this.btnSalvarPedido.UseVisualStyleBackColor = false;
            this.btnSalvarPedido.Click += new System.EventHandler(this.btnSalvarPedido_Click);
            // 
            // lblFretePedido
            // 
            this.lblFretePedido.AutoSize = true;
            this.lblFretePedido.Location = new System.Drawing.Point(3, 429);
            this.lblFretePedido.Name = "lblFretePedido";
            this.lblFretePedido.Size = new System.Drawing.Size(31, 13);
            this.lblFretePedido.TabIndex = 14;
            this.lblFretePedido.Text = "Frete";
            // 
            // lblSituPedido
            // 
            this.lblSituPedido.AutoSize = true;
            this.lblSituPedido.Location = new System.Drawing.Point(6, 388);
            this.lblSituPedido.Name = "lblSituPedido";
            this.lblSituPedido.Size = new System.Drawing.Size(85, 13);
            this.lblSituPedido.TabIndex = 12;
            this.lblSituPedido.Text = "Situação Pedido";
            // 
            // dtPedido
            // 
            this.dtPedido.Location = new System.Drawing.Point(565, 43);
            this.dtPedido.Name = "dtPedido";
            this.dtPedido.Size = new System.Drawing.Size(204, 20);
            this.dtPedido.TabIndex = 3;
            // 
            // lblDtPedido
            // 
            this.lblDtPedido.AutoSize = true;
            this.lblDtPedido.Location = new System.Drawing.Point(562, 27);
            this.lblDtPedido.Name = "lblDtPedido";
            this.lblDtPedido.Size = new System.Drawing.Size(80, 13);
            this.lblDtPedido.TabIndex = 2;
            this.lblDtPedido.Text = "Data do pedido";
            // 
            // lblQtdProduto
            // 
            this.lblQtdProduto.AutoSize = true;
            this.lblQtdProduto.Location = new System.Drawing.Point(601, 69);
            this.lblQtdProduto.Name = "lblQtdProduto";
            this.lblQtdProduto.Size = new System.Drawing.Size(62, 13);
            this.lblQtdProduto.TabIndex = 8;
            this.lblQtdProduto.Text = "Quantidade";
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(466, 86);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(132, 20);
            this.txtValorProduto.TabIndex = 7;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(466, 70);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor";
            // 
            // lblProdutoPedido
            // 
            this.lblProdutoPedido.AutoSize = true;
            this.lblProdutoPedido.Location = new System.Drawing.Point(3, 69);
            this.lblProdutoPedido.Name = "lblProdutoPedido";
            this.lblProdutoPedido.Size = new System.Drawing.Size(44, 13);
            this.lblProdutoPedido.TabIndex = 4;
            this.lblProdutoPedido.Text = "Produto";
            // 
            // CadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.cadastroBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroPedido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroPedido_FormClosing);
            this.cadastroBox.ResumeLayout(false);
            this.cadastroBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQtdProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItensPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cadastroBox;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSalvarPedido;
        private System.Windows.Forms.Label lblFretePedido;
        private System.Windows.Forms.Label lblSituPedido;
        private System.Windows.Forms.DateTimePicker dtPedido;
        private System.Windows.Forms.Label lblDtPedido;
        private System.Windows.Forms.Label lblQtdProduto;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblProdutoPedido;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.ComboBox cbxFrete;
        private System.Windows.Forms.ComboBox cbxSituPedido;
        private System.Windows.Forms.DataGridView dtgItensPedido;
        private System.Windows.Forms.TextBox txtItensPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmQtdProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtTotalPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValorTotal;
    }
}