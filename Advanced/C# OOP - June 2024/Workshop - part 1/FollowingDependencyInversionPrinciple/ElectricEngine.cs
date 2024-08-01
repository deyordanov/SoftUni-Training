namespace FollowingDependencyInversionPrinciple
{
    internal class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting the electric engine...");
        }
    }
}
