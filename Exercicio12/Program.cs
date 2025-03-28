using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int palpite;
        bool jogando = true;

        Console.WriteLine("Jogo de Adivinhação (1-100)");
        Console.WriteLine("Digite '0' para sair a qualquer momento.");

        while (jogando)
        {
            Console.Write("O seu palpite é: ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                jogando = false;
                Console.WriteLine("É uma pena que você se cansou de jogar. O número era: " + numeroSecreto);
                continue;
            }

            if (!int.TryParse(input, out palpite))
            {
                Console.WriteLine("Por favor, digite apenas números!");
                continue;
            }

            if (palpite < numeroSecreto)
                Console.WriteLine("MAIOR");
            else if (palpite > numeroSecreto)
                Console.WriteLine("MENOR");
            else
            {
                Console.WriteLine("PARABEEENNSSSS, VOCE ACERTOU!");
                jogando = false;
            }
        }
    }
}