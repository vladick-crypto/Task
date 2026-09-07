using System;

class NumberTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть висоту трикутника: ");
        if (int.TryParse(Console.ReadLine(), out int height))
        {
            for (int i = 1; i <= height; i++)
            {
             
                Console.Write(new string(' ', height - i));

            
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Будь ласка, введіть коректне число.");
        }

        Console.ReadKey();
    }
}