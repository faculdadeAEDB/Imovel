using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Imob.View.Rent
{
    public partial class frmAlgueis : Form
    {
        public frmAlgueis()
        {
            InitializeComponent();
        }

        private void Rent_Load(object sender, EventArgs e)
        {

        }

        private void Cosdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Cosdgv.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex == 6)
                {

                }
                if (e.ColumnIndex == 7)
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Cadastro de Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Cosdgv.Rows.RemoveAt(e.RowIndex);
                    }

                }
            }
        }

        private void frmAlgueis_Load(object sender, EventArgs e)
        {
            foreach (var item in (new PropriedadeController.PropriedadeControllerClient()).Obter().ToList())
            {
                dgvImoveis.Rows.Add(
                    item.ID,
                    item.Endereco,
                    item.Tipo
                );
            }
        }

        private void rentBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvImoveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvImoveis.Rows[e.RowIndex].DataBoundItem != null || true)
            {
                if (e.ColumnIndex == 3)
                {

                }
                if (e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Cadastro de Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        dgvImoveis.Rows.RemoveAt(e.RowIndex);
                    }

                }
            }
        }
    }
}
