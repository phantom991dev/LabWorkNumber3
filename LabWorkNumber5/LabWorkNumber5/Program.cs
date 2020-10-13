using System;

namespace LabWorkNumber5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Stop = true;
            int chislo;

            while (Stop)
            {
                Console.WriteLine("Введите любое число из этого примера  z = 1 - x / 2 + y ^ 2 / 6 - x ^ 3 / 24 + y ^ 4 / 120 > ");
                chislo = Convert.ToInt32(Console.ReadLine());

                if (chislo == 0)
                    break;
                if (chislo == 5)
                    break;
                if (chislo == 7)
                    break;
                if (chislo == 8)
                    break;
                if (chislo == 9)
                    break;
                if (chislo == 10)
                    break;

            }
        }
    }
}
