using System;

namespace APBD_Task1
{
    class Program
    {
        static int CalculateAverage(int a, int b, int c)
        {
            int sum = a + b + c;
            int average = sum / 3;
            return average;
        }

        static int CalculateMax(int[] values)
        {
            int max = values[0];

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }

            return max;
        }


        static int CalculateMin(int[] values)
        {
            int min = values[0];

            for(int i = 1;i < values.Length; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
            }
            return min;
        }



        static void Main(string[] args)
        {
            int result = CalculateAverage(10, 20, 30);
            Console.WriteLine(result);

            int[] numbers = { 1, 2, 5, 4, 3 };
            int maxNumber = CalculateMax(numbers);
            Console.WriteLine(maxNumber);

            int minNumber = CalculateMin(numbers);
            Console.WriteLine(minNumber);
        }
    }
}