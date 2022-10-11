namespace Stack
{
    internal class StartUp
    {
        static void Main()
        {
            List<string> list = new List<string>();
            MyStack<string> stack = new();
            while ((list = Console.ReadLine().Split().ToList())[0].ToUpper() != "END")
            {
                try
                {
                    switch (list[0])
                    {
                        case "Push":
                            List<string> inputs = new List<string>();
                            for (int i = 1; i < list.Count; i++)
                            {
                                inputs.Add(list[i]);
                            }
                            if (inputs.Count != 0)
                                stack.Push(inputs);
                            break;
                        case "Pop":
                            stack.Pop();
                            break;
                    }
                }
                catch (Exception k)
                {
                    Console.WriteLine(k.Message);
                }
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Main();
        }
    }
}