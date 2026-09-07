using System;

class MillionaireGame
{
    static void Main()
    {
  
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int score = 0;
        int currentPoints = 100;

  
        string[] questions = {
            "Питання 1, якого кольору прапор України?\n1. жовтий і блакитний\n2. червоний і зелений\n3. чорний і жовтий\n4. зелений і фіолетовий",
            "Питання 2, в якому місті знаходиться ДТЕУ?\n1. Вінниця\n2. Київ\n3. Львів\n4. Одеса",
            "Питання 3, скільки бітів в одному байті?\n1. 4\n2. 8\n3. 16\n4. 32",
            "Питання 4, яка найбільша планета Сонячної системи?\n1. Марс\n2. Земля\n3. Юпітер\n4. Сатурн",
            "Питання 5, скільки днів у високосному році?\n1. 364\n2. 365\n3. 366\n4. 367"
        };

       
        int[] correctAnswers = { 1, 2, 2, 3, 3 };

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"Current User Score: {score}");
            Console.WriteLine(questions[i]);
            Console.Write("Ваша відповідь: ");

            if (int.TryParse(Console.ReadLine(), out int answer))
            {
                if (answer == correctAnswers[i])
                {
                    Console.WriteLine("Correct answer\n");
                    score += currentPoints;
                    currentPoints *= 2; 
                }
                else
                {
                    Console.WriteLine("Wrong Answer");
                    Console.WriteLine("Кінець програми.");

               
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Будь ласка, введіть число від 1 до 4.");
                Console.WriteLine("Кінець програми.");
                Console.ReadKey();
                return;
            }
        }

        Console.WriteLine($"Ви перемогли! Ваш фінальний рахунок: {score}");


        Console.ReadKey();
    }
}