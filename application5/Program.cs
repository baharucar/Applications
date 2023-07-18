namespace application5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask for id and password if the entered id and password correct, direct the login screen
            string id = "admin";
            string password = "1234a";
            Console.WriteLine("Enter the id");
            string id1 = Console.ReadLine();
            Console.WriteLine("Enter the password");
            string password2 = Console.ReadLine();
            if (id==id1 && password==password2)
            {
                Console.WriteLine("Welcome to Login Screen");
            }
            else
            {
                Console.WriteLine("You entered incorrectly");
            }
        }
    }
}