// Exceções e Coleções      - 07/08/24

// Lendo um arquivo TXT  - Tratando uma Exceção
// try   //Tente executar esse código com cautela
// {
// string[] linhas = File.ReadAllLines("arquivos/n/ola_mundo.txt");

// foreach(string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// // Pode ter mais de uma exceção 
// } catch(FileNotFoundException ex) //Pega a exceção e faz o comando que foi posto entre {}
// {
//     Console.WriteLine($"Arquivo não encontrado: \n{ex.Message}");
// }
// catch(DirectoryNotFoundException diretorio)
// {
//     Console.WriteLine($"Caminho não encontrado: \n{diretorio.Message}");
// }
// catch(Exception exemplo)
// {
//     Console.WriteLine($"Exceção genérica: \n{exemplo.Message}");
// }
// Console.WriteLine("\nChegou até aqui");

// ------------------------------------------------

// Throw - Jogando uma exceção
// using Classes.Common.Models;
// new ExemploExcecao().Metodo1();

// ------------------------------------------------

// // Filas - FIFO_
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(11);
// fila.Enqueue(9);
// fila.Enqueue(22);

// foreach(int item in fila){
//     Console.WriteLine(item);

// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
//   // Não é passado parametro porque é removido por ordem de chegada

// fila.Enqueue(10);
// foreach(int item in fila){
//     Console.WriteLine(item);
// }

// ------------------------------------------------

//Coleção Stack(Pilha)
// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(6);
// pilha.Push(10);
// pilha.Push(1);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);

// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(23);
// Console.WriteLine(pilha.Peek());  // .Peek() Retorna o objeto que está no topo da pilha.

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);

// }

// ------------------------------------------------

// Dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.Write($"Removendo o estado: {estados.Remove("BA")} \n");

Console.Write($" Mudando um nome do estado: {estados["SP"] = "Saum Paulo "}\n");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}\n");
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}else{
    Console.WriteLine($"valor não existe, é seguro adicionar {chave}");

}

Console.Write(estados["MG"]);  // Acessando um existente 

Console.WriteLine("\n---------------"); 

Dictionary<int, string> nomes = new Dictionary<int, string>();
nomes.Add(1, "Gabi");
nomes.Add(2, "Olavio");
nomes.Add(3, "Marta");

foreach(var item in nomes )
{
    Console.WriteLine($"N°: {item.Key} Nome: {item.Value}");
}

nomes.Remove(1);
nomes[3] = "Murilo";

foreach(var item in nomes )
{
    Console.WriteLine($"N°: {item.Key} Nome: {item.Value}");
}



