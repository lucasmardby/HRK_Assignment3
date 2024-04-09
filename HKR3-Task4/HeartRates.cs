namespace HKR3_Task4
{
    public class HeartRates
    {
        string firstName;
        string lastName;
        int yearOfBirth;
        int currentYear;

        DateTime moment = DateTime.Now;

        public HeartRates(string firstName, string lastName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
            CurrentYear = moment.Year;
        }

        public string FirstName
        { 
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int YearOfBirth
        { 
            get { return yearOfBirth; }
            set { yearOfBirth = value; } 
        }
        public int CurrentYear
        {
            get { return currentYear; }
            set { currentYear = value; }
        }

        public int CalculateAge()
        {
            return CurrentYear - YearOfBirth;
        }
        public int CalculateMaxHeartRate()
        {
            return 220 - CalculateAge();
        }
        public double CalculateTargetHeartRateMin()
        {
            return CalculateMaxHeartRate() * 0.5d;
        }
        public double CalculateTargetHeartRateMax()
        {
            return CalculateMaxHeartRate() * 0.8d;
        }

    }
}
