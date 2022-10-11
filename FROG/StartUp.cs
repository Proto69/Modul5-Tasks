namespace FROG
{
    public class StartUp
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToList();
            Lake lake = new(input);

            foreach (var item in lake)
            {
                Console.WriteLine(item);
            }
        }
    }
}