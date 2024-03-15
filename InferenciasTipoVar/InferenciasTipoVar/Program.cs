// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Inferência Tipos (var)");
Console.WriteLine();

// o uso de var no c# é possivel vc está deixando na mão da linguagem a tipificação da variável
var idade = 25;
var nome = "Maria";
var salario = 2500.00m;


Console.WriteLine($"{nome} tem {idade} anos e ganha {salario}");


var teste = new Teste();  // estou adicionando a varaivel teste uma nova classe Teste que chama o metodoMeuMetodo

teste.MeuMetodo(); // como esta em (); então ele inicializa sozinho 




// classe teste que sera ativada
class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Sistema de Teste inicializado");
    }
}
