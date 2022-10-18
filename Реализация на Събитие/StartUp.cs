namespace Реализация_на_Събитие
{
    public class StartUp
    {
        static void Main()
        {
            Dispatcher dispatcher = new();
            string name = "";
            while ((name = Console.ReadLine()).ToLower() != "end")
            {
                dispatcher.Name = name;
            }
        }
    }
}