namespace application16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print the multiplication table with the number up to one more than the value entered from the keyboard.
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int calculation = 0;
            for (int i =1; i<=number; i++)
            {
                calculation = i * (i + 1);
                Console.WriteLine(i + "*" + (i+1) + "=" + calculation);
            }
        }
    }
}