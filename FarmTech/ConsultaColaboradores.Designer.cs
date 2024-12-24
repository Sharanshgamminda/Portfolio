namespace FarmTech
{
    partial class ConsultaColaboradores
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
            this.btnBuscarColaborador = new System.Windows.Forms.Button();
            this.btnCadastrarColaborador = new System.Windows.Forms.Button();
            this.resulBuscaColaborador = new System.Windows.Forms.DataGridView();
            this.txtBuscaColaborador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resulBuscaColaborador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarColaborador
            // 
            this.btnBuscarColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(74)))));
            this.btnBuscarColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarColaborador.Location = new System.Drawing.Point(863, 11);
            this.btnBuscarColaborador.Name = "btnBuscarColaborador";
            this.btnBuscarColaborador.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarColaborador.TabIndex = 12;
            this.btnBuscarColaborador.Text = "Buscar";
            this.btnBuscarColaborador.UseVisualStyleBackColor = false;
            this.btnBuscarColaborador.Click += new System.EventHandler(this.btnBuscarColaborador_Click);
            // 
            // btnCadastrarColaborador
            // 
            this.btnCadastrarColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(202)))), ((int)(((byte)(74)))));
            this.btnCadastrarColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarColaborador.Location = new System.Drawing.Point(12, 39);
            this.btnCadastrarColaborador.Name = "btnCadastrarColaborador";
            this.btnCadastrarColaborador.Size = new System.Drawing.Size(93, 44);
            this.btnCadastrarColaborador.TabIndex = 11;
            this.btnCadastrarColaborador.Text = "Cadastrar novo colaborador";
            this.btnCadastrarColaborador.UseVisualStyleBackColor = false;
            this.btnCadastrarColaborador.Click += new System.EventHandler(this.btnCadastrarColaborador_Click);
            // 
            // resulBuscaColaborador
            // 
            this.resulBuscaColaborador.AllowUserToAddRows = false;
            this.resulBuscaColaborador.AllowUserToDeleteRows = false;
            this.resulBuscaColaborador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resulBuscaColaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resulBuscaColaborador.Location = new System.Drawing.Point(12, 89);
            this.resulBuscaColaborador.Name = "resulBuscaColaborador";
            this.resulBuscaColaborador.ReadOnly = true;
            this.resulBuscaColaborador.Size = new System.Drawing.Size(926, 480);
            this.resulBuscaColaborador.TabIndex = 10;
            // 
            // txtBuscaColaborador
            // 
            this.txtBuscaColaborador.AcceptsReturn = true;
            this.txtBuscaColaborador.Location = new System.Drawing.Point(12, 13);
            this.txtBuscaColaborador.MaxLength = 200;
            this.txtBuscaColaborador.Name = "txtBuscaColaborador";
            this.txtBuscaColaborador.Size = new System.Drawing.Size(844, 20);
            this.txtBuscaColaborador.TabIndex = 9;
            // 
            // ConsultaColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.btnBuscarColaborador);
            this.Controls.Add(this.btnCadastrarColaborador);
            this.Controls.Add(this.resulBuscaColaborador);
            this.Controls.Add(this.txtBuscaColaborador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaColaboradores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaColaboradores";
            ((System.ComponentModel.ISupportInitialize)(this.resulBuscaColaborador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarColaborador;
        private System.Windows.Forms.Button btnCadastrarColaborador;
        private System.Windows.Forms.DataGridView resulBuscaColaborador;
        private System.Windows.Forms.TextBox txtBuscaColaborador;
    }
}