using Projeto_Construir_Desktop;

namespace DomainClass
{
    public class Banco : IEntidade
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string InstituicaoBancaria { get; set; }
        public string Descricao { get; set; }
        public int Agencia { get; set; }
        public int ContaCorrente { get; set; }
        public double SaltoAtual { get; set; }
    }
}
