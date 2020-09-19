using System;
using Projeto_Dominio.Domain.DomainRepositories.Interfaces;

namespace Projeto_Infraestrutura.Infraestrutura.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.List<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public T FindByPk(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
