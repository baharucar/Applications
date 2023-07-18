namespace application5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            //sum of entered 5 numbers
            for(int i =1; i<=5; i++)
            {
                Console.WriteLine("Enter a number");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("result: " + sum);
        }
    }
}