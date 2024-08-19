using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    internal class Validation
    {
        public static int GetPositiveRadius()
        {
            int result = -1;
            while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
            {
                Console.WriteLine("Invalid input.");
            }
            return result;
        }

        public static bool GetGrowAgain(Circle circle, int radius)
        {
            while (true)
            {

                Console.WriteLine("Should the circle grow? y/n");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    circle.Grow();
                    return true;
                    break;
                }
                else if (input == "n")
                {
                    return false;
                    Console.WriteLine($"Goodbye. The Circle's final radius is {radius}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid response.");
                }
            }
        }
    }
}
