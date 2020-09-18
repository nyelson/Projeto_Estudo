using Projeto_Dominio.Domain.DomainEntities;
using Projeto_Dominio.Domain.DomainRepositories.Interfaces;

namespace Projeto_Dominio.Domain.DomainServices
{
    public class ServicesAluno : ServicesBase<Aluno>
    {
        public ServicesAluno(IRepositoryBase<Aluno> repository) : base(repository)
        {
        }
    }
}