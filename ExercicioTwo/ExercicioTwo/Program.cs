using System;

class Program()
{
    public static void Main()
    {
        Console.WriteLine("Digite seu primeiro nome:");
        string? firstName = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome:");
        string? surname = Console.ReadLine();

        if (firstName != null && surname != null)
        {
            Console.WriteLine("Seu nome completo é: "+ firstName + " " + surname);
        }
        else
        {
            Console.WriteLine("Nenhum nome foi informado!");
        }
    }
}