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

        private void Cosdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbAlgueisCliente.Text = dgvAlgueisClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        public void Atualizando_grids()
        {
            foreach (var item in (new PropriedadeController.PropriedadeControllerClient()).Obter().ToList())
            {
                dgvAlgueisImoveis.Rows.Add(
                    item.ID,
                    item.Endereco,
                    item.Tipo
                );
            }

            foreach (var item in (new ClienteController.ClienteControllerClient()).Obter().ToList())
            {
                dgvAlgueisClientes.Rows.Add(
                    item.ID,
                    item.Nome,
                    item.Idade,
                    item.Endereco,
                    item.Telefone,
                    item.cpf
                );
            }

        }

        private void frmAlgueis_Load(object sender, EventArgs e)
        {
            Atualizando_grids();
        }

        private void dgvImoveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbAlgueisImovel_ID.Text = dgvAlgueisImoveis.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbAlgueisImovel_Endereco.Text = dgvAlgueisImoveis.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnProVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProNovo_Click(object sender, EventArgs e)
        {
            txbAlgueisCliente.Text = "";
            txbAlgueisImovel_Endereco.Text = "";
            txbAlgueisImovel_ID.Text = "";
            txbAlgueisProprietario.Text = "";
            txbAlgueisValor.Text = "";

        }
    }
}
