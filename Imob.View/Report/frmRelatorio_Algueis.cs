﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imob.View.Report
{
    public partial class frmRelatorio_Algueis : Form
    {
        public frmRelatorio_Algueis()
        {
            InitializeComponent();
        }

        private void btnPagamentosVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}