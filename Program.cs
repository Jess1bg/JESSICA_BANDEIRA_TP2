using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe a sua data de nascimento (dd/mm/aaaa): ");
        DateTime dataNascimento;

        while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
        {
            Console.Write("Formato incorreto. Tente outra vez (dd/mm/aaaa): ");
        }

        DateTime hoje = DateTime.Today;
        int anos = hoje.Year - dataNascimento.Year;
        int meses = hoje.Month - dataNascimento.Month;
        int dias = hoje.Day - dataNascimento.Day;

        if (dias < 0)
        {
            meses--;
            dias += DateTime.DaysInMonth(hoje.Year, hoje.Month - 1);
        }
        if (meses < 0)
        {
            anos--;
            meses += 12;
        }

        Console.WriteLine($"Idade: {anos} anos, {meses} meses e {dias} dias");
    }
}