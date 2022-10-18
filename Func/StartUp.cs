namespace Func
{
    public class StartUp
    {
        public delegate void AddNumbers(int a, int b);
        static void Main()
        {
            //Action
            List<string> list = Console.ReadLine().Split().ToList();
            string str = Console.ReadLine();

            Action<string> action = str => Console.WriteLine(str);
            list.ForEach(action);

            //Func
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Func<List<int>, int> func = nums => GetMinValue(nums);
            Console.WriteLine(func(nums));

            //Predicate
            Predicate<int> predicateEven = num => num % 2 == 0;
            Predicate<int> predicateOdd = num => num % 2 != 0;
            string type = Console.ReadLine();
            if (type == "odd")
                Console.WriteLine(string.Join(" ", nums.FindAll(predicateOdd)));
            else if (type == "even")
                Console.WriteLine(string.Join(" ", nums.FindAll(predicateEven)));

            //Delegate
            AddNumbers addNumbers = (a, b) => Console.WriteLine($"{a} + {b} = {a + b}");
            addNumbers(10, 20);
            //Output: 10 + 20 = 30
            addNumbers += PrintInterval;
            addNumbers(10, 20);
            //Output: 10 + 20 = 30
            //------=|=------
        }

        static void PrintInterval(int a, int b)
        {
            Console.WriteLine("------=|=------");
        }

        static int GetMinValue(List<int> list)
        {
            int min = list[0];
            foreach (var item in list)
            {
                if (item < min)
                    min = item;
            }
            return min;
        }

    }
}