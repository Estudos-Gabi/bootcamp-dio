using System.Text;
using Classes.Common.Models;
Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "gabrielle S.");
Pessoa p2 = new Pessoa(nome: "maria");
Pessoa p3 = new Pessoa(nome: "jose");
Pessoa p4 = new Pessoa(nome: "romeno");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 50);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria():C}");