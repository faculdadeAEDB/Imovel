namespace Imob.View.Report
{
    partial class frmRelatorio_Algueis
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
            this.lblRelatorioAlgueis = new System.Windows.Forms.Label();
            this.dgvAlugueis = new System.Windows.Forms.DataGridView();
            this.btnPagamentosVoltar = new System.Windows.Forms.Button();
            this.txbAlgueisTotalValor = new System.Windows.Forms.TextBox();
            this.txbAlugueisTotalAlugueis = new System.Windows.Forms.TextBox();
            this.lblAlgueisTotalValor = new System.Windows.Forms.Label();
            this.lblAlgueisTotalAlgueis = new System.Windows.Forms.Label();
            this.ID_Aluguel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Proprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Imovel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Fim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir_Alguel = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlugueis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRelatorioAlgueis
            // 
            this.lblRelatorioAlgueis.AutoSize = true;
            this.lblRelatorioAlgueis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRelatorioAlgueis.Location = new System.Drawing.Point(232, 9);
            this.lblRelatorioAlgueis.Name = "lblRelatorioAlgueis";
            this.lblRelatorioAlgueis.Size = new System.Drawing.Size(151, 20);
            this.lblRelatorioAlgueis.TabIndex = 2;
            this.lblRelatorioAlgueis.Text = "Relatório de Algueis";
            // 
            // dgvAlugueis
            // 
            this.dgvAlugueis.AllowUserToAddRows = false;
            this.dgvAlugueis.AllowUserToDeleteRows = false;
            this.dgvAlugueis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlugueis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlugueis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Aluguel,
            this.Nome_Cliente,
            this.Nome_Proprietario,
            this.ID_Imovel,
            this.Data_Inicio,
            this.Data_Fim,
            this.Excluir_Alguel});
            this.dgvAlugueis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlugueis.Location = new System.Drawing.Point(12, 32);
            this.dgvAlugueis.MultiSelect = false;
            this.dgvAlugueis.Name = "dgvAlugueis";
            this.dgvAlugueis.ReadOnly = true;
            this.dgvAlugueis.Size = new System.Drawing.Size(586, 514);
            this.dgvAlugueis.TabIndex = 3;
            this.dgvAlugueis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlgueis_CellContentClick);
            // 
            // btnPagamentosVoltar
            // 
            this.btnPagamentosVoltar.Location = new System.Drawing.Point(523, 552);
            this.btnPagamentosVoltar.Name = "btnPagamentosVoltar";
            this.btnPagamentosVoltar.Size = new System.Drawing.Size(75, 34);
            this.btnPagamentosVoltar.TabIndex = 11;
            this.btnPagamentosVoltar.Text = "Voltar";
            this.btnPagamentosVoltar.UseVisualStyleBackColor = true;
            this.btnPagamentosVoltar.Click += new System.EventHandler(this.btnPagamentosVoltar_Click);
            // 
            // txbAlgueisTotalValor
            // 
            this.txbAlgueisTotalValor.Location = new System.Drawing.Point(375, 560);
            this.txbAlgueisTotalValor.Name = "txbAlgueisTotalValor";
            this.txbAlgueisTotalValor.ReadOnly = true;
            this.txbAlgueisTotalValor.Size = new System.Drawing.Size(100, 20);
            this.txbAlgueisTotalValor.TabIndex = 10;
            // 
            // txbAlugueisTotalAlugueis
            // 
            this.txbAlugueisTotalAlugueis.Location = new System.Drawing.Point(127, 560);
            this.txbAlugueisTotalAlugueis.Name = "txbAlugueisTotalAlugueis";
            this.txbAlugueisTotalAlugueis.ReadOnly = true;
            this.txbAlugueisTotalAlugueis.Size = new System.Drawing.Size(100, 20);
            this.txbAlugueisTotalAlugueis.TabIndex = 9;
            // 
            // lblAlgueisTotalValor
            // 
            this.lblAlgueisTotalValor.AutoSize = true;
            this.lblAlgueisTotalValor.Location = new System.Drawing.Point(258, 563);
            this.lblAlgueisTotalValor.Name = "lblAlgueisTotalValor";
            this.lblAlgueisTotalValor.Size = new System.Drawing.Size(111, 13);
            this.lblAlgueisTotalValor.TabIndex = 8;
            this.lblAlgueisTotalValor.Text = "Valor total dos Algueis";
            // 
            // lblAlgueisTotalAlgueis
            // 
            this.lblAlgueisTotalAlgueis.AutoSize = true;
            this.lblAlgueisTotalAlgueis.Location = new System.Drawing.Point(13, 563);
            this.lblAlgueisTotalAlgueis.Name = "lblAlgueisTotalAlgueis";
            this.lblAlgueisTotalAlgueis.Size = new System.Drawing.Size(83, 13);
            this.lblAlgueisTotalAlgueis.TabIndex = 7;
            this.lblAlgueisTotalAlgueis.Text = "Total de Algueis";
            // 
            // ID_Aluguel
            // 
            this.ID_Aluguel.HeaderText = "ID do Alguel";
            this.ID_Aluguel.Name = "ID_Aluguel";
            this.ID_Aluguel.ReadOnly = true;
            // 
            // Nome_Cliente
            // 
            this.Nome_Cliente.HeaderText = "Nome do Inquilino";
            this.Nome_Cliente.Name = "Nome_Cliente";
            this.Nome_Cliente.ReadOnly = true;
            // 
            // Nome_Proprietario
            // 
            this.Nome_Proprietario.HeaderText = "Nome do Proprietario";
            this.Nome_Proprietario.Name = "Nome_Proprietario";
            this.Nome_Proprietario.ReadOnly = true;
            // 
            // ID_Imovel
            // 
            this.ID_Imovel.HeaderText = "Imovel";
            this.ID_Imovel.Name = "ID_Imovel";
            this.ID_Imovel.ReadOnly = true;
            // 
            // Data_Inicio
            // 
            this.Data_Inicio.HeaderText = "Data do inicio do contrato";
            this.Data_Inicio.Name = "Data_Inicio";
            this.Data_Inicio.ReadOnly = true;
            // 
            // Data_Fim
            // 
            this.Data_Fim.HeaderText = "Data do fim do contrato";
            this.Data_Fim.Name = "Data_Fim";
            this.Data_Fim.ReadOnly = true;
            // 
            // Excluir_Alguel
            // 
            this.Excluir_Alguel.HeaderText = "Excluir";
            this.Excluir_Alguel.Name = "Excluir_Alguel";
            this.Excluir_Alguel.ReadOnly = true;
            this.Excluir_Alguel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Excluir_Alguel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmRelatorio_Algueis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 593);
            this.Controls.Add(this.btnPagamentosVoltar);
            this.Controls.Add(this.txbAlgueisTotalValor);
            this.Controls.Add(this.txbAlugueisTotalAlugueis);
            this.Controls.Add(this.lblAlgueisTotalValor);
            this.Controls.Add(this.lblAlgueisTotalAlgueis);
            this.Controls.Add(this.dgvAlugueis);
            this.Controls.Add(this.lblRelatorioAlgueis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorio_Algueis";
            this.Text = "frmRelatorio_Algueis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlugueis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRelatorioAlgueis;
        private System.Windows.Forms.DataGridView dgvAlugueis;
        private System.Windows.Forms.Button btnPagamentosVoltar;
        private System.Windows.Forms.TextBox txbAlgueisTotalValor;
        private System.Windows.Forms.TextBox txbAlugueisTotalAlugueis;
        private System.Windows.Forms.Label lblAlgueisTotalValor;
        private System.Windows.Forms.Label lblAlgueisTotalAlgueis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Aluguel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Proprietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Imovel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Fim;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir_Alguel;
    }
}