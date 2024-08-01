namespace ViolatingDependencyInversion
{
    public class Car
    {
        public Car()
        {
            this.Engine = new DieselEngine();
        }

        public DieselEngine Engine { get; set; }
    }
}
