namespace Сравняване_на_обекти
{
    public class StartUp
    {
        static void Main()
        {
            List<string> input = new();
            List<Person> persons = new();
            while ((input = Console.ReadLine().Split().ToList())[0].ToUpper() != "END")
            {
                Person person = new(input[0], int.Parse(input[1]), input[2]);
                persons.Add(person);
            }
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            foreach (Person person in persons)
            {
                if (person.CompareTo(persons[n - 1]) == 0)
                    count++;
            }
            if (count == 1)
                Console.WriteLine("No matches");
            else
                Console.WriteLine($"{count} {persons.Count - count} {persons.Count}");
        }
    }
}