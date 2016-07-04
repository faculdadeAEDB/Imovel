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
            (new ClienteController.ClienteControllerClient()).Obter();
        }

        private void CosbtnNovo_Click(object sender, EventArgs e)
        {
            Imob.Site.Models.Customer c = new Imob.Site.Models.Customer();
            c.Nome = CoslblNome.Text;
            c.Endereco = CoslblEndereco.Text;
            c.Telefone = CoslblTelefone.Text;
            c.Idade = CoslblIdade.Text;
            c.cpf = Convert.ToInt32(CoslblCPF.Text);

            (new ClienteController.ClienteControllerClient()).Salvar(c);
        }

        private void CosbtnSalvar_Click(object sender, EventArgs e)
        {
            Imob.Site.Models.Customer c = new Imob.Site.Models.Customer();
            c.Nome = CoslblNome.Text;
            c.Endereco = CoslblEndereco.Text;
            c.Telefone = CoslblTelefone.Text;
            c.Idade = CoslblIdade.Text;
            c.cpf = Convert.ToInt32(CoslblCPF.Text);

            (new ClienteController.ClienteControllerClient()).Editar(c);
        }

        private void CosbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
