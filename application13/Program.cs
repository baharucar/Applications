namespace application13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The program that finds how many numbers are divided by the number entered from outside in the numbers from 75 to 300. (75 included, 300 not included)
            int amount = 0;
            Console.WriteLine("enter the divided number");
            int dividedNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 75; i < 300; i++)
            {
                if (i % dividedNumber == 0)
                {
                    amount++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("the amount of numbers: " + amount);
        }
    }
}