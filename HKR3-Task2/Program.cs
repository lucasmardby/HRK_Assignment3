using System.Runtime.CompilerServices;

namespace HKR3_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();

            bool exitApplication;
            do
            {
                Console.Clear();
                exitApplication = MainMenu();
            } while (exitApplication == false);

            bool MainMenu()
            {

                Console.WriteLine("Welcome to the Account Book!\n\n");
                Console.WriteLine("Enter a number to:");
                Console.WriteLine("Deposit [1]\nWithdraw [2]\nor Exit the application [3]");

                int menuChoice = CheckValidNumber();

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the deposit amount:");
                        myAccount.Balance = myAccount.Deposit(CheckValidNumber());
                        Console.WriteLine($"Your balance becomes {myAccount.Balance}");
                        Console.ReadLine();
                        return false;
                    case 2:
                        Console.WriteLine("Enter the withdrawal amount:");
                        myAccount.Balance = myAccount.Withdraw(CheckValidNumber());
                        Console.WriteLine($"Your new balance becomes {myAccount.Balance}");
                        Console.ReadLine();
                        return false;
                    case 3:
                        Console.WriteLine("Exiting Bank Application");
                        Console.ReadLine();
                        return true;
                    default:
                        Console.WriteLine("Error, enter a valid menu option.");
                        return false;
                }

            }

            int CheckValidNumber()
            {
                int numberInput = 0;

                string readResult;
                bool validInput;
                do
                {
                    validInput = false;
                    readResult = Console.ReadLine();
                    if (int.TryParse(readResult, out _))
                    {
                        numberInput = int.Parse(readResult);
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Error, enter a correct number value.");
                    }

                } while (validInput == false);

                return numberInput;
            }

        }

    }
}
