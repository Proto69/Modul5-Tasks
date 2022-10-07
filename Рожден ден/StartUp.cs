using System.Net.Http.Headers;
using Рожден_ден.Interfaces;

namespace Рожден_ден
{
    public class StartUp
    {
        static void Main()
        {
            List<IBirthday> list = new();
            List<string> input = new();
            while ((input = Console.ReadLine().Split(" ").ToList())[0] != "End")
            {
                switch (input[0])
                {
                    case "Citizen":
                        Human human = new(input[1], int.Parse(input[2]), long.Parse(input[3]), input[4]);
                        list.Add(human);
                        break;
                    case "Robot":
                        Robot robot = new(input[1], long.Parse(input[2]));
                        list.Add(robot);
                        break;
                    case "Pet":
                        Pet pet = new(input[1], input[2]);
                        list.Add(pet);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid input!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            string key = Console.ReadLine();
            List<string> invalidBirthDays = new();
            foreach (var user in list)
            {
                if (user.GetType().Name != "Robot")
                {
                    string birthDay = user.GetBirthDay();
                    string birthDayYear = birthDay.Substring(birthDay.Length - 4);
                    if (birthDayYear == key)
                        invalidBirthDays.Add(birthDay);
                }
            }
            Console.WriteLine(string.Join("\n", invalidBirthDays));
        }
    }
}