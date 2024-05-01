using PaymentGateWay.Classes;

namespace PaymentGateWay.Services
{
    public class CourseService : ICourseService
    {
        private readonly List<Course> _courses;

        public CourseService()
        {
            _courses = new List<Course>
            {
                new Course(1, "Course 1", "Description of Course 1", 100),
                new Course(2, "Course 2", "Description of Course 2", 150),
                new Course(3, "Course 3", "Description of Course 3", 200)
            };
        }

        public Task<Course> GetCourseById(int courseId)
        {
            // Find the course with the specified ID in the list
            var course = _courses.Where(c => c.Id == courseId).FirstOrDefault();

            // Return the course asynchronously
            return Task.FromResult(course);
        }

        public Task<IEnumerable<Course>> GetAllCourses()
        {
            // Return all courses asynchronously
            return Task.FromResult<IEnumerable<Course>>(_courses);
        }
    }
}

