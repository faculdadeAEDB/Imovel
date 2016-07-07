namespace Imob.View.Customer
{
    partial class frmClientes
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
            this.CosbtnNovo = new System.Windows.Forms.Button();
            this.CosbtnSalvar = new System.Windows.Forms.Button();
            this.CosbtnVoltar = new System.Windows.Forms.Button();
            this.Cosdgv = new System.Windows.Forms.DataGridView();
            this.CostxbCPF = new System.Windows.Forms.TextBox();
            this.CoslblCPF = new System.Windows.Forms.Label();
            this.CostxbTelefone = new System.Windows.Forms.TextBox();
            this.CoslblTelefone = new System.Windows.Forms.Label();
            this.CostxbEndereco = new System.Windows.Forms.TextBox();
            this.CoslblEndereco = new System.Windows.Forms.Label();
            this.CostxbNome = new System.Windows.Forms.TextBox();
            this.CoslblNome = new System.Windows.Forms.Label();
            this.CostxbIdade = new System.Windows.Forms.TextBox();
            this.CoslblIdade = new System.Windows.Forms.Label();
            this.ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientebtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClientebtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Cosdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // CosbtnNovo
            // 
            this.CosbtnNovo.Location = new System.Drawing.Point(360, 89);
            this.CosbtnNovo.Name = "CosbtnNovo";
            this.CosbtnNovo.Size = new System.Drawing.Size(75, 23);
            this.CosbtnNovo.TabIndex = 47;
            this.CosbtnNovo.Text = "Novo";
            this.CosbtnNovo.UseVisualStyleBackColor = true;
            this.CosbtnNovo.Click += new System.EventHandler(this.CosbtnNovo_Click);
            // 
            // CosbtnSalvar
            // 
            this.CosbtnSalvar.Location = new System.Drawing.Point(441, 89);
            this.CosbtnSalvar.Name = "CosbtnSalvar";
            this.CosbtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.CosbtnSalvar.TabIndex = 46;
            this.CosbtnSalvar.Text = "Salvar";
            this.CosbtnSalvar.UseVisualStyleBackColor = true;
            this.CosbtnSalvar.Click += new System.EventHandler(this.CosbtnSalvar_Click);
            // 
            // CosbtnVoltar
            // 
            this.CosbtnVoltar.Location = new System.Drawing.Point(522, 89);
            this.CosbtnVoltar.Name = "CosbtnVoltar";
            this.CosbtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.CosbtnVoltar.TabIndex = 45;
            this.CosbtnVoltar.Text = "Voltar";
            this.CosbtnVoltar.UseVisualStyleBackColor = true;
            this.CosbtnVoltar.Click += new System.EventHandler(this.CosbtnVoltar_Click);
            // 
            // Cosdgv
            // 
            this.Cosdgv.AllowUserToAddRows = false;
            this.Cosdgv.AllowUserToDeleteRows = false;
            this.Cosdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cosdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteID,
            this.ClienteNome,
            this.ClienteIdade,
            this.ClienteEndereco,
            this.ClienteTelefone,
            this.ClienteCPF,
            this.ClientebtnExcluir,
            this.ClientebtnEditar});
            this.Cosdgv.Location = new System.Drawing.Point(13, 118);
            this.Cosdgv.Name = "Cosdgv";
            this.Cosdgv.ReadOnly = true;
            this.Cosdgv.Size = new System.Drawing.Size(584, 197);
            this.Cosdgv.TabIndex = 44;
            // 
            // CostxbCPF
            // 
            this.CostxbCPF.Location = new System.Drawing.Point(380, 63);
            this.CostxbCPF.Name = "CostxbCPF";
            this.CostxbCPF.Size = new System.Drawing.Size(217, 20);
            this.CostxbCPF.TabIndex = 43;
            // 
            // CoslblCPF
            // 
            this.CoslblCPF.AutoSize = true;
            this.CoslblCPF.Location = new System.Drawing.Point(347, 66);
            this.CoslblCPF.Name = "CoslblCPF";
            this.CoslblCPF.Size = new System.Drawing.Size(27, 13);
            this.CoslblCPF.TabIndex = 42;
            this.CoslblCPF.Text = "CPF";
            // 
            // CostxbTelefone
            // 
            this.CostxbTelefone.Location = new System.Drawing.Point(73, 63);
            this.CostxbTelefone.Name = "CostxbTelefone";
            this.CostxbTelefone.Size = new System.Drawing.Size(163, 20);
            this.CostxbTelefone.TabIndex = 41;
            // 
            // CoslblTelefone
            // 
            this.CoslblTelefone.AutoSize = true;
            this.CoslblTelefone.Location = new System.Drawing.Point(18, 66);
            this.CoslblTelefone.Name = "CoslblTelefone";
            this.CoslblTelefone.Size = new System.Drawing.Size(49, 13);
            this.CoslblTelefone.TabIndex = 40;
            this.CoslblTelefone.Text = "Telefone";
            // 
            // CostxbEndereco
            // 
            this.CostxbEndereco.Location = new System.Drawing.Point(73, 38);
            this.CostxbEndereco.Name = "CostxbEndereco";
            this.CostxbEndereco.Size = new System.Drawing.Size(524, 20);
            this.CostxbEndereco.TabIndex = 35;
            // 
            // CoslblEndereco
            // 
            this.CoslblEndereco.AutoSize = true;
            this.CoslblEndereco.Location = new System.Drawing.Point(14, 41);
            this.CoslblEndereco.Name = "CoslblEndereco";
            this.CoslblEndereco.Size = new System.Drawing.Size(53, 13);
            this.CoslblEndereco.TabIndex = 34;
            this.CoslblEndereco.Text = "Endereço";
            // 
            // CostxbNome
            // 
            this.CostxbNome.Location = new System.Drawing.Point(73, 12);
            this.CostxbNome.Name = "CostxbNome";
            this.CostxbNome.Size = new System.Drawing.Size(524, 20);
            this.CostxbNome.TabIndex = 33;
            // 
            // CoslblNome
            // 
            this.CoslblNome.AutoSize = true;
            this.CoslblNome.Location = new System.Drawing.Point(32, 15);
            this.CoslblNome.Name = "CoslblNome";
            this.CoslblNome.Size = new System.Drawing.Size(35, 13);
            this.CoslblNome.TabIndex = 32;
            this.CoslblNome.Text = "Nome";
            // 
            // CostxbIdade
            // 
            this.CostxbIdade.Location = new System.Drawing.Point(282, 63);
            this.CostxbIdade.Name = "CostxbIdade";
            this.CostxbIdade.Size = new System.Drawing.Size(59, 20);
            this.CostxbIdade.TabIndex = 49;
            // 
            // CoslblIdade
            // 
            this.CoslblIdade.AutoSize = true;
            this.CoslblIdade.Location = new System.Drawing.Point(242, 66);
            this.CoslblIdade.Name = "CoslblIdade";
            this.CoslblIdade.Size = new System.Drawing.Size(34, 13);
            this.CoslblIdade.TabIndex = 48;
            this.CoslblIdade.Text = "Idade";
            // 
            // ClienteID
            // 
            this.ClienteID.HeaderText = "ID";
            this.ClienteID.Name = "ClienteID";
            this.ClienteID.ReadOnly = true;
            // 
            // ClienteNome
            // 
            this.ClienteNome.HeaderText = "Nome";
            this.ClienteNome.Name = "ClienteNome";
            this.ClienteNome.ReadOnly = true;
            // 
            // ClienteIdade
            // 
            this.ClienteIdade.HeaderText = "Idade";
            this.ClienteIdade.Name = "ClienteIdade";
            this.ClienteIdade.ReadOnly = true;
            // 
            // ClienteEndereco
            // 
            this.ClienteEndereco.HeaderText = "Endereco";
            this.ClienteEndereco.Name = "ClienteEndereco";
            this.ClienteEndereco.ReadOnly = true;
            // 
            // ClienteTelefone
            // 
            this.ClienteTelefone.HeaderText = "Telefone";
            this.ClienteTelefone.Name = "ClienteTelefone";
            this.ClienteTelefone.ReadOnly = true;
            // 
            // ClienteCPF
            // 
            this.ClienteCPF.HeaderText = "CPF";
            this.ClienteCPF.Name = "ClienteCPF";
            this.ClienteCPF.ReadOnly = true;
            // 
            // ClientebtnExcluir
            // 
            this.ClientebtnExcluir.HeaderText = "Excluir";
            this.ClientebtnExcluir.Name = "ClientebtnExcluir";
            this.ClientebtnExcluir.ReadOnly = true;
            // 
            // ClientebtnEditar
            // 
            this.ClientebtnEditar.HeaderText = "Editar";
            this.ClientebtnEditar.Name = "ClientebtnEditar";
            this.ClientebtnEditar.ReadOnly = true;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 327);
            this.Controls.Add(this.CostxbIdade);
            this.Controls.Add(this.CoslblIdade);
            this.Controls.Add(this.CosbtnNovo);
            this.Controls.Add(this.CosbtnSalvar);
            this.Controls.Add(this.CosbtnVoltar);
            this.Controls.Add(this.Cosdgv);
            this.Controls.Add(this.CostxbCPF);
            this.Controls.Add(this.CoslblCPF);
            this.Controls.Add(this.CostxbTelefone);
            this.Controls.Add(this.CoslblTelefone);
            this.Controls.Add(this.CostxbEndereco);
            this.Controls.Add(this.CoslblEndereco);
            this.Controls.Add(this.CostxbNome);
            this.Controls.Add(this.CoslblNome);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cosdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CosbtnNovo;
        private System.Windows.Forms.Button CosbtnSalvar;
        private System.Windows.Forms.Button CosbtnVoltar;
        private System.Windows.Forms.DataGridView Cosdgv;
        private System.Windows.Forms.TextBox CostxbCPF;
        private System.Windows.Forms.Label CoslblCPF;
        private System.Windows.Forms.TextBox CostxbTelefone;
        private System.Windows.Forms.Label CoslblTelefone;
        private System.Windows.Forms.TextBox CostxbEndereco;
        private System.Windows.Forms.Label CoslblEndereco;
        private System.Windows.Forms.TextBox CostxbNome;
        private System.Windows.Forms.Label CoslblNome;
        private System.Windows.Forms.TextBox CostxbIdade;
        private System.Windows.Forms.Label CoslblIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteCPF;
        private System.Windows.Forms.DataGridViewButtonColumn ClientebtnExcluir;
        private System.Windows.Forms.DataGridViewButtonColumn ClientebtnEditar;
    }
}