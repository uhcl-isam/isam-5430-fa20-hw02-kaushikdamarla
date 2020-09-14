using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments.Loop1
{
    public class OddNumbers
    {
        /// <summary>
        /// First prompt for the start and the end number. Then, Write all odd integers between start and ending number inclusive (in ascending order) on separate lines.
        /// </summary>

        public static void Main()
        {
            Console.Error.WriteLine("Enter the starting number");
            int n = int.Parse(Console.ReadLine());

            // Codes to enter start
            Console.Error.WriteLine("Enter the ending number");
            int p = int.Parse(Console.ReadLine());

            int i;



            // Codes to enter end.
            for (i=n; i<=p; i++ ) {

                if ( i%2 != 0)
                    {
                        Console.WriteLine(i);
                    }
            }

            
        }
    }
}
