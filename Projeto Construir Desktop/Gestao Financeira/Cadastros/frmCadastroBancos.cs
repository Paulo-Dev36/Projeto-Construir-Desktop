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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Construir_Desktop.Gestao_Financeira.Cadastros
{
    public partial class frmCadastroBancos : Form
    {
        readonly RepositorioInstituicaoBancaria repositorioInstituicao = new RepositorioInstituicaoBancaria();
        readonly RepositorioBanco repositorioBanco = new RepositorioBanco();
        readonly Banco banco = new Banco();
        Componentes componentes = new Componentes();
        readonly ValidadorBanco validadorBanco = new ValidadorBanco();

        readonly DataTable dtTable = new DataTable();
        public frmCadastroBancos()
        {
            InitializeComponent();
            MapeiaInstituicoesBancarias();
            AddColunasTabela();
            GridBancos(repositorioBanco.GetAll());

            txtSaldoInicial.Text = string.Format("{0:#,##0.00}", 0d);
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
            txtDescricaoBanco.Clear();
            txtSaldoInicial.Text = string.Format("{0:#,##0.00}", 0d);
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
            dgvBanco.EnableHeadersVisualStyles = false;
            dgvBanco.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvBanco.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
            dgvBanco.Columns[5].DefaultCellStyle.Format = "C2";
        }

        private void DadosDataTable(IEnumerable<Banco> bancos)
        {
            dtTable.Clear();
            foreach (Banco banco in bancos)
            {
                dtTable.Rows.Add(banco.Id, banco.Descricao, banco.InstituicaoBancaria, banco.Agencia, banco.ContaCorrente, banco.SaltoAtual) ;
            }
        }

        private void DadosDataTable(Banco banco)
        {
            dtTable.Clear();
            if (banco != null)
                dtTable.Rows.Add(banco.Id, banco.Descricao, banco.InstituicaoBancaria, banco.Agencia, banco.ContaCorrente, banco.SaltoAtual);
        }

        private void AddColunasTabela()
        {
            dtTable.Columns.Add("Cod", typeof(int));
            dtTable.Columns.Add("Descrição", typeof(string));
            dtTable.Columns.Add("Instituição Bancária", typeof(string));
            dtTable.Columns.Add("Agência", typeof(int));
            dtTable.Columns.Add("Conta Corrente", typeof(int));
            dtTable.Columns.Add("Saldo Atual", typeof(double));
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(dgvBanco.Columns.Count > 0)
            {
                txtDescricaoBanco.Text = dgvBanco.CurrentRow.Cells[1].Value.ToString();
                comboBoxBanco.Text = dgvBanco.CurrentRow.Cells[2].Value.ToString();
                txtAgencia.Text = dgvBanco.CurrentRow.Cells[3].Value.ToString();
                txtContaCorrente.Text = dgvBanco.CurrentRow.Cells[4].Value.ToString();

                txtSaldoInicial.Text = Convert.ToDouble(dgvBanco.CurrentRow.Cells[5].Value).ToString("C");
                labelSaldoAtual.Visible = false;
                txtSaldoInicial.Visible = false;
                buttonAdicionar.Visible = false;
                buttonModificar.Visible = true;
                buttonCancelar.Visible = true;
                buttonLimpar.Visible = false;
            }
        }

        private void txtAgencia_KeyPress(object sender, KeyPressEventArgs e) => componentes.PermitirSomenteNumeros(sender, e);

        private void txtContaCorrente_KeyPress(object sender, KeyPressEventArgs e) => componentes.PermitirSomenteNumeros(sender, e);

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            buttonAdicionar.Visible = true;
            buttonLimpar.Visible = true;
            buttonModificar.Visible = false;
            buttonCancelar.Visible = false;
            
            txtSaldoInicial.Visible = true;
            labelSaldoAtual.Visible = true;

            LimparCampos();
        }

        private void ButtonAdicionar_Click(object sender, EventArgs e)
        {
            if (validadorBanco.EhCampoVazio(txtAgencia.Text, txtContaCorrente.Text, txtDescricaoBanco.Text, 
                Convert.ToDouble(txtSaldoInicial.Text)))
            {
                return;
            }
            banco.InstituicaoBancaria = comboBoxBanco.Text;
            banco.Descricao = txtDescricaoBanco.Text;
            banco.Agencia = Int32.Parse(txtAgencia.Text);
            banco.ContaCorrente = Int32.Parse(txtContaCorrente.Text);
            banco.SaltoAtual = Convert.ToDouble(txtSaldoInicial.Text);
            banco.Token = banco.ContaCorrente.ToString();

            repositorioBanco.Add(banco);
            GridBancos(repositorioBanco.GetAll());
            LimparCampos();
        }

        private void txtSaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            componentes.PermitirSomenteNumeros(sender, e);
            componentes.FormatarEmReais(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.Id = (int)dgvBanco.CurrentRow.Cells[0].Value;

            repositorioBanco.Remove(banco);
            GridBancos(repositorioBanco.GetAll());
        }
    }
}
