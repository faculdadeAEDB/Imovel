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
                }

            }
        }
    }
}
