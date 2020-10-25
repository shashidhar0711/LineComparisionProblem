/*
 * 
 *  C# CODING STANDARDS - LINE SPACE
 *  NOTE - A SINGLE BLANK LINE SEPARATES THE TWO BLOCKS i.e. USING STATEMENTS, CLASS DECLARATION, etc
 */

/******************************************************************************
 *  Compilation:  C:\Users\Santhu\source\repos\LineComparisionProblem_C\bin\Debug\netcoreapp3.1\LineComparisionProblem_C.exe
 *  Execution:    LineComparisionProblem_C.exe
 *  
 *  Purpose: Computing Comparision Between Two Lengths
 *
 *  @author  Shashidhar C
 *  @version 1.0
 *  @since   18-10-2020
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
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
            /// Computation
            Program program = new Program();
            Console.WriteLine("If get 0 (both are Equal), get 1 (Length1 is greater than Length2)," +
                "get -1 (Length1 is lesser than Length2) :: "+program.ComputeMethod());
        }

        /// <summary>
        /// Computes the method.
        /// </summary>
        /// <returns></returns>
        public int ComputeMethod()
        {
            /// Local Variables
            int length1 = 0, length2 = 0;

            /// By Looping Untill Condition ends
            for (int i = 1; i <= 2; i++)
            {
                /// Taking User Inputs from Console
                Console.WriteLine("Inputs for Two Lines " +i);
                Console.WriteLine("Enter the Value of (x1) :");
                int x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Value of (x2) :");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Value of (y1) :");
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Value of (y2) :");
                int y2 = Convert.ToInt32(Console.ReadLine());
                if (i == 1)
                {
                    /// Calculating Length of Line 1
                    length1 =(int)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                }
                if (i == 2)
                {
                    /// Calculating the Length of Line 2
                    length2 = (int)Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                }
            }
            /// It Returns a Value 
            return length1.CompareTo(length2);
        }
    }
}
