using System;

namespace Practice
{
   class SumOfArray
    {
        public static void Main()
        {
            Console.WriteLine("Enter size of an arry");
            int  n = Convert.ToInt32(Console.ReadLine());
            int   sum = 0;
            
            int[] arr = new int[n];
            Console.WriteLine("Enter elements in an array");
            for(int i =0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i =0;i < arr.Length;i++)
            {
                sum = sum + arr[i];
            }


            Console.WriteLine("Sum of Array Elements" +sum);


             

        }
    }
}
