using System;
using System.IO;

namespace Random
{
    internal class SendMoneyMenu
    {
        public void ShowSendMoneyMenu()
        {
            try
            {
                string sendMoney = File.ReadAllText(@"C:\Users\USER\source\repos\Random\SendMoney.txt");
                Console.WriteLine(sendMoney);

                Console.WriteLine("Enter an option");
                string option = Console.ReadLine();

                string number;
                while (true) {
                    
                    if (option == "1")
                    {
                        Console.WriteLine("Enter recipient phone number");
                        number = Console.ReadLine();

                        Console.WriteLine("Enter recipient phone number");
                        if (Console.ReadLine() == number)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Numbers do not match, please try again");
                        }
                    }
                    else if (option == "2")
                    {
                        OtherNetworks otherNetworks = new OtherNetworks();
                        otherNetworks.OtherNetworksMenu();
                       
                    }
                    else if (option == "3") { 
                        BankAccount account = new BankAccount();
                        account.BankAccountMenu();
                    }

                }
                Console.WriteLine("Enter Amount");
                string amount = Console.ReadLine();

                Console.WriteLine("Enter Reference");
                string reference = Console.ReadLine();

                Console.WriteLine("Enter pin");
                int pin = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Send GHS{amount} to {number} - name? \nTotal Fee 0.0(Transaction Fee 0.0 + E-Levy 0.0) \nReference: 1 \nTaxable Amount is GHS0.0 ");
                Console.WriteLine("1. Confirm \n2. Cancel");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Transaction Processed succesfully");
                }
                else if (Console.ReadLine() == "2") 
                {
                        Console.WriteLine("Process terminated");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error reading from file: {e.Message}");
            }
        }
    }
}
