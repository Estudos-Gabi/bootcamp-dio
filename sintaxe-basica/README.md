<img src="https://github.com/Estudos-Gabi/anotacoes-bootcamp-fullstack/blob/main/sintaxe-basica/images/banners%20(2).png" alt="banner">

<h2>

Sobre

</h2>

[![- BootCamp](https://img.shields.io/badge/_-BootCamp-pink?style=for-the-badge)](https://web.dio.me/track/coding-the-future-xp-full-stack-developer)

<p> Segundo módulo do bootcamp com os seguintes cursos:

- Sintaxe e Tipos de Dados em C#
- Tipos de Operadores em C#
- Operadores Aritméticos em C#S
- Conhecendo as Estruturas de Repetição em C#
- Conhecendo a Organização de um Programa em C#
- Array e Listas em C#
- Construindo um Sistema para um Estacionamento com C#

</p>


<h2> Sintaxe e Tipos de Dados em C# </h2>

 <h3> Entendendo a estrutura de um projeto </h3> 
  
<p> Para iniciar um projeto .NET é necessário que vá ao terminal e escreva: </p>

```shell
  dotnet new console 
``` 

<p> Esta é a estrutura padrão de um projeto: </p>

<img src="https://github.com/Estudos-Gabi/anotacoes-bootcamp-fullstack/blob/main/sintaxe-basica/images/Captura%20de%20tela%202024-07-31%20104701.png" alt="estrutura do projeto padrão">

<p>
  
  As pastas  `bin`     e `obj` são pastas que não precisam ser mexidas

 Os arquivos `sintaxe-basica.csproj`  e  ` sintaxe-basica.sln`  são as configurações do projeto. 

  Já o `Program.cs`  é onde vamos fazer o código em si.
  	
</p>


<h3> O conceito de classe </h3> 
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
<img src="#" alt="criando classe">

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
