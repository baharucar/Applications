namespace application6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a model of mobile phone");
            Console.WriteLine("For Iphone press the 1 key");
            Console.WriteLine("For Samsung press the 2 key");
            Console.WriteLine("For Huawei press the 3 key");
            char selection = Convert.ToChar(Console.ReadLine());
            switch(selection)
            {
                case '1':
                    Console.WriteLine("Iphone");
                break;
                case '2':
                    Console.WriteLine("Samsung");
                break;
                case '3':
                    Console.WriteLine("Huawei");
                break;
                default:
                    Console.WriteLine("You pressed the wrong key");
                break;
            }
        }
    }
}
