namespace application2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the program that entered midterm and final exam grades, if midterm grade equal are greater than 50 and final grade equal and greater than 70 print 'you passed :)' if not print 'you could not passed :(' 
            Console.WriteLine("Enter the midterm grade");
1            float midtermGrade = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the final grade");
            float finalGrade = Convert.ToSingle(Console.ReadLine());
            if (midtermGrade>=50 && finalGrade>=70)
            {
                Console.WriteLine("You passed :)");
            }
            else
            {
                Console.WriteLine("You could not passed :(");
            }
        }
    }
}