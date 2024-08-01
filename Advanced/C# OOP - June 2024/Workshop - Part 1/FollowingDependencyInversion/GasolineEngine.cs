namespace FollowingDependencyInversion
{
    public class GasolineEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting the gasoline engine...");
        }
    }
}
