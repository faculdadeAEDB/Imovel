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
            this.components = new System.ComponentModel.Container();
            this.PropriedbtnNovo = new System.Windows.Forms.Button();
            this.PropriedbtnSalvar = new System.Windows.Forms.Button();
            this.PropriedbtnVoltar = new System.Windows.Forms.Button();
            this.Proprieddgv = new System.Windows.Forms.DataGridView();
            this.PropiedtxbID = new System.Windows.Forms.TextBox();
            this.PropiedlvlID = new System.Windows.Forms.Label();
            this.PropiedcbxTipo = new System.Windows.Forms.ComboBox();
            this.PropiedlvlTipo = new System.Windows.Forms.Label();
            this.PropriedtxbEndereco = new System.Windows.Forms.TextBox();
            this.PropiedlvlEndereco = new System.Windows.Forms.Label();
            this.habitationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Proprieddgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PropriedbtnNovo
            // 
            this.PropriedbtnNovo.Location = new System.Drawing.Point(357, 41);
            this.PropriedbtnNovo.Name = "PropriedbtnNovo";
            this.PropriedbtnNovo.Size = new System.Drawing.Size(75, 23);
            this.PropriedbtnNovo.TabIndex = 41;
            this.PropriedbtnNovo.Text = "Novo";
            this.PropriedbtnNovo.UseVisualStyleBackColor = true;
            this.PropriedbtnNovo.Click += new System.EventHandler(this.PropriedbtnNovo_Click);
            // 
            // PropriedbtnSalvar
            // 
            this.PropriedbtnSalvar.Location = new System.Drawing.Point(438, 41);
            this.PropriedbtnSalvar.Name = "PropriedbtnSalvar";
            this.PropriedbtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.PropriedbtnSalvar.TabIndex = 40;
            this.PropriedbtnSalvar.Text = "Salvar";
            this.PropriedbtnSalvar.UseVisualStyleBackColor = true;
            this.PropriedbtnSalvar.Click += new System.EventHandler(this.PropriedbtnSalvar_Click);
            // 
            // PropriedbtnVoltar
            // 
            this.PropriedbtnVoltar.Location = new System.Drawing.Point(519, 40);
            this.PropriedbtnVoltar.Name = "PropriedbtnVoltar";
            this.PropriedbtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.PropriedbtnVoltar.TabIndex = 39;
            this.PropriedbtnVoltar.Text = "Voltar";
            this.PropriedbtnVoltar.UseVisualStyleBackColor = true;
            this.PropriedbtnVoltar.Click += new System.EventHandler(this.PropriedbtnVoltar_Click);
            // 
            // Proprieddgv
            // 
            this.Proprieddgv.AllowUserToAddRows = false;
            this.Proprieddgv.AllowUserToDeleteRows = false;
            this.Proprieddgv.AutoGenerateColumns = false;
            this.Proprieddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Proprieddgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.donoDataGridViewTextBoxColumn});
            this.Proprieddgv.DataSource = this.habitationBindingSource;
            this.Proprieddgv.Location = new System.Drawing.Point(19, 70);
            this.Proprieddgv.Name = "Proprieddgv";
            this.Proprieddgv.ReadOnly = true;
            this.Proprieddgv.Size = new System.Drawing.Size(575, 243);
            this.Proprieddgv.TabIndex = 38;
            // 
            // PropiedtxbID
            // 
            this.PropiedtxbID.Location = new System.Drawing.Point(406, 13);
            this.PropiedtxbID.Name = "PropiedtxbID";
            this.PropiedtxbID.ReadOnly = true;
            this.PropiedtxbID.Size = new System.Drawing.Size(75, 20);
            this.PropiedtxbID.TabIndex = 37;
            // 
            // PropiedlvlID
            // 
            this.PropiedlvlID.AutoSize = true;
            this.PropiedlvlID.Location = new System.Drawing.Point(382, 17);
            this.PropiedlvlID.Name = "PropiedlvlID";
            this.PropiedlvlID.Size = new System.Drawing.Size(18, 13);
            this.PropiedlvlID.TabIndex = 36;
            this.PropiedlvlID.Text = "ID";
            // 
            // PropiedcbxTipo
            // 
            this.PropiedcbxTipo.FormattingEnabled = true;
            this.PropiedcbxTipo.Items.AddRange(new object[] {
            "Casa",
            "Apartamento",
            "Sítio",
            "Chácara",
            "Kitnet"});
            this.PropiedcbxTipo.Location = new System.Drawing.Point(519, 13);
            this.PropiedcbxTipo.Name = "PropiedcbxTipo";
            this.PropiedcbxTipo.Size = new System.Drawing.Size(75, 21);
            this.PropiedcbxTipo.TabIndex = 35;
            // 
            // PropiedlvlTipo
            // 
            this.PropiedlvlTipo.AutoSize = true;
            this.PropiedlvlTipo.Location = new System.Drawing.Point(485, 16);
            this.PropiedlvlTipo.Name = "PropiedlvlTipo";
            this.PropiedlvlTipo.Size = new System.Drawing.Size(28, 13);
            this.PropiedlvlTipo.TabIndex = 34;
            this.PropiedlvlTipo.Text = "Tipo";
            // 
            // PropriedtxbEndereco
            // 
            this.PropriedtxbEndereco.Location = new System.Drawing.Point(75, 13);
            this.PropriedtxbEndereco.Name = "PropriedtxbEndereco";
            this.PropriedtxbEndereco.Size = new System.Drawing.Size(301, 20);
            this.PropriedtxbEndereco.TabIndex = 29;
            // 
            // PropiedlvlEndereco
            // 
            this.PropiedlvlEndereco.AutoSize = true;
            this.PropiedlvlEndereco.Location = new System.Drawing.Point(16, 16);
            this.PropiedlvlEndereco.Name = "PropiedlvlEndereco";
            this.PropiedlvlEndereco.Size = new System.Drawing.Size(53, 13);
            this.PropiedlvlEndereco.TabIndex = 28;
            this.PropiedlvlEndereco.Text = "Endereço";
            // 
            // habitationBindingSource
            // 
            this.habitationBindingSource.DataSource = typeof(Imob.Site.Models.Habitation);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donoDataGridViewTextBoxColumn
            // 
            this.donoDataGridViewTextBoxColumn.DataPropertyName = "Dono";
            this.donoDataGridViewTextBoxColumn.HeaderText = "Dono";
            this.donoDataGridViewTextBoxColumn.Name = "donoDataGridViewTextBoxColumn";
            this.donoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmPropriedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 327);
            this.Controls.Add(this.PropriedbtnNovo);
            this.Controls.Add(this.PropriedbtnSalvar);
            this.Controls.Add(this.PropriedbtnVoltar);
            this.Controls.Add(this.Proprieddgv);
            this.Controls.Add(this.PropiedtxbID);
            this.Controls.Add(this.PropiedlvlID);
            this.Controls.Add(this.PropiedcbxTipo);
            this.Controls.Add(this.PropiedlvlTipo);
            this.Controls.Add(this.PropriedtxbEndereco);
            this.Controls.Add(this.PropiedlvlEndereco);
            this.Name = "frmPropriedades";
            this.Text = "Propriedades";
            this.Load += new System.EventHandler(this.PropiedcbxID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Proprieddgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PropriedbtnNovo;
        private System.Windows.Forms.Button PropriedbtnSalvar;
        private System.Windows.Forms.Button PropriedbtnVoltar;
        private System.Windows.Forms.DataGridView Proprieddgv;
        private System.Windows.Forms.TextBox PropiedtxbID;
        private System.Windows.Forms.Label PropiedlvlID;
        private System.Windows.Forms.ComboBox PropiedcbxTipo;
        private System.Windows.Forms.Label PropiedlvlTipo;
        private System.Windows.Forms.TextBox PropriedtxbEndereco;
        private System.Windows.Forms.Label PropiedlvlEndereco;
        private System.Windows.Forms.BindingSource habitationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donoDataGridViewTextBoxColumn;
    }
}