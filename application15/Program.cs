namespace application15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The program that adds the squares of the evens from the 5 numbers entered from the keyboard and the sum of the cubes of the odds
            int square = 0;
            int cube = 0;
            for (int i=1; i<=5; i++)
            {
                Console.WriteLine("Enter " + i +". number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number % 2 == 0 )
                {
                    square += number * number;
                }
                else
                {
                    cube += number * number * number;
                }
            }
            Console.WriteLine("the sum of squares: " + square);
            Console.WriteLine("the sum of cubes: " + cube);
        }
    }
}