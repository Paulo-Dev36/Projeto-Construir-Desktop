using System.Windows.Forms;

namespace Projeto_Construir_Desktop
{
    public class ValidadorBanco
    {
        public bool EhCampoVazio(string agencia, string contaCorrente, string descricaoBanco, double saldoAtual)
        {
            if (string.IsNullOrWhiteSpace(agencia))
            {
                MessageBox.Show("Campo da agência obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (string.IsNullOrWhiteSpace(contaCorrente))
            {
                MessageBox.Show("Campo da conta corrente obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (string.IsNullOrWhiteSpace(descricaoBanco))
            {
                MessageBox.Show("Campo da descrição do banco obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (saldoAtual <= 0.00)
            {
                DialogResult confirmacao = MessageBox.Show("Realmente deseja cadastrar um banco com o saldo R$0,00?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
