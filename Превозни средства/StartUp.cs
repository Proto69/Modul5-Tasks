namespace Превозни_средства
{
    internal class StartUp
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();
            Car car = new(double.Parse(input[1]), double.Parse(input[2]));
            input = Console.ReadLine().Split(" ").ToList();
            Truck truck = new(double.Parse(input[1]), double.Parse(input[2]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(" ").ToList();
                switch (input[0])
                {
                    case "Drive":
                        if (input[1] == "Car")
                        {
                            car.Drive(double.Parse(input[2]));
                        }
                        else if (input[1] == "Truck")
                        {
                            truck.Drive(double.Parse(input[2]));
                        }
                        break;
                    case "Refuel":
                        if (input[1] == "Car")
                        {
                            car.Refuel(double.Parse(input[2]));
                        }
                        else if (input[1] == "Truck")
                        {
                            truck.Refuel(double.Parse(input[2]));
                        }
                        break;
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}