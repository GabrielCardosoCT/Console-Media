// See https://aka.ms/new-console-template for more information
using System;

namespace Media
{

    class Program 
    {
        static void Main(string[] args)
        {
            // Saudação
            Console.WriteLine("Porfavor, digite o seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome);
            // ------------------------
            
            Console.WriteLine("A seguir, digite os números que serão usados para calcular a média.");

            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto número:");
            int n4 = int.Parse(Console.ReadLine());

            int media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("Sua média é de " + media);

            if (media >= 6) {
                Console.WriteLine("Você foi aprovado na disciplina.");
                Console.WriteLine("Parabéns!");
            }
            else {
                Console.WriteLine("Você foi reprovado na disciplina");
                Console.WriteLine("Que pena...");
            }

            Console.WriteLine("*** Fim da execução");


        }
    }
}