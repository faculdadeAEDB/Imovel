using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imob.View.PropriedadeController;
using Imob.View.ProprietarioController;
using Imob.View.AluguelController;

namespace Imob.View.Habitation
{
    public partial class frmPropriedades : Form
    {
        public frmPropriedades()
        {
            InitializeComponent();
        }

        private void PropriedbtnNovo_Click(object sender, EventArgs e)
        {
            txbPropriedadesEndereco.Text = "";
            txbPropriedadesID.Text = "";
            cbxPropriedadesTipo.Text = "";

        }

        private void PropriedbtnSalvar_Click(object sender, EventArgs e)
        {
             Imob.Site.Models.Habitation c = new Imob.Site.Models.Habitation();
             c.Endereco = txbPropriedadesEndereco.Text;
            c.Tipo = cbxPropriedadesTipo.Text;
             (new PropriedadeController.PropriedadeControllerClient()).Editar(c);
            Atualizando_datagrid();
        }

        private void PropriedbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PropiedcbxID_Load(object sender, EventArgs e)
        {
            Atualizando_datagrid();
        }

        public void Atualizando_datagrid()
        {
            foreach (var item in (new PropriedadeController.PropriedadeControllerClient()).Obter().ToList())
            {
                dgvPropriedades.Rows.Add(
                    item.ID,
                    item.Tipo
                );
            }
        }

        private void dgvPropriedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPropriedades.Rows[e.RowIndex].DataBoundItem != null || true)
            {
                if (e.ColumnIndex == 3)
                {

                }
                if (e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Cadastro de Propriedades", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        dgvPropriedades.Rows.RemoveAt(e.RowIndex);
                    }

                }
            }
        }
    }
}
