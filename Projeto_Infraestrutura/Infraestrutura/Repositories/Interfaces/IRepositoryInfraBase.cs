using System;
using Projeto_Dominio.Domain.DomainRepositories.Interfaces;

namespace Projeto_Infraestrutura.Infraestrutura.Repositories.Interfaces
{
    public interface IRepositoryInfraBase<T> : IRepositoryBase<T> where T : class
    {
    }
}
