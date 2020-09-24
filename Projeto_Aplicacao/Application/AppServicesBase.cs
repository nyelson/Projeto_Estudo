using System.Collections.Generic;
using Projeto_Aplicacao.Application.Interfaces;
using Projeto_Dominio.Domain.DomainServices.Interfaces;

namespace Projeto_Aplicacao.Application
{
    public abstract class AppServicesBase<T> : IAppServicesBase<T> where T : class
    {
        private readonly IDomainServicesBase<T> domain;

        public AppServicesBase(IDomainServicesBase<T> _domain)
        {
            domain = _domain;
        }

        public void Delete(T obj)
        {
            domain.Delete(obj);
        }

        public List<T> FindAll()
        {
            return domain.FindAll();
        }

        public T FindByPk(int id)
        {
            return domain.FindByPk(id);
        }

        public void Insert(T obj)
        {
            domain.Insert(obj);
        }

        public void Update(T obj)
        {
            domain.Update(obj);
        }
    }
}