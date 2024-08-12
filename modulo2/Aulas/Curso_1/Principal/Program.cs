using System.Data;
using System.Globalization;
using Classes.Common.Models;

string dataString = "2024-13-14 19:11";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None,
 out DateTime data);


if(sucesso )
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");

}
else
{
 Console.WriteLine($"{dataString} não é uma data válida");
}

Console.WriteLine(data);











/** : -> Significa que quero formatar o valor 
C -> É o formato currency de acordo com o sistema (moeda)

decimal valorMonetario = 84.234100M;
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMonetario.ToString("N7"));

SAÍDA:

R$ 84,23
$84.23
84,2341230

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); -> Muda para todo o sistema, se tiver multiplos 
países envolvidos, não é interessante fazer assim

Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US"))); -> Formata de acordo com a cultura


double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;

Console.WriteLine(numero.ToString("##/##/##"));
Console.WriteLine(numero.ToString("#-###-##"));


SAIDA:

34,21%
12/34/56
1-234-56



DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd-MM-yy HH:mm"));
Console.WriteLine(data.ToString("dd-MM-yyyy"));







 */


















// Pessoa p = new Pessoa("Gabrielle","Marcela");

// Pessoa p1 = new Pessoa("Pedro","Pascal");


// Pessoa p2 = new Pessoa("Marcela","Morango");


//  Curso cursoDeIngles = new Curso();

//  cursoDeIngles.NomeCurso = "Inglês";
//  cursoDeIngles.Alunos = new List<Pessoa>();

//  cursoDeIngles.AdicionarAluno(p);
//  cursoDeIngles.AdicionarAluno(p1);
//  cursoDeIngles.AdicionarAluno(p2);

// cursoDeIngles.ListarAlunos();


//  Curso cursoDeFrances = new Curso();

//  cursoDeFrances.NomeCurso = "Francês";
//  cursoDeFrances.Alunos = new List<Pessoa>();

//  cursoDeFrances.AdicionarAluno(p);



// cursoDeFrances.ListarAlunos();
