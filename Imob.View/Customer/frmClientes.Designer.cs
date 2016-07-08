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
            this.btnClientesResetar = new System.Windows.Forms.Button();
            this.btnClientesSalvar = new System.Windows.Forms.Button();
            this.btnClientesVoltar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.Cliente_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente_CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClibtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClibtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txbClientesCPF = new System.Windows.Forms.TextBox();
            this.lblClientesCPF = new System.Windows.Forms.Label();
            this.txbClientesTelefone = new System.Windows.Forms.TextBox();
            this.lblClientesTelefone = new System.Windows.Forms.Label();
            this.txbClientesEndereco = new System.Windows.Forms.TextBox();
            this.lblClientesEndereco = new System.Windows.Forms.Label();
            this.txbClientesNome = new System.Windows.Forms.TextBox();
            this.lblClientesNome = new System.Windows.Forms.Label();
            this.txbClientesIdade = new System.Windows.Forms.TextBox();
            this.lblClientesIdade = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientesResetar
            // 
            this.btnClientesResetar.Location = new System.Drawing.Point(13, 89);
            this.btnClientesResetar.Name = "btnClientesResetar";
            this.btnClientesResetar.Size = new System.Drawing.Size(75, 23);
            this.btnClientesResetar.TabIndex = 47;
            this.btnClientesResetar.Text = "Resetar";
            this.btnClientesResetar.UseVisualStyleBackColor = true;
            this.btnClientesResetar.Click += new System.EventHandler(this.btnClientesNovo_Click);
            // 
            // btnClientesSalvar
            // 
            this.btnClientesSalvar.Location = new System.Drawing.Point(441, 89);
            this.btnClientesSalvar.Name = "btnClientesSalvar";
            this.btnClientesSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnClientesSalvar.TabIndex = 46;
            this.btnClientesSalvar.Text = "Salvar";
            this.btnClientesSalvar.UseVisualStyleBackColor = true;
            this.btnClientesSalvar.Click += new System.EventHandler(this.CosbtnSalvar_Click);
            // 
            // btnClientesVoltar
            // 
            this.btnClientesVoltar.Location = new System.Drawing.Point(522, 89);
            this.btnClientesVoltar.Name = "btnClientesVoltar";
            this.btnClientesVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnClientesVoltar.TabIndex = 45;
            this.btnClientesVoltar.Text = "Voltar";
            this.btnClientesVoltar.UseVisualStyleBackColor = true;
            this.btnClientesVoltar.Click += new System.EventHandler(this.CosbtnVoltar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente_ID,
            this.Cliente_Nome,
            this.Cliente_Idade,
            this.Cliente_Endereco,
            this.Cliente_Telefone,
            this.Cliente_CPF,
            this.ClibtnEditar,
            this.ClibtnExcluir});
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.Location = new System.Drawing.Point(13, 118);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(584, 197);
            this.dgvClientes.TabIndex = 44;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cosdgv_CellContentClick);
            // 
            // Cliente_ID
            // 
            this.Cliente_ID.HeaderText = "ID";
            this.Cliente_ID.Name = "Cliente_ID";
            this.Cliente_ID.ReadOnly = true;
            // 
            // Cliente_Nome
            // 
            this.Cliente_Nome.HeaderText = "Nome";
            this.Cliente_Nome.Name = "Cliente_Nome";
            this.Cliente_Nome.ReadOnly = true;
            // 
            // Cliente_Idade
            // 
            this.Cliente_Idade.HeaderText = "Idade";
            this.Cliente_Idade.Name = "Cliente_Idade";
            this.Cliente_Idade.ReadOnly = true;
            // 
            // Cliente_Endereco
            // 
            this.Cliente_Endereco.HeaderText = "Endereço";
            this.Cliente_Endereco.Name = "Cliente_Endereco";
            this.Cliente_Endereco.ReadOnly = true;
            // 
            // Cliente_Telefone
            // 
            this.Cliente_Telefone.HeaderText = "Telefone";
            this.Cliente_Telefone.Name = "Cliente_Telefone";
            this.Cliente_Telefone.ReadOnly = true;
            // 
            // Cliente_CPF
            // 
            this.Cliente_CPF.HeaderText = "CPF";
            this.Cliente_CPF.Name = "Cliente_CPF";
            this.Cliente_CPF.ReadOnly = true;
            // 
            // ClibtnEditar
            // 
            this.ClibtnEditar.HeaderText = "Editar";
            this.ClibtnEditar.Name = "ClibtnEditar";
            this.ClibtnEditar.ReadOnly = true;
            this.ClibtnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClibtnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ClibtnExcluir
            // 
            this.ClibtnExcluir.HeaderText = "Excluir";
            this.ClibtnExcluir.Name = "ClibtnExcluir";
            this.ClibtnExcluir.ReadOnly = true;
            // 
            // txbClientesCPF
            // 
            this.txbClientesCPF.Location = new System.Drawing.Point(380, 63);
            this.txbClientesCPF.Name = "txbClientesCPF";
            this.txbClientesCPF.Size = new System.Drawing.Size(217, 20);
            this.txbClientesCPF.TabIndex = 43;
            // 
            // lblClientesCPF
            // 
            this.lblClientesCPF.AutoSize = true;
            this.lblClientesCPF.Location = new System.Drawing.Point(347, 66);
            this.lblClientesCPF.Name = "lblClientesCPF";
            this.lblClientesCPF.Size = new System.Drawing.Size(27, 13);
            this.lblClientesCPF.TabIndex = 42;
            this.lblClientesCPF.Text = "CPF";
            // 
            // txbClientesTelefone
            // 
            this.txbClientesTelefone.Location = new System.Drawing.Point(73, 63);
            this.txbClientesTelefone.Name = "txbClientesTelefone";
            this.txbClientesTelefone.Size = new System.Drawing.Size(163, 20);
            this.txbClientesTelefone.TabIndex = 41;
            // 
            // lblClientesTelefone
            // 
            this.lblClientesTelefone.AutoSize = true;
            this.lblClientesTelefone.Location = new System.Drawing.Point(18, 66);
            this.lblClientesTelefone.Name = "lblClientesTelefone";
            this.lblClientesTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblClientesTelefone.TabIndex = 40;
            this.lblClientesTelefone.Text = "Telefone";
            // 
            // txbClientesEndereco
            // 
            this.txbClientesEndereco.Location = new System.Drawing.Point(73, 38);
            this.txbClientesEndereco.Name = "txbClientesEndereco";
            this.txbClientesEndereco.Size = new System.Drawing.Size(524, 20);
            this.txbClientesEndereco.TabIndex = 35;
            // 
            // lblClientesEndereco
            // 
            this.lblClientesEndereco.AutoSize = true;
            this.lblClientesEndereco.Location = new System.Drawing.Point(14, 41);
            this.lblClientesEndereco.Name = "lblClientesEndereco";
            this.lblClientesEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblClientesEndereco.TabIndex = 34;
            this.lblClientesEndereco.Text = "Endereço";
            // 
            // txbClientesNome
            // 
            this.txbClientesNome.Location = new System.Drawing.Point(73, 12);
            this.txbClientesNome.Name = "txbClientesNome";
            this.txbClientesNome.Size = new System.Drawing.Size(524, 20);
            this.txbClientesNome.TabIndex = 33;
            // 
            // lblClientesNome
            // 
            this.lblClientesNome.AutoSize = true;
            this.lblClientesNome.Location = new System.Drawing.Point(32, 15);
            this.lblClientesNome.Name = "lblClientesNome";
            this.lblClientesNome.Size = new System.Drawing.Size(35, 13);
            this.lblClientesNome.TabIndex = 32;
            this.lblClientesNome.Text = "Nome";
            // 
            // txbClientesIdade
            // 
            this.txbClientesIdade.Location = new System.Drawing.Point(282, 63);
            this.txbClientesIdade.Name = "txbClientesIdade";
            this.txbClientesIdade.Size = new System.Drawing.Size(59, 20);
            this.txbClientesIdade.TabIndex = 49;
            // 
            // lblClientesIdade
            // 
            this.lblClientesIdade.AutoSize = true;
            this.lblClientesIdade.Location = new System.Drawing.Point(242, 66);
            this.lblClientesIdade.Name = "lblClientesIdade";
            this.lblClientesIdade.Size = new System.Drawing.Size(34, 13);
            this.lblClientesIdade.TabIndex = 48;
            this.lblClientesIdade.Text = "Idade";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 327);
            this.Controls.Add(this.txbClientesIdade);
            this.Controls.Add(this.lblClientesIdade);
            this.Controls.Add(this.btnClientesResetar);
            this.Controls.Add(this.btnClientesSalvar);
            this.Controls.Add(this.btnClientesVoltar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txbClientesCPF);
            this.Controls.Add(this.lblClientesCPF);
            this.Controls.Add(this.txbClientesTelefone);
            this.Controls.Add(this.lblClientesTelefone);
            this.Controls.Add(this.txbClientesEndereco);
            this.Controls.Add(this.lblClientesEndereco);
            this.Controls.Add(this.txbClientesNome);
            this.Controls.Add(this.lblClientesNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientesResetar;
        private System.Windows.Forms.Button btnClientesSalvar;
        private System.Windows.Forms.Button btnClientesVoltar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txbClientesCPF;
        private System.Windows.Forms.Label lblClientesCPF;
        private System.Windows.Forms.TextBox txbClientesTelefone;
        private System.Windows.Forms.Label lblClientesTelefone;
        private System.Windows.Forms.TextBox txbClientesEndereco;
        private System.Windows.Forms.Label lblClientesEndereco;
        private System.Windows.Forms.TextBox txbClientesNome;
        private System.Windows.Forms.Label lblClientesNome;
        private System.Windows.Forms.TextBox txbClientesIdade;
        private System.Windows.Forms.Label lblClientesIdade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente_CPF;
        private System.Windows.Forms.DataGridViewButtonColumn ClibtnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ClibtnExcluir;
    }
}