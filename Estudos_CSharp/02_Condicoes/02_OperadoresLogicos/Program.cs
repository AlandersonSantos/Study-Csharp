//============================
// OPERADORES LÓGICOS
//============================

//Operadores lógicos servem para combinar condições e produzir
//um resultado que sempre será verdadeiro (true) ou falso (false).

//============================
// OPERADORES OR (PIPE, ||, OU)
//============================

//O operador OR (||), ele analisar mais uma condição, caso uma dessas condições
//seja verdadeira, ele permite a entrada.

//Idade tem que ser maior que 18 OU ter autorização dos responsável

/*
Console.WriteLine("Informe sua idade: ");
int idade = Console.Read();

bool autorDosResponsavel = true;


if (idade >= 18 || autorDosResponsavel)
{
    Console.WriteLine("Pode entrar");
}
else
{
    Console.WriteLine("Não pode entar");
}
*/

//============================
// OPERADORES AND (&&)
//============================

//Sendo o operador mais exigente, ele precisa que as duas condições
//Sejam verdadeiras, caso uma seja falsa, ele resultara um false.

/*
bool precensaMinima = true;
float temMedia = 6.5f;

if(precensaMinima && temMedia >=7)
{
    Console.WriteLine("Está aprovado");
}
else
{
    Console.WriteLine("Está reprovado");
}
*/

/*
//============================
// OPERADORES NOT (!)
//============================

//Ele nega a afirmação de uma condição verdadeira ou false.
//O false se torna verdadeiro ou verdadeiro se torna falso.

bool choveu = false;
bool estaTarde = true;

if(!choveu && !estaTarde)
{
    Console.WriteLine("Irei pedalar");
}
else
{
    Console.WriteLine("Irei pedalar outro dia");
}
*/