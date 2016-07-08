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
        private int editandoId = 0;

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
            dgvClientes.Rows.Clear();
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

            dgvClientes.Update();
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
            if (verificarcampos())
            {
                Site.Models.Customer c = new Site.Models.Customer();
                c.Nome = txbClientesNome.Text;
                c.Endereco = txbClientesEndereco.Text;
                c.Telefone = txbClientesTelefone.Text;
                c.Idade = txbClientesIdade.Text;
                c.cpf = Convert.ToInt32(txbClientesCPF.Text);

                if (editandoId != 0)
                {
                    c.ID = editandoId;
                    Site.Models.Customer cliente = (new ClienteControllerClient()).Editar(c);
                    Atualizando_datagrid();
                }
                else
                {
                    Site.Models.Customer cliente = (new ClienteControllerClient()).Salvar(c);
                    Atualizando_datagrid(cliente);
                }

                editandoId = 0;
                resetarCampos();
            }
            else
                MessageBox.Show("Nem todos os campos foram preenchidos", "Campos Incorretos");

        }

        private bool verificarcampos()
        {
            if (txbClientesCPF.Text.Trim() != "" && txbClientesEndereco.Text.Trim() != "" && txbClientesIdade.Text.Trim() != "" && txbClientesNome.Text.Trim() != "" && txbClientesTelefone.Text.Trim() != "")
            {
               return(true);
            }
                return (false);

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
                    editandoId = Convert.ToInt16(dgvClientes.Rows[0].Cells[0].Value);
                    txbClientesNome.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txbClientesIdade.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txbClientesEndereco.Text = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txbClientesTelefone.Text = dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txbClientesCPF.Text = dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
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
            resetarCampos();
        }

        private void resetarCampos()
        {
            txbClientesCPF.Text = "";
            txbClientesEndereco.Text = "";
            txbClientesIdade.Text = "";
            txbClientesNome.Text = "";
            txbClientesTelefone.Text = "";
            editandoId = 0;
        }
    }
}
