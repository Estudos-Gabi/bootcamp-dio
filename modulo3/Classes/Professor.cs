using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    public  class Professor : Pessoa
    {

         public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {
            
        }
       
        public decimal Salario { get; set; }

        public sealed override void Apresentar()  //polimorfismo
        {
            Console.WriteLine($" Olá, meu nome é {Nome} tenho {Idade} anos, e meu salário é de {Salario:C}");
        }
    }
}