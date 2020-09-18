using FluentNHibernate.Mapping;
using Projeto_Dominio.Domain.DomainEntities;

namespace Projeto_Infraestrutura.Infraestrutura.Mapping
{
    public class AlunoMap : ClassMap<Aluno>
    {
        public AlunoMap()
        {
            Id(x => x.CodigoAluno);
            Map(x => x.NomeAluno);
            Map(x => x.DocumentoAluno);
            Map(x => x.MatriculaAluno);
            Map(x => x.DataNascimento);
        }
    }
}
