using System;

class Program
{
    static void Main()
    {
        Console.Write("Por favor, digite o valor do seu salário bruto: ");
        double salarioBruto = double.Parse(Console.ReadLine());
        double desconto = 0;

        if (salarioBruto <= 2000)
            desconto = salarioBruto * 0.05;
        else if (salarioBruto <= 4000)
            desconto = salarioBruto * 0.12 - 140;
        else if (salarioBruto <= 6000)
            desconto = salarioBruto * 0.18 - 380;
        else
            desconto = salarioBruto * 0.25 - 650;

        double salarioLiquido = salarioBruto - desconto;

        Console.WriteLine($"\nSalário Bruto: R$ {salarioBruto:F2}");
        Console.WriteLine($"Desconto de Impostos: R$ {desconto:F2}");
        Console.WriteLine($"Salário Líquido: R$ {salarioLiquido:F2}");
    }
}