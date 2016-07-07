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
            this.btnImovel = new System.Windows.Forms.Button();
            this.btnProNovo = new System.Windows.Forms.Button();
            this.btnProSalvar = new System.Windows.Forms.Button();
            this.btnProVoltar = new System.Windows.Forms.Button();
            this.grdProprietario = new System.Windows.Forms.DataGridView();
            this.ProprietID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProprietNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProprietEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProprietCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProprietTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProprietbtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProprietbtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PropriettxbCPF = new System.Windows.Forms.TextBox();
            this.ProprietlblCPF = new System.Windows.Forms.Label();
            this.PropriettxbTelefone = new System.Windows.Forms.TextBox();
            this.ProprietlblTelefone = new System.Windows.Forms.Label();
            this.PropriettxbEndereco = new System.Windows.Forms.TextBox();
            this.ProprietlblEndereco = new System.Windows.Forms.Label();
            this.PropriettxbNome = new System.Windows.Forms.TextBox();
            this.ProprietlblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdProprietario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImovel
            // 
            this.btnImovel.Location = new System.Drawing.Point(13, 92);
            this.btnImovel.Name = "btnImovel";
            this.btnImovel.Size = new System.Drawing.Size(96, 23);
            this.btnImovel.TabIndex = 46;
            this.btnImovel.Text = "Cadastrar Imóvel";
            this.btnImovel.UseVisualStyleBackColor = true;
            this.btnImovel.Click += new System.EventHandler(this.btnImovel_Click);
            // 
            // btnProNovo
            // 
            this.btnProNovo.Location = new System.Drawing.Point(359, 92);
            this.btnProNovo.Name = "btnProNovo";
            this.btnProNovo.Size = new System.Drawing.Size(75, 23);
            this.btnProNovo.TabIndex = 45;
            this.btnProNovo.Text = "Novo";
            this.btnProNovo.UseVisualStyleBackColor = true;
            this.btnProNovo.Click += new System.EventHandler(this.btnProNovo_Click);
            // 
            // btnProSalvar
            // 
            this.btnProSalvar.Location = new System.Drawing.Point(440, 92);
            this.btnProSalvar.Name = "btnProSalvar";
            this.btnProSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnProSalvar.TabIndex = 44;
            this.btnProSalvar.Text = "Salvar";
            this.btnProSalvar.UseVisualStyleBackColor = true;
            this.btnProSalvar.Click += new System.EventHandler(this.btnProSalvar_Click);
            // 
            // btnProVoltar
            // 
            this.btnProVoltar.Location = new System.Drawing.Point(521, 92);
            this.btnProVoltar.Name = "btnProVoltar";
            this.btnProVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnProVoltar.TabIndex = 43;
            this.btnProVoltar.Text = "Voltar";
            this.btnProVoltar.UseVisualStyleBackColor = true;
            this.btnProVoltar.Click += new System.EventHandler(this.btnProVoltar_Click);
            // 
            // grdProprietario
            // 
            this.grdProprietario.AllowUserToDeleteRows = false;
            this.grdProprietario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProprietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProprietario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProprietID,
            this.ProprietNome,
            this.ProprietEndereco,
            this.ProprietCPF,
            this.ProprietTelefone,
            this.ProprietbtnEditar,
            this.ProprietbtnExcluir});
            this.grdProprietario.Location = new System.Drawing.Point(13, 121);
            this.grdProprietario.Name = "grdProprietario";
            this.grdProprietario.ReadOnly = true;
            this.grdProprietario.Size = new System.Drawing.Size(584, 194);
            this.grdProprietario.TabIndex = 42;
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
            // PropriettxbCPF
            // 
            this.PropriettxbCPF.Location = new System.Drawing.Point(359, 65);
            this.PropriettxbCPF.Name = "PropriettxbCPF";
            this.PropriettxbCPF.Size = new System.Drawing.Size(238, 20);
            this.PropriettxbCPF.TabIndex = 41;
            // 
            // ProprietlblCPF
            // 
            this.ProprietlblCPF.AutoSize = true;
            this.ProprietlblCPF.Location = new System.Drawing.Point(325, 68);
            this.ProprietlblCPF.Name = "ProprietlblCPF";
            this.ProprietlblCPF.Size = new System.Drawing.Size(27, 13);
            this.ProprietlblCPF.TabIndex = 40;
            this.ProprietlblCPF.Text = "CPF";
            // 
            // PropriettxbTelefone
            // 
            this.PropriettxbTelefone.Location = new System.Drawing.Point(73, 65);
            this.PropriettxbTelefone.Name = "PropriettxbTelefone";
            this.PropriettxbTelefone.Size = new System.Drawing.Size(230, 20);
            this.PropriettxbTelefone.TabIndex = 39;
            // 
            // ProprietlblTelefone
            // 
            this.ProprietlblTelefone.AutoSize = true;
            this.ProprietlblTelefone.Location = new System.Drawing.Point(18, 68);
            this.ProprietlblTelefone.Name = "ProprietlblTelefone";
            this.ProprietlblTelefone.Size = new System.Drawing.Size(49, 13);
            this.ProprietlblTelefone.TabIndex = 38;
            this.ProprietlblTelefone.Text = "Telefone";
            // 
            // PropriettxbEndereco
            // 
            this.PropriettxbEndereco.Location = new System.Drawing.Point(73, 38);
            this.PropriettxbEndereco.Name = "PropriettxbEndereco";
            this.PropriettxbEndereco.Size = new System.Drawing.Size(524, 20);
            this.PropriettxbEndereco.TabIndex = 33;
            // 
            // ProprietlblEndereco
            // 
            this.ProprietlblEndereco.AutoSize = true;
            this.ProprietlblEndereco.Location = new System.Drawing.Point(14, 41);
            this.ProprietlblEndereco.Name = "ProprietlblEndereco";
            this.ProprietlblEndereco.Size = new System.Drawing.Size(53, 13);
            this.ProprietlblEndereco.TabIndex = 32;
            this.ProprietlblEndereco.Text = "Endereço";
            // 
            // PropriettxbNome
            // 
            this.PropriettxbNome.Location = new System.Drawing.Point(73, 12);
            this.PropriettxbNome.Name = "PropriettxbNome";
            this.PropriettxbNome.Size = new System.Drawing.Size(524, 20);
            this.PropriettxbNome.TabIndex = 31;
            // 
            // ProprietlblNome
            // 
            this.ProprietlblNome.AutoSize = true;
            this.ProprietlblNome.Location = new System.Drawing.Point(32, 15);
            this.ProprietlblNome.Name = "ProprietlblNome";
            this.ProprietlblNome.Size = new System.Drawing.Size(35, 13);
            this.ProprietlblNome.TabIndex = 30;
            this.ProprietlblNome.Text = "Nome";
            // 
            // frmProprietarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 327);
            this.Controls.Add(this.btnImovel);
            this.Controls.Add(this.btnProNovo);
            this.Controls.Add(this.btnProSalvar);
            this.Controls.Add(this.btnProVoltar);
            this.Controls.Add(this.grdProprietario);
            this.Controls.Add(this.PropriettxbCPF);
            this.Controls.Add(this.ProprietlblCPF);
            this.Controls.Add(this.PropriettxbTelefone);
            this.Controls.Add(this.ProprietlblTelefone);
            this.Controls.Add(this.PropriettxbEndereco);
            this.Controls.Add(this.ProprietlblEndereco);
            this.Controls.Add(this.PropriettxbNome);
            this.Controls.Add(this.ProprietlblNome);
            this.MaximizeBox = false;
            this.Name = "frmProprietarios";
            this.Text = "Proprietarios";
            this.Load += new System.EventHandler(this.frmProprietarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProprietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImovel;
        private System.Windows.Forms.Button btnProNovo;
        private System.Windows.Forms.Button btnProSalvar;
        private System.Windows.Forms.Button btnProVoltar;
        private System.Windows.Forms.DataGridView grdProprietario;
        private System.Windows.Forms.TextBox PropriettxbCPF;
        private System.Windows.Forms.Label ProprietlblCPF;
        private System.Windows.Forms.TextBox PropriettxbTelefone;
        private System.Windows.Forms.Label ProprietlblTelefone;
        private System.Windows.Forms.TextBox PropriettxbEndereco;
        private System.Windows.Forms.Label ProprietlblEndereco;
        private System.Windows.Forms.TextBox PropriettxbNome;
        private System.Windows.Forms.Label ProprietlblNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProprietID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProprietNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProprietEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProprietCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProprietTelefone;
        private System.Windows.Forms.DataGridViewButtonColumn ProprietbtnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn ProprietbtnExcluir;
    }
}