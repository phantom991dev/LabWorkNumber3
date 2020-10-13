using System;

namespace LabWorkNumber5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Stop = true;
            int number;

            while (Stop)
            {
                Console.WriteLine("Введите любое число из этого примера  z = 1 - x / 2 + y ^ 2 / 6 - x ^ 3 / 24 + y ^ 4 / 120 > ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                    break;
                if (number == 5)
                    break;
                if (number == 7)
                    break;
                if (number == 8)
                    break;
                if (number == 9)
                    break;
                if (number == 10)
                    break;

            }
        }
    }
}
