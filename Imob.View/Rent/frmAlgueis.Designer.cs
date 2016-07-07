namespace Imob.View.Rent
{
    partial class frmAlgueis
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
            this.lblAlgueisCliente = new System.Windows.Forms.Label();
            this.txbAlgueisCliente = new System.Windows.Forms.TextBox();
            this.txbAlgueisProprietario = new System.Windows.Forms.TextBox();
            this.lblAlgueisProprietario = new System.Windows.Forms.Label();
            this.txbAlgueisImovel_ID = new System.Windows.Forms.TextBox();
            this.lblAlgueisImovel_ID = new System.Windows.Forms.Label();
            this.lblAlgueisImovel_Endereco = new System.Windows.Forms.Label();
            this.txbAlgueisImovel_Endereco = new System.Windows.Forms.TextBox();
            this.lblAlgueisClientes = new System.Windows.Forms.Label();
            this.lblAlgueisImoveis = new System.Windows.Forms.Label();
            this.lblAlgueisValor = new System.Windows.Forms.Label();
            this.txbAlgueisValor = new System.Windows.Forms.TextBox();
            this.btnProNovo = new System.Windows.Forms.Button();
            this.btnProSalvar = new System.Windows.Forms.Button();
            this.btnProVoltar = new System.Windows.Forms.Button();
            this.dgvAlgueisClientes = new System.Windows.Forms.DataGridView();
            this.ClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteIdade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAlgueisImoveis = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbAlugueisDataInicio = new System.Windows.Forms.TextBox();
            this.lblAlugueisDataInicio = new System.Windows.Forms.Label();
            this.txbAlugueisDataFim = new System.Windows.Forms.TextBox();
            this.lblAlugueisDataFim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlgueisClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlgueisImoveis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlgueisCliente
            // 
            this.lblAlgueisCliente.AutoSize = true;
            this.lblAlgueisCliente.Location = new System.Drawing.Point(9, 9);
            this.lblAlgueisCliente.Name = "lblAlgueisCliente";
            this.lblAlgueisCliente.Size = new System.Drawing.Size(42, 13);
            this.lblAlgueisCliente.TabIndex = 2;
            this.lblAlgueisCliente.Text = "Cliente:";
            // 
            // txbAlgueisCliente
            // 
            this.txbAlgueisCliente.Location = new System.Drawing.Point(51, 6);
            this.txbAlgueisCliente.Name = "txbAlgueisCliente";
            this.txbAlgueisCliente.Size = new System.Drawing.Size(248, 20);
            this.txbAlgueisCliente.TabIndex = 3;
            // 
            // txbAlgueisProprietario
            // 
            this.txbAlgueisProprietario.Location = new System.Drawing.Point(370, 6);
            this.txbAlgueisProprietario.Name = "txbAlgueisProprietario";
            this.txbAlgueisProprietario.Size = new System.Drawing.Size(228, 20);
            this.txbAlgueisProprietario.TabIndex = 5;
            // 
            // lblAlgueisProprietario
            // 
            this.lblAlgueisProprietario.AutoSize = true;
            this.lblAlgueisProprietario.Location = new System.Drawing.Point(310, 9);
            this.lblAlgueisProprietario.Name = "lblAlgueisProprietario";
            this.lblAlgueisProprietario.Size = new System.Drawing.Size(63, 13);
            this.lblAlgueisProprietario.TabIndex = 4;
            this.lblAlgueisProprietario.Text = "Proprietario:";
            // 
            // txbAlgueisImovel_ID
            // 
            this.txbAlgueisImovel_ID.Location = new System.Drawing.Point(63, 32);
            this.txbAlgueisImovel_ID.Name = "txbAlgueisImovel_ID";
            this.txbAlgueisImovel_ID.Size = new System.Drawing.Size(29, 20);
            this.txbAlgueisImovel_ID.TabIndex = 7;
            // 
            // lblAlgueisImovel_ID
            // 
            this.lblAlgueisImovel_ID.AutoSize = true;
            this.lblAlgueisImovel_ID.Location = new System.Drawing.Point(9, 35);
            this.lblAlgueisImovel_ID.Name = "lblAlgueisImovel_ID";
            this.lblAlgueisImovel_ID.Size = new System.Drawing.Size(55, 13);
            this.lblAlgueisImovel_ID.TabIndex = 6;
            this.lblAlgueisImovel_ID.Text = "Imovel ID:";
            // 
            // lblAlgueisImovel_Endereco
            // 
            this.lblAlgueisImovel_Endereco.AutoSize = true;
            this.lblAlgueisImovel_Endereco.Location = new System.Drawing.Point(98, 35);
            this.lblAlgueisImovel_Endereco.Name = "lblAlgueisImovel_Endereco";
            this.lblAlgueisImovel_Endereco.Size = new System.Drawing.Size(90, 13);
            this.lblAlgueisImovel_Endereco.TabIndex = 8;
            this.lblAlgueisImovel_Endereco.Text = "Imovel Endereço:";
            // 
            // txbAlgueisImovel_Endereco
            // 
            this.txbAlgueisImovel_Endereco.Location = new System.Drawing.Point(186, 32);
            this.txbAlgueisImovel_Endereco.Name = "txbAlgueisImovel_Endereco";
            this.txbAlgueisImovel_Endereco.Size = new System.Drawing.Size(276, 20);
            this.txbAlgueisImovel_Endereco.TabIndex = 9;
            // 
            // lblAlgueisClientes
            // 
            this.lblAlgueisClientes.AutoSize = true;
            this.lblAlgueisClientes.Location = new System.Drawing.Point(136, 91);
            this.lblAlgueisClientes.Name = "lblAlgueisClientes";
            this.lblAlgueisClientes.Size = new System.Drawing.Size(39, 13);
            this.lblAlgueisClientes.TabIndex = 12;
            this.lblAlgueisClientes.Text = "Cliente";
            // 
            // lblAlgueisImoveis
            // 
            this.lblAlgueisImoveis.AutoSize = true;
            this.lblAlgueisImoveis.Location = new System.Drawing.Point(433, 91);
            this.lblAlgueisImoveis.Name = "lblAlgueisImoveis";
            this.lblAlgueisImoveis.Size = new System.Drawing.Size(43, 13);
            this.lblAlgueisImoveis.TabIndex = 13;
            this.lblAlgueisImoveis.Text = "Imoveis";
            // 
            // lblAlgueisValor
            // 
            this.lblAlgueisValor.AutoSize = true;
            this.lblAlgueisValor.Location = new System.Drawing.Point(468, 35);
            this.lblAlgueisValor.Name = "lblAlgueisValor";
            this.lblAlgueisValor.Size = new System.Drawing.Size(34, 13);
            this.lblAlgueisValor.TabIndex = 15;
            this.lblAlgueisValor.Text = "Valor:";
            // 
            // txbAlgueisValor
            // 
            this.txbAlgueisValor.Location = new System.Drawing.Point(508, 32);
            this.txbAlgueisValor.Name = "txbAlgueisValor";
            this.txbAlgueisValor.Size = new System.Drawing.Size(90, 20);
            this.txbAlgueisValor.TabIndex = 14;
            // 
            // btnProNovo
            // 
            this.btnProNovo.Location = new System.Drawing.Point(361, 58);
            this.btnProNovo.Name = "btnProNovo";
            this.btnProNovo.Size = new System.Drawing.Size(75, 23);
            this.btnProNovo.TabIndex = 49;
            this.btnProNovo.Text = "Novo";
            this.btnProNovo.UseVisualStyleBackColor = true;
            this.btnProNovo.Click += new System.EventHandler(this.btnProNovo_Click);
            // 
            // btnProSalvar
            // 
            this.btnProSalvar.Location = new System.Drawing.Point(442, 58);
            this.btnProSalvar.Name = "btnProSalvar";
            this.btnProSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnProSalvar.TabIndex = 48;
            this.btnProSalvar.Text = "Salvar";
            this.btnProSalvar.UseVisualStyleBackColor = true;
            // 
            // btnProVoltar
            // 
            this.btnProVoltar.Location = new System.Drawing.Point(523, 58);
            this.btnProVoltar.Name = "btnProVoltar";
            this.btnProVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnProVoltar.TabIndex = 47;
            this.btnProVoltar.Text = "Voltar";
            this.btnProVoltar.UseVisualStyleBackColor = true;
            this.btnProVoltar.Click += new System.EventHandler(this.btnProVoltar_Click);
            // 
            // dgvAlgueisClientes
            // 
            this.dgvAlgueisClientes.AllowUserToAddRows = false;
            this.dgvAlgueisClientes.AllowUserToDeleteRows = false;
            this.dgvAlgueisClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlgueisClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlgueisClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClienteID,
            this.ClienteNome,
            this.ClienteIdade,
            this.ClienteEndereco,
            this.ClienteTelefone,
            this.ClienteCPF});
            this.dgvAlgueisClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlgueisClientes.Location = new System.Drawing.Point(12, 107);
            this.dgvAlgueisClientes.MultiSelect = false;
            this.dgvAlgueisClientes.Name = "dgvAlgueisClientes";
            this.dgvAlgueisClientes.ReadOnly = true;
            this.dgvAlgueisClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlgueisClientes.Size = new System.Drawing.Size(287, 208);
            this.dgvAlgueisClientes.TabIndex = 51;
            this.dgvAlgueisClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cosdgv_CellContentClick);
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
            // dgvAlgueisImoveis
            // 
            this.dgvAlgueisImoveis.AllowUserToAddRows = false;
            this.dgvAlgueisImoveis.AllowUserToDeleteRows = false;
            this.dgvAlgueisImoveis.AllowUserToResizeColumns = false;
            this.dgvAlgueisImoveis.AllowUserToResizeRows = false;
            this.dgvAlgueisImoveis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlgueisImoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlgueisImoveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Endereco,
            this.Tipo});
            this.dgvAlgueisImoveis.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlgueisImoveis.Location = new System.Drawing.Point(313, 107);
            this.dgvAlgueisImoveis.MultiSelect = false;
            this.dgvAlgueisImoveis.Name = "dgvAlgueisImoveis";
            this.dgvAlgueisImoveis.ReadOnly = true;
            this.dgvAlgueisImoveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlgueisImoveis.Size = new System.Drawing.Size(285, 208);
            this.dgvAlgueisImoveis.TabIndex = 52;
            this.dgvAlgueisImoveis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImoveis_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereco";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // txbAlugueisDataInicio
            // 
            this.txbAlugueisDataInicio.Location = new System.Drawing.Point(63, 60);
            this.txbAlugueisDataInicio.Name = "txbAlugueisDataInicio";
            this.txbAlugueisDataInicio.Size = new System.Drawing.Size(59, 20);
            this.txbAlugueisDataInicio.TabIndex = 54;
            this.txbAlugueisDataInicio.Text = "XX/XX/XX";
            // 
            // lblAlugueisDataInicio
            // 
            this.lblAlugueisDataInicio.AutoSize = true;
            this.lblAlugueisDataInicio.Location = new System.Drawing.Point(3, 63);
            this.lblAlugueisDataInicio.Name = "lblAlugueisDataInicio";
            this.lblAlugueisDataInicio.Size = new System.Drawing.Size(61, 13);
            this.lblAlugueisDataInicio.TabIndex = 53;
            this.lblAlugueisDataInicio.Text = " Data Inicio";
            // 
            // txbAlugueisDataFim
            // 
            this.txbAlugueisDataFim.Location = new System.Drawing.Point(186, 60);
            this.txbAlugueisDataFim.Name = "txbAlugueisDataFim";
            this.txbAlugueisDataFim.Size = new System.Drawing.Size(59, 20);
            this.txbAlugueisDataFim.TabIndex = 56;
            this.txbAlugueisDataFim.Text = "XX/XX/XX";
            // 
            // lblAlugueisDataFim
            // 
            this.lblAlugueisDataFim.AutoSize = true;
            this.lblAlugueisDataFim.Location = new System.Drawing.Point(128, 63);
            this.lblAlugueisDataFim.Name = "lblAlugueisDataFim";
            this.lblAlugueisDataFim.Size = new System.Drawing.Size(52, 13);
            this.lblAlugueisDataFim.TabIndex = 55;
            this.lblAlugueisDataFim.Text = " Data Fim";
            // 
            // frmAlgueis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 327);
            this.Controls.Add(this.txbAlugueisDataFim);
            this.Controls.Add(this.lblAlugueisDataFim);
            this.Controls.Add(this.txbAlugueisDataInicio);
            this.Controls.Add(this.lblAlugueisDataInicio);
            this.Controls.Add(this.dgvAlgueisImoveis);
            this.Controls.Add(this.dgvAlgueisClientes);
            this.Controls.Add(this.btnProNovo);
            this.Controls.Add(this.btnProSalvar);
            this.Controls.Add(this.btnProVoltar);
            this.Controls.Add(this.lblAlgueisValor);
            this.Controls.Add(this.txbAlgueisValor);
            this.Controls.Add(this.lblAlgueisImoveis);
            this.Controls.Add(this.lblAlgueisClientes);
            this.Controls.Add(this.txbAlgueisImovel_Endereco);
            this.Controls.Add(this.lblAlgueisImovel_Endereco);
            this.Controls.Add(this.txbAlgueisImovel_ID);
            this.Controls.Add(this.lblAlgueisImovel_ID);
            this.Controls.Add(this.txbAlgueisProprietario);
            this.Controls.Add(this.lblAlgueisProprietario);
            this.Controls.Add(this.txbAlgueisCliente);
            this.Controls.Add(this.lblAlgueisCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlgueis";
            this.Text = "Alguéis";
            this.Load += new System.EventHandler(this.frmAlgueis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlgueisClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlgueisImoveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAlgueisCliente;
        private System.Windows.Forms.TextBox txbAlgueisCliente;
        private System.Windows.Forms.TextBox txbAlgueisProprietario;
        private System.Windows.Forms.Label lblAlgueisProprietario;
        private System.Windows.Forms.TextBox txbAlgueisImovel_ID;
        private System.Windows.Forms.Label lblAlgueisImovel_ID;
        private System.Windows.Forms.Label lblAlgueisImovel_Endereco;
        private System.Windows.Forms.TextBox txbAlgueisImovel_Endereco;
        private System.Windows.Forms.Label lblAlgueisClientes;
        private System.Windows.Forms.Label lblAlgueisImoveis;
        private System.Windows.Forms.Label lblAlgueisValor;
        private System.Windows.Forms.TextBox txbAlgueisValor;
        private System.Windows.Forms.Button btnProVoltar;
        private System.Windows.Forms.Button btnProSalvar;
        private System.Windows.Forms.Button btnProNovo;
        private System.Windows.Forms.DataGridView dgvAlgueisClientes;
        private System.Windows.Forms.DataGridView dgvAlgueisImoveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.TextBox txbAlugueisDataInicio;
        private System.Windows.Forms.Label lblAlugueisDataInicio;
        private System.Windows.Forms.TextBox txbAlugueisDataFim;
        private System.Windows.Forms.Label lblAlugueisDataFim;
    }
}