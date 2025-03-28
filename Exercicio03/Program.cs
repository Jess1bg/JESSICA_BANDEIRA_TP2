using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma data (dd/mm/aaaa): ");
        DateTime data1;
        while (!DateTime.TryParse(Console.ReadLine(), out data1))
        {
            Console.Write("Formato incorreto. Digite novamente (dd/mm/aaaa): ");
        }

        Console.Write("Digite uma segunda data (dd/mm/aaaa): ");
        DateTime data2;
        while (!DateTime.TryParse(Console.ReadLine(), out data2))
        {
            Console.Write("Formato incorreto. Digite novamente (dd/mm/aaaa): ");
        }

        if (data1 > data2)
        {
            DateTime temp = data1;
            data1 = data2;
            data2 = temp;
        }

        TimeSpan diferencaDias = data2 - data1;
        int anos = data2.Year - data1.Year;
        int meses = data2.Month - data1.Month;
        int dias = data2.Day - data1.Day;

        if (dias < 0)
        {
            meses--;
            dias += DateTime.DaysInMonth(data2.Year, data2.Month - 1);
        }
        if (meses < 0)
        {
            anos--;
            meses += 12;
        }

        Console.WriteLine($"Diferença: {anos} anos, {meses} meses e {dias} dias");
    }
}