using DomainClass;
using FirebirdSql.Data.FirebirdClient;
using Projeto_Construir_Desktop;
using Projeto_Construir_Desktops;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public class RepositorioInstituicaoBancaria : RepositorioAbstrato<InstituicaoBancaria>
    {
        private ConexaoFDB conexaoFDB = new ConexaoFDB();
        public override void Add(InstituicaoBancaria instituicaoBancaria)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<InstituicaoBancaria> Get(Expression<Func<InstituicaoBancaria, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<InstituicaoBancaria> GetAll()
        {
            var listaInstituicaoBancarias = $@"SELECT * FROM TBINSTITUICAOBANCARIA";

            FbConnection connect = conexaoFDB.ConexaoBanco();
            connect.Open();
            var cmd = connect.CreateCommand();
            cmd.CommandText = listaInstituicaoBancarias;

            var cmdDt = new FbDataAdapter(cmd);
            var dataTable = new DataTable();
            cmdDt.Fill(dataTable);

            List<InstituicaoBancaria> instituicaoBancarias = new List<InstituicaoBancaria>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var instituicao = new InstituicaoBancaria
                {
                    Id = (int)dataTable.Rows[i][0],
                    NomeInstituicao = dataTable.Rows[i][1].ToString() 
                };

                instituicaoBancarias.Add(instituicao);
            }
            return instituicaoBancarias;
        }

        public override void Remove(InstituicaoBancaria instituicaoBancaria)
        {
            throw new NotImplementedException();
        }

        public override void Update(InstituicaoBancaria instituicaoBancaria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ListaNomesInstituicao()
        {
            IEnumerable<InstituicaoBancaria> instituicoes = GetAll().OrderBy(x => x.NomeInstituicao);
            List<string> nomesInstituicoes = new List<string>();

            foreach (var instituicao in instituicoes)
            {
                nomesInstituicoes.Add(instituicao.NomeInstituicao);
            }

            return nomesInstituicoes;
        }
    }
}
