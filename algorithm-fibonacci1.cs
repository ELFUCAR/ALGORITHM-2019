/******************************************************************************

fibonacci 1.

*******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0;
            int y = 1;
            int z;
            int n;

            Console.WriteLine("enter step");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(x + " " + "\n" + y + " ");

            for(int i=0; i< n-2; i++)
            {
                z = x + y;
                Console.WriteLine( z );
                x = y;
                y = z;

            }

            Console.ReadKey(); //Program sonunda konsolun kapanmaması komutu


        }
    }
}