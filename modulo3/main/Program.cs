using Classes;
using Classes.Interfaces;

/**
//Abstração e  Encapsulamento
ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(50);
c1.ExibirSaldo();


// Herança e Polimorfismo

Aluno a1 = new Aluno();
a1.Nome = "Gabrielle";
a1.Idade = 21;
a1. Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Jose";
p1.Idade = 40;
p1.Salario = 1000;
p1.Apresentar();

// ------------------------------
// Classes Abstratas e Interfaces com C#

Corrente c1 = new Corrente();
c1.Creditar(100);
c1.ExibirSaldo();
c1.Creditar(600);
c1.ExibirSaldo();


// Classe Object    

Computador c1 = new Computador();
c1.ToString();
*/


ICalculadora c1 = new Calculadora();
Console.WriteLine(c1.Dividir(10,2));
