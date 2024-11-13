using System;
using System.IO;

namespace Random
{
    internal class BankAccount
    {
        public void BankAccountMenu()
        {
            Console.WriteLine("Please choose network");
            Console.WriteLine("1. Mtn \n2. ATMoney\n3. G-Money\n4.ZeePay \n5. GhanaPay \n0. Back");
            string option = Console.ReadLine();

        }

    }

}
