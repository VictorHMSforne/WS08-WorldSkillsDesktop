using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS
{
    public partial class FrmClinica : Form
    {
        public FrmClinica()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Exame exame = new Exame();
            exame.InserirClinica(txtDoenca.Text,txtAlergia.Text,txtCirurgias.Text,txtTrans.Text,txtMedicamento.Text,txtOutros.Text);
            FrmHistoricoOcupacional frmHistorico = new FrmHistoricoOcupacional();
            this.Hide();
            frmHistorico.ShowDialog();
        }
    }
}
