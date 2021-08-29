using System;


namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Enter the size of Array :");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[size];
            for (i = 0; i <= size - 1; i++)
            {
                Console.WriteLine("Enter the Arr [" + i + "]th element in Array :");
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            FindSecondMax FSM = new FindSecondMax();
            FSM.PrintMaxSecond(Arr,size);
        }
    }
    
    public class FindSecondMax
    {
        public void PrintMaxSecond(int[] arr, int size)
        {
            int max;
            
            
            for (int i=0; i<=size-1; i++)
             {
                for(int j = i; j<=size-1;j++)
                {
                    if (arr[i] > arr[j])
                    {
                        max = arr[i];
                        arr[i] = arr[j];
                        arr[j] = max;
                    }
                }
                
                
             }
             Console.WriteLine("Second maximum no from array is :" + arr[size-2]);
            
        }


    }

}
