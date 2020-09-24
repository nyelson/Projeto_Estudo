using System.Collections.Generic;

namespace Projeto_Aplicacao.Application.Interfaces
{
    public interface IAppServicesBase<T> where T : class
    {
         #region Manutenção de dados
         void Insert(T obj);
         void Delete(T obj);
         void Update(T obj);
         T FindByPk(int id);
         List<T> FindAll();
         #endregion
    }
}