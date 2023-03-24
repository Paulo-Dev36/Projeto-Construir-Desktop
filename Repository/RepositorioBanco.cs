using DomainClass;
using FirebirdSql.Data.FirebirdClient;
using Projeto_Construir_Desktop;
using Projeto_Construir_Desktops;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

namespace Repository
{
    public class RepositorioBanco : RepositorioAbstrato<Banco>
    {
        private ConexaoFDB conexaoFDB = new ConexaoFDB();
        public override void Add(Banco usuario)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Banco> Get(Expression<Func<Banco, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Banco> GetAll()
        {
            var listaBancos = $@"SELECT * FROM TBBANCO";

            FbConnection connect = conexaoFDB.ConexaoBanco();
            connect.Open();
            var cmd = connect.CreateCommand();
            cmd.CommandText = listaBancos;

            var cmdDt = new FbDataAdapter(cmd);
            var dataTable = new DataTable();
            cmdDt.Fill(dataTable);

            List<Banco> bancos = new List<Banco>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var banco = new Banco
                {
                    Id = (int)dataTable.Rows[i][0],
                    Token = dataTable.Rows[i][1].ToString(),
                    InstituicaoBancaria = dataTable.Rows[i][2].ToString(),
                    NomeBanco = dataTable.Rows[i][3].ToString(),
                    Agencia = (int)dataTable.Rows[i][4],
                    ContaCorrente = (int)dataTable.Rows[i][5],
                    SaltoAtual = (float)dataTable.Rows[i][6]
                };

                bancos.Add(banco);
            }
            return bancos;
        }

        public override void Remove(Banco usuario)
        {
            throw new NotImplementedException();
        }

        public override void Update(Banco usuario)
        {
            throw new NotImplementedException();
        }
    }
}
