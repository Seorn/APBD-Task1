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

        static void Main(string[] args)
        {
            int result = CalculateAverage(10, 20, 30);
            Console.WriteLine(result);
        }
    }
}