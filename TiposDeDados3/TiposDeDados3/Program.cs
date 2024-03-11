// See https://aka.ms/new-console-template for more information
Console.WriteLine("Atribuindo valores para bool e char");
Console.WriteLine("Definindo variáveis do tipo string, object e dynamic");


Console.WriteLine("Boolean e  Char");
bool ativo = true;              // bool e Boolean  são equivalentes
Boolean inativo = false;

Console.WriteLine(ativo);
Console.WriteLine(inativo);

char sexo = 'M';

Console.WriteLine();
Console.WriteLine("O sexo do bebe é " + sexo);


Console.WriteLine();
Console.WriteLine("string e object");
// tipo string para conjunto de caracteres
string nome = "Maria";

/*
 A variável object pode armazenar qualquer tipo de valor, 
 pois é a base para todos os tipos em C#.
 */

object qualquerCoisa = 10; // pode ser qualquer tipo


/* A variável dynamic permite que o tipo seja determinado em tempo de execução,
   fornecendo flexibilidade. */

dynamic valor = 10;
valor = "dez";


Console.WriteLine(valor);
Console.WriteLine(nome);
