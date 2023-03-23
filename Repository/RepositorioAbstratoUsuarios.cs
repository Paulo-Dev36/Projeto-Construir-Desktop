using Projeto_Construir_Desktop;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Projeto_Construir_Desktops
{
    public abstract class RepositorioAbstrato<T> where T : IEntidade
    {
        public abstract void Add(T usuario);
        public abstract void Update(T usuario);
        public abstract void Remove(T usuario);
        public abstract IEnumerable<T> GetAll();
        public abstract IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
    }
}
