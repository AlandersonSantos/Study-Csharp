//============================
// SWITCH CASE
//============================

//O switch case é uma estrutura de decisão usada quando você quer executar ações diferentes dependendo do valor de uma variável. 
//Em vez de fazer vários if e else if, ele organiza melhor o código quando a comparação é sempre com a mesma variável.


//Console.WriteLine("Digite uma letra: ");
/*
//Console.ReadLine() é a entrada de informação do usuário
string letra = Console.ReadLine();
*/


//============================
// USANDO O IF ANINHADO COMO EXEMPLO:
//============================

/*
if (letra == "a")
{
    Console.WriteLine("Isso é uma vogal");
}
else if(letra == "e")
{
    Console.WriteLine("Isso é uma vogal");
}
else if(letra == "i")
{
    Console.WriteLine("Isso é uma vogal");
}
else if(letra == "o")
{
    Console.WriteLine("Isso é uma vogal");
}
else if(letra == "u")
{
    Console.WriteLine("Isso é uma vogal");
}
else
{
    Console.WriteLine("Isso não é uma vogal");
}
*/

//============================
// USANDO O IF E OPERADORES LÓGICOS COMO EXEMPLO:
//============================

// OPERADOR || (OU) piper, usar quando precisamos ter um condição correta.

/*
if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
    Console.WriteLine("Isso é uma vogal");
}
else
{
    Console.WriteLine("Isso não é uma vogal");
}
*/

//============================
// UTILIZANDO SWITCH CASE
//============================

//SWITE(VARIAVEL) - Diz qual a variável será analisada.

//BREAK - ele diz ao código para finalizar, quando a condição é atendida.
//Sem ele o código continua rodando.

//DEFAULT - Ele executa quando nenhuma das CASE combina.

/*
switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Uma vogal");
        break;

    default:
        Console.WriteLine("Isso não é uma vogal");
        break;
}
*/