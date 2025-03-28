using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = numero; i >= 0; i--)
        {
            Console.Write(i);
            if (i > 0) Console.Write(", ");
        }
    }
}