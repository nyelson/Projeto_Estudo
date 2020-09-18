using Projeto_Dominio.Domain.DomainEntities;
using Projeto_Dominio.Domain.DomainRepositories.Interfaces;

namespace Projeto_Dominio.Domain.DomainServices
{
    public class ServicesTurma : ServicesBase<Turma>
    {
        public ServicesTurma(IRepositoryBase<Turma> repository) : base(repository)
        {
        }
    }
}