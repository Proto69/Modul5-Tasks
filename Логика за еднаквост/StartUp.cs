namespace Логика_за_еднаквост
{
    public class StartUp
    {
        static void Main()
        {
            HashSet<Person> hashSet = new(new HashComparer());
            SortedSet<Person> sortedSet = new(new SortedComparer());

            int n = int.Parse(Console.ReadLine());
            List<string> input = new();
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().ToList();
                Person person = new(input[0], int.Parse(input[1]));
                hashSet.Add(person);
                sortedSet.Add(person);
            }
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
            Main();
        }
    }
}