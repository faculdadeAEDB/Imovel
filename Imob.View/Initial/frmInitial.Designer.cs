namespace Imob.View.Initial
{
    partial class frmInitial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInitial));
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProprietarios = new System.Windows.Forms.Button();
            this.btnPropriedades = new System.Windows.Forms.Button();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.btnTaxas = new System.Windows.Forms.Button();
            this.btnAlguel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            resources.ApplyResources(this.btnClientes, "btnClientes");
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProprietarios
            // 
            resources.ApplyResources(this.btnProprietarios, "btnProprietarios");
            this.btnProprietarios.Name = "btnProprietarios";
            this.btnProprietarios.UseVisualStyleBackColor = true;
            this.btnProprietarios.Click += new System.EventHandler(this.btnProprietarios_Click);
            // 
            // btnPropriedades
            // 
            resources.ApplyResources(this.btnPropriedades, "btnPropriedades");
            this.btnPropriedades.Name = "btnPropriedades";
            this.btnPropriedades.UseVisualStyleBackColor = true;
            this.btnPropriedades.Click += new System.EventHandler(this.btnPropriedades_Click);
            // 
            // btnPagamentos
            // 
            resources.ApplyResources(this.btnPagamentos, "btnPagamentos");
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.UseVisualStyleBackColor = true;
            this.btnPagamentos.Click += new System.EventHandler(this.btnPagamentos_Click);
            // 
            // btnTaxas
            // 
            resources.ApplyResources(this.btnTaxas, "btnTaxas");
            this.btnTaxas.Name = "btnTaxas";
            this.btnTaxas.UseVisualStyleBackColor = true;
            this.btnTaxas.Click += new System.EventHandler(this.btnTaxas_Click);
            // 
            // btnAlguel
            // 
            resources.ApplyResources(this.btnAlguel, "btnAlguel");
            this.btnAlguel.Name = "btnAlguel";
            this.btnAlguel.UseVisualStyleBackColor = true;
            this.btnAlguel.Click += new System.EventHandler(this.btnAlguel_Click);
            // 
            // frmInitial
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAlguel);
            this.Controls.Add(this.btnTaxas);
            this.Controls.Add(this.btnPagamentos);
            this.Controls.Add(this.btnPropriedades);
            this.Controls.Add(this.btnProprietarios);
            this.Controls.Add(this.btnClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInitial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProprietarios;
        private System.Windows.Forms.Button btnPropriedades;
        private System.Windows.Forms.Button btnPagamentos;
        private System.Windows.Forms.Button btnTaxas;
        private System.Windows.Forms.Button btnAlguel;
    }
}