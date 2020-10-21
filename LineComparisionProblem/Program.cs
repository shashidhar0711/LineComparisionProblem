using System;

namespace LineComparisionProblem
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
       /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            /// variables
            int x1, x2, y1, y2;

            /// Accepts the User Inputs From Console
            /// Calling a toFindLength() Method 
            Console.WriteLine("Enter the Values of (x1,y1),(x2,y2) Points :");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(toFindLength(x1,y1,x2,y2));
        }

        /// <summary>
        /// Function to Calculate Length
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        /// <returns></returns>
        public static int toFindLength(int x1, int y1, int x2, int y2)
        {
            /// Calculating Length
            /// Returns a value of Length to integer value
            return (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) );
        }
    }
}
