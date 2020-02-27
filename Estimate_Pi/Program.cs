using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimate_Pi
{

    class Program
    {
        /// <summary>
        /// Estimates Pi with random function
        /// </summary>
        /// <param name="n">Number of random points</param>
        /// <returns>approximate Pi</returns>
        public static double EstimatePi(int n)
        {
            Random rand = new Random();
            int circlePoints = 0, totalPoints = 0;
            double x, y;

            for (int i = 0; i < n; ++i)
            {
                x = rand.NextDouble();
                y = rand.NextDouble();

                if (x * x + y * y <= 1)
                {
                    circlePoints++;
                }
                totalPoints++;
            }

            return 4.0 * circlePoints / totalPoints;
        }
        static void Main()
        {
            int numberOfPoints;
            for (int i = 0; i < 6; ++i)
            {
                numberOfPoints = (int)Math.Pow(10, i + 1);
                Console.WriteLine("Points: " + numberOfPoints.ToString("0\t") + " Pi: " + EstimatePi(numberOfPoints));
            }
        }
    }
}
