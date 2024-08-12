using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Common.Models
{
    public class Suite
    {
        private string _tipoSuite;
        private int _capacidade;
        private decimal _valorDiaria;


        public Suite(string tipoSuite,int capacidade, decimal valorDiaria){

            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;

        }



        public string TipoSuite
        {
            get
            {
                return $"{_tipoSuite[0].ToString().ToUpper()}{_tipoSuite.Substring(1)}";
            }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Escolha uma suite!!");
                }
                _tipoSuite = value;
            }
        }

        public int Capacidade
        {
            get => _capacidade;
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Capacidade não pode ser Negativa!");
                }
                    
                _capacidade = value;
            }
        }
        public decimal ValorDiaria
        {
            get => _valorDiaria;
            set
            {
                if(value == 0 )
                {
                     Console.WriteLine("Capacidade não pode ser Negativa!");
                }
                _valorDiaria = value;
            }

            
    
        }


    }
}