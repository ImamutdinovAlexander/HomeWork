using System;

using static System.Console;

namespace ConsolApp1
{
    class Program
    {
        static void Main()
        {

           

            const int size = 5;

            int[] arr = new int[size] { 3, 5, 1, 7, 22 };

           

            int max = arr[0];
            int min = arr[0];
            int mid = arr[0];
          

            for (int i = 0; i < size; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }

                mid += arr[i]/size;
            }


            WriteLine(max);
            WriteLine(min);
            WriteLine(mid);

            ReadKey();

        }
    }
}
