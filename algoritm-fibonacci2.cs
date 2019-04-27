/******************************************************************************

fibonacci 2.

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
        
        public static long Fibo(int n)
        {
            int a = 1;
            int b = 1;
            
             for(int i=0; i< = n; i++)
            {
                fibo = a + b;
    
                b = a;
                a = fibo;

            }
            
            return fibo;
        }
        
        static void Main()
        {
            Console.WriteLine("enter step");
            step = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(a + " " + "\n" + b + " ");

           

            Console.ReadKey(); //Program sonunda konsolun kapanmaması komutu


        }
    }
}