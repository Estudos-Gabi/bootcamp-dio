using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Common.Models
{
    public class Curso
    {

        //Cosntrutor
 



        public string NomeCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }


        /*
        Assinatura de um metodo: 
        [tipo] [Nome] (Parametros){}

        void - Não retorna nada
        int - retorna um inteiro
        string
        
        */
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);

        }


        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;  // .Count conta quantos elementos tem em uma List
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno) 
        {
           return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {

            Console.WriteLine($"\nAlunos do curso de: {NomeCurso}");
            // foreach(Pessoa aluno in Alunos)
            // {

            //     Console.WriteLine(aluno.NomeCompleto );

            // }

            for(int i = 0; i < Alunos.Count; i++)
            {
                string texto = $"N° {i + 1}: {Alunos[i].NomeCompleto}";
                Console.WriteLine (texto);

            }



        }

    }
}