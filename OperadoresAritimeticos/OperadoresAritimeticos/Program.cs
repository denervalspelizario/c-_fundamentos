// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores Aritméticos");

Console.WriteLine("Informe o valor de x");

int x = Convert.ToInt32(Console.ReadLine());  // basicamente eu to pegando pegando o dado digitado no console
                                              // que vem como string e convertendo para int 

Console.WriteLine("Informe o valor de y");

int y = Convert.ToInt32(Console.ReadLine());  // basicamente eu to pegando pegando o dado digitado no console
                                              // que vem como string e convertendo para int 

Console.WriteLine($"soma de x + y = {x + y}");
Console.WriteLine($"subtração de x - y = {x - y}");
double divisao = x / y;
Console.WriteLine($"divisão de x / y = {divisao}");
Console.WriteLine($"multiplicação de x * y = {x * y}");


// Uso de algumas operãções usando a classe Math

Console.WriteLine($"\nRaiz quadrada de x {Math.Sqrt(x)}");
Console.WriteLine($"\nPotencia de x elevado a y {Math.Pow(x,y)}");
Console.WriteLine($"\nValor mínimo entre x e y {Math.Min(x,y)}");
Console.WriteLine($"\nValor maximo entre x e y {Math.Max(x, y)}");
Console.WriteLine($"\nCoseno de x  {Math.Cos(x)}");




Console.ReadKey();
