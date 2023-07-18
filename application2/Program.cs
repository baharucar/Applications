namespace application2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if the average of two number which entered are equal or greater than 70, print 'good' if not print 'bad'.
            Console.WriteLine("Enter first number");
            float Number1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter second number");
            float Number2 = Convert.ToSingle(Console.ReadLine());
            float Average = (Number1 + Number2) / 2;
            if (Average >= 70)
            {
                Console.WriteLine("good");
            }
            else
            {
                Console.WriteLine("bad");
            }
        }
    }
}
