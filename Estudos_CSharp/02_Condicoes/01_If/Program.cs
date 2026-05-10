//============================
// CONDICIONAL
//============================

//São operadores que possibilitar a alteração,
//da exercução de um código


//****************************
// EXEMPLO:
//****************************

/*
Imagine que estamos em uma loja on-line, com um determinada quantidade de estoque,
e precisamos analisar se o estoque tem a quantidade certa que o cliente deseja.
*/

/*
//Quantidade de material no estoque.
int quantidadeEmEstoque = 100;

//Quantidade que o cliente deseja comprar.
int quantidadecomprar = 200;

//Uma analise de verdadeiro ou falso, para ver se é possivel vende.
// Se minha quantidade de estoque for maior que quantidade de venda é igual: VERDADEIRO
//caso, seuja ao contrario retorne: FALSO
bool possivelVenda = quantidadeEmEstoque >= quantidadecomprar;


Console.WriteLine($"Quantidade de material no estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de compra: {quantidadecomprar}");
Console.WriteLine($" É possivel fazer a compra? {possivelVenda}");
//============================
// IF - SE / ELSE - SENÃO
//============================

//Se o Estoque for maior que o pedido, ele realizar a compra.
if (possivelVenda)
{
    Console.WriteLine("Compra realizada.");
}
//Caso o pedido seja maior que o estoque, ele informar que não possui estoque suficiente.
else
{
    Console.WriteLine("Estoque abaixo do pedido.");
}
*/


//============================
// IF ANINHADO (ELSE IF - CONTINUAÇÃO)
//============================

//Objetivo dele é colocar mais uma condição para ser analisada.
//Vamos fazer uma condição de que se a venda for igual a zero, não ira funcionar

//(==) esse sinal simbolizar uma comparação.
//(&&) Sinal do AND, as duas condições tem que ser verdadeira.


/*
int quantidadeEmEstoque = 100;

int quantidadecomprar = 0;

//Temos duas condições caso as duas seja verdadeira, retorna um TRUE,
//caso seja uma delas verdadeira, vai retorna FALSE
//Só verdadeiro se a quantidade de comprar for maior que 0 e qua.ntidade de estoque for maior que a comprar.
bool possivelVenda = quantidadecomprar > 0 && quantidadeEmEstoque >= quantidadecomprar;

Console.WriteLine($"Quantidade de material no estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade de compra: {quantidadecomprar}");
Console.WriteLine($" É possivel fazer a compra? {possivelVenda}");

//Caso a quantidade de comprar for 0, ele informar isso
if (quantidadecomprar == 0)
{
    Console.WriteLine("Comprar inválida");
}
//Se o Estoque for maior que o pedido, ele realizar a compra.
else if (possivelVenda)
{
    Console.WriteLine("Compra realizada.");
}
//Caso o pedido seja maior que o estoque, ele informar que não possui estoque suficiente.
else
{
    Console.WriteLine("Estoque abaixo do pedido.");
}
*/

