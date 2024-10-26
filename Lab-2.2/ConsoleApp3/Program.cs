using System;

namespace Pered
{
    class Program
    {
        public static void Pered()
        {
            double a = 1.0;
            double b = 2.0;
            double dx = 0.025;
            double x = a;

            Console.WriteLine("Цикл з передумовою");

            Console.WriteLine(" x\t\t y");
            Console.WriteLine("----------------------");


            while (x <= b)
            {
                try
                {

                    double y = Math.Log(x, 2);

                    Console.WriteLine($"{x:F3}\t\t{y:F5}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{x:F3}\t\tError: {ex.Message}");
                }

                x += dx;
            }
            Console.ReadKey();
        }
    }

}

namespace Pislya
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double a = 1.0;
            double b = 2.0;
            double dx = 0.025;
            double x = a;

            Console.WriteLine("Цикл з післяумовою");

            Console.WriteLine(" x\t\t y");
            Console.WriteLine("----------------------");

            do
            {
                try
                {
                    double y = Math.Log(x, 2);
                    Console.WriteLine($"{x:F3}\t\t{y:F5}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{x:F3}\t\tError: {ex.Message}");
                }

                x += dx;
            } while (x <= b);
            Pered.Program.Pered();
        }
    }
}
