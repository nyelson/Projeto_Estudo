using Projeto_Dominio.Domain.DomainEntities;
using Projeto_Dominio.Domain.DomainRepositories.Interfaces;

namespace Projeto_Dominio.Domain.DomainServices
{
    public class DomainServicesAluno : DomainServicesBase<Aluno>
    {
        public DomainServicesAluno(IRepositoryBase<Aluno> repository) : base(repository)
        {
        }
    }
}