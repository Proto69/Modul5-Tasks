using System.Net.Http.Headers;
using Рожден_ден.Interfaces;

namespace Рожден_ден
{
    public class StartUp
    {
        static void Main()
        {
            List<IID> list = new();
            List<string> input = new();
            while ((input = Console.ReadLine().Split(" ").ToList())[0] != "End")
            {
                switch (input.Count)
                {
                    case 3:
                        Human human = new(input[0], int.Parse(input[1]), long.Parse(input[2]));
                        list.Add(human);
                        break;
                    case 2:
                        Robot robot = new(input[0], long.Parse(input[1]));
                        list.Add(robot);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid input!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            int key = int.Parse(Console.ReadLine());
            List<long> invalidIds = new();
            foreach (var user in list)
            {
                long id = user.ID;
                if (id % 1000 == key)
                    invalidIds.Add(user.GetID());
            }
            Console.WriteLine(string.Join("\n", invalidIds));
        }
    }
}