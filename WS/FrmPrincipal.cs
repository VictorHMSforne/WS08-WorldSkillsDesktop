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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Exame exame = new Exame();
            string ocupacao = "";
            string data = DateTime.Now.ToString("dd/MM/yyyy");
            if (rbAdmi.Checked == true)
            {
                 ocupacao = rbAdmi.Text;
            }
            if (rbMudanca.Checked == true)
            {
                 ocupacao = rbMudanca.Text;
            }
            if (rbDemi.Checked == true)
            {
                 ocupacao = rbDemi.Text;
            }
            if (rbPerio.Checked == true)
            {
                 ocupacao = rbPerio.Text;
            }
            if (rbRetorno.Checked == true)
            {
                 ocupacao = rbRetorno.Text;
            }

            exame.InserirExame(ocupacao,txtNome.Text,txtIdade.Text,txtFunc.Text,txtEmpresa.Text,txtRG.Text,data);
            FrmClinica frmClinica = new FrmClinica();
            this.Hide();
            frmClinica.ShowDialog();
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
