using System;
using System.Globalization;

class Program()
{
    public static void Main()
    {

        int count = 0;
        string words = "";

        while(words == null || words == "")
        {
            Console.WriteLine("Digite uma ou mais palavras:");
            words = Console.ReadLine();
        }

        for(int i = 0; i < words.Length; i++)
        {
            if(words[i] != ' ')
            {
                count++;
            }
        }

        Console.WriteLine("A palavra(s) tem : " + count + " letras!!");

    }

}
