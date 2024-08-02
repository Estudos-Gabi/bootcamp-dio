using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Common
{
    public class Estacionamento
    {

        // Atributos
        private decimal precoInicial { get; set; } = 0;
        private decimal precoPorHora { get; set; } = 0;

        private List<string> veiculos = new List<string>();


        string placa;
        int horas;
        decimal valorTotal;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }




        // Métodos
        public void Adicionarveiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("veículo adicionado com sucesso!\n ");
        }


      public void RemoverVeiculo()
{
    Console.WriteLine("Digite a placa do veículo para remover: ");
    string placa = Console.ReadLine();

    // Encontra o veículo independentemente de maiúsculas e minúsculas
    var veiculo = veiculos.FirstOrDefault(x => x.ToUpper() == placa.ToUpper());

    if (veiculo != null)
    {
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
        if (int.TryParse(Console.ReadLine(), out int horas))
        {
            valorTotal = precoInicial + (precoPorHora * horas);

            // Remove o veículo encontrado
            veiculos.Remove(veiculo);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal} \n");
        }
        else
        {
            Console.WriteLine("Entrada inválida para a quantidade de horas.");
        }
    }
    else
    {
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente\n");
    }
}


        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var placa in veiculos)
                {
                    Console.WriteLine($"Veiculo: {placa} \n");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }




    }
}