namespace Imob.View.Payment
{
    partial class frmPagamentos
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
            this.btnPagamentosPagar = new System.Windows.Forms.Button();
            this.lblPagamentosData = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPagamentosAluguel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagamentosPagar
            // 
            this.btnPagamentosPagar.Location = new System.Drawing.Point(492, 8);
            this.btnPagamentosPagar.Name = "btnPagamentosPagar";
            this.btnPagamentosPagar.Size = new System.Drawing.Size(106, 23);
            this.btnPagamentosPagar.TabIndex = 0;
            this.btnPagamentosPagar.Text = "Pagar";
            this.btnPagamentosPagar.UseVisualStyleBackColor = true;
            // 
            // lblPagamentosData
            // 
            this.lblPagamentosData.AutoSize = true;
            this.lblPagamentosData.Location = new System.Drawing.Point(22, 13);
            this.lblPagamentosData.Name = "lblPagamentosData";
            this.lblPagamentosData.Size = new System.Drawing.Size(30, 13);
            this.lblPagamentosData.TabIndex = 1;
            this.lblPagamentosData.Text = "Data";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblPagamentosAluguel
            // 
            this.lblPagamentosAluguel.AutoSize = true;
            this.lblPagamentosAluguel.Location = new System.Drawing.Point(201, 13);
            this.lblPagamentosAluguel.Name = "lblPagamentosAluguel";
            this.lblPagamentosAluguel.Size = new System.Drawing.Size(42, 13);
            this.lblPagamentosAluguel.TabIndex = 3;
            this.lblPagamentosAluguel.Text = "Aluguel";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.paymentBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataSource = typeof(Imob.Site.Models.Payment);
            // 
            // frmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 52);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPagamentosAluguel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPagamentosData);
            this.Controls.Add(this.btnPagamentosPagar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPagamentos";
            this.Text = "Pagamentos";
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagamentosPagar;
        private System.Windows.Forms.Label lblPagamentosData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPagamentosAluguel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource paymentBindingSource;
    }
}