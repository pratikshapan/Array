﻿using System;


namespace Practice
{
     class Copy
    {
        public static void Main3()
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i, n;
            Console.Write("Input the number of elements in an array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }

           
            Console.Write("\nThe elements stored in the first array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            
            
            Console.Write("\n\nThe elements copied into the second array are :\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }
            Console.Write("\n\n");
        }
    }
}


