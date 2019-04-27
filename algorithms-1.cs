/******************************************************************************

Sorting Algorthms

*******************************************************************************/
using System;
class Program {
    
    //------------------------------------
    
     public static int[] BubleSort(int[] tab){
            
            int n = tab.Length;
            
            do{
                //swapped = false;
                for(int i=0; i< n-1; i++){
                    int tmp = tab[i];
        
                    if(tmp > tab[i+1]){
                        //tab.swap(tab[i],tab[i+1]);
                        tab[i]=tab[i+1];
                        tab[i+1]=tmp;
                        //swapped = true;
                        
                    }
                    
                }
                
                n= n-1;
            }while(n != 1);
            return tab;
        }
    
    //----------------------------------
    
    
    
     public static void printOut( int[] arr){
           Console.WriteLine();
            for(int i=0; i <arr.Length; i++){
                Console.Write(arr[i] + " ");
            }  
            Console.WriteLine();
        }
        
  static void Main() {
      
      int[] tab={1,0,4,8,11,3,8,-2,5};
      printOut(tab);
      
      tab = BubleSort(tab);
      
      printOut(tab);
      
 
  }
}

