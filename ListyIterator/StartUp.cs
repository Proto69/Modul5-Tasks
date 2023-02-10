namespace ListyIterator
{
    internal class StartUp
    {
        static void Main()
        {
            List<string> list = new List<string>();
            ListyIterator<string> iterator = new ListyIterator<string>();
            while ((list = Console.ReadLine().Split().ToList())[0].ToUpper() != "END")
            {
                try
                {
                    switch (list[0])
                    {
                        case "Create":
                            List<string> inputs = new List<string>();
                            for (int i = 1; i < list.Count; i++)
                            {
                                inputs.Add(list[i]);
                            }
                            if (inputs.Count != 0)
                                iterator = new ListyIterator<string>(inputs);
                            break;
                        case "HasNext":
                            Console.WriteLine(iterator.HasNext());
                            break;
                        case "Move":
                            Console.WriteLine(iterator.Move());
                            break;
                        case "Print":
                            iterator.Print();
                            break;
                    }
                }
                catch (Exception k)
                {
                    Console.WriteLine(k.Message);
                }
            }
            Main();
        }
    }
}