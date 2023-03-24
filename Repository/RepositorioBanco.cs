using DomainClass;
using FirebirdSql.Data.FirebirdClient;
using Projeto_Construir_Desktop;
using Projeto_Construir_Desktops;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Repository
{
    public class RepositorioBanco : RepositorioAbstrato<Banco>
    {
        private ConexaoFDB conexaoFDB = new ConexaoFDB();
        public override void Add(Banco banco)
        {
            FbConnection connect = conexaoFDB.ConexaoBanco();
            connect.Open();

            var insert = @"INSERT INTO TBBANCO (IDBANCO, TOKEN, BANCO, DESCRICAO, AGENCIA, CONTACORRENTE, SALDOATUAL) 
                                   VALUES(@IDBANCO, @TOKEN, @BANCO, @DESCRICAO, @AGENCIA, @CONTACORRENTE, @SALDOATUAL)";
            var cmd = connect.CreateCommand();
            cmd.CommandText = insert;
            
            var obterUltimoId = @"SELECT FIRST 1 IDBANCO FROM TBBANCO
                                    ORDER BY 1 DESC";

            var cmd2 = connect.CreateCommand();
            cmd2.CommandText = obterUltimoId;

            var cmdDt2 = new FbDataAdapter(cmd2);
            var dataTable = new DataTable();
            cmdDt2.Fill(dataTable);

            banco.Id = (int)dataTable.Rows[0][0] + 1;

            cmd.Parameters.AddWithValue(@"IDBANCO", banco.Id);
            cmd.Parameters.AddWithValue(@"TOKEN", banco.Token);
            cmd.Parameters.AddWithValue(@"BANCO", banco.InstituicaoBancaria);
            cmd.Parameters.AddWithValue(@"DESCRICAO", banco.Descricao);
            cmd.Parameters.AddWithValue(@"AGENCIA", banco.Agencia);
            cmd.Parameters.AddWithValue(@"CONTACORRENTE", banco.ContaCorrente);
            cmd.Parameters.AddWithValue(@"SALDOATUAL", banco.SaltoAtual);
            cmd.ExecuteNonQuery();
        }

        public override IEnumerable<Banco> Get(Expression<Func<Banco, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Banco> GetAll()
        {
            var listaBancos = $@"SELECT * FROM TBBANCO ORDER BY 1";

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
                    Descricao = dataTable.Rows[i][3].ToString(),
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
