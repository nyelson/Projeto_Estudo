using FluentNHibernate.Mapping;
using Projeto_Dominio.Domain.DomainEntities;

namespace Projeto_Infraestrutura.Infraestrutura.Mapping
{
    public class TurmaMap : ClassMap<Turma>
    {
        public TurmaMap()
        {
            Id(x => x.CodigoTurma);
            Map(x => x.NomeTurma);
            References(x => x.Alunos);
        }
    }
}
