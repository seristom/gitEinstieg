using System;

namespace ExperienceWithGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today: 24.04.2019");
			Console.WriteLine("Developer in this Project are: ");
            
            Console.WriteLine("Serist,");
            Console.WriteLine(",...");
            int max = Int32.MaxValue;
            for (int i = 0; i < max; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i + "ist eine Primzahl");
                }
            }
            Console.Read();
        }

        public static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
