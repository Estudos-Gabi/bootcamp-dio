using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Common.Models
{
    public class Pessoa
    {
        private string _nome;
    
        public Pessoa(string nome)
        {
            Nome = nome;
         
        }

        public string Nome
        {
            get
            {
                return $"{_nome[0].ToString().ToUpper()}{_nome.Substring(1)}";
            }

            set
            {
                if (value == "")
                {
                    Console.WriteLine("O campo Nome não pode ser vazio!!");
                }

                _nome = value;
            }
        }

       
        
    }
}