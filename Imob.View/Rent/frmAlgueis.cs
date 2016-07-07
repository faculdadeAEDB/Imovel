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
