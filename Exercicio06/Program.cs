using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Por favor informe o seu peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Agora digite a sua altura (m, use vírgula): ");
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double imc = peso / (altura * altura);
        string classificacao;

        if (imc < 18.5)
            classificacao = "Abaixo do peso";
        else if (imc < 25)
            classificacao = "Peso normal";
        else if (imc < 30)
            classificacao = "Sobrepeso";
        else if (imc < 35)
            classificacao = "Obesidade Grau I";
        else if (imc < 40)
            classificacao = "Obesidade Grau II";
        else
            classificacao = "Obesidade Grau III";

        Console.WriteLine($"IMC: {imc:F1}");
        Console.WriteLine($"Classificação: {classificacao}");
    }
}