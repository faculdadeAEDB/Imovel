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
            Imob.Site.Models.Customer c = new Imob.Site.Models.Customer();

            c.Nome = "Xablau";
            c.Telefone = "9999";
            c.Idade = "20";
            c.cpf = 12378;

            (new ClienteController.ClienteControllerClient()).Salvar(c);
        }
    }
}
