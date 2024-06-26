using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS
{
    public partial class FrmHistoricoOcupacional : Form
    {
        public FrmHistoricoOcupacional()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Exame exame = new Exame();
            exame.InserirHistorico(txtFuncoes.Text,txtAcidentes.Text);
            MessageBox.Show("Obrigado por ter feito essa Pesquisa!", "Pesquisa Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
