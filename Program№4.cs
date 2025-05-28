using System;

class Program
{
    static string TranslateSeason(string seasonUa)
    {
        switch (seasonUa.Trim().ToLower())
        {
            case "весна":
                return "Spring";
            case "літо":
                return "Summer";
            case "осінь":
                return "Autumn";
            case "зима":
                return "Winter";
            default:
                return null; 
        }
    }

    static void Main()
    {
        Console.WriteLine("Автор: Дейко Влад");

        string inputSeason;
        string translated;

        while (true)
        {
            Console.Write("Введіть назву пори року українською мовою: ");
            inputSeason = Console.ReadLine();

            translated = TranslateSeason(inputSeason);

            if (translated != null)
            {
                Console.WriteLine($"\nАнглійською: {translated}");
                break;
            }
            else
            {
                Console.WriteLine(" Помилка: введено невідому пору року. Спробуйте ще раз.\n");
            }
        }

        Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
