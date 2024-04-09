namespace HKR3_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to the Heart Rate App!---\n\n");

            Console.WriteLine("Enter your first name,");
            string firstName = CheckValidString();

            Console.WriteLine("And last name,");
            string lastName = CheckValidString();

            Console.WriteLine("And finally, your year of birth.");
            int yearOfBirth = CheckValidNumber();

            HeartRates heartRate = new HeartRates(firstName, lastName, yearOfBirth);

            Console.WriteLine("Your Heart Rate");
            Console.WriteLine($"Name: {heartRate.FirstName} {heartRate.LastName}");
            Console.WriteLine($"Age: {heartRate.CalculateAge()} years");
            Console.WriteLine($"Maximum Heart Rate: {heartRate.CalculateMaxHeartRate()} BPM");
            Console.WriteLine($"Target Heart Rate: {heartRate.CalculateTargetHeartRateMin()} and {heartRate.CalculateTargetHeartRateMax()} BPM");
            Console.ReadLine();

            string CheckValidString()
            {
                string readResult = "";

                bool validInput;
                do
                {
                    validInput = false;
                    readResult = Console.ReadLine();
                    if (!String.IsNullOrEmpty(readResult))
                    {
                        readResult.Trim();
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Error, enter a correct name.");
                    }

                } while (validInput == false);

                return readResult;
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
