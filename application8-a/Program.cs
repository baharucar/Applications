namespace application5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // program that find the average of 10 between 30
            int sum = 0;
            int number = 0;
            for(int i=10; i<=30; i++)
            {
                sum = sum += i;
                number++;
            }
            Console.WriteLine("the average is: " + sum/number);
        }
    }
}