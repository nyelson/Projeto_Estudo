using System;
using System.Collections.Generic;
using Projeto_Dominio.Domain.DomainRepositories.Interfaces;
using Projeto_Dominio.Domain.DomainServices.Interfaces;

namespace Projeto_Dominio.Domain.DomainServices
{
    public class DomainServicesBase<T> : IDomainServicesBase<T> where T : class
    {
        private readonly IRepositoryBase<T> repositorio;

        public DomainServicesBase(IRepositoryBase<T> repository)
        {
            repositorio = repository;
        }

        public void Delete(T obj)
        {
            try
            {
                repositorio.BeginTransaction();
                repositorio.Delete(obj);
                repositorio.Commit();
            }
            catch
            {
                repositorio.Rollback();
                throw new Exception();
            }
        }

        public List<T> FindAll()
        {
            return repositorio.FindAll();
        }

        public T FindByPk(int id)
        {
            return repositorio.FindByPk(id);
        }

        public void Insert(T obj)
        {
            try
            {
                repositorio.BeginTransaction();
                repositorio.Insert(obj);
                repositorio.Commit();
            }
            catch
            {
                repositorio.Rollback();
                throw new Exception();
            }
        }

        public void Update(T obj)
        {
            try
            {
                repositorio.BeginTransaction();
                repositorio.Update(obj);
                repositorio.Commit();
            }
            catch
            {
                repositorio.Rollback();
                throw new Exception();
            }
        }
    }
}