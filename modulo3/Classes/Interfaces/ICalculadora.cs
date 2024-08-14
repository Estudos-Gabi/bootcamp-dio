using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicarr(int num1, int num2);
        
        int Dividir(int num1, int num2)
        {
            return num1/num2;
        }
    }
}