<img src="https://github.com/Estudos-Gabi/anotacoes-bootcamp-fullstack/blob/main/sintaxe-basica/images/banners%20(2).png" alt="banner">

<div align=center> 

[![- BootCamp](https://img.shields.io/badge/_-BootCamp-pink?style=for-the-badge)](https://web.dio.me/track/coding-the-future-xp-full-stack-developer)
</div>

<details>  

<summary>Segundo módulo do bootcamp com os seguintes cursos: </summary> 


- Sintaxe e Tipos de Dados em C#
- Operadores Aritméticos em C#S
- Conhecendo as Estruturas de Repetição em C#
- Conhecendo a Organização de um Programa em C#
- Array e Listas em C#
- Construindo um Sistema para um Estacionamento com C#

</details>


Fiz apenas anotações do que achei importante, porque tem algumas coisas que são similares ao Java e que já estudei anteriormente (por exemplo os operadores, as estruturas de repetições) 

[![Anotações](https://img.shields.io/badge/_-Anotações-black?style=for-the-badge)](https://github.com/Estudos-Gabi/anotacoes-bootcamp-fullstack/tree/main/sintaxe-basica#-sintaxe-e-tipos-de-dados-em-c-)


 
<h2> Anotações</h2>

 <details>
<summary>
 <h3> Básico </h3> 	
</summary>

  <p> Para iniciar um projeto .NET é necessário que vá ao terminal e escreva: </p>

```shell
  dotnet new console 
``` 

<p> Esta é a estrutura padrão de um projeto: </p>

<img src="https://github.com/Estudos-Gabi/anotacoes-bootcamp-fullstack/blob/main/sintaxe-basica/images/estruturaProjeto.png" alt="estrutura do projeto padrão">

<p>
  
  As pastas  `bin`     e `obj` são pastas que não precisam ser mexidas

 Os arquivos `sintaxe-basica.csproj`  e  ` sintaxe-basica.sln`  são as configurações do projeto. 

  Já o `Program.cs`  é onde vamos fazer o código em si.
  	
</p>

 </details>

  
<details>

 <summary> <h3> Classe </h3>  </summary>


<p>
  
  A classe é um dos conceitos fundamentais da Programação Orientada a Objetos (POO). Ela pode ser vista como um molde ou uma blueprint que define um conjunto de atributos e métodos que serão usados para criar objetos.  
  
  *byChatGPT*
  
 </p>

  <div align=center>
  
   | Pessoa | 
|:-----|
|Atributos  | 
|Métodos  | 

  
  </div>


<h3> Criando nossa classe no código </h3> 
<p> 
  Para criar a classe siga os senquintes passos:
  
 1. Recomendado criar uma pasta `Models`
 2. Dentro da pasta `Models` clique com o direito no mouse e selecione  `New C#` > `Class`
 3. Depois aparecerá uma caixa para digitar o nome da classe

**Nota**: O nome das classes sempre começam com a letra maiúscula. 

</p>
<img src="https://github.com/Estudos-Gabi/anotacoes-bootcamp-fullstack/blob/main/sintaxe-basica/images/criandoClasse.png" alt="criando classe">

<h4> Estrutura base de uma classe </h4>

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxe_basica.Models
{
    public class Pesssoa
    {
        
    }
}
```

<p>

  Para adicionar um atributo a classe, digite `prop`e aperte `tab`. Assim será adicionado uma propriedade default: 
</p>

```C#
 namespace sintaxe_basica.Models
{
    public class Pesssoa
    {
       public int MyProperty { get; set; }
    }
}
```
<p> Por fim, como ficou nossa classe Pessoa: </p>

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sintaxe_basica.Models
{
    public class Pesssoa
    {
       public String Nome { get; set; }
       public int Idade { get; set; }

       public void Apresentar()
       {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
       }
    }
}
```
<p> 
 
 Importante destacar o `namespace` que indica onde está nossa classe, e também será utilizado para por a classe em uso no `Main`</p>

```C#

namespace sintaxe_basica.Models

```

<h4> Utilizando a classe Pessoa </h4>

<p>
 
 Para utilizar a classe, basta chamá-la com o `namespace` definido anteriormente, junto ao `using`.
 E depois, instaciar os parâmetros e utilizar os métodos. 
 </p>

```C#

using sintaxe_basica.Models;

Pesssoa p = new Pesssoa();

p.Nome = "Gabi";
p.Idade = 21;
p.Apresentar();

```
<h5> Resultado </h5>

<p> Para executar o código e ver o resultado, faça o comando: </p>

```shell
dotnet run
````
<p> E ficará assim no terminal: </p>

```terminal
Olá, meu nome é Gabi e tenho 21 anos!
```



 
</details>

<details> 
<summary><h3> Dados </h3> </summary>
	<details> 
 <summary> Tipos</summary>
<img src="https://github.com/Estudos-Gabi/anotacoes-bootcamp-fullstack/blob/main/sintaxe-basica/images/tiposDados.png" alt="tipos de dados">

<p> 
 
 Imagem tirada do [Tutorial Teacher](https://www.tutorialsteacher.com/csharp/csharp-data-types)
</p>

</details>




<p>
 
 Achei interessante o tipo `Decimal` que é dedicado para o financeiro, no Java não tem isso.</p>




<h2> Casting de Dados </h2>

<p> No C# tem formas de fazer Casting </p>

<p> Maneira Explicita:  </p>

```C#

double myDouble = 9.78;
int myInt = (int) myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt);      // Outputs 9
```

<p> 
 
 Com o comando `Convert` 
 
`Convert.ToBoolean`, `Convert.ToDouble`, `Convert.ToString`, `Convert.ToInt32 (int)` e  `Convert.ToInt64 (long)`:

</p>

```C#

int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
 
```

<p> Com o comando `Parse` dá para converter uma String para um tipo númerico  </p>

```C#

String numeroString = "5";
double numeroDouble = double.Parse(numeroString);

```

<p> Porém, caso a String seja por exemplo:   </p>


```C#

String numeroString = "5A";

```
<p> 
 
 Terá erro e o programa será encerrado, e para que isso não aconteça utilizamos o `tryParse` </p>

<p>
 
 `tryParse` é uma maneira segura de converter String para um número  </p>

```C#
string numeroString = "5.5";
double numeroDouble;

bool sucesso = double.TryParse(numeroString, out numeroDouble);

if (sucesso)
{
    Console.WriteLine($"Conversão bem-sucedida: {numeroDouble}");
}
else
{
    Console.WriteLine("Falha na conversão.");
}
```

</details>


<details>
	<summary> <h3> Estrutura de um projeto .NET </h3> </summary>

 <h3> 
 
 O arquivo `.sln`(Solution) </h3>

 <p>

  O arquivo `.sln` é um arquivo de solução que gerencia um ou mais projetos dentro de uma solução no Visual Studio. Ele contém informações sobre a estrutura da solução, incluindo referências aos projetos que ela contém.
 </p>


<details>
<summary> Exemplo de uma solution </summary>


```C#
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio Version 17
VisualStudioVersion = 17.5.002.0
MinimumVisualStudioVersion = 10.0.40219.1
Project("{9A19103F-16F7-4668-BE54-9A1E7A4F7556}") = "Principal", "Principal\Principal.csproj", "{CAAC9DE9-734D-4401-9089-0E04F07C971C}"
EndProject
Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Comuns.Common", "Comuns.Common\Comuns.Common.csproj", "{F6DB1644-3C3D-4221-990A-E4020B39B292}"
EndProject
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Release|Any CPU = Release|Any CPU
	EndGlobalSection
	GlobalSection(ProjectConfigurationPlatforms) = postSolution
		{CAAC9DE9-734D-4401-9089-0E04F07C971C}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{CAAC9DE9-734D-4401-9089-0E04F07C971C}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{CAAC9DE9-734D-4401-9089-0E04F07C971C}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{CAAC9DE9-734D-4401-9089-0E04F07C971C}.Release|Any CPU.Build.0 = Release|Any CPU
		{F6DB1644-3C3D-4221-990A-E4020B39B292}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
		{F6DB1644-3C3D-4221-990A-E4020B39B292}.Debug|Any CPU.Build.0 = Debug|Any CPU
		{F6DB1644-3C3D-4221-990A-E4020B39B292}.Release|Any CPU.ActiveCfg = Release|Any CPU
		{F6DB1644-3C3D-4221-990A-E4020B39B292}.Release|Any CPU.Build.0 = Release|Any CPU
	EndGlobalSection
	GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection
	GlobalSection(ExtensibilityGlobals) = postSolution
		SolutionGuid = {248D9922-0045-4326-A4EF-11A06005B194}
	EndGlobalSection
EndGlobal
```
 
</details>
 
<p> 
 
 Uma extensão recomendada pelo professor foi o `vscode-solution-explore`</p>

 <img src="#" alt="Print da extensão"> 

<p> A extensão te ajuda a gerenciar suas solutions, podendo criar novas, ou adicionar solutions existentes ao seu projeto. Assim que a extensão é portada: </p>

 <img src="#" alt="Tela da extensão"> 

<h3> 
 
 O arquivo `.csproj`(C# Project) </h3>

<p>
 
 O arquivo `.csproj` é um arquivo de projeto específico para projetos C#. Ele define como o projeto é construído e quais recursos e dependências ele inclui. Este arquivo está no formato XML.</p>

```C#
<Project Sdk="Microsoft.NET.Sdk">

  <ItemGroup>
    <ProjectReference Include="..\Principal\Principal.csproj" />
  </ItemGroup>

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```

<p>
 A relação entre os dois arquivos se dá em: 

- O arquivo `.sln` agrupa um ou mais arquivos .csproj, permitindo que você trabalhe em múltiplos projetos dentro de uma única solução.
- Cada arquivo `.csproj` define um projeto específico, incluindo suas dependências, configurações de compilação e recursos. 
</p>

<p> 
 
 É uma boa práticas criar um projeto Common, que contenha classes que são comuns entre outros projetos. 
 Um projeto Common é do tipo `biblioteca de classes`.
</p>

<p> Um exemplo de estrutura de projeto: </p>

<img src="#" alt="Estrutura do projeto"> 
 
</details>









 
