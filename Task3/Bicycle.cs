namespace Task3
{
    public class Bicycle
    {
        private static int id = 1000;
        private int speed;
        private string model = "Crescent";

        public Bicycle()
        {
            Id += 1;
            Speed = 0;
        }

        public int Id
        { 
            get { return id; }
            set { id = value; }
        }
        public int Speed
        { 
            get 
            { 
                return speed; 
            }
            set 
            {
                if (value < 0)
                    speed = 0;
                else if (value > 100)
                    speed = 100;
                else
                    speed = value;
            }
        }
        public string Model
        {
            get { return model; }
        }


        public void Accelerate()
        {
            Speed += 5;
        }

        public void Brake()
        {
            Speed -= 5;
        }

        public void DisplayCurrentBicycle()
        {
            Console.WriteLine($"{Model} {Id}, Speed: {Speed}");
        }

    }
}
