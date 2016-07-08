using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imob.View.ClienteController;

namespace Imob.View.Customer
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            Atualizando_datagrid();
        }

        public void Atualizando_datagrid()
        {
            foreach (var item in (new ClienteController.ClienteControllerClient()).Obter().ToList())
            {
                dgvClientes.Rows.Add(
                    item.ID,
                    item.Nome,
                    item.Idade,
                    item.Endereco,
                    item.Telefone,
                    item.cpf
                );
            }
        }

        public void Atualizando_datagrid(Site.Models.Customer cliente)
        {
            dgvClientes.Rows.Add(
                cliente.ID,
                cliente.Nome,
                cliente.Idade,
                cliente.Endereco,
                cliente.Telefone,
                cliente.cpf
            );
        }

        private void CosbtnSalvar_Click(object sender, EventArgs e)
        {
            Site.Models.Customer c = new Site.Models.Customer();
            c.Nome = txbClientesNome.Text;
            c.Endereco = txbClientesEndereco.Text;
            c.Telefone = txbClientesTelefone.Text;
            c.Idade = txbClientesIdade.Text;
            c.cpf = Convert.ToInt32(txbClientesCPF.Text);
            Site.Models.Customer cliente = (new ClienteControllerClient()).Salvar(c);
            Atualizando_datagrid(cliente);
        }

        private void CosbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cosdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Rows[e.RowIndex].DataBoundItem != null || true)
            {
                if (e.ColumnIndex == 6)
                {
                    txbClientesNome.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txbClientesIdade.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txbClientesEndereco.Text = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txbClientesTelefone.Text = dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txbClientesCPF.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                if (e.ColumnIndex == 7)
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Cadastro de Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        dgvClientes.Rows.RemoveAt(e.RowIndex);
                    }

                }
            }
        }

        private void btnClientesNovo_Click(object sender, EventArgs e)
        {
            txbClientesCPF.Text = "";
            txbClientesEndereco.Text = "";
            txbClientesIdade.Text = "";
            txbClientesNome.Text = "";
            txbClientesTelefone.Text = "";
        }
    }
}
