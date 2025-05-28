using System;

class Program
{
    static bool IsMultiple(int a, int b)
    {
        if (b == 0)
        {
            return false; 
        }
        return a % b == 0;
    }

    static void Main()
    {
        Console.WriteLine("Автор:Дейко Влад");

        int number1, number2;

        while (true)
        {
            Console.Write("Введіть перше ціле число: ");
            if (int.TryParse(Console.ReadLine(), out number1))
                break;
            else
                Console.WriteLine(" Помилка: введено некоректне число. Спробуйте ще раз.\n");
        }

        while (true)
        {
            Console.Write("Введіть друге ціле число (не нуль): ");
            if (int.TryParse(Console.ReadLine(), out number2) && number2 != 0)
                break;
            else
                Console.WriteLine(" Помилка: число повинно бути цілим і не дорівнювати нулю.\n");
        }

        if (IsMultiple(number1, number2))
            Console.WriteLine($"\n {number1} є кратним {number2}.");
        else
            Console.WriteLine($"\n {number1} не є кратним {number2}.");

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
