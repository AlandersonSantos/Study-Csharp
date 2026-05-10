// ============================
// OPERADOR DE ATRIBUIÇÃO (=)
// ============================

// Em C#, o operador "=" significa atribuir um valor a uma variável.

//Criamos uma variável inteira com valor 19
//int a = 19;

//Criamos outra variável inteira com valor 2
//int b = 2;

//Criamos uma terceira variável que armazena a soma
//int c = a + b;

//Console.WriteLine(c);



//============================
//COMBINANDO OPERADORES (=)
//============================

//Criamos uma variável inteira
//int d = 10;

//Criamos outra variável inteira
//int e = 5;

//Armazenamos a soma
//int f = d + e;


//Utilizando uma variável existente
//Somamos mais 5 ao valor atual
//f = f + 5; // 15 + 5

//Console.WriteLine(f);


//Forma resumida da operação acima
//f += 5;
//onsole.WriteLine(f);

//f -= 5;
//Console.WriteLine(f);

//f *= 5;
//Console.WriteLine(f);

//f /= 5;
//Console.WriteLine(f);


//======================
//ORDEM DOS OPERADOES
//======================

/*
****Ordem****

Primeiro: Parenteses "()".
Segundo:Divisão e Multiplicação "/ e *".
Terceiro: Adição e Subtração "+ e -".


*/

//São as regras das ordem matemáticas, como divisão, subtração, multiplicação e adição.


//Primeiro ele divide e depois soma
/*
double a = 4 / 2 + 2; // 4
Console.WriteLine(a);
*/


//Primeiro soma e depois divide, os parenteses tem mais prioridade.
/*
double b = 4 / (2 + 2); // 1
Console.WriteLine(b);
*/