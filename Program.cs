//Stefeson
Console.Clear();

Console.WriteLine("Qual seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual seu sobrenome?");
string sobrenome = Console.ReadLine();

Console.Clear();

Console.WriteLine($"Seu nome completo é: {nome} {sobrenome}");

Thread.Sleep(3000);
Console.WriteLine($"Seu nome de catálogo é: {sobrenome}, {nome}.");
