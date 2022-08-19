using System;

namespace Practice
{
    class PrintElement
    {
        public static void Main100()
        {

            /* int[] arr = { 11, 12, 13, 14, 15 };
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine(arr[i]);
             }*/
            int[] arr = new int[10];
            int i;
        

            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
          /*  for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");*/

            foreach(int n in arr)
            {
                Console.WriteLine(n);
            }

        }
    }
}