using System;


namespace Practice
{
     class negative
    {
        public static void Main97()
        {
            int[] arr = new int[100];
            int i, num;
            int count = 0;

            
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Enter elements in array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("All negative elements in array are: ");
            for (i = 0; i < num; i++)
            {
                
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                    count++;
                }

            }
            Console.WriteLine("Total Number of Negative elemnt found is = " + count);
            Console.ReadLine();
        }

    }

}
   
