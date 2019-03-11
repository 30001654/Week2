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
            double[] array2 = new double[1000];
            Console.WriteLine("*********** Random Numbers **********");

            initArray(array1);
            printArray(array1);
            dupArray(array1, array2);
            Console.WriteLine("*********** Numbers greater than 2 **********");
            queryArray(array1);

            Console.ReadLine();
        }

        private static void initArray(double[] array1)
        {
            for (int i = 0; i < 1000; i++)
            {
                array1[i] = RandomNumberBetween(0.00, 10.00);
            }
        }

        private static void printArray(double[] array1)
        {
            string line = "";

            for (int i = 0; i < 1000; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(line);
                    line = "";
                }
                line += String.Format("{0:0.00}", array1[i]) + " ";
            }
        }

        private static void dupArray(double[] array1, double[] array2)
        {
            for(int i = 0; i < 1000; i++)
            {
                array2[i] = array1[i];
            }
        }

        private static void queryArray(double[] array2)
        {
            int count = 1;
            var biggerThan2 =
                from number in array2
                where number > 2
                select number;

            foreach (double x in biggerThan2)
            {
                Console.Write(String.Format("{0:0.00}", x) + " ");
                if (count % 10 == 0)
                {
                    Console.Write("\n");
                }
                count++;
            }
        }

        private static readonly Random random = new Random();

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
    }
}
