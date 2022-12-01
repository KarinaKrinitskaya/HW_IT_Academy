using System;
namespace CSharpAdvanced
{
    static public class FlowerRepainter<T> where T : Flower
    {
        private static List<string> colors = new List<string>()
        {
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Indigo",
            "Violet"
        };

        public static void IncreasePrice(T flower)
        {
            flower.Price *= 1.15;
        }

        public static void RepaintFlower(T flower)
        {
            Console.WriteLine($"\nChoose the color for your {flower.Name}. Enter the number:");
            for(int i = 0; i < colors.Count; i++)
            {
                Console.WriteLine($"{colors[i]} - {i}");
            }
            string selectStr = Console.ReadLine();
            bool isOk = int.TryParse(selectStr, out int select);
            if (!isOk || select < 0 || select > 5)
            {
                Console.WriteLine("Incorrect number. Will not repaint.");
            }
            else
            {
                flower.Color = colors[select];
                IncreasePrice(flower);
            }
        }
    }
}

