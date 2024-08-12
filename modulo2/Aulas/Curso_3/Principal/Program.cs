
using Principal.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Models/vendas.json");

List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda venda in listaVendas)
{
    Console.WriteLine($"ID: {venda.Id} - Data: {venda.dataVenda.ToString("dd/MM/yyyy HH:mm")}\n" +
    $"Produto: {venda.Produto} - Preço: {venda.Preco}\n");
}


























// DateTime dataAtual = DateTime.Now;

// List<Vendas> listaVendas = new List<Vendas>();


// Vendas v1 = new Vendas(1, "Lapis", 5.0M,dataAtual);
// Vendas v2= new Vendas(2, "Borracha", 3.0M,dataAtual);
// Vendas v3= new Vendas(3, "Cadernno", 30.0M,dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);
// listaVendas.Add(v3);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// File.WriteAllText("Models/vendas.json",serializado);  //escrevendo o resultado em um arquivo .Json

// Console.WriteLine(serializado);


















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso,linhaArquivo, _) = arquivo.LerArquivo("Models/arquivo.txt");


// if(sucesso)
// {
//     // Console.WriteLine("Quantidade linhas dos arquivos: " + quantidadeLinhas);
//     foreach(string linha in linhaArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }else{
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }

// // Descarte de informações> colocar _ 













// //Maneira mais recomendada: legibilidade 
// (int ID, string Nome, string Sobrenome) tupla = (1, "Gabrielle", "Soares");

// Console.WriteLine(tupla.Item1);
// Console.WriteLine(tupla.Item2);
// Console.WriteLine(tupla.Item3);

// // Outras maneiras de declarar uma tupla:
// // Desvantagem: Não dá para nomear os itens.
// ValueTuple<int,string,double,string> tupla2 = (1, "Gabi", 1.54, "Ola");
// var tupla3 = Tuple.Create(1, "Gabi", 1.54, "Ola");