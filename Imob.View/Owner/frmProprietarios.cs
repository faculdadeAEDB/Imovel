using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imob.View.Habitation;
using Imob.View.ClienteController;

namespace Imob.View.Owner
{
    public partial class frmProprietarios : Form
    {
        public frmProprietarios()
        {
            InitializeComponent();
        }

        private void btnImovel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmProprietarios()).ShowDialog();
            this.Visible = true;
        }

        private void btnProNovo_Click(object sender, EventArgs e)
        {
            txbProprietariosCPF.Text = "";
            txbProprietariosEndereco.Text = "";
            txbProprietariosNome.Text = "";
            txbProprietariosTelefone.Text = "";
        }

        private void btnProSalvar_Click(object sender, EventArgs e)
        {
            Imob.Site.Models.Owner c = new Imob.Site.Models.Owner();
            c.Nome = txbProprietariosNome.Text;
            c.Endereco = txbProprietariosEndereco.Text;
            c.Telefone = txbProprietariosTelefone.Text;
            c.CPF = txbProprietariosCPF.Text;

            (new ProprietarioController.ProprietarioControllerClient()).Editar(c);

            Atualizando_datagrid();
        }

        private void btnProVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProprietarios_Load(object sender, EventArgs e)
        {
            Atualizando_datagrid();
        }

        public void Atualizando_datagrid()
        {
            dgvProprietarios.Rows.Clear();
            var c = (new ProprietarioController.ProprietarioControllerClient()).Obter();

            foreach (var item in c.ToList())
            {
                dgvProprietarios.Rows.Add(
                    item.ID,
                    item.Nome,
                    item.Endereco,
                    item.CPF,
                    item.Telefone
                );
            }
            dgvProprietarios.Update();
        }

        private void dgvProprietarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProprietarios.Rows[e.RowIndex].DataBoundItem != null || true)
            {
                if (e.ColumnIndex == 3)
                {

                }
                if (e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Cadastro de Proprietario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        dgvProprietarios.Rows.RemoveAt(e.RowIndex);
                    }

                }
            }
        }
    }
}
