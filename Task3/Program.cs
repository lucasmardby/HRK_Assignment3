namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();

            bool exitApplication;
            do
            {
                Console.Clear();
                exitApplication = MainMenu();
            } while (exitApplication == false);

            bool MainMenu()
            {
                Console.WriteLine("Welcome to the Bicycle App!\n\n");
                Console.WriteLine("Enter a number to:");
                Console.WriteLine("\tAccelerate [1]\n\tBrake [2]\n\tCreate a new Bicycle [3]\n\n\tor Exit the application [4]\n");

                Console.WriteLine("Your current bicycle is:");
                bicycle.DisplayCurrentBicycle();
                Console.WriteLine();
                Console.WriteLine("Your choice:");

                int menuChoice = CheckValidNumber();

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Accelerating...");
                        bicycle.Accelerate();
                        Console.ReadLine();
                        return false;
                    case 2:
                        Console.WriteLine("Braking...");
                        bicycle.Brake();
                        Console.ReadLine();
                        return false;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Creating new bicycle:");
                        bicycle = new Bicycle();
                        bicycle.DisplayCurrentBicycle();
                        Console.ReadLine();
                        return false;
                    case 4:
                        Console.WriteLine("Exiting Bicycle Application");
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
