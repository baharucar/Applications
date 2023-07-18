namespace application2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the program that print positive, negative or neutral for the number entered

            Console.WriteLine("Enter the number");
            numberloop:
            float number = Convert.ToSingle(Console.ReadLine());
            if (number>0)
            {
                Console.WriteLine("The number: " + number + " is positive");
                
            }
            else if(number<0)
            {
                Console.WriteLine("The number: " + number + " is negative");
            }
            else
            {
                Console.WriteLine("The number: " + number + " is neutral");
            }
            goto numberloop;
        }   

    }
}