namespace Imob.View.Initial
{
    partial class Iniciar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciar));
            this.btnInitialClientes = new System.Windows.Forms.Button();
            this.btnInitialProprietarios = new System.Windows.Forms.Button();
            this.btnInitialPropriedades = new System.Windows.Forms.Button();
            this.btnInitialPagamentos = new System.Windows.Forms.Button();
            this.btnInitialAlguel = new System.Windows.Forms.Button();
            this.lblRelatorios = new System.Windows.Forms.Label();
            this.btnRelatorioAlugueis = new System.Windows.Forms.Button();
            this.btnRelatorioPagamentos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInitialClientes
            // 
            resources.ApplyResources(this.btnInitialClientes, "btnInitialClientes");
            this.btnInitialClientes.Name = "btnInitialClientes";
            this.btnInitialClientes.UseVisualStyleBackColor = true;
            this.btnInitialClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnInitialProprietarios
            // 
            resources.ApplyResources(this.btnInitialProprietarios, "btnInitialProprietarios");
            this.btnInitialProprietarios.Name = "btnInitialProprietarios";
            this.btnInitialProprietarios.UseVisualStyleBackColor = true;
            this.btnInitialProprietarios.Click += new System.EventHandler(this.btnProprietarios_Click);
            // 
            // btnInitialPropriedades
            // 
            resources.ApplyResources(this.btnInitialPropriedades, "btnInitialPropriedades");
            this.btnInitialPropriedades.Name = "btnInitialPropriedades";
            this.btnInitialPropriedades.UseVisualStyleBackColor = true;
            this.btnInitialPropriedades.Click += new System.EventHandler(this.btnPropriedades_Click);
            // 
            // btnInitialPagamentos
            // 
            resources.ApplyResources(this.btnInitialPagamentos, "btnInitialPagamentos");
            this.btnInitialPagamentos.Name = "btnInitialPagamentos";
            this.btnInitialPagamentos.UseVisualStyleBackColor = true;
            this.btnInitialPagamentos.Click += new System.EventHandler(this.btnPagamentos_Click);
            // 
            // btnInitialAlguel
            // 
            resources.ApplyResources(this.btnInitialAlguel, "btnInitialAlguel");
            this.btnInitialAlguel.Name = "btnInitialAlguel";
            this.btnInitialAlguel.UseVisualStyleBackColor = true;
            this.btnInitialAlguel.Click += new System.EventHandler(this.btnAlguel_Click);
            // 
            // lblRelatorios
            // 
            resources.ApplyResources(this.lblRelatorios, "lblRelatorios");
            this.lblRelatorios.Name = "lblRelatorios";
            // 
            // btnRelatorioAlugueis
            // 
            resources.ApplyResources(this.btnRelatorioAlugueis, "btnRelatorioAlugueis");
            this.btnRelatorioAlugueis.Name = "btnRelatorioAlugueis";
            this.btnRelatorioAlugueis.UseVisualStyleBackColor = true;
            this.btnRelatorioAlugueis.Click += new System.EventHandler(this.btnRelatorioAlugueis_Click);
            // 
            // btnRelatorioPagamentos
            // 
            resources.ApplyResources(this.btnRelatorioPagamentos, "btnRelatorioPagamentos");
            this.btnRelatorioPagamentos.Name = "btnRelatorioPagamentos";
            this.btnRelatorioPagamentos.UseVisualStyleBackColor = true;
            this.btnRelatorioPagamentos.Click += new System.EventHandler(this.btnRelatorioPagamentos_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Iniciar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelatorioPagamentos);
            this.Controls.Add(this.btnRelatorioAlugueis);
            this.Controls.Add(this.lblRelatorios);
            this.Controls.Add(this.btnInitialAlguel);
            this.Controls.Add(this.btnInitialPagamentos);
            this.Controls.Add(this.btnInitialPropriedades);
            this.Controls.Add(this.btnInitialProprietarios);
            this.Controls.Add(this.btnInitialClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Iniciar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInitialClientes;
        private System.Windows.Forms.Button btnInitialProprietarios;
        private System.Windows.Forms.Button btnInitialPropriedades;
        private System.Windows.Forms.Button btnInitialPagamentos;
        private System.Windows.Forms.Button btnInitialAlguel;
        private System.Windows.Forms.Label lblRelatorios;
        private System.Windows.Forms.Button btnRelatorioAlugueis;
        private System.Windows.Forms.Button btnRelatorioPagamentos;
        private System.Windows.Forms.Label label1;
    }
}