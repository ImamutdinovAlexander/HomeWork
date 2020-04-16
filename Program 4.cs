using System;
using static System.Console;


namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[5] { 4, -3, 6, 9, -11 };
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                if (arr[i] > 0 && arr[i]%2 ==  0) 
                {
                    sum += arr[i];
                    
                }
                
            }

            WriteLine(sum);

            ReadKey();
        }
    }
}
