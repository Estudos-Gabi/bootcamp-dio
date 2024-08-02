using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Common.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }


        /*
        Assinatura de um metodo: 
        [tipo] [Nome] (Parametros){}

        void - Não retorna nada
        
        
        */
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);

        }
    }
}