// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores de Atribuição");


// usando operadores de atribuição com tipos numéricos

var x = 10;


Console.WriteLine($"O Valor inicial de x = {x}"); // 10
Console.WriteLine($"x += 5 o resultado será  {x += 5}"); // 15
Console.WriteLine($"x -= 5 o resultado será  {x -= 5}"); // 12
Console.WriteLine($"x *= 5 o resultado será  {x *= 5}"); // 48
Console.WriteLine($"x /= 5 o resultado será  {x /= 5}"); // 9
Console.WriteLine($"x %= 5 o resultado será  {x %= 5}"); // 4

// da para fazer atribuição com + com strings segue exemplo

var dado = "123";

dado += "456";

Console.WriteLine(dado); // o resultado de da variavel dado será 123456

Console.ReadLine();
