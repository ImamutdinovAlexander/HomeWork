using System;

using static System.Console;

namespace ConsolApp1
{
    class Program
    {
        static void Main()
        {



            const int size = 5;

            int[] arr = new int[size];

            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(10, 45);
                WriteLine("Массив: " + arr[i]);
            }



            for (int j = 0; j < size - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {

                    WriteLine(arr[j]);
                }
            }

            ReadKey();

        }
    }
}
