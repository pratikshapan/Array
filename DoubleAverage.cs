using System;

namespace Practice
{
     class DoubleAverage
    {

        public void Average(double[] arr, int size)
        {

            double sum = 0;
            double average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += arr[i];
            }
            average = sum / size;
            Console.WriteLine("Sum Of Array is : " + sum);
            Console.WriteLine("Average Of Array is : " + average);
            Console.ReadLine();
        }
            public static void Main25(string[] args)
            {
                int size;
                Console.WriteLine("Enter the Size :");
                size = Int32.Parse(Console.ReadLine());
                double[] a = new double[size];
                Console.WriteLine("Enter the Elements of the Array : ");
                for (int i = 0; i < size; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                int len = a.Length;
            DoubleAverage pg = new DoubleAverage();
                pg.Average(a, len);

            }



        }

    }


