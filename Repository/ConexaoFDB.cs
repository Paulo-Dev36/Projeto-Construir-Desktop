using FirebirdSql.Data.FirebirdClient;

namespace Projeto_Construir_Desktop
{
    public class ConexaoFDB
    {
        public const string ServerName = "localhost";
        public const string Porta = "3054";
        public const string UserName = "sysdba";
        public const string Password = "masterkey";
        public const string DataBase = "CONSTRUIR.FB4";

        public string ConnString = $@"User={UserName}; Password={Password};Database=C:\Users\paulo-vr\Documents\Teste\CONSTRUIR.FB4;
                                                    character set=Iso8859_1; DataSource={ServerName};Port={Porta}";

        public FbConnection Conexao;

        public FbConnection ConexaoBanco()
        {
            return Conexao = new FbConnection(ConnString);
        }
    }
}
