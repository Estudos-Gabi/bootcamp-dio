using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Models
{
    abstract class Smartphone
    {
        public string Numero { get; set; }
        private string _modelo;
        private string _IMEI;
        private int _memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public string Modelo
        {
            get => _modelo;

            set
            {
                _modelo = value;
            }
        }
        public string IMEI
        {
            get => _IMEI;
            set
            {
                _IMEI = value;
            }
        }
        public int Memoria
        {
            get => _memoria;

            set
            {
                _memoria = value;
            }
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public abstract void InstalarAplicativo(string nomeApp);

    }
}