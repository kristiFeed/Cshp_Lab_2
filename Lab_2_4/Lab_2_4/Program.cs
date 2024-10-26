using System;

namespace main
{
    class Num
    {
        public static (int max, int min, int Max, int Min) FindNum(int n, int m, int[,] a)
        {
            int max = int.MinValue;
            int min = int.MaxValue;

            int Min = 0;
            int Max = 0;

            foreach (int value in a)
            {
                if (value < min)
                {
                    min = value;
                    Min = 1;

                }
                else if (value == min)
                {
                    Min++;
                }

                if (value > max)
                {
                    max = value;
                    Max = 1;
                }
                else if (value == max)
                {
                    Max++;
                }

            }
            return (max, min, Max, Min);
        }
    }
    class Keyboard
    {
        public static void Key()
        {
            int n = 0, m = 0;


            while (n <= 0)
            {
                Console.Write("Введіть n = ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("n повинен бути більше 0");
                }
            }

            while (m <= 0)
            {
                Console.Write("Введіть m = ");
                m = int.Parse(Console.ReadLine());

                if (m <= 0)
                {
                    Console.WriteLine("m повинен бути більше 0");
                }
            }

            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Масив");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            var res = Num.FindNum(n, m, a);

            Console.WriteLine($"Максимальний елемент: {res.max}, кількість входжень: {res.Max}");
            Console.WriteLine($"Мінімальний елемент: {res.min}, кількість входжень: {res.Min}");



        }

    }
    class Ran
    {
        public static void Rand()
        {
            Random rand = new Random();
            int n = 0, m = 0;


            while (n <= 0)
            {
                Console.Write("Введіть n = ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("n повинен бути більше 0");
                }
            }

            while (m <= 0)
            {
                Console.Write("Введіть m = ");
                m = int.Parse(Console.ReadLine());

                if (m <= 0)
                {
                    Console.WriteLine("m повинен бути більше 0");
                }
            }

            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rand.Next(-100, 101);
                }
            }

            Console.WriteLine("Масив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            var res = Num.FindNum(n, m, a);

            Console.WriteLine($"Максимальний елемент: {res.max}, кількість входжень: {res.Max}");
            Console.WriteLine($"Мінімальний елемент: {res.min}, кількість входжень: {res.Min}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int c;

            do
            {

                Console.WriteLine("\nМеню\n1. Ввести значення з клавіатури.\n2. Згенерувати масив\n0. Вихід з програми");

                c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Keyboard.Key();
                        break;

                    case 2:
                        Ran.Rand();
                        break;

                    case 0:
                        Console.WriteLine("Вихід з програми.");
                        break;

                    default:
                        Console.WriteLine("Неправильне число");
                        break;
                }

            } while (c != 0);
        }
    }

}
