using System;

class Program
{
    static void PrintMultiplicationTable(int number)
    {
        if (number == 0)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}\t");
                }
                Console.WriteLine();
            }
        }
        else
        {
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Автор: Дейко Влад");

        int number;
        while (true)
        {
            Console.Write("Введіть число від 1 до 9 (або 0 для повної таблиці): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number) && number >= 0 && number <= 9)
            {
                break; 
            }
            else
            {
                Console.WriteLine(" Помилка: введено некоректне число. Спробуйте ще раз.\n");
            }
        }

        Console.WriteLine("\n Таблиця множення:\n");
        PrintMultiplicationTable(number);

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
