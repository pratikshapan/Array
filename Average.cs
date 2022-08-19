using System;


namespace Practice
{
    class Average
    {
        public static void Main238()
        {

            double sum = 0, avg = 0;
            
            Console.Write("Enter Size of an array");
            int n = Int32.Parse(Console.ReadLine());
            double[] numbers = new double[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                sum += numbers[i];
               
            }
            avg = sum / numbers.Length;
            
            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine("The Average is : " + avg);
            Console.WriteLine("Count is " + numbers.Length);
            


            /* int[] a = new int[100];
             int i, n, sum = 0;
             double avg = 0;
             Console.Write("Input the number of elements to be stored in the array :");
             n = Convert.ToInt32(Console.ReadLine());

             Console.Write("Input {0} elements in the array :\n", n);
             for (i = 0; i < n; i++)
             {
                 Console.Write("element - {0} : ", i);
                 a[i] = Convert.ToInt32(Console.ReadLine());
             }

             for (i = 0; i < n; i++)
             {
                 sum += a[i];
                 avg = sum / a[i];
             }

             Console.Write("Sum of elements in the array is : {0} \n", sum);
             Console.Write("Average of elements in the array is : {0} \n", avg);*/
        }
    }
}