using System;

namespace Projeto_Dominio.Domain.DomainEntities
{
    public class Aluno
    {
        public Aluno()
        {
        }

        public Aluno(int codigoAluno, string nomeAluno, string documentoAluno, string matriculaAluno, DateTime dataNascimento)
        {
            CodigoAluno = codigoAluno;
            NomeAluno = nomeAluno;
            DocumentoAluno = documentoAluno;
            MatriculaAluno = matriculaAluno;
            DataNascimento = dataNascimento;
        }

        public virtual int CodigoAluno { get; set; }
        public virtual string NomeAluno { get; set; }
        public virtual string DocumentoAluno { get; set; }
        public virtual string MatriculaAluno { get; set; }
        public virtual DateTime DataNascimento { get; set; }
    }
}