using Projeto_Dominio.Domain.DomainEntities;
using Projeto_Dominio.Domain.DomainServices.Interfaces;

namespace Projeto_Aplicacao.Application
{
    public class AppServicesAluno : AppServicesBase<Aluno>
    {
        public AppServicesAluno(IDomainServicesBase<Aluno> _domain) : base(_domain)
        {
        }
    }
}