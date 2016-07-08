namespace Imob.View.Owner
{
    partial class frmProprietarios
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
            this.btnProprietariosImovel = new System.Windows.Forms.Button();
            this.btnProprietariosResetar = new System.Windows.Forms.Button();
            this.btnProprietariosSalvar = new System.Windows.Forms.Button();
            this.btnProprietariosVoltar = new System.Windows.Forms.Button();
            this.dgvProprietarios = new System.Windows.Forms.DataGridView();
            this.ProprietID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProprietNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProprietEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProprietCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProprietTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProprietbtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProprietbtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txbProprietariosCPF = new System.Windows.Forms.TextBox();
            this.lblProprietariosCPF = new System.Windows.Forms.Label();
            this.txbProprietariosTelefone = new System.Windows.Forms.TextBox();
            this.lblProprietariosTelefone = new System.Windows.Forms.Label();
            this.txbProprietariosEndereco = new System.Windows.Forms.TextBox();
            this.lblProprietariosEndereco = new System.Windows.Forms.Label();
            this.txbProprietariosNome = new System.Windows.Forms.TextBox();
            this.lblProprietariosNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProprietarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProprietariosImovel
            // 
            this.btnProprietariosImovel.Location = new System.Drawing.Point(13, 92);
            this.btnProprietariosImovel.Name = "btnProprietariosImovel";
            this.btnProprietariosImovel.Size = new System.Drawing.Size(96, 23);
            this.btnProprietariosImovel.TabIndex = 46;
            this.btnProprietariosImovel.Text = "Cadastrar Imóvel";
            this.btnProprietariosImovel.UseVisualStyleBackColor = true;
            this.btnProprietariosImovel.Click += new System.EventHandler(this.btnImovel_Click);
            // 
            // btnProprietariosResetar
            // 
            this.btnProprietariosResetar.Location = new System.Drawing.Point(359, 92);
            this.btnProprietariosResetar.Name = "btnProprietariosResetar";
            this.btnProprietariosResetar.Size = new System.Drawing.Size(75, 23);
            this.btnProprietariosResetar.TabIndex = 45;
            this.btnProprietariosResetar.Text = "Resetar";
            this.btnProprietariosResetar.UseVisualStyleBackColor = true;
            this.btnProprietariosResetar.Click += new System.EventHandler(this.btnProNovo_Click);
            // 
            // btnProprietariosSalvar
            // 
            this.btnProprietariosSalvar.Location = new System.Drawing.Point(440, 92);
            this.btnProprietariosSalvar.Name = "btnProprietariosSalvar";
            this.btnProprietariosSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnProprietariosSalvar.TabIndex = 44;
            this.btnProprietariosSalvar.Text = "Salvar";
            this.btnProprietariosSalvar.UseVisualStyleBackColor = true;
            this.btnProprietariosSalvar.Click += new System.EventHandler(this.btnProSalvar_Click);
            // 
            // btnProprietariosVoltar
            // 
            this.btnProprietariosVoltar.Location = new System.Drawing.Point(521, 92);
            this.btnProprietariosVoltar.Name = "btnProprietariosVoltar";
            this.btnProprietariosVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnProprietariosVoltar.TabIndex = 43;
            this.btnProprietariosVoltar.Text = "Voltar";
            this.btnProprietariosVoltar.UseVisualStyleBackColor = true;
            this.btnProprietariosVoltar.Click += new System.EventHandler(this.btnProVoltar_Click);
            // 
            // dgvProprietarios
            // 
            this.dgvProprietarios.AllowUserToDeleteRows = false;
            this.dgvProprietarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProprietarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProprietarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProprietID,
            this.ProprietNome,
            this.ProprietEndereco,
            this.ProprietCPF,
            this.ProprietTelefone,
            this.ProprietbtnEditar,
            this.ProprietbtnExcluir});
            this.dgvProprietarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProprietarios.Location = new System.Drawing.Point(13, 121);
            this.dgvProprietarios.MultiSelect = false;
            this.dgvProprietarios.Name = "dgvProprietarios";
            this.dgvProprietarios.ReadOnly = true;
            this.dgvProprietarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProprietarios.Size = new System.Drawing.Size(584, 194);
            this.dgvProprietarios.TabIndex = 42;
            this.dgvProprietarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProprietarios_CellContentClick);
            // 
            // ProprietID
            // 
            this.ProprietID.HeaderText = "ID";
            this.ProprietID.Name = "ProprietID";
            this.ProprietID.ReadOnly = true;
            // 
            // ProprietNome
            // 
            this.ProprietNome.HeaderText = "Nome";
            this.ProprietNome.Name = "ProprietNome";
            this.ProprietNome.ReadOnly = true;
            // 
            // ProprietEndereco
            // 
            this.ProprietEndereco.HeaderText = "Endereço";
            this.ProprietEndereco.Name = "ProprietEndereco";
            this.ProprietEndereco.ReadOnly = true;
            // 
            // ProprietCPF
            // 
            this.ProprietCPF.HeaderText = "CPF";
            this.ProprietCPF.Name = "ProprietCPF";
            this.ProprietCPF.ReadOnly = true;
            // 
            // ProprietTelefone
            // 
            this.ProprietTelefone.HeaderText = "Telefone";
            this.ProprietTelefone.Name = "ProprietTelefone";
            this.ProprietTelefone.ReadOnly = true;
            // 
            // ProprietbtnEditar
            // 
            this.ProprietbtnEditar.HeaderText = "Editar";
            this.ProprietbtnEditar.Name = "ProprietbtnEditar";
            this.ProprietbtnEditar.ReadOnly = true;
            // 
            // ProprietbtnExcluir
            // 
            this.ProprietbtnExcluir.HeaderText = "Excluir";
            this.ProprietbtnExcluir.Name = "ProprietbtnExcluir";
            this.ProprietbtnExcluir.ReadOnly = true;
            this.ProprietbtnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProprietbtnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txbProprietariosCPF
            // 
            this.txbProprietariosCPF.Location = new System.Drawing.Point(359, 65);
            this.txbProprietariosCPF.Name = "txbProprietariosCPF";
            this.txbProprietariosCPF.Size = new System.Drawing.Size(238, 20);
            this.txbProprietariosCPF.TabIndex = 41;
            // 
            // lblProprietariosCPF
            // 
            this.lblProprietariosCPF.AutoSize = true;
            this.lblProprietariosCPF.Location = new System.Drawing.Point(325, 68);
            this.lblProprietariosCPF.Name = "lblProprietariosCPF";
            this.lblProprietariosCPF.Size = new System.Drawing.Size(27, 13);
            this.lblProprietariosCPF.TabIndex = 40;
            this.lblProprietariosCPF.Text = "CPF";
            // 
            // txbProprietariosTelefone
            // 
            this.txbProprietariosTelefone.Location = new System.Drawing.Point(73, 65);
            this.txbProprietariosTelefone.Name = "txbProprietariosTelefone";
            this.txbProprietariosTelefone.Size = new System.Drawing.Size(230, 20);
            this.txbProprietariosTelefone.TabIndex = 39;
            // 
            // lblProprietariosTelefone
            // 
            this.lblProprietariosTelefone.AutoSize = true;
            this.lblProprietariosTelefone.Location = new System.Drawing.Point(18, 68);
            this.lblProprietariosTelefone.Name = "lblProprietariosTelefone";
            this.lblProprietariosTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblProprietariosTelefone.TabIndex = 38;
            this.lblProprietariosTelefone.Text = "Telefone";
            // 
            // txbProprietariosEndereco
            // 
            this.txbProprietariosEndereco.Location = new System.Drawing.Point(73, 38);
            this.txbProprietariosEndereco.Name = "txbProprietariosEndereco";
            this.txbProprietariosEndereco.Size = new System.Drawing.Size(524, 20);
            this.txbProprietariosEndereco.TabIndex = 33;
            // 
            // lblProprietariosEndereco
            // 
            this.lblProprietariosEndereco.AutoSize = true;
            this.lblProprietariosEndereco.Location = new System.Drawing.Point(14, 41);
            this.lblProprietariosEndereco.Name = "lblProprietariosEndereco";
            this.lblProprietariosEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblProprietariosEndereco.TabIndex = 32;
            this.lblProprietariosEndereco.Text = "Endereço";
            // 
            // txbProprietariosNome
            // 
            this.txbProprietariosNome.Location = new System.Drawing.Point(73, 12);
            this.txbProprietariosNome.Name = "txbProprietariosNome";
            this.txbProprietariosNome.Size = new System.Drawing.Size(524, 20);
            this.txbProprietariosNome.TabIndex = 31;
            // 
            // lblProprietariosNome
            // 
            this.lblProprietariosNome.AutoSize = true;
            this.lblProprietariosNome.Location = new System.Drawing.Point(32, 15);
            this.lblProprietariosNome.Name = "lblProprietariosNome";
            this.lblProprietariosNome.Size = new System.Drawing.Size(35, 13);
            this.lblProprietariosNome.TabIndex = 30;
            this.lblProprietariosNome.Text = "Nome";
            // 
            // frmProprietarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 327);
            this.Controls.Add(this.btnProprietariosImovel);
            this.Controls.Add(this.btnProprietariosResetar);
            this.Controls.Add(this.btnProprietariosSalvar);
            this.Controls.Add(this.btnProprietariosVoltar);
            this.Controls.Add(this.dgvProprietarios);
            this.Controls.Add(this.txbProprietariosCPF);
            this.Controls.Add(this.lblProprietariosCPF);
            this.Controls.Add(this.txbProprietariosTelefone);
            this.Controls.Add(this.lblProprietariosTelefone);
            this.Controls.Add(this.txbProprietariosEndereco);
            this.Controls.Add(this.lblProprietariosEndereco);
            this.Controls.Add(this.txbProprietariosNome);
            this.Controls.Add(this.lblProprietariosNome);
            this.MaximizeBox = false;
            this.Name = "frmProprietarios";
            this.Text = "Proprietarios";
            this.Load += new System.EventHandler(this.frmProprietarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProprietarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProprietariosImovel;
        private System.Windows.Forms.Button btnProprietariosResetar;
        private System.Windows.Forms.Button btnProprietariosSalvar;
        private System.Windows.Forms.Button btnProprietariosVoltar;
        private System.Windows.Forms.DataGridView dgvProprietarios;
        private System.Windows.Forms.TextBox txbProprietariosCPF;
        private System.Windows.Forms.Label lblProprietariosCPF;
        private System.Windows.Forms.TextBox txbProprietariosTelefone;
        private System.Windows.Forms.Label lblProprietariosTelefone;
        private System.Windows.Forms.TextBox txbProprietariosEndereco;
        private System.Windows.Forms.Label lblProprietariosEndereco;
        private System.Windows.Forms.TextBox txbProprietariosNome;
        private System.Windows.Forms.Label lblProprietariosNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProprietID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProprietNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProprietEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProprietCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProprietTelefone;
        private System.Windows.Forms.DataGridViewButtonColumn ProprietbtnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ProprietbtnExcluir;
    }
}