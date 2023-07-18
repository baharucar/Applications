namespace application10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select your loan type");
            string loanselection = Console.ReadLine();
            if (loanselection == "consumer loan" || loanselection == "Consumer Loan")
            {
                Console.WriteLine("Please enter the balance you will withdraw");
                float balance = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Do you have SGK? 'YES' or 'NO' ");
                string sgkSelectionForCustomerLoan = Console.ReadLine();
                Console.WriteLine("Please enter your salary");
                float salary = Convert.ToSingle(Console.ReadLine());
                if (sgkSelectionForCustomerLoan == "YES" && salary >=10000)
                {
                    Console.WriteLine("You can get a 48-month loan.The amount you have to pay monthly: " + (salary + (salary*89/100)));
                }
                else
                {
                    Console.WriteLine("You can get a 24-month loan.The amount you have to pay monthly: " + (salary + (salary * 99 / 100)));

                }
            }
            else if (loanselection == "home loan" || loanselection == "Home Loan")
            {
                Console.WriteLine("Do you have SGK? 'YES' or 'NO' ");
                string sgkSelectionForHomeLoan = Console.ReadLine();
                Console.WriteLine("Do you have Guarantor? 'YES' or 'NO' ");
                string guarantorSelectionForHomeLoan = Console.ReadLine();
                if (sgkSelectionForHomeLoan == "YES" && guarantorSelectionForHomeLoan == "YES")
                {
                    Console.WriteLine("Please enter the amount of loan");
                    float amountOfLoan = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Please choose maturity period \n for 1-6 years press key 1 \n for 2-8 years press key 2 \n for 3-10 years press key 3");
                    char maturityPeriodSelection = Convert.ToChar(Console.ReadLine());
                    switch (maturityPeriodSelection)
                    {
                        case '1':
                            Console.WriteLine("Your monthly payment amount: " + ((amountOfLoan*72) + (amountOfLoan*72*0.69)));
                            break;
                        case '2':
                            Console.WriteLine("Your monthly payment amount: " + ((amountOfLoan * 96) + (amountOfLoan * 96 * 1.20)));
                            break;
                        case '3':
                            Console.WriteLine("Your monthly payment amount: " + ((amountOfLoan * 120) + (amountOfLoan *120 * 1.40)));
                            break;
                        default:
                            Console.WriteLine("You pressed the wrong key");
                            break;
                    }    
                }
                else
                {
                    Console.WriteLine("Application is rejected");
                }

                
            }
            else
            {
                Console.WriteLine("Your application is rejected"); 
            }

            

            

        }
    }
}