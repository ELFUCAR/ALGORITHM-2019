  /******************************************************************************

Sorting Algorthms

*******************************************************************************/
using System;
class Program {
    
    //------------------------------------
    
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
    
    //----------------------------------
    
    
    
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
        
  static void Main() {
      
      int[] tab={1,0,4,8,11,3,8,-2,5};
      
             DateTime start;
             TimeSpan timeItTook;

            int n = 5000; int th = 500;

            int min = 0; int max = 100;

            Random random = new Random();
            //-------------------
            
             int[] listZero =new int [n];
             int[] listOne =new int [n];
             int[] listTwo =new int [n];
             int[] listThree =new int [n];
            
            
            for (int i = 0; i < n; i++)

            {

                listZero[i] = random.Next(min, max);

            }
            
            for (int i = 0; i < n; i++)

            {

                listOne[i] = listZero[i];
                listTwo[i] = listZero[i];
                listThree[i] = listZero[i];

            }
            
          Console.WriteLine("\nSorting by Bubble");
          tab = listOne;
          PrintOut(tab,th);
          
            start = DateTime.Now;
            tab = BubleSort(tab);
            timeItTook  = DateTime.Now - start;
            PrintOut(tab,th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            PrintOut(listZero,th);
        // tab = SelectionSorting  (tab);
           
          
           
  }
}


         

     


