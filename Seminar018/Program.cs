using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество чисел M: ");
        if (!int.TryParse(Console.ReadLine(), out int m))
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
            return;
        }

        int countPositiveNumbers = 0;

        for (int i = 1; i <= m; i++)
        {
            Console.Write($"Введите число {i}: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number > 0)
                {
                    countPositiveNumbers++;
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                i--; // Повторяем ввод текущего числа.
            }
        }

        Console.WriteLine($"Количество положительных чисел: {countPositiveNumbers}");
    }
}
