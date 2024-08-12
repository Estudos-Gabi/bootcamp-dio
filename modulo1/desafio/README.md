<img src="https://github.com/Estudos-Gabi/anotacoes-bootcamp-fullstack/blob/main/Módulo%201/desafio/imagens/bannerDesafio.png" alt="banners"> 

[![DIO - Desafio ](https://img.shields.io/badge/DIO_--_Desafio_-pink?style=for-the-badge)](https://github.com/digitalinnovationone/trilha-net-fundamentos-desafio)
<h3> 📄 Descrição</h3>

<p>
  
Este repositório contém a implementação de um sistema de estacionamento simples, desenvolvido como parte de um desafio do bootcamp. O objetivo deste projeto foi colocar em prática vários conceitos básicos e essenciais do C# e do .NET, bem como do uso do Git para controle de versão.


</p>

<h3>Funcionalidades</h3>

<p>
O sistema possui um menu interativo com as seguintes opções:
  
- Cadastrar carro: Permite adicionar um novo carro ao estacionamento.
- Remover carro: Remove um carro previamente cadastrado.
- Listar carros: Exibe todos os carros atualmente cadastrados no estacionamento.
- Encerrar: Encerra o sistema.
</p>

<h3>
    Tecnologias Utilizadas
</h3>


<p>

- C#: Linguagem de programação utilizada para o desenvolvimento do sistema.
- .NET: Framework utilizado para criar e executar a aplicação.
- Git: Sistema de controle de versão utilizado para gerenciar o código-fonte.

</p>

<h3>  Conceitos Praticados </h3>
<p>

Durante o desenvolvimento deste projeto, pratiquei e aperfeiçoei os seguintes conceitos:

- Manipulação de solutions e criação de projetos em C#.
- Utilização da sintaxe da linguagem C# para desenvolver a aplicação.
- Uso do Git para versionamento e armazenamento do código no GitHub.
- Estruturação de um menu interativo utilizando while e switch case para navegação pelas opções do sistema.
</p>






---
<h1> Explicação do código </h1>

Primeiro era nescessário fazer a classe estacionamento:

<img src="https://github.com/digitalinnovationone/trilha-net-fundamentos-desafio/blob/main/diagrama_classe_estacionamento.png" alt="Diagrama da classe">


<details>
<summary> <h3> Classe Estacionamento </h3></summary>

  ```C#
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
```
</details>

<p> Destaque para essa linha: </p>

```C#
 if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
```

<p>
  
  O método Any pertence à LINQ (Language Integrated Query) e é usado para determinar se qualquer elemento de uma coleção existe.
 - Sem argumentos, Any retorna true se a coleção contiver pelo menos um elemento; caso contrário, retorna false.
</p>


<p>

 ```C#
 x => x.ToUpper() == placa.ToUpper():
 ```

- Este é um lambda expression (uma função anônima).
- x representa cada elemento individual da coleção veiculos.
- x.ToUpper() converte o valor de x para maiúsculas.
- placa.ToUpper() converte o valor de placa para maiúsculas.
- x.ToUpper() == placa.ToUpper() compara o elemento atual da coleção (em maiúsculas) com a variável placa (também em maiúsculas).
</p>

<details>
<summary><h3> Execução </h3></summary>

```C#
using Classes.Common;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine(" Digite uma opção: ");
    Console.WriteLine(" 1 - Cadastrar veículo: ");
    Console.WriteLine(" 2 - Remover veículo: ");
    Console.WriteLine(" 3 - Listar veículos: ");
    Console.WriteLine(" 4 - Encerrar: ");
    switch (Console.ReadLine())
    {
        case "1":
            es.Adicionarveiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
```
</details>

<div align=center >
  <img src="https://github.com/Estudos-Gabi/bootcamp-dio/blob/main/Módulo%201/desafio/imagens/exec.gif" alt="gif de execução" width=50%  >

</div>

