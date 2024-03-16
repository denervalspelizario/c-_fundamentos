// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores Relacionais");


int x = 10;
int y = 20;


Console.WriteLine($"Valor de x = {x}");
Console.WriteLine($"Valor de y = {y}");

Console.WriteLine( x == y); // false

bool resultado = x == y; // false

Console.WriteLine(resultado);


Console.WriteLine(x == y);
Console.WriteLine(x > y);
Console.WriteLine(x < y);
Console.WriteLine(x >= y);
Console.WriteLine(x <= y);
Console.WriteLine(x != y);



// Metodo Equals

Console.WriteLine(x.Equals(y));  // atravez do metodo equals a gente compara variaveis


Console.ReadKey();