namespace application8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // program that sum of 5 to 40
            int sum = 0;
            for (int i = 5; i <= 40; i++)
            {
                Console.WriteLine(i);
                sum += i;
                Console.WriteLine("result: " + sum);
            }
        }
    }
}