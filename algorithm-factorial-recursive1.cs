/******************************************************************************

factorial recursive.

*******************************************************************************/
using System;
class Recursive {
    
    
    
    public static long Factorial (int n)
    {
        if(n<2)
           return 1;  //factorial with 0 and 1 is 1
           
           
     return n*Factorial(n-1); //the function calls itself
     
    }
    
  static void Main()
  {
     Console.WriteLine(0+" - "+Factorial(0));
     Console.WriteLine(5+" - "+Factorial(5));
     Console.WriteLine(12+" - "+Factorial(12));
  }
}
//result=Factorial(4)=4*Factorial(3)=4*3*Factorial(2)=4*3*2*Factorial(1)