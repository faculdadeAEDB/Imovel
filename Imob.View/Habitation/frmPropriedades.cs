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
        private int editandoID = 0;
        public frmPropriedades()
        {
            InitializeComponent();
        }

        private void PropriedbtnNovo_Click(object sender, EventArgs e)
        {
            resetarCampos();
        }

        private void resetarCampos()
        {
            txbPropriedadesEndereco.Text = "";
            txbPropriedadesID.Text = "";
            cbxPropriedadesTipo.Text = "";
            txbPropriedadesDono.Text = "";
            editandoID = 0;
        }
        
        private void PropriedbtnSalvar_Click(object sender, EventArgs e)
        {
            if ((verificarcampos()))
            {
                Imob.Site.Models.Habitation c = new Imob.Site.Models.Habitation();
                c.Endereco = txbPropriedadesEndereco.Text;
                c.Tipo = cbxPropriedadesTipo.Text;

                if (editandoID != 0)
                {
                    c.ID = editandoID;
                    (new PropriedadeController.PropriedadeControllerClient()).Editar(c);
                    Atualizando_datagrid();
                }
                else
                {
                    Imob.Site.Models.Habitation propriedade = (new PropriedadeControllerClient()).Salvar(c);
                    Atualizando_datagrid(propriedade);
                }
                editandoID = 0;
                resetarCampos();
            }
            else
                MessageBox.Show("Nem todos os campos foram preenchidos", "Campos Incorretos");
        }

        private bool verificarcampos()
        {
            if (txbPropriedadesDono.Text.Trim() != "" && txbPropriedadesEndereco.Text.Trim() != "")
            {
                return (true);
            }
            return (false);

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
            dgvPropriedades.Rows.Clear();
            foreach (var item in (new PropriedadeController.PropriedadeControllerClient()).Obter().ToList())
            {
                dgvPropriedades.Rows.Add(
                    item.ID,
                    item.Endereco, 
                    item.Tipo
                );
            }
        }

        public void Atualizando_datagrid(Site.Models.Habitation propriedade)
        {
            dgvPropriedades.Rows.Add(
                propriedade.ID,
                propriedade.Endereco,
                propriedade.Tipo
                );
        }

        private void dgvPropriedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPropriedades.Rows[e.RowIndex].DataBoundItem != null || true)
            {
                if (e.ColumnIndex == 3)
                {
                    txbPropriedadesID.Text = dgvPropriedades.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txbPropriedadesEndereco.Text = dgvPropriedades.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cbxPropriedadesTipo.Text = dgvPropriedades.Rows[e.RowIndex].Cells[2].Value.ToString();
                    editandoID = Convert.ToInt32(txbPropriedadesID.Text);
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
