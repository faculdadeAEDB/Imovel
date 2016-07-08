using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imob.View.Report
{
    public partial class frmRelatorio_Pagamentos : Form
    {
        decimal contadorvalor = 0;
        int contadorPagamentos = 0;
        public frmRelatorio_Pagamentos()
        {
            InitializeComponent();
        }

        private void btnPagamentosVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPagamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Cadastro de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    dgvPagamentos.Rows.RemoveAt(e.RowIndex);
                    Contando_Pagamentos();
                    Contando_Valores();
                }

            }
        }

        private void frmRelatorio_Pagamentos_Load(object sender, EventArgs e)
        {
            Contando_Pagamentos();
            Contando_Valores();
        }

        private void Contando_Valores()
        {
            contadorvalor = 0;
            foreach (var item in (new PagamentoController.PagamentoControllerClient()).Obter().ToList())
            {
                contadorvalor = +item.Alguel.Valor;
            }
            txbPagamentosTotalValor.Text = contadorvalor.ToString();
        }

        private void Contando_Pagamentos()
        {
            contadorPagamentos = 0;
            foreach (var item in (new PagamentoController.PagamentoControllerClient()).Obter().ToList())
            {
                contadorPagamentos = contadorPagamentos + 1;
            }
            txbPagamentosTotalPagamentos.Text = contadorPagamentos.ToString();
        }
    }
}
