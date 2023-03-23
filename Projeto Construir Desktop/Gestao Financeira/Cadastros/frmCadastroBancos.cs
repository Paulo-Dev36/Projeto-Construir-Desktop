using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Construir_Desktop.Gestao_Financeira.Cadastros
{
    public partial class frmCadastroBancos : Form
    {
        RepositorioInstituicaoBancaria repositorioInstituicao = new RepositorioInstituicaoBancaria();
        public frmCadastroBancos()
        {
            InitializeComponent();
            MapeiaInstituicoesBancarias();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MapeiaInstituicoesBancarias()
        {
            foreach (String nomeInstituicao in repositorioInstituicao.ListaNomesInstituicao())
            {
                comboBoxBanco.Items.Add(nomeInstituicao);
            }
            comboBoxBanco.SelectedIndex = 0;
        }

        private void buttonLimpar_Click(object sender, EventArgs e) => LimparCampos();
        
        private void LimparCampos()
        {
            txtAgencia.Clear();
            txtContaCorrente.Clear();
            txtNomeInstituicao.Clear();
            txtSaldoInicial.Clear();
        }
    }
}
