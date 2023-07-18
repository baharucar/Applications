namespace application5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sum of entered 5 numbers which are even 
            int sum = 0;
            for (int i =1; i<=5; i++)
            {
                Console.WriteLine("Enter a number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine("sum of 5 even number: " + sum);
        }
    }
}