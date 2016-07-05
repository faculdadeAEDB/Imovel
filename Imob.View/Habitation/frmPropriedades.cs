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

namespace Imob.View.Habitation
{
    public partial class PropiedcbxID : Form
    {
        public PropiedcbxID()
        {
            InitializeComponent();
        }

        private void PropriedbtnNovo_Click(object sender, EventArgs e)
        {
            Imob.Site.Models.Habitation c = new Imob.Site.Models.Habitation();
            c.Endereco = PropriedtxbEndereco.Text;
            c.Tipo = PropiedcbxTipo.Text;

            (new PropriedadeController.PropriedadeControllerClient()).Salvar(c);
        }

        private void PropriedbtnSalvar_Click(object sender, EventArgs e)
        {
             Imob.Site.Models.Habitation c = new Imob.Site.Models.Habitation();
             c.Endereco = PropriedtxbEndereco.Text;
             c.Tipo = PropiedcbxTipo.Text;

             (new PropriedadeController.PropriedadeControllerClient()).Editar(c); 
        }

        private void PropriedbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PropiedcbxID_Load(object sender, EventArgs e)
        {
            var c = (new PropriedadeController.PropriedadeControllerClient()).Obter();
            Proprieddgv.DataSource = c.ToList();
        }
        
    }
}
