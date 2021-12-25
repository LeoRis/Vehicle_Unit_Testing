namespace Vehicle
{
    public class Plane : IMutual, IReadFromBase
    {
        public string Wings { get; set; }

        public void Move()
        {
            System.Console.WriteLine("The plane is moving");
        }

        public void Read()
        {
            System.Console.WriteLine("Read from base...");
        }

        public void Turn()
        {
            System.Console.WriteLine("The plane is turning");
        }

        public int Speed(int startSpeed, int stopSpeed)
        {
            return startSpeed + stopSpeed;
        }

        public void Write()
        {
            throw new System.NotImplementedException();
        }
    }
}
