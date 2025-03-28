using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua nota de 0 a 10: ");
        double nota = double.Parse(Console.ReadLine());

        string classificacao;

        if (nota < 5)
            classificacao = "Infelizmente sua nota é insuficiente";
        else if (nota < 7)
            classificacao = "Sua nota é regular";
        else if (nota < 9)
            classificacao = "Bom";
        else
            classificacao = "Parabens sua nota foi excelente";

        Console.WriteLine($"Classificação: {classificacao}");
    }
}