namespace Imob.View.Report
{
    partial class frmRelatorio_Pagamentos
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
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.lblRelatorioPagamentos = new System.Windows.Forms.Label();
            this.lblPagamentosTotalPagamentos = new System.Windows.Forms.Label();
            this.lblPagamentosTotalValor = new System.Windows.Forms.Label();
            this.txbPagamentosTotalPagamentos = new System.Windows.Forms.TextBox();
            this.txbPagamentosTotalValor = new System.Windows.Forms.TextBox();
            this.btnPagamentosVoltar = new System.Windows.Forms.Button();
            this.ID_Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir_Pagamento = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.AllowUserToAddRows = false;
            this.dgvPagamentos.AllowUserToDeleteRows = false;
            this.dgvPagamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Pagamento,
            this.Data_Pagamento,
            this.Valor_Pagamento,
            this.Excluir_Pagamento});
            this.dgvPagamentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPagamentos.Location = new System.Drawing.Point(12, 32);
            this.dgvPagamentos.MultiSelect = false;
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.ReadOnly = true;
            this.dgvPagamentos.Size = new System.Drawing.Size(586, 514);
            this.dgvPagamentos.TabIndex = 0;
            this.dgvPagamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamentos_CellContentClick);
            // 
            // lblRelatorioPagamentos
            // 
            this.lblRelatorioPagamentos.AutoSize = true;
            this.lblRelatorioPagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRelatorioPagamentos.Location = new System.Drawing.Point(210, 9);
            this.lblRelatorioPagamentos.Name = "lblRelatorioPagamentos";
            this.lblRelatorioPagamentos.Size = new System.Drawing.Size(189, 20);
            this.lblRelatorioPagamentos.TabIndex = 1;
            this.lblRelatorioPagamentos.Text = "Relatório de Pagamentos";
            // 
            // lblPagamentosTotalPagamentos
            // 
            this.lblPagamentosTotalPagamentos.AutoSize = true;
            this.lblPagamentosTotalPagamentos.Location = new System.Drawing.Point(13, 563);
            this.lblPagamentosTotalPagamentos.Name = "lblPagamentosTotalPagamentos";
            this.lblPagamentosTotalPagamentos.Size = new System.Drawing.Size(108, 13);
            this.lblPagamentosTotalPagamentos.TabIndex = 2;
            this.lblPagamentosTotalPagamentos.Text = "Total de Pagamentos";
            // 
            // lblPagamentosTotalValor
            // 
            this.lblPagamentosTotalValor.AutoSize = true;
            this.lblPagamentosTotalValor.Location = new System.Drawing.Point(233, 563);
            this.lblPagamentosTotalValor.Name = "lblPagamentosTotalValor";
            this.lblPagamentosTotalValor.Size = new System.Drawing.Size(136, 13);
            this.lblPagamentosTotalValor.TabIndex = 3;
            this.lblPagamentosTotalValor.Text = "Valor total dos Pagamentos";
            // 
            // txbPagamentosTotalPagamentos
            // 
            this.txbPagamentosTotalPagamentos.Location = new System.Drawing.Point(124, 560);
            this.txbPagamentosTotalPagamentos.Name = "txbPagamentosTotalPagamentos";
            this.txbPagamentosTotalPagamentos.ReadOnly = true;
            this.txbPagamentosTotalPagamentos.Size = new System.Drawing.Size(100, 20);
            this.txbPagamentosTotalPagamentos.TabIndex = 4;
            // 
            // txbPagamentosTotalValor
            // 
            this.txbPagamentosTotalValor.Location = new System.Drawing.Point(375, 560);
            this.txbPagamentosTotalValor.Name = "txbPagamentosTotalValor";
            this.txbPagamentosTotalValor.ReadOnly = true;
            this.txbPagamentosTotalValor.Size = new System.Drawing.Size(100, 20);
            this.txbPagamentosTotalValor.TabIndex = 5;
            // 
            // btnPagamentosVoltar
            // 
            this.btnPagamentosVoltar.Location = new System.Drawing.Point(523, 552);
            this.btnPagamentosVoltar.Name = "btnPagamentosVoltar";
            this.btnPagamentosVoltar.Size = new System.Drawing.Size(75, 34);
            this.btnPagamentosVoltar.TabIndex = 6;
            this.btnPagamentosVoltar.Text = "Voltar";
            this.btnPagamentosVoltar.UseVisualStyleBackColor = true;
            this.btnPagamentosVoltar.Click += new System.EventHandler(this.btnPagamentosVoltar_Click);
            // 
            // ID_Pagamento
            // 
            this.ID_Pagamento.HeaderText = "Pagamento";
            this.ID_Pagamento.Name = "ID_Pagamento";
            this.ID_Pagamento.ReadOnly = true;
            // 
            // Data_Pagamento
            // 
            this.Data_Pagamento.HeaderText = "Data";
            this.Data_Pagamento.Name = "Data_Pagamento";
            this.Data_Pagamento.ReadOnly = true;
            // 
            // Valor_Pagamento
            // 
            this.Valor_Pagamento.HeaderText = "Valor";
            this.Valor_Pagamento.Name = "Valor_Pagamento";
            this.Valor_Pagamento.ReadOnly = true;
            // 
            // Excluir_Pagamento
            // 
            this.Excluir_Pagamento.HeaderText = "Excluir";
            this.Excluir_Pagamento.Name = "Excluir_Pagamento";
            this.Excluir_Pagamento.ReadOnly = true;
            this.Excluir_Pagamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Excluir_Pagamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmRelatorio_Pagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 593);
            this.Controls.Add(this.btnPagamentosVoltar);
            this.Controls.Add(this.txbPagamentosTotalValor);
            this.Controls.Add(this.txbPagamentosTotalPagamentos);
            this.Controls.Add(this.lblPagamentosTotalValor);
            this.Controls.Add(this.lblPagamentosTotalPagamentos);
            this.Controls.Add(this.lblRelatorioPagamentos);
            this.Controls.Add(this.dgvPagamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorio_Pagamentos";
            this.Text = "Relatorio_Pagamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.Label lblRelatorioPagamentos;
        private System.Windows.Forms.Label lblPagamentosTotalPagamentos;
        private System.Windows.Forms.Label lblPagamentosTotalValor;
        private System.Windows.Forms.TextBox txbPagamentosTotalPagamentos;
        private System.Windows.Forms.TextBox txbPagamentosTotalValor;
        private System.Windows.Forms.Button btnPagamentosVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Pagamento;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir_Pagamento;
    }
}