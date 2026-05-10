using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
Criamos uma Classe chamada pessoa que possui dois atributos
e um método
*/



/*
Namespace: Funciona como organização, das classes, representa uma caminho lógico.
Podem ser alterados os nomes, coloque de forma seja util, para sua organização.
*/
namespace Fundamentos_C_.models.Pessoa
{
    //Classe Pessoa que é a forma
    public class Pessoa
    {
        //Primei atributo: Nome do tipo caracter
        public string Nome { get; set; }
        //Segundo atributo: Idade com valor inteiro
        public int Idade { get; set; }

        //Seu método: Ele se apresentar
        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos");
        }
    }
}