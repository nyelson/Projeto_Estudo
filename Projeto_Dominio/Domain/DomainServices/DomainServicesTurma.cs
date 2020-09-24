using Projeto_Dominio.Domain.DomainEntities;
using Projeto_Dominio.Domain.DomainRepositories.Interfaces;

namespace Projeto_Dominio.Domain.DomainServices
{
    public class DomainServicesTurma : DomainServicesBase<Turma>
    {
        public DomainServicesTurma(IRepositoryBase<Turma> repository) : base(repository)
        {
        }
    }
}