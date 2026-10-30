//* Exercício 1

// Console.Write("Digite seu nome: ");
// string? nome = Console.ReadLine();

// Console.Write("Digite sua idade: ");
// int idade = Convert.ToInt32(Console.ReadLine());

// Console.Write("Digite sua cidade: ");
// string? cidade = Console.ReadLine();

// Console.WriteLine($"Olá, {nome}! Você tem {idade} anos e mora em {cidade}.");

//* Exercício 2

Console.Write("Digite o nome do produto: ");
string? produto = Console.ReadLine();

Console.Write("Digite a quantidade do produto: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite seu preço: ");
double preco = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("O valor a pagar do produto " + produto + " é: " + (quantidade * preco).ToString("C"));

