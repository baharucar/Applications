namespace application14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The program that finds the number of 3 digit numbers out of the 10 entered and the sum of the others
            int sum = 0;
            int amount = 0;
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("Enter " +  i +  ".number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number >99 && number < 1000 )
                {
                    amount++;
                }
                else
                {
                    sum += number;
                }
            }
            Console.WriteLine("amount of 3 digit numbers: " + amount);
            Console.WriteLine("sum of other numbers: " + sum);
        }
    }
}