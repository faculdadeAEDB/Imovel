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
            Imob.Site.Models.Owner c = new Imob.Site.Models.Owner();
            c.Nome = PropriettxbNome.Text;
            c.Endereco = PropriettxbEndereco.Text;
            c.Telefone = PropriettxbTelefone.Text;
            c.CPF = PropriettxbCPF.Text;

            (new ProprietarioController.ProprietarioControllerClient()).Salvar(c);
        }

        private void btnProSalvar_Click(object sender, EventArgs e)
        {
            Imob.Site.Models.Owner c = new Imob.Site.Models.Owner();
            c.Nome = PropriettxbNome.Text;
            c.Endereco = PropriettxbEndereco.Text;
            c.Telefone = PropriettxbTelefone.Text;
            c.CPF = PropriettxbCPF.Text;

            (new ProprietarioController.ProprietarioControllerClient()).Editar(c);
        }

        private void btnProVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProprietarios_Load(object sender, EventArgs e)
        {
            var c = (new ProprietarioController.ProprietarioControllerClient()).Obter();
            
            foreach (var item in c.ToList())
            {
                grdProprietario.Rows.Add (
                    item.ID,
                    item.Nome,
                    item.Endereco,
                    item.CPF,
                    item.Telefone
                );
            }
        }
    }
}
