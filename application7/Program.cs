namespace application6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //select transportation type,domestic,abroad
            // domestic> number of ticket, price, İstanbul, Ankara
            //abroad> number of ticket, price, asia, europe
            //a> ticket*number discount of %27
            //b> ticket* number discount of %17
            Console.WriteLine("Please select transportation type");
            Console.WriteLine("Press key 1 for domestic");
            Console.WriteLine("Press key 2 for abroad");
            char selection = Convert.ToChar(Console.ReadLine());
            switch(selection)
            {
                case '1':
                    Console.WriteLine("Domestic");
                    Console.WriteLine("Please enter the price of ticket");
                    float price = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Please enter the number of ticket");
                    int numberofticket = Convert.ToInt32(Console.ReadLine());
                    float result = price * numberofticket;
                    Console.WriteLine("Please choose the region \n for Europe: e \n for Asia: a");
                    char selection2 = Convert.ToChar(Console.ReadLine());
                    if (selection2 == 'a' || selection2 == 'A')
                    {
                        result += result * 27 / 100;
                        Console.WriteLine(result);
                    }
                    else if (selection2 == 'e' || selection2 == 'E')
                    {
                        result += result * 17 / 100;
                        Console.WriteLine("The price you will pay: " + result);
                    }
                    else
                    {
                        Console.WriteLine("You pressed the wrong key");
                    }
                    break;
                case '2':
                    Console.WriteLine("Abroad");
                    Console.WriteLine("Please enter the price of ticket");
                    float price2 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Please enter the number of ticket");
                    int numberofticket2 = Convert.ToInt32(Console.ReadLine());
                    float result2 = price2 * numberofticket2;
                    Console.WriteLine("Please choose the region \n for Istanbul: i \n for Ankara: a");
                    char selection3 = Convert.ToChar(Console.ReadLine());
                    if (selection3 == 'i' || selection3 == 'I')
                    {
                        result2 += result2 * 27 / 100;
                        Console.WriteLine(result2);
                    }
                    else if (selection3 == 'e' || selection3 == 'E')
                    {
                        result2 += result2 * 17 / 100;
                        Console.WriteLine("The price you will pay: " + result2);
                    }
                    else
                    {
                        Console.WriteLine("You pressed the wrong key");
                    }
                    break;
                default:
                    Console.WriteLine("You pressed the wrong key");
                    break;
            }
        }
    }
}