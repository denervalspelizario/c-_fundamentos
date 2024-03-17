namespace OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## Operador Uniário e Ternário ##");

            Console.WriteLine();

            Console.WriteLine("Informe o numero: \n");

            var n = Convert.ToInt32(Console.ReadLine()); // recendo o numero que o usuario digitou

            Console.WriteLine($"O negativo de {n} é {-n}");


            Console.WriteLine("=====================");

            Console.WriteLine("Informe a temperatura");
            int temperatura = Convert.ToInt32(Console.ReadLine()); // recebendo a temperatura informada pelo user

            var resultado = temperatura >= 23 ? "Está calor para caraleo" : "Está frio bote uma blusa";

            Console.WriteLine(resultado);

        }
    }
}
