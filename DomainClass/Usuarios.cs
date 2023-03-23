namespace Projeto_Construir_Desktop
{
    public class Usuarios : IEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public int Permissao { get; set; }
        public bool Administrador { get; set; }
        public string Senha { get; set; }
        public bool Autorizado { get; set; } = false;
    }
}
