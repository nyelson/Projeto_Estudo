using Projeto_Dominio.Domain.DomainEntities;
using Projeto_Dominio.Domain.DomainServices.Interfaces;

namespace Projeto_Aplicacao.Application
{
    public class AppServicesTurma : AppServicesBase<Turma>
    {
        public AppServicesTurma(IDomainServicesBase<Turma> _domain) : base(_domain)
        {
        }
    }
}