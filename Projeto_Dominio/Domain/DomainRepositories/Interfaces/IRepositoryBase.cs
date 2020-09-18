using System.Collections.Generic;

namespace Projeto_Dominio.Domain.DomainRepositories.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
         #region Manutenção de dados
         void Insert(T obj);
         void Delete(T obj);
         void Update(T obj);
         T FindByPk(int id);
         List<T> FindAll();
         #endregion

         #region Controle de transações
         void BeginTransaction();
         void Commit();
         void Rollback();
         void Dispose();
         #endregion
    }
}