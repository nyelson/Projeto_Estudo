using Projeto_Dominio.Domain.DomainEntities;
using Projeto_Dominio.Domain.DomainRepositories.Interfaces;

namespace Projeto_Dominio.Domain.DomainRepositories
{
    public class RepositoryTurma : RepositoryBase<Turma>
    {
        public RepositoryTurma(IRepositoryBase<Turma> repository) : base(repository)
        {
        }
    }
}