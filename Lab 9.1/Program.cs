using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y, z;
            string inputNumber;

            while (true)
            {
                Console.WriteLine("Input x:");
                inputNumber = Console.ReadLine();
                x = float.Parse(inputNumber);

                Console.WriteLine("Input y:");
                inputNumber = Console.ReadLine();
                y = float.Parse(inputNumber);

                Console.WriteLine("Input z:");
                inputNumber = Console.ReadLine();
                z = float.Parse(inputNumber);

                double resultDouble = Math.Sin(z - y) * Math.Cos((y + z) * Math.Abs(x));
                string resultString = string.Format("{0:F" + 2 + "}", resultDouble);
                Console.WriteLine("Result = " + resultString);

                if (x < -10) Console.WriteLine("x < -10");
                else if (x < -1) Console.WriteLine("x < -1");
                else if (x < 10) Console.WriteLine("x > 1");
                else Console.WriteLine("x > 10");

                if (x == 0) break;
                else if (x < 10) Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
