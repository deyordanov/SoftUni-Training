namespace DemoWebApp.Models
{
    public class Courses
    {
        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();

            for(int i = 1; i <= 100; i++)
            {
                courses.Add(new Course($"Course {i}"));
            }

            return courses;
        }
    }
}
