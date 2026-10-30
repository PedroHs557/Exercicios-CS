//* Exercício 1

Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite sua cidade: ");
string? cidade = Console.ReadLine();

Console.WriteLine($"Olá, {nome}! Você tem {idade} anos e mora em {cidade}.");