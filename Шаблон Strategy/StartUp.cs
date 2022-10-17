namespace Шаблон_Strategy
{
    public class StartUp
    {
        static void Main()
        {
            var SortedSetAge = new SortedSet<Person>(new AgeComparer());
            var SortedSetName = new SortedSet<Person>(new NameComparer());

            int n = int.Parse(Console.ReadLine());
            List<string> input = new(); 
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().ToList();
                Person person = new(input[0], int.Parse(input[1]));
                SortedSetAge.Add(person);
                SortedSetName.Add(person);
            }
            Print(SortedSetName);
            Console.WriteLine("------=|=------");
            Print(SortedSetAge);
            Main();
        }

        static void Print<T>(SortedSet<T> set)
        {
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}