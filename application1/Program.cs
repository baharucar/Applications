

namespace application1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // show the number which is greater than other one
            Console.WriteLine("Enter number 1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1>number2)
            {
                Console.WriteLine("number 1 "  + " greater than " + "number 2 " );
            }
            else if (number2>number1)
            {
                Console.WriteLine("number 2 "  + " greater than " + "number1 " );
            }
            else
            {
                Console.WriteLine("number1 equals number2");
            }
        }
    }
}

