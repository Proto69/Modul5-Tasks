using System.Net.Http.Headers;
using Недостиг_на_храна.Interfaces;

namespace Недостиг_на_храна
{
    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, IBuyer> dict = new();
            List<string> input = new();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(" ").ToList();
                switch (input.Count)
                {
                    case 4:
                        Citizen human = new(input[0], int.Parse(input[1]), long.Parse(input[2]), input[3]);
                        dict.Add(human.Name, human);
                        break;
                    case 3:
                        Rebel rebel = new(input[0], int.Parse(input[1]), input[2]);
                        dict.Add(rebel.Name, rebel);
                        break;
                    /*Пожелание:
                     * default:
                        ErrorShower("Invalid input!");
                        break;*/
                }
            }
            string name = "";
            int allFood = 0;
            while ((name = Console.ReadLine()) != "End")
            {
                if (dict.ContainsKey(name))
                    allFood += dict[name].BuyFood();
                //Пожелание:
                //else
                //    ErrorShower("Invalid name!");
            }
            Console.WriteLine(allFood);
        }

        public static void ErrorShower(string error)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(error);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}