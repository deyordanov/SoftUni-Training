string name = Console.ReadLine();
int projects = int.Parse(Console.ReadLine());

int hoursToCompleteProjects = projects * 3;

Console.WriteLine($"The architect {name} will need {hoursToCompleteProjects} hours to complete {projects} project/s.");