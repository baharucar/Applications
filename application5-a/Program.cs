namespace application5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask for id and password if the entered id and password correct, direct the login screen, make it in order
            string id = "admin";
            string password="1234a";
            tryagainid:
            Console.WriteLine("Enter the id");
            string id1 = Console.ReadLine();
            if(id==id1)
            {
                tryagainpass:
                Console.WriteLine("Enter the password");
                string password1 = Console.ReadLine();
                if (password == password1)
                {
                    Console.Clear();
                    Console.WriteLine("Welcome the login screen");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You entered password incorrectly");
                    goto tryagainpass;
                }
            }
            else
            {
                Console.WriteLine("You entered id incorrectly");
                goto tryagainid;
            }

        }  
    }
}