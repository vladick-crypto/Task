using System;
using System.Data;

class StringCalculator
{
    static void Main()
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть математичний вираз: ");
        string expression = Console.ReadLine();

        try
        {
 
            DataTable table = new DataTable();
            var result = table.Compute(expression, string.Empty);

            Console.WriteLine($"Відповідь програми: {result}");
        }
        catch (Exception)
        {
            Console.WriteLine("Помилка: введено некоректний вираз.");
        }

  
        Console.ReadKey();
    }
}