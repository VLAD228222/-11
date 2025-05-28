using System;

class Program
{
    static void Swap(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        Console.WriteLine("Автор: Дейко Влад");

        double x, y;

        while (true)
        {
            Console.Write("Введіть перше число: ");
            if (double.TryParse(Console.ReadLine(), out x))
                break;
            else
                Console.WriteLine("❌ Помилка: введено некоректне число. Спробуйте ще раз.");
        }

        while (true)
        {
            Console.Write("Введіть друге число: ");
            if (double.TryParse(Console.ReadLine(), out y))
                break;
            else
                Console.WriteLine("❌ Помилка: введено некоректне число. Спробуйте ще раз.");
        }

        Console.WriteLine($"\nДо обміну: x = {x}, y = {y}");

        Swap(ref x, ref y);

        Console.WriteLine($"Після обміну: x = {x}, y = {y}");

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
