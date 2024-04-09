namespace HKR3_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers, to be the radius of the two spheres we'll create.");

            int firstRadius = 0;
            int secondRadius = 0;

            string readResult;
            bool validInput;

            Console.WriteLine("The first number,");
            do
            {
                validInput = false;
                readResult = Console.ReadLine();

                if (int.TryParse(readResult, out _))
                {
                    firstRadius = Convert.ToInt32(readResult);

                    if (firstRadius > 0)
                    {
                        validInput = true;
                    }
                }
            } while (validInput == false);

            Console.WriteLine("And the second number,");
            do
            {
                validInput = false;
                readResult = Console.ReadLine();

                if (int.TryParse(readResult, out _))
                {
                    secondRadius = Convert.ToInt32(readResult);

                    if (secondRadius > 0)
                    {
                        validInput = true;
                    }
                }
            } while (validInput == false);

            Sphere sphereOne = new();
            sphereOne.Radius = firstRadius;

            Sphere sphereTwo = new(secondRadius);

            string volume = String.Format("{0:0.00}", sphereOne.CalculateVolume(sphereOne));
            string surfaceArea = String.Format("{0:0.00}", sphereOne.CalculateSurfaceArea(sphereOne));

            Console.WriteLine("Spheres\t\tVolume\t\tSurface Area");
            Console.WriteLine($"One\t\t{volume}\t\t{surfaceArea}");

            volume = String.Format("{0:0.00}", sphereTwo.CalculateVolume(sphereTwo));
            surfaceArea = String.Format("{0:0.00}", sphereTwo.CalculateSurfaceArea(sphereTwo));

            Console.WriteLine($"Two\t\t{volume}\t\t{surfaceArea}");

        }
    }
}
