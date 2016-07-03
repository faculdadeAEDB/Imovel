namespace Imob.View.Habitation
{
    partial class VisaoGeral
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
            this.btnImoNovo = new System.Windows.Forms.Button();
            this.btnImoSalvar = new System.Windows.Forms.Button();
            this.btnImoVoltar = new System.Windows.Forms.Button();
            this.dgvImo = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImoNovo
            // 
            this.btnImoNovo.Location = new System.Drawing.Point(357, 70);
            this.btnImoNovo.Name = "btnImoNovo";
            this.btnImoNovo.Size = new System.Drawing.Size(75, 23);
            this.btnImoNovo.TabIndex = 41;
            this.btnImoNovo.Text = "Novo";
            this.btnImoNovo.UseVisualStyleBackColor = true;
            // 
            // btnImoSalvar
            // 
            this.btnImoSalvar.Location = new System.Drawing.Point(438, 70);
            this.btnImoSalvar.Name = "btnImoSalvar";
            this.btnImoSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnImoSalvar.TabIndex = 40;
            this.btnImoSalvar.Text = "Salvar";
            this.btnImoSalvar.UseVisualStyleBackColor = true;
            // 
            // btnImoVoltar
            // 
            this.btnImoVoltar.Location = new System.Drawing.Point(519, 69);
            this.btnImoVoltar.Name = "btnImoVoltar";
            this.btnImoVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnImoVoltar.TabIndex = 39;
            this.btnImoVoltar.Text = "Voltar";
            this.btnImoVoltar.UseVisualStyleBackColor = true;
            // 
            // dgvImo
            // 
            this.dgvImo.AllowUserToAddRows = false;
            this.dgvImo.AllowUserToDeleteRows = false;
            this.dgvImo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImo.Location = new System.Drawing.Point(19, 101);
            this.dgvImo.Name = "dgvImo";
            this.dgvImo.ReadOnly = true;
            this.dgvImo.Size = new System.Drawing.Size(575, 212);
            this.dgvImo.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(519, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Casa",
            "Apartamento",
            "Sítio",
            "Chácara",
            "Kitnet"});
            this.comboBox1.Location = new System.Drawing.Point(519, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Tipo";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(318, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 20);
            this.textBox4.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Bairro";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(188, 20);
            this.textBox3.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cidade";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(404, 20);
            this.textBox2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Endereço";
            // 
            // VisaoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 327);
            this.Controls.Add(this.btnImoNovo);
            this.Controls.Add(this.btnImoSalvar);
            this.Controls.Add(this.btnImoVoltar);
            this.Controls.Add(this.dgvImo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Name = "VisaoGeral";
            this.Text = "VisaoGeral";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImoNovo;
        private System.Windows.Forms.Button btnImoSalvar;
        private System.Windows.Forms.Button btnImoVoltar;
        private System.Windows.Forms.DataGridView dgvImo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}