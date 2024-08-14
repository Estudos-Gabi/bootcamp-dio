using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes.Interfaces;

namespace Classes
{
    public class Calculadora : ICalculadora   //Implementação
    {
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiplicarr(int num1, int num2)
        {
              return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
              return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
              return num1 - num2;
        }
    }
}