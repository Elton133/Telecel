using System;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Random
{
    internal class OtherNetworks
    {
        public void OtherNetworksMenu()
        {
            Console.WriteLine("Please choose network");
            Console.WriteLine("1. Mtn \n2. ATMoney\n3. G-Money\n4.ZeePay \n5. GhanaPay \n0. Back");
            string option = Console.ReadLine();

            string number;
            while (true)
            {
                if (option == "1" || option == "2")
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


            }
            Console.WriteLine("Enter Amount");
            string amount = Console.ReadLine();

            Console.WriteLine("Enter Reference");
            string reference = Console.ReadLine();

            Console.WriteLine("Enter pin");
            int pin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Send GHS{amount} to {number} - name? \nTotal Fee 0.0(Transaction Fee 0.0 + E-Levy 0.0) \nReference: {reference} \nTaxable Amount is GHS0.0 ");
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
    }
}

          
           