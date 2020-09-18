using Projeto_Dominio.Domain.DomainEntities;
using Projeto_Dominio.Domain.DomainRepositories.Interfaces;

namespace Projeto_Dominio.Domain.DomainRepositories
{
    public class RepositoryAluno : RepositoryBase<Aluno>
    {
        public RepositoryAluno(IRepositoryBase<Aluno> repository) : base(repository)
        {
        }
    }
}