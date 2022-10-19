namespace Четене_на_редове
{
    public class Program
    {
        static void Main()
        {
            //Testing
            StreamReader streamReader = new("smth.txt");
            string? line = streamReader.ReadLine();
            line = streamReader.ReadLine();
            line = streamReader.ReadLine();
            line = streamReader.ReadLine();
            line = streamReader.ReadLine();
            Console.WriteLine(line);
        }
    }
}