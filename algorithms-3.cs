/* Algorithms                                          */
/* Comparisons of three methods of sorting             */
/* Bubble sorting, Sorting by Selection and Insertion  */
/* --------------------------------------------------  */

using System;
namespace Sorting
{
    class Program
    {

        public static int getMin(int[] arr, int start)
        {
            int min = arr[start];
            int minIndex = start;
            for (int i = start + 1; i < arr.Length; i++)
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
            return minIndex;
        }

        public static int[] sortBySelection(int[] arr,bool display=false)
        {
          //  long swaps = 0;
            int minIndex;
            for (int i = 0; i < arr.Length; i++)
            {
                int tmp = arr[i];
                minIndex = getMin(arr, i);
                if (i != minIndex)
                {
                   arr[i] = arr[minIndex];
                   arr[minIndex] = tmp;
                   
                //  if(display)
                //   {
                //   swaps++;
                //   }
                }
            }
           //Console.WriteLine("Insertion method did " + swaps + " swaps.");
            return arr;
        }

        public static int[] sortByInsertion(int[] arr,bool display=false)
        {
            long comparisons = 0;
            long swaps = 0;
            int currentValue;
            for (int i = 1; i < arr.Length; i++)
            {
                currentValue = arr[i];
                // Set the start of our inner loop to the same value as i
                
                int j = i;
                
                if(display)
                {
                comparisons++;
                    
                }
                
                while (j > 0 && arr[j - 1] > currentValue)
                {
                    arr[j] = arr[j - 1];
                    j--;
                    if(display)
                    {
                       swaps++;  
                    }
                   
                    
                }
                arr[j] = currentValue;
            }
            Console.WriteLine("Insertion method did " + swaps + " swaps. Comparisons: " + comparisons);
            return arr;
        }

        public static int[] buubleSorting(int[] arr,bool display)
        {
            long comparisons = 0;
            long swaps = 0;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if(display)
                    {
                    comparisons++;
                    }
                    
                     if (arr[i] > arr[i + 1])
                    {
                        int tmp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = tmp;
                        swapped = true;
                        if(display)
                        {
                        swaps++;
                    }
                        
                    }
                }
            } while (swapped == true);
            
            Console.WriteLine("Bubble sort method did " + swaps + " swaps. Comparisons: " + comparisons );
            return arr;
        }


        public static void PrintOut(int[] arr, int n, int everyNth)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % everyNth == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
        
        
        
        public static void PrintOutAll(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                
                
                    Console.Write(arr[i] + " ");
                
            }
        }


        public static void Main(string[] args)
        {
            DateTime start;
            TimeSpan timeItTook;
            int n = 50000; int th = 5000;
            int min = 0; int max = 500;
            Random random = new Random();

            int[] listZero = new int[n];
            int[] listOne = new int[n];
            int[] listTwo = new int[n];
            int[] listThree = new int[n];
            int[] listFour = new int[n];

            //the array of N random integers
            for (int i = 0; i < n; i++)
            {
                listZero[i] = random.Next(min, max);
            }
            Console.WriteLine("The original array has {0} values. Every {1}th is printed out. ", n, th);
            PrintOut(listZero, n, th);
            Console.WriteLine("\n------------------");

            for (int i = 0; i < n; i++)
            {
                listOne[i] = listZero[i];
                listTwo[i] = listZero[i];
                listThree[i] = listZero[i];
                listFour[i] = listZero[i];
            }

            Console.WriteLine("\nSorting by Selection");
            start = DateTime.Now;
            listOne = sortBySelection(listOne);
            timeItTook  = DateTime.Now - start;
            PrintOut(listOne, n, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");

            Console.WriteLine("\nSorting by Insertion");
            start = DateTime.Now;
            listTwo = sortByInsertion(listFour,true);
            timeItTook = DateTime.Now - start;
            PrintOut(listFour, n, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            
            
            Console.WriteLine("\nSorting by Insertion");
            start = DateTime.Now;
            listTwo = sortByInsertion(listTwo,false);
            timeItTook = DateTime.Now - start;
            PrintOut(listTwo, n, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");


            Console.WriteLine("\nBubble Sorting");
            start = DateTime.Now;
            listThree = buubleSorting(listThree,true);
            timeItTook = DateTime.Now - start;
            PrintOut(listThree, n, th);
            Console.WriteLine("\nIt took " + timeItTook);
            Console.WriteLine("------------------");
            
            
            
            int[] test1={2,1,7,0,5};
            test1=buubleSorting(test1,true);
            PrintOutAll(test1);
            
            
            int[] test2={2,1,7,0,5};
            test2=sortByInsertion(test2,true);
            PrintOutAll(test2);
            
            
            //int[] test3={2,1,7,0,5};
           // test3=sortBySelection(test3,true);
           // PrintOutAll(test3);
            
            

        }
    }
}






