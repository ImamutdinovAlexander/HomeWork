using System;
using static System.Console;


namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            int size = 10;
            int[] arr = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(10, 500);
            }
            int max = arr[0];
            int p = 0;
            for (int i = 0; i < size; i++)
            {
                if ( max < arr[i] && i%2 ==0 && i!= 0 )
                {
                    max = arr[i];
                    p = i;
                }
            }
            WriteLine("Позиция:  " + p + "  Число:  " + max);

            ReadKey();
        }


    }
}
