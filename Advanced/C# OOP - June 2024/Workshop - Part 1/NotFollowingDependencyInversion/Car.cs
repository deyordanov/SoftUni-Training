namespace NotFollowingDependencyInversion
{
    public class Car
    {
        public Car()
        {
            this.Engine = new Engine();
        }
        public Engine Engine { get; set; }

        // public Tires Tires { get; set; }

        // public int Doors { get; set; }
    }
}
