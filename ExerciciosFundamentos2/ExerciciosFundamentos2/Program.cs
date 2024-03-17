namespace ExerciciosFundamentos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicios 2 Fundmanentos C#");

            Console.WriteLine("Exercicio 1");
            string nome = "Denerval";
            int idade = 17;
            double nota = 7.5;


            Console.WriteLine($"Aluno {nome} tem {idade} anos e sua nota é {nota}\n");


            //Exercicio 2
            Console.WriteLine("Exercicio 2");

            Console.WriteLine($"Aluno = {nome} \nidade = {idade}  \nnota = {nota}\n");

            // Exercicio 3

            Console.WriteLine("Digite alguma letra 1!");
            char l1 = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("Digite alguma letra 2!");
            char l2 = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("Digite alguma letra 3!");
            char l3 = Convert.ToChar(Console.ReadLine());


            Console.WriteLine($"A primeira letra foi a {l1}, a segunda foi a {l2}, e a terceira {l3}\n");

         
            

            Console.WriteLine("Exercicio 3");
            Console.WriteLine("Digite um valor!");
            double valor01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um segundo valor!");
            double valor02 = Convert.ToDouble(Console.ReadLine());


            double soma = valor01 + valor02;
            double subtracao = valor01 - valor02;   
            double divisao = valor01 / valor02;
            double multiplicacao = valor01 * valor02;
            double exponenciacao = Math.Pow(valor01, valor02);
            double resto = valor01 % valor02;

            Console.WriteLine($"A soma de {valor01} + {valor02} = {soma}\n ");
            Console.WriteLine($"A subtracao de {valor01} - {valor02} = {subtracao}\n ");
            Console.WriteLine($"A divisao de {valor01} / {valor02} = {divisao}\n ");
            Console.WriteLine($"A multiplicacao de {valor01} * {valor02} = {multiplicacao}\n ");
            Console.WriteLine($"A exponenciacao do {valor01} elevado ao {valor02} = {exponenciacao}\n ");
            Console.WriteLine($"O resto do {valor01} com {valor02} = {resto}\n ");





            Console.WriteLine();





        }
    }
}
