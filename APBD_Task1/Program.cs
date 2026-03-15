namespace APBD_Task1
{


    class Program
    {

        static int CalculateAverage(int[] values)
        {
            int sum = 0;

            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum / values.Length;
        }

        static void Main(string[] args)
        {
            int[] averageValues = { 10, 20, 30 };
            int result = CalculateAverage(averageValues);
            Console.WriteLine(result);
        }
    }
}