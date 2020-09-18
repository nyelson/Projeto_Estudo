using System.Collections.Generic;

namespace Projeto_Dominio.Domain.DomainEntities
{
    public class Turma
    {
        public Turma()
        {
        }

        public Turma(int codigoTurma, string nomeTurma, IList<Aluno> alunos)
        {
            CodigoTurma = codigoTurma;
            NomeTurma = nomeTurma;
            Alunos = alunos;
        }

        public virtual int CodigoTurma { get; set; }
        public virtual string NomeTurma { get; set; }

        #region Relacionamentos
        public virtual IList<Aluno> Alunos { get; set; } 
        #endregion
    }
}