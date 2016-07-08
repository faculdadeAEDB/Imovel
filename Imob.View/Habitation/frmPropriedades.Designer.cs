namespace Imob.View.Habitation
{
    partial class frmPropriedades
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
            this.btnPropriedadesResetar = new System.Windows.Forms.Button();
            this.btnPropriedadesSalvar = new System.Windows.Forms.Button();
            this.btnPropriedadesVoltar = new System.Windows.Forms.Button();
            this.txbPropriedadesID = new System.Windows.Forms.TextBox();
            this.lblPropiedadesID = new System.Windows.Forms.Label();
            this.cbxPropriedadesTipo = new System.Windows.Forms.ComboBox();
            this.lvlPropiedadesTipo = new System.Windows.Forms.Label();
            this.txbPropriedadesEndereco = new System.Windows.Forms.TextBox();
            this.lblPropriedadesEndereco = new System.Windows.Forms.Label();
            this.dgvPropriedades = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropriedbtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PropriedbtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txbPropriedadesDono = new System.Windows.Forms.TextBox();
            this.lblPropriedadesDono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropriedades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPropriedadesResetar
            // 
            this.btnPropriedadesResetar.Location = new System.Drawing.Point(357, 41);
            this.btnPropriedadesResetar.Name = "btnPropriedadesResetar";
            this.btnPropriedadesResetar.Size = new System.Drawing.Size(75, 23);
            this.btnPropriedadesResetar.TabIndex = 41;
            this.btnPropriedadesResetar.Text = "Resetar";
            this.btnPropriedadesResetar.UseVisualStyleBackColor = true;
            this.btnPropriedadesResetar.Click += new System.EventHandler(this.PropriedbtnNovo_Click);
            // 
            // btnPropriedadesSalvar
            // 
            this.btnPropriedadesSalvar.Location = new System.Drawing.Point(438, 41);
            this.btnPropriedadesSalvar.Name = "btnPropriedadesSalvar";
            this.btnPropriedadesSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnPropriedadesSalvar.TabIndex = 40;
            this.btnPropriedadesSalvar.Text = "Salvar";
            this.btnPropriedadesSalvar.UseVisualStyleBackColor = true;
            this.btnPropriedadesSalvar.Click += new System.EventHandler(this.PropriedbtnSalvar_Click);
            // 
            // btnPropriedadesVoltar
            // 
            this.btnPropriedadesVoltar.Location = new System.Drawing.Point(519, 40);
            this.btnPropriedadesVoltar.Name = "btnPropriedadesVoltar";
            this.btnPropriedadesVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnPropriedadesVoltar.TabIndex = 39;
            this.btnPropriedadesVoltar.Text = "Voltar";
            this.btnPropriedadesVoltar.UseVisualStyleBackColor = true;
            this.btnPropriedadesVoltar.Click += new System.EventHandler(this.PropriedbtnVoltar_Click);
            // 
            // txbPropriedadesID
            // 
            this.txbPropriedadesID.Location = new System.Drawing.Point(406, 13);
            this.txbPropriedadesID.Name = "txbPropriedadesID";
            this.txbPropriedadesID.ReadOnly = true;
            this.txbPropriedadesID.Size = new System.Drawing.Size(75, 20);
            this.txbPropriedadesID.TabIndex = 37;
            // 
            // lblPropiedadesID
            // 
            this.lblPropiedadesID.AutoSize = true;
            this.lblPropiedadesID.Location = new System.Drawing.Point(382, 17);
            this.lblPropiedadesID.Name = "lblPropiedadesID";
            this.lblPropiedadesID.Size = new System.Drawing.Size(18, 13);
            this.lblPropiedadesID.TabIndex = 36;
            this.lblPropiedadesID.Text = "ID";
            // 
            // cbxPropriedadesTipo
            // 
            this.cbxPropriedadesTipo.FormattingEnabled = true;
            this.cbxPropriedadesTipo.Items.AddRange(new object[] {
            "Casa",
            "Apartamento",
            "Sítio",
            "Chácara",
            "Kitnet"});
            this.cbxPropriedadesTipo.Location = new System.Drawing.Point(519, 13);
            this.cbxPropriedadesTipo.Name = "cbxPropriedadesTipo";
            this.cbxPropriedadesTipo.Size = new System.Drawing.Size(75, 21);
            this.cbxPropriedadesTipo.TabIndex = 35;
            // 
            // lvlPropiedadesTipo
            // 
            this.lvlPropiedadesTipo.AutoSize = true;
            this.lvlPropiedadesTipo.Location = new System.Drawing.Point(485, 16);
            this.lvlPropiedadesTipo.Name = "lvlPropiedadesTipo";
            this.lvlPropiedadesTipo.Size = new System.Drawing.Size(28, 13);
            this.lvlPropiedadesTipo.TabIndex = 34;
            this.lvlPropiedadesTipo.Text = "Tipo";
            // 
            // txbPropriedadesEndereco
            // 
            this.txbPropriedadesEndereco.Location = new System.Drawing.Point(75, 13);
            this.txbPropriedadesEndereco.Name = "txbPropriedadesEndereco";
            this.txbPropriedadesEndereco.Size = new System.Drawing.Size(301, 20);
            this.txbPropriedadesEndereco.TabIndex = 29;
            // 
            // lblPropriedadesEndereco
            // 
            this.lblPropriedadesEndereco.AutoSize = true;
            this.lblPropriedadesEndereco.Location = new System.Drawing.Point(16, 16);
            this.lblPropriedadesEndereco.Name = "lblPropriedadesEndereco";
            this.lblPropriedadesEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblPropriedadesEndereco.TabIndex = 28;
            this.lblPropriedadesEndereco.Text = "Endereço";
            // 
            // dgvPropriedades
            // 
            this.dgvPropriedades.AllowUserToAddRows = false;
            this.dgvPropriedades.AllowUserToDeleteRows = false;
            this.dgvPropriedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPropriedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropriedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Endereco,
            this.Tipo,
            this.PropriedbtnEditar,
            this.PropriedbtnExcluir});
            this.dgvPropriedades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPropriedades.Location = new System.Drawing.Point(19, 78);
            this.dgvPropriedades.MultiSelect = false;
            this.dgvPropriedades.Name = "dgvPropriedades";
            this.dgvPropriedades.ReadOnly = true;
            this.dgvPropriedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPropriedades.Size = new System.Drawing.Size(575, 237);
            this.dgvPropriedades.TabIndex = 42;
            this.dgvPropriedades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropriedades_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Endereco
            // 
            this.Endereco.HeaderText = "Endereço";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // PropriedbtnEditar
            // 
            this.PropriedbtnEditar.HeaderText = "Editar";
            this.PropriedbtnEditar.Name = "PropriedbtnEditar";
            this.PropriedbtnEditar.ReadOnly = true;
            this.PropriedbtnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PropriedbtnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PropriedbtnExcluir
            // 
            this.PropriedbtnExcluir.HeaderText = "Excluir";
            this.PropriedbtnExcluir.Name = "PropriedbtnExcluir";
            this.PropriedbtnExcluir.ReadOnly = true;
            this.PropriedbtnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PropriedbtnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txbPropriedadesDono
            // 
            this.txbPropriedadesDono.Location = new System.Drawing.Point(55, 43);
            this.txbPropriedadesDono.Name = "txbPropriedadesDono";
            this.txbPropriedadesDono.Size = new System.Drawing.Size(259, 20);
            this.txbPropriedadesDono.TabIndex = 44;
            // 
            // lblPropriedadesDono
            // 
            this.lblPropriedadesDono.AutoSize = true;
            this.lblPropriedadesDono.Location = new System.Drawing.Point(16, 45);
            this.lblPropriedadesDono.Name = "lblPropriedadesDono";
            this.lblPropriedadesDono.Size = new System.Drawing.Size(33, 13);
            this.lblPropriedadesDono.TabIndex = 43;
            this.lblPropriedadesDono.Text = "Dono";
            // 
            // frmPropriedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 327);
            this.Controls.Add(this.txbPropriedadesDono);
            this.Controls.Add(this.lblPropriedadesDono);
            this.Controls.Add(this.dgvPropriedades);
            this.Controls.Add(this.btnPropriedadesResetar);
            this.Controls.Add(this.btnPropriedadesSalvar);
            this.Controls.Add(this.btnPropriedadesVoltar);
            this.Controls.Add(this.txbPropriedadesID);
            this.Controls.Add(this.lblPropiedadesID);
            this.Controls.Add(this.cbxPropriedadesTipo);
            this.Controls.Add(this.lvlPropiedadesTipo);
            this.Controls.Add(this.txbPropriedadesEndereco);
            this.Controls.Add(this.lblPropriedadesEndereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPropriedades";
            this.Text = "Propriedades";
            this.Load += new System.EventHandler(this.PropiedcbxID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropriedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPropriedadesResetar;
        private System.Windows.Forms.Button btnPropriedadesSalvar;
        private System.Windows.Forms.Button btnPropriedadesVoltar;
        private System.Windows.Forms.TextBox txbPropriedadesID;
        private System.Windows.Forms.Label lblPropiedadesID;
        private System.Windows.Forms.ComboBox cbxPropriedadesTipo;
        private System.Windows.Forms.Label lvlPropiedadesTipo;
        private System.Windows.Forms.TextBox txbPropriedadesEndereco;
        private System.Windows.Forms.Label lblPropriedadesEndereco;
        private System.Windows.Forms.DataGridView dgvPropriedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewButtonColumn PropriedbtnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn PropriedbtnExcluir;
        private System.Windows.Forms.TextBox txbPropriedadesDono;
        private System.Windows.Forms.Label lblPropriedadesDono;
    }
}