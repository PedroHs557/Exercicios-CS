//* Exercício 1

// Console.Write("Digite seu nome: ");
// string? nome = Console.ReadLine();

// Console.Write("Digite sua idade: ");
// int idade = Convert.ToInt32(Console.ReadLine());

// Console.Write("Digite sua cidade: ");
// string? cidade = Console.ReadLine();

// Console.WriteLine($"Olá, {nome}! Você tem {idade} anos e mora em {cidade}.");

//* Exercício 2

// Console.Write("Digite o nome do produto: ");
// string? produto = Console.ReadLine();

// Console.Write("Digite a quantidade do produto: ");
// int quantidade = Convert.ToInt32(Console.ReadLine());

// Console.Write("Digite seu preço: ");
// double preco = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("O valor a pagar do produto " + produto + " é: " + (quantidade * preco).ToString("C"));

//* Exercício 3

// Console.Write("Digite a nota do aluno: ");
// double nota = Convert.ToDouble(Console.ReadLine());

// if (10 >= nota && nota >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else if (7 > nota && nota >= 5)
// {
//     Console.WriteLine("Recuperação");
// }
// else if (nota < 5)
// {
//     Console.WriteLine("Reprovado");
// }

// else
// {
//     Console.WriteLine("Nota inválida");
// }

//* Exercício 4

// Console.Write("Digite o número: ");
// decimal numero = Convert.ToDecimal(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     decimal resultado = numero * i;
//     Console.WriteLine($"{numero} x {i} = {resultado}");
// }

//* Exercício 5

    Random rnd = new Random();
    int NA = rnd.Next(1, 11);
    
    Console.Write("Digite um número entre 1 e 10: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    while (numero != NA)
    {
        if (numero < 1 || numero > 10)
        {
            Console.WriteLine("Número inválido. Digite um número entre 1 e 10.");
        }
        else if (numero > NA)
        {
            Console.WriteLine("O número é menor.");
        }
        else if (numero < NA)
        {
            Console.WriteLine("O número é maior.");
        }

        Console.Write("Digite outro número entre 1 e 10: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero == NA)
        {
            Console.WriteLine("Parabéns! Você acertou o número.");
        }
    }