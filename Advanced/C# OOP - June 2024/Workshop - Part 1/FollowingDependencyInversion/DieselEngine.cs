﻿namespace FollowingDependencyInversion
{
    public class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting the diesel engine...");
        }
    }
}
