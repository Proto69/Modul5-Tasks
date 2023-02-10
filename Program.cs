namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
            for (int i = 0; i < n; i++)
            {
                switch(int.Parse(Console.ReadLine()))
                {
                    case < 200:
                        p1++;
                        break;
                    case < 400:
                        p2++;
                        break;
                    case < 600:
                        p3++;
                        break;
                    case < 800:
                        p4++;
                        break;
                    default:
                        p5++;
                        break;
                }
            }
            p1 = (p1 / n) * 100;
            p2 = (p2 / n) * 100;
            p3 = (p3 / n) * 100;
            p4 = (p4 / n) * 100;
            p5 = (p5 / n) * 100;
            Console.WriteLine($"{p1:F2}% \n{p2:F2}% \n{p3:F2}% \n{p4:F2}% \n{p5:F2}%");
        }
    }
}