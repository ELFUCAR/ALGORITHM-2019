using System;

namespace Sort
{
    class Sort
    {

        public void BubbleSort(int[] arr)
        {
            int temp;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int j = 1; j <= arr.Length - 1; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }




        static void SelectionSort(int[] arr)
        {
            int smallestIndex, index, minIndex, temp;
            for (index = 0; index < arr.Length - 1; index++)
            {
                smallestIndex = index;
                for (minIndex = index; minIndex < arr.Length; minIndex++)
                {
                    if (arr[minIndex] < arr[smallestIndex])
                        smallestIndex = minIndex;
                    temp = arr[smallestIndex];
                    arr[smallestIndex] = arr[index];
                    arr[index] = temp;
                }
            }
        }

        public int BinarySearch(int s, int[] arr)
        {
            int start = 0, finish = arr.GetUpperBound(0), avg = start + finish / 2;
            while (start <= finish)
            {
                avg = (start + finish) / 2;
                if (arr[avg] > s)
                {
                    finish = avg - 1;
                }
                else if (arr[avg] < s)
                {
                    start = avg + 1;
                }
                else
                {
                    return avg;
                }
            }

            return -1;
        }

        class Test
        {
            static void Main(string[] args)
            {

                string sorted = "";

                Sort b1 = new Sort();
                Sort s1 = new Sort();

                int[] arr = { 78, 55, 45, 98, 13 };

                b1.BubbleSort(arr);

                Console.Write(" Buble sorting: ");
                foreach (int p in arr)
                    Console.Write(p + " ");



                SelectionSort(arr);
                foreach (var item in arr)
                {
                    sorted = sorted + item.ToString() + " ";
                }
                Console.WriteLine("\n--------------------------");
                Console.WriteLine(" Selection Sort: " + sorted);



                s1.BinarySearch(12,arr);
                Console.WriteLine("--------------------------");
                
                

                Console.ReadKey();
            }
        }
    }
}