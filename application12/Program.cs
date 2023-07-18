namespace application12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program that amount of setted start and end value which divisible by 3 and 5
            Console.WriteLine("Please enter the start value");

            int startValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the end value");
            int endValue = Convert.ToInt32(Console.ReadLine());

            int amount = 0;
            for(int i=startValue; i<=endValue; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                    amount++;
                }
            }
            Console.WriteLine("amount of numbers that divisible by 3 and 5: " + amount);
        }
    }
}