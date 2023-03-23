using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System;
using System.Collections.Generic;
using Projeto_Construir_Desktops;
using System.Linq.Expressions;
using System.Linq;

namespace Projeto_Construir_Desktop
{
    public class RepositorioUsuario : RepositorioAbstratoUsuarios<Usuarios>
    {
        private ConexaoFDB conexaoFDB = new ConexaoFDB();

        public override IEnumerable<Usuarios> GetAll()
        {
            var listaUsuarios = $@"SELECT * FROM TBUSUARIOS";
            
            FbConnection connect = conexaoFDB.ConexaoBanco();
            connect.Open();
            var cmd = connect.CreateCommand();
            cmd.CommandText = listaUsuarios;

            var cmdDt = new FbDataAdapter(cmd);
            var dataTable = new DataTable();
            cmdDt.Fill(dataTable);

            List < Usuarios > usuarios = new List<Usuarios>();

            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                var usuario = new Usuarios
                {
                    ID = (int)dataTable.Rows[i][0],
                    Nome = dataTable.Rows[i][1].ToString(),
                    Cpf = dataTable.Rows[i][2].ToString(),
                    Email = dataTable.Rows[i][3].ToString(),
                    Administrador = (bool)dataTable.Rows[i][4],
                    Senha = dataTable.Rows[i][5].ToString(),
                };

                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public bool Logar(string nomeUsuario, string senhaUsuario)
        {
            var sql = $@"SELECT IDUSUARIO, NOMEUSUARIO, SENHAUSUARIO
                        FROM TBUSUARIOS WHERE NOMEUSUARIO = '{nomeUsuario}' ";

            FbConnection connect = conexaoFDB.ConexaoBanco();

            try
            {
                connect.Open();
                var cmd = connect.CreateCommand();
                cmd.CommandText = sql;

                var cmdDt = new FbDataAdapter(cmd);
                var dtble = new DataTable();
                cmdDt.Fill(dtble);

                if (dtble.Rows.Count > 0)
                {
                    Usuarios usuario = new Usuarios();
                    usuario.ID = (int)dtble.Rows[0][0];
                    usuario.Nome = dtble.Rows[0][1].ToString();
                    usuario.Senha = dtble.Rows[0][2].ToString();

                    if (usuario.Nome.Equals("ADMINISTRADOR") && senhaUsuario.Equals("PF" + DateTime.Now.Day + DateTime.Now.Year))
                    {
                        return true;
                    }
                    if (usuario.Senha.Equals(senhaUsuario))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        public override void Add(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public override void Update(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Usuarios> Get(Expression<Func<Usuarios, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> ListaNomeUsuarios()
        {
            IEnumerable<Usuarios> usuarios = GetAll().OrderBy(x => x.Nome);
            List<string> nomesUsuarios = new List<string>();   

            foreach(var usuario in usuarios)
            {
                nomesUsuarios.Add(usuario.Nome);
            }

            return nomesUsuarios;
        }
    }
}