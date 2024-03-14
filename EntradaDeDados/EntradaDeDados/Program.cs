// See https://aka.ms/new-console-template for more information
using System.Threading.Channels;

Console.WriteLine("Entrada de Dados");

Console.WriteLine("\nInforme o seu nome completo");

string nomeCompleto = Console.ReadLine(); // recebendo o dado digitado

Console.WriteLine("\nInforme a sua idade");

int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInfome o dia do seu nascimento");
int diaNascimento = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("\nO seu nome é " + nomeCompleto); // imprimindo atravez de uma concatenação 

Console.WriteLine($"\nA sua idade é {idade}");

Console.WriteLine("\nO dia do seu nascimento foi " + diaNascimento);

Console.ReadKey();