using System;

class Program()
{
    public static void Main()
    {

        DateTime agora = DateTime.Now;

        Console.WriteLine("Data completa: " + agora.ToString("dddd, dd/MM/yyyy"));
        Console.WriteLine("Data normal: " + agora.ToString("d"));
        Console.WriteLine("Horas: " + agora.ToString("T"));
        Console.WriteLine("Horas: " + agora.ToString("dd MMMM yyyy"));

    }
}