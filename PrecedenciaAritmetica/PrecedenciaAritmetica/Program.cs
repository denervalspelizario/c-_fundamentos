// See https://aka.ms/new-console-template for more information
Console.WriteLine("Precedência de operadores");


int x = 10 - 2 * 3;


Console.WriteLine(x);
Console.WriteLine();

// ordem de precedencia de operadores logicos

// ordem seria !  ,   && , ||    ou seja !(ou NOT) primeiro, && segundo e ||(or)  em ultimo


bool o = !(9 != 8) && 5 >= 7 || 8 >= 6 ;



Console.WriteLine(o); // true
Console.WriteLine();


// ordem de precedencia de operadores

int a = 5, b = 6, c = 7;

int r = --a * b - ++c;


Console.WriteLine(r); // 19





