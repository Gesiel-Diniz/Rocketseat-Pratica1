using System;

class Program()
{
    public static void Main()
    {
        Console.WriteLine("Digite seu nome:");
        string? nome = Console.ReadLine();

        if(nome != null)
        {
            Console.WriteLine("Olá, " + nome + "! Seja muito bem-vindo!");
        }
        else
        {
            Console.WriteLine("Nenhum nome foi informado!");
        }
    }
}
