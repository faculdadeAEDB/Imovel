using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imob.View.Payment
{
    public partial class frmPagamentos : Form
    {
        public frmPagamentos()
        {
            InitializeComponent();
        }

        private void frmPagamentos_Load(object sender, EventArgs e)
        {
            AluguelController.AluguelControllerClient aluguel = new AluguelController.AluguelControllerClient();
            foreach (var item in aluguel.ObterIdEInquilinos())
            {
                cbxPagamentosAluguel.Items.Add(item);
            }
        }

        private void btnPagamentosPagar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
