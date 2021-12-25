namespace Vehicle
{
    public class Car : IMutual
    {
        public string Type { get; set; }

        public void Move()
        {
            System.Console.WriteLine("The car is moving.");
        }

        public void Turn()
        {
            System.Console.WriteLine("The car is turning.");
        }
    }
}
