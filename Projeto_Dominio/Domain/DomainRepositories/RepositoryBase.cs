using Projeto_Dominio.Domain.DomainRepositories.Interfaces;

namespace Projeto_Dominio.Domain.DomainRepositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly IRepositoryBase<T> repositorio;
        
        public RepositoryBase(IRepositoryBase<T> repository)
        {
            repositorio = repository;
        }

        public void BeginTransaction()
        {
            throw new System.NotImplementedException();
        }

        public void Commit()
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T obj)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.List<T> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public T FindByPk(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new System.NotImplementedException();
        }

        public void Rollback()
        {
            throw new System.NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new System.NotImplementedException();
        }
    }
}