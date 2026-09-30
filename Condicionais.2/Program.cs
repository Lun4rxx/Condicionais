// Cria uma variável para informar se o cliente é VIP.
// true = é cliente VIP
// false = não é cliente VIP
bool clienteVIP = true;


// Cria uma variável para armazenar a idade do cliente.
int idade = 18;


// Cria uma variável para armazenar o valor normal do ingresso.
double valorIngresso = 30.00;


// Cria uma variável para informar se o cliente é estudante.
// true = é estudante
// false = não é estudante
bool ehEstudante = false;


// Verifica se o cliente é VIP.
// Se for VIP, ele recebe um desconto de 60%.
// Por isso, pagará apenas 40% do valor original.
if (clienteVIP)
{
    valorIngresso = valorIngresso * 0.4;
}


// Caso o cliente não seja VIP, verificamos outras possibilidades
// para aplicar um desconto de 50%.
//
// O desconto será aplicado se:
// - a idade for menor ou igual a 7 anos;
// - OU a idade for maior ou igual a 60 anos;
// - OU o cliente for estudante.
else if (idade <= 7 || idade >= 60 || ehEstudante)
{
    valorIngresso = valorIngresso * 0.5;
}


// Exibe na tela o valor final que o cliente deverá pagar.
Console.WriteLine($"O valor do ingresso a pagar é R$ {valorIngresso}");