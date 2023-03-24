using DomainClass;
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
        RepositorioBanco repositorioBanco = new RepositorioBanco();

        readonly DataTable dtTable = new DataTable();
        public frmCadastroBancos()
        {
            InitializeComponent();
            MapeiaInstituicoesBancarias();
            AddColunasTabela();
            GridBancos(repositorioBanco.GetAll());
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
        private void GridBancos(Banco banco)
        {
            DadosDataTable(banco);
            bindingSource1.DataSource = dtTable;
            dgvBanco.DataSource = bindingSource1;
        }

        private void GridBancos(IEnumerable<Banco> bancos)
        {
            DadosDataTable(bancos);
            bindingSource1.DataSource = dtTable;
            dgvBanco.DataSource = bindingSource1;
            //dgvBanco.Columns[0].Width = 50;
            //dgvBanco.Columns[1].Width = 150;
            //dgvBanco.Columns[2].Width = 150;
            //dgvBanco.Columns[3].Width = 150;
            //dgvBanco.Columns[4].Width = 120;
            dgvBanco.EnableHeadersVisualStyles = false;
            dgvBanco.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            //dgvBanco.ColumnHeadersDefaultCellStyle.BackColor = Color.Silver;
            dgvBanco.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dgvBanco.Columns[5].DefaultCellStyle.Format = "C2";
        }

        private void DadosDataTable(IEnumerable<Banco> bancos)
        {
            dtTable.Clear();
            foreach (Banco banco in bancos)
            {
                dtTable.Rows.Add(banco.Id, banco.NomeBanco, banco.Agencia, banco.CodigoBanco, banco.ContaCorrente, banco.SaltoAtual) ;
            }
        }

        private void DadosDataTable(Banco banco)
        {
            dtTable.Clear();
            if (banco != null)
                dtTable.Rows.Add(banco.Id, banco.NomeBanco, banco.Agencia, banco.CodigoBanco, banco.ContaCorrente, banco.SaltoAtual);
        }

        private void AddColunasTabela()
        {
            dtTable.Columns.Add("Cod", typeof(int));
            dtTable.Columns.Add("Nome Banco", typeof(string));
            dtTable.Columns.Add("Agência", typeof(int));
            dtTable.Columns.Add("Instituição Bancária", typeof(int));
            dtTable.Columns.Add("Conta Corrente", typeof(int));
            dtTable.Columns.Add("Saldo Atual", typeof(double));
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
