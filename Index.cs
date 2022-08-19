using System;


namespace Practice
{
    internal class Index
    {
        public static void Main22()
        {
            int i, n, temp = 0;
            int[] arr = new int[5];
            Console.Write("Enter five numbers: ");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("Enter a number for search:");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < 5; i++)
            {
                if (arr[i] == n)
                {
                    temp = 1;
                }

            }
            if (temp == 1)
            {
                Console.WriteLine("Number found:" + n);
            }
            else
            {
                Console.WriteLine("Number not found:" + n);
            }
            int index = Array.IndexOf(arr, n);
            Console.WriteLine("Index of given number is =" + index);
        }
    }
}
