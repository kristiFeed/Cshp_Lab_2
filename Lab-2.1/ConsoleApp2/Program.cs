using System;

namespace city
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int a;

            do 
            {
                Console.WriteLine("Введіть індекс");

                a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 58000:

                        Console.WriteLine($"Місто за індексом {a}: Чернівці.");

                        break;

                    case 01001:

                        Console.WriteLine($"Місто за індексом {a}: Київ.");

                        break;

                    case 79000:

                        Console.WriteLine($"Місто за індексом {a}: Львів.");

                        break;

                    case 65000:

                        Console.WriteLine($"Місто за індексом {a}: Одеса.");

                        break;

                    case 49000:

                        Console.WriteLine($"Місто за індексом {a}: Дніпро.");

                        break;

                    case 73000:

                        Console.WriteLine($"Місто за індексом {a}: Херсон.");

                        break;

                    case 61000:

                        Console.WriteLine($"Місто за індексом {a}: Харків.");

                        break;

                    case 76000:

                        Console.WriteLine($"Місто за індексом {a}: Івано-Франківськ.");

                        break;

                    case 50000:

                        Console.WriteLine($"Місто за індексом {a}: Кривий Ріг.");

                        break;

                    case 40000:

                        Console.WriteLine($"Місто за індексом {a}: Суми.");

                        break;

                    case 0:

                        Console.WriteLine("Вихід з програми.");

                        break;

                    default:

                        Console.WriteLine("Неправильний індекс.");

                    break;
                }
            }while (a != 0);
            
        }
    }
}

