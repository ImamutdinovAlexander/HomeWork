using System;

using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            const int size = 5;
            int[] arr = new int[size] { 10, 2, -5, -4, 23 };
            for (int i = 0; i < size; i++)
            {
                arr[i] = arr[i] * -1;
                WriteLine(arr[i]);
            }

            ReadKey();

        }
    }
}
