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
    public partial class frmRelatorio_Algueis : Form
    {
        decimal contadorvalor = 0;
        int contadoralugueis = 0;
        public frmRelatorio_Algueis()
        {
            InitializeComponent();
        }

        private void btnPagamentosVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAlgueis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Cadastro de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    dgvAlugueis.Rows.RemoveAt(e.RowIndex);
                    Contando_Alugueis();
                    Contando_Valores();
                }

            }
        }

        private void frmRelatorio_Algueis_Load(object sender, EventArgs e)
        {
            Atualizando_grids();
            Contando_Alugueis();
            Contando_Valores();
        }

        private void Contando_Valores()
        {
            contadorvalor = 0;
            foreach (var item in (new AluguelController.AluguelControllerClient()).Obter().ToList())
            {
                contadorvalor =+ item.Valor;
            }
            txbAlgueisTotalValor.Text = contadorvalor.ToString();
        }

        private void Contando_Alugueis()
        {
            contadoralugueis = 0;
            foreach(var item in (new AluguelController.AluguelControllerClient()).Obter().ToList())
            {
                contadoralugueis = contadoralugueis + 1;
            }
            txbAlugueisTotalAlugueis.Text = contadoralugueis.ToString();
        }

        private void Atualizando_grids()
        {
            foreach (var item in (new AluguelController.AluguelControllerClient()).Obter().ToList())
            {
                dgvAlugueis.Rows.Add(
                    item.ID,
                    item.Inquilino,
                    item.Dono,
                    item.DataInicio,
                    item.DataFim,
                    item.Valor
                );
            }
        }
    }
}
