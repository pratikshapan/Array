using System;


namespace Practice
{
    class Position
    {
        public static void Main7()
        {
            
            int[] arr = new int[10];

            int n, i, num, loc;

            Console.Write("Enter size of an array:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter array elements:");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter element for insert:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter location:");
            loc = Convert.ToInt32(Console.ReadLine());

            for (i = n; i >= loc; i--)
            {
                arr[i] = arr[i - 1];
            }
            n++;
            arr[loc - 1] = num;

            Console.Write("\nList After Insertion :");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }


        }

    }
}