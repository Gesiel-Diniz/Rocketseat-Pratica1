using System;

class Program()
{
    public static void Main()
    {

        string secondNumber = "0";

        Console.WriteLine("Digite o primeiro número:");
        string? firsNumber = Console.ReadLine();

        while (secondNumber is null || secondNumber == "0")
        {
            Console.WriteLine("Digite o segundo número:");
            secondNumber = Console.ReadLine();

            if (secondNumber is null || secondNumber == "0")
            {
                Console.WriteLine("O segundo número não pode ser zero ou nulo");
            }

        }
    

        if(firsNumber != null && secondNumber != null)
        {
            sum(firsNumber, secondNumber);
            subtract(firsNumber, secondNumber);
            multiplication(firsNumber, secondNumber);
            division(firsNumber, secondNumber);
            average(firsNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("Digite dois números válidos");
        }


    }

    private static void sum(string numOne, string numTwo)
    {
        Console.WriteLine("O resultado da soma é:" + (Convert.ToDouble(numOne) + Convert.ToDouble(numTwo)));
    }

    private static void subtract(string numOne, string numTwo)
    {
        Console.WriteLine("O resultado da subtração é:" + (Convert.ToDouble(numOne) - Convert.ToDouble(numTwo)));
    }

    private static void multiplication(string numOne, string numTwo)
    {
        Console.WriteLine("O resultado da multiplicação é:" + (Convert.ToDouble(numOne) * Convert.ToDouble(numTwo)));
    }

    private static void division(string numOne, string numTwo)
    {
        Console.WriteLine("O resultado da divisão é:" + (Convert.ToDouble(numOne) / Convert.ToDouble(numTwo)));
    }

    private static void average(string numOne, string numTwo)
    {
        Console.WriteLine("A média é:" + Convert.ToDouble((Convert.ToDouble(numOne) + Convert.ToDouble(numTwo))/2));
    }
}