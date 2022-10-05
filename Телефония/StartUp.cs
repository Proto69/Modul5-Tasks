namespace Телефония
{
    internal class StartUp
    {
        static void Main()
        {
            Smartphone smartphone = new();
            string[] input = Console.ReadLine().Split(" ").ToArray();
            string[] input1 = Console.ReadLine().Split(" ").ToArray();
            foreach (var number in input)
            {
                smartphone.Call(number);
            }
            foreach (var address in input1)
            {
                smartphone.Browse(address);
            }
        }
    }
}