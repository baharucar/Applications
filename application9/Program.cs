namespace application9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id = "admin";
            string password = "1234a";
            Console.WriteLine("Please enter id");
            string id1 = Console.ReadLine();
            Console.WriteLine("Please enter password");
            string password1 = Console.ReadLine();
            if (id == id1 && password == password1)
            { 
                Console.WriteLine("Login succesfully");
                Console.WriteLine("Enter Your Age");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your your retirement bonus days");
                int retirementBonusDays = Convert.ToInt32(Console.ReadLine());
                if (age >=40 && retirementBonusDays>=5000)
                {
                    Console.WriteLine("Congrats! You deserved the retirement bonus!");
                    Console.WriteLine("Please enter salary");
                    float salary = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Please enter your total years of work");
                    int totalYearsOfWork = Convert.ToInt32(Console.ReadLine());
                    if (totalYearsOfWork >=20)
                    {
                        
                        Console.WriteLine("Your retirement bonus: " + ((salary*retirementBonusDays)*77.5/100));
                    }
                    else
                    {
                        Console.WriteLine("Your retirement bonus: " + ((salary * retirementBonusDays) * 50.5 / 100));
                    }
                }
                else
                {
                    Console.WriteLine("Days left to your retirement bonus: " + (5000-retirementBonusDays));
                    Console.WriteLine("Do you want to pay bonus day debt? \n for 'Yes' Press key 1 \n for 'No' press key 2");
                    char selection = Convert.ToChar(Console.ReadLine());
                    switch(selection)
                    {
                        case '1':
                            Console.WriteLine("For 50000tl debt in 5 installments: " + (50000/5) + "tl monthly");
                            break;
                        case '2':
                            Console.WriteLine("Thank you for applying");
                            break;
                        default:
                            Console.WriteLine("You pressed the wrong key");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Informations are incorrect");
            }

        }
    }
}