using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Principal.Models
{
    public class Pessoa
    {
        private string _nome;
        private string _sobrenome;


        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome  = Sobrenome;
        }

        public string Nome
        {
            get => _nome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome = value;
            }
        }

        public string Sobrenome
        {
            get => _sobrenome;

            set{
                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio!");
                }
                _sobrenome = value;  
            }
        }
    }
}