namespace Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------");
            Console.WriteLine("Vodafone Help Line");
            Console.WriteLine("------------------");

            Console.WriteLine("Short codes available");
            Console.WriteLine("To check your airtime and bundle balance dial *124# and then follow the prompts");
            Console.WriteLine("To access your mobile money dial *110# and then follow the prompts");

            string input = Console.ReadLine();

            
            if(input == "*110#")
            {
                try
                {
                    string MomoMenu = File.ReadAllText(@"C:\Users\USER\source\repos\Random\MomoMenu.txt");
                    Console.WriteLine(MomoMenu);

                    Console.WriteLine("Select from the above");
                    string option = Console.ReadLine();

                    if(option == "1")
                    {
                        SendMoneyMenu sendMoneyMenu = new SendMoneyMenu();
                        sendMoneyMenu.ShowSendMoneyMenu();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error reading from file: {e.Message}");
                }
            }
            else
            {
                    Console.WriteLine("Invalid service code");     
            }

        }
    }
}
