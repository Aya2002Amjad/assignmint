using System;

namespace Assignment1._2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("please enter the array size: ");
            int n =Convert.ToInt32( Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Please enter num {0}{1}",i+1,":");
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The output for the sorted array : ");
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
