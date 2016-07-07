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
            ProprietarioControllerClient prop = new ProprietarioControllerClient();
            var c = new PropriedadeControllerClient().Obter();
            foreach (Site.Models.Habitation item in c.ToList())
            {
                this.DgvProprietarios.Rows.Add(
                    item.ID,
                    item.Endereco,
                    item.Tipo
                );
            }
        }
        
    }
}
