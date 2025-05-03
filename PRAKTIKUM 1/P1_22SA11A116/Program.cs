class Program
{
    //22SA11A116
    static void Main(string[] args)
    {
        int amount = 3000000, deposit, withdraw;
        int choice, pin = 0;

        Console.WriteLine("Enter Your 6 Digit Pin:");
        pin = int.Parse(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("\nWelcome To Ungu Bank ATM Service!!\n");
            Console.WriteLine("1. Current Balance\n");
            Console.WriteLine("2. Withdraw\n");
            Console.WriteLine("3. Deposit\n");
            Console.WriteLine("4. Cancel\n");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Enter Your Choice:");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nYour Current Balance is Rp: {0}", amount);
                    break;

                case 2:
                    Console.WriteLine("\nEnter the Withdraw amount:");
                    withdraw = int.Parse(Console.ReadLine());

                    if (withdraw % 50000 != 0)
                    {
                        Console.WriteLine("\nPlease Enter the Amount in Multiples of 50000");
                    }
                    else if (withdraw > (amount - 1000))
                    {
                        Console.WriteLine("\nSorry, Insufficient Balance");
                    }
                    else
                    {
                        amount = amount - withdraw;
                        Console.WriteLine("\nPlease Collect Your Cash!!");
                        Console.WriteLine("Your Current Balance is Rp: {0}", amount);
                    }
                    break;

                case 3:
                    Console.WriteLine("\nEnter the Deposit amount:");
                    deposit = int.Parse(Console.ReadLine());
                    amount = amount + deposit;
                    Console.WriteLine("\nYour Amount Has Been Deposited Successfully!!");
                    Console.WriteLine("Your Total Balance is Rp: {0}", amount);
                    break;

                case 4:
                    Console.WriteLine("\nThank You!");
                    return;

                default:
                    Console.WriteLine("\nInvalid Choice. Please Try Again.");
                    break;
            }
        }
    }
}