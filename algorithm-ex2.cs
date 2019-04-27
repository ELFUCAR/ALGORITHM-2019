/******************************************************************************
Buble sort / binarySearchTarget
*******************************************************************************/
using System;
namespace Sorting
{
class Program 
{
     public static int[] BubleSort(int[] tab){
            
            int comparisons=0;
            int swaps=0;
            int n = tab.Length;
            
            do{
                //swapped = false;
                for(int i=0; i< n-1; i++){
                    int tmp = tab[i];
                   comparisons++;
                   
                    if(tmp > tab[i+1]){
                        //tab.swap(tab[i],tab[i+1]);
                        tab[i]=tab[i+1];
                        tab[i+1]=tmp;
                        swaps++;
                        //swapped = true;
                        
                    }
                }
                
                n= n-1;
            }while(n != 1);
            
            Console.WriteLine(comparisons);
             Console.WriteLine(swaps);
            return tab;
     }     
     
       public static void PrintOut(int[] arr,  int everyNth)

        {
             Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)

            {

                if (i % everyNth == 1)

                {

                    Console.Write(arr[i] + " ");

                }

            }
             Console.WriteLine();
        }
        
        public static void PrintOut(int[] arr)

        {
             Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)

            {

                    Console.Write(arr[i] + " ");

            }
             Console.WriteLine();
        }
        
        
      public static int binarySearchTarget(int[] array, int targetValue)
    
    {
	    int min = 0;
	    int max = array.Length - 1;
        int guess;
        int result = -1;
    
        while ( min <= max ) {
            guess = ((min + max)/2);
            if (array[guess] == targetValue) { 
              result = guess; 
            } 
    
            if (array[guess] < targetValue ) {
                min = guess + 1;
            } 
            else { 
                max = guess - 1; 
            } 
        }
     return result;
    }

        
  static void Main(string[] args) {
      
      int min = 0; int max = 100;
       int n = 50; int th = 5;
      
       Random random=new Random();
       
      int[] listZero = new int[n];
      

            //the array of N random integers
            for (int i = 0; i < n; i++)
            {
                listZero[i] = random.Next(min,max);
            }
            
            listZero=BubleSort(listZero);
            
            PrintOut(listZero);
            
             int value=7;
           int result=binarySearchTarget(listZero,value);
      
            
            if(result==-1)
            {
                
                Console.WriteLine("The value {0} not found",value);
                
            }
            else
            {
                
                Console.WriteLine("The value {0} found at index ö{1}",value,result);
                
            }
      
  }
  }
}