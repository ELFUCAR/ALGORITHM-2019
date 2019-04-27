/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace sortstrings
{
    class Program
    {
        static void Main(string[] args)
        {


            string str1 = "ABC";
            string str2 = "XFG";
            if (String.Compare(str1, str2) < 0)
            {
                // str1 is less than str2
                Console.WriteLine("Yes");
            }
            else if (String.Compare(str1, str2) == 0)
            {
                // str1 equals str2
                Console.WriteLine("Equals");
            }
            else
            {
                // str11 is greater than str2, and String.Compare returned a value greater than 0
                Console.WriteLine("No");
            }


            Console.ReadKey();

        }
    }
}