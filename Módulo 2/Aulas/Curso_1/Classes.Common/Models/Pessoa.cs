using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Common.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome 
        { 
            /**
            // Um modo de fazer: 
                get
            {
                return _nome.ToUpper();  //TRatamento que retorna o nome no formato Maiusculo 
            }
            */
        
            //Body Expressions (maneira mais resumida e legivel)  preferivel usar sempre que possivel
          
            get=> _nome.ToUpper();

            set 
            {
                if(value == " ")  
                {
                    throw new ArgumentException("O nome não pode ser vazio!"); 
                    //Validação que joga uma exceção se caso o nome estiver vazio

                }

                _nome = value;

            }
        }
        public int Idade {

        get => _idade;
        
        set 
         {
            if(value < 0)
            {
                throw new ArgumentException("\n A idade não pode ser menor do que 0! \n");
            
            }

            _idade = value;
         }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto  => $"{Nome} {Sobrenome}";
        





        public void Apresentar(){
            Console.Write($"Seu nome é {NomeCompleto} , é você tem {Idade} anos! ");

        }
    }
}

        /*
        Modificadores de acesso:
        Public - qualquer um pode acessar a propriedade
        Private - Apenas acessivel dentro da propria classe

        Neste codigo, tanto  o _nome quanto o _idade estão protegidas contra alterações externas
        Idade e Nome  estão validando as informações e ai sim passando para as propriedades privadas.
        Isso é chamado de Encapsulamento
        
        */