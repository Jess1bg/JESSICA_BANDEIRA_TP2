using System;

class Program
{
    static void Main()
    {
        Console.Write("Insira a sua data de nascimento (dd/mm/aaaa): ");
        DateTime dataNascimento;

        while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
        {
            Console.Write("Formato incorreto. Tente novamente (dd/mm/aaaa): ");
        }

        Console.WriteLine("-----------------------------"); 

        DateTime hoje = DateTime.Today;
        DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

        if (proximoAniversario < hoje)
        {
            proximoAniversario = proximoAniversario.AddYears(1);
        }

        int diasRestantes = (proximoAniversario - hoje).Days;
        Console.WriteLine($"Faltam {diasRestantes} dias para o seu próximo aniversário.");
    }
}