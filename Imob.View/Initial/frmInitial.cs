using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imob.View.Initial
{
    public partial class frmInitial : Form
    {
        public frmInitial()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Imob.View.Customer.frmClientes()).ShowDialog();
            this.Visible = true;
        }

        private void btnProprietarios_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Imob.View.Owner.frmProprietarios()).ShowDialog();
            this.Visible = true;
        }

        private void btnPropriedades_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Imob.View.Habitation.frmPropriedades()).ShowDialog();
            this.Visible = true;
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Imob.View.Payment.frmPagamentos()).ShowDialog();
            this.Visible = true;
        }

        private void btnTaxas_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Imob.View.Fee.frmTaxas()).ShowDialog();
            this.Visible = true;
        }

        private void btnAlguel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new Imob.View.Rent.frmAlgueis()).ShowDialog();
            this.Visible = true;
        }
    }
}
