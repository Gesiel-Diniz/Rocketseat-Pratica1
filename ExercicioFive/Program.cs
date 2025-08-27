using System;

class Program()
{
    public static void Main()
    {
        Console.WriteLine("Digite uma placa:");
        string? placa = Console.ReadLine();

        bool size = placa.Length == 7;

        if (!size)
        {
            Console.WriteLine("O formato da placa não tem 7 dígitos!!");
            return;
        }

        bool isLetters = placa.Substring(0, 3).All(char.IsLetter);
        bool isNumbers = placa.Substring(3, 4).All(char.IsDigit);

        if (isLetters && isNumbers)
        {
            Console.WriteLine("Placa no formato correto!!");
        }
        else
        {
            Console.WriteLine("Placa no formato incorreto!!");
        }


    }
}
