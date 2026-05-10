//==========================================================
//CONVERTENDO TIPOS DE VARIÁVEIS (INT, FLOAT, STRING E BOOL)
// ==========================================================


/*Processo de converção e chamado de Cast - Canting,
é a forma de passar um a valor do tipo STRING, para um número INT.
Tem duas formas de converte.*/



//*************************************************
//1- CONVERT: Uma classe que recebe vários métodos
//*************************************************

//Nesse casa recebemos uma STRING de valor "8", mas convertemos ela para INT.
//int a = Convert.ToInt32("8");

// Console.WriteLine(a);



//*************************************************
//2- PARSE: Um método que converte o valor para o desejado.

//*************************************************

// int b = int.Parse("5");

// Console.WriteLine(b);

//Gerar um erro não é um inteiro valido, possui uma letrar.
//b = int.Parse("5g");

// Console.WriteLine(b);



//*************************************************
//DIFERENÇA - CONVERT E PARSE.
//*************************************************


//             ====PARSE====
// Parse é usado para converter uma string para outro tipo de dado.
// Porém, ele não aceita valores nulos (null).
// */

// //Retorna um erro.
// //int z = int.Parse(null);

/*
           ====CONVERT====
Convert também serve para converter valores entre tipos de dados.
A diferença é que ele aceita valores nulos e retorna um valor padrão.

Exemplo:

0 para números

false para boolean

// */


// int w = Convert.ToInt32(null);
//Console.WriteLine(w);

//bool r = Convert.ToBoolean(null);
//Console.WriteLine(r);


//======================
//CONVERÇÃO PARA STRING
//======================

//Gera um erro, afinal ele não recebe uma string, mas sim um inteiro
//int inteiro = 5;
//string d = inteiro;


//int numero = 100;
//double pi = 3.14;

//Utilizando o proprio método do objeto
//string n1 = numero.ToString();

//Utilizando o convert.tostring, para fazer a conversão.
//string n2 = Convert.ToString(pi);


//Console.WriteLine(n1);
//Console.WriteLine(n2);

//======================
//CAST IMPLÍCITO
//======================

//Faz uma conversão de forma autómatica, sem necidade da conversão.

//O inteiro cabe facilmente no limite de um Double.

/*
int a = 10;

double b = a;

Console.WriteLine(b); // 10
*/


//Nesse exemplo gerar um erro, por conta que double armazena trilhões, o inteiros somente bilhoes
//Gerando esse erro, pois o valor não cabe no inteiro.
//Podemos utilizar o Converte para resolver ou limitar o double
/*
double a = 10;

int b = a;


Console.WriteLine(b); // 10
*/

//*****************************************
//EXEMPLO DE COMO FAZAR ESSA CONVERSÃO
//*****************************************

//Fazendo isso conseguimos fazer funciona, usando o tipo com a maior casa númerica,
//mas convertemos ela para inteiro

/*

double a = 10;

int b = Convert.ToInt32(a);


Console.WriteLine(b); // 10

*/

//*****************************************
//USANDO O MAXVALUE
//*****************************************

//Diz que queremos usar o valor total daquela tipo de dados.

//Valor cheio de int: 2147483647
//Valor cheio de double: 1.7976931348623157E+308
//Valor cheio de decimal: 79228162514264337593543950335
//Valor cheio de long: 9223372036854775807

//Fazendo que inteiro encaixe de forma certa, mas ao contrário,
//precisamos do converte.
// int a = int.MaxValue; //Valor cheio de int: 2147483647
// double b = Convert.ToInt32(a); //Valor cheio de double: 1.7976931348623157E+308


// Console.WriteLine(b); // 10