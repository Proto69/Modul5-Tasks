namespace Обхождане_на_свързан_списък
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            MyLinkedList<int> list = new();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                switch (input[0])
                {
                    case "Add":
                        list.Add(int.Parse(input[1]));
                        break;
                    case "Remove":
                        list.Remove(int.Parse(input[1]));
                        break;
                }
            }
            Console.WriteLine(list.Count);
            foreach (var node in list)
            {
                Console.Write(node);
            }
            Main();
        }
    }
}