namespace FollowingDependencyInversion
{
    public class Car
    {
        public Car(IEngine engine)
        {
            this.Engine = engine;
        }
        public IEngine Engine { get; set; }
    }
}
