using System;

namespace Keyboard
{
    public class Key
    {
        public static void Keyboard(int n)
        {

            int[] a = new int[n];

            Console.WriteLine("Введіть числа масива");

            for (int i = 0; i < a.Length; i++)
            {

                a[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Масив:");

            foreach (int b in a)
            {

                Console.Write(b + " ");


            }

            var result = Res(0, 0, a);
            int p = result.p;
            int m = result.m;

            Console.WriteLine("\nДодатніх елементів: " + p);
            Console.WriteLine("Відємних елементів: " + m);
        }
        public static (int p, int m) Res(int pl, int min, int[] a)
        {
            int m = 0;
            int p = 0;

            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] > 0)
                {
                    p++;
                }
                else if (a[i] < 0)
                {
                    m++;
                }
            }

            return (p, m);
        }

    }


}



namespace Ran
{
    class Ran
    {
        public static void Rand(int n)
        {
            Random random = new Random();

            int[] a = new int[n];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-100, 101);
            }

            Console.WriteLine("Масив:");

            foreach (int b in a)
            {

                Console.Write(b + " ");


            }

            int m = 0;

            int p = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    m++;
                }
                else if (a[i] > 0)
                {
                    p++;
                }
            }

            Console.WriteLine("\nДодатніх елементів: " + p);
            Console.WriteLine("Відємних елементів: " + m);

        }
    }
}

namespace Program
{
    class Programm
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int c;
            int n;
            do
            {

                Console.WriteLine("Меню:\n1. Ввести масив с клавіатури.\n2. Сгенерувати масив.\n0. Вихід з програми.");

                c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        do
                        {
                            Console.Write("Введіть n: ");

                            n = int.Parse(Console.ReadLine());

                            if (n <= 0)
                            {
                                Console.WriteLine("Ви ввели число менше 0 або нуль. Спробуйте ще раз");
                            }


                        } while (n <= 0);

                        Keyboard.Key.Keyboard(n);
                        break;

                    case 2:
                        do
                        {

                            Console.Write("Введіть n: ");

                            n = int.Parse(Console.ReadLine());

                            if (n <= 0)
                            {
                                Console.WriteLine("Ви ввели число менше 0 або нуль. Спробуйте ще раз");
                            }


                        } while (n <= 0);

                        Ran.Ran.Rand(n);
                        break;

                    case 0:

                        Console.WriteLine("Вихід з програми");

                        break;

                    default:
                        Console.WriteLine("Неправильне число");

                        break;

                }
            } while (c != 0);
        }

    }
}
