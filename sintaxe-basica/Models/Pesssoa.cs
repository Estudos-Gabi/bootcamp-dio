using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxe_basica.Models
{
    public class Pesssoa
    {
       public String Nome { get; set; } = null!;
       public int Idade { get; set; }

       public void Apresentar()
       {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
       }
    }
}