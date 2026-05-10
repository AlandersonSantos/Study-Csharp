//============================
//TIPOS DE DADOS
//============================

/*

STRING --> Usado para cadeia de texto, sempre acompanhado por aspas duplas:
"Maçã", "Peixe", "Jesus Cristo".

INT --> Para valores numéricos inteiros:
2026, 666, 68, 269876.

DOUBLE --> Para valores decimais:
 1.20, 3.14, 0.555.

DECIMAL --> Usado principalmente para valores monetários,
pois trabalha melhor com precisão decimal:
1000.56789, 580.

OBS: Precisa da letra "M" no final do valor.
Exemplo: 2.80M

BOOL --> Valor lógico usado para verdadeiro ou falso:
true ou false.

("Texto" + Variavel) --> Usado para concatenar valores.

Console.WriteLine(Variavel ou "Texto")
--> Comando usado para mostrar algo no terminal.

pi.ToString("0.000")
--> Usado para formatar números decimais.

*/



//Variável do tipo string
//string nome = "Paulo";

//Variável do tipo inteiro
//int idade = 32;


// O tipo double pode ignorar zeros no final.
// Exemplo: 3.140 pode aparecer como 3.14
//double pi = 3.140;


//Tipo mais usado para valores monetários,
//pois mantém a precisão decimal
//decimal preco = 2.80M;


//Valor lógico (verdadeiro ou falso)
//bool condicao = false;


//Console.WriteLine(nome);
//Console.WriteLine("Minha variável idade é " + idade);
//Console.WriteLine("O valor da minha variável pi é " + pi.ToString("0.000"));
// Console.WriteLine("Preço do produto: " + preco);
// Console.WriteLine("Minha variável condição é " + condicao);


// ============================
//TIPO DateTime
//============================

// para representar datas e horários.
//Ele coleta essas informações diretamente do computador.

//Pega a data e hora atuais
//DateTime dataAtual = DateTime.Now;
//Console.WriteLine(dataAtual);


// Pega a data e hora atuais e adiciona 5 dias
// dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual);


//  Pegamos a data e hora atuais
// dataAtual = DateTime.Now;

//  Mas mostramos somente a data
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));


// Pegamos a data e hora atuais
//  dataAtual = DateTime.Now;

// Mostramos data, hora e minutos
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
