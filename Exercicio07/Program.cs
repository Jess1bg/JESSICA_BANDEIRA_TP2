﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("Este número é par.");
        }
        else
        {
            Console.WriteLine("Este número é ímpar.");
        }
    }
}