namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ulong smth = ulong.Parse(Console.ReadLine());
            ulong smth = 64;
                ulong a = 1;
            for(ulong i = 1; i <= smth; i++)
            {
                a = a * i;
            }
            Console.WriteLine(a);
        }
    }
}