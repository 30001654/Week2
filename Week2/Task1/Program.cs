using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {

        static void Main(string[] args)
        {
            double[] array1 = new double[1000];
            Console.WriteLine("*********** Random Numbers **********");
            string line = "";

            for (int i = 0; i < 1000; i++)
            {
                array1[i] = RandomNumberBetween(0.00, 10.00);
            }

            for (int i = 0; i < 1000; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(line);
                    line = "";
                }
                line += String.Format("{0:0.00}", array1[i]) + " ";
            }

            Console.ReadLine();
        }

        private static readonly Random random = new Random();

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
    }
}
