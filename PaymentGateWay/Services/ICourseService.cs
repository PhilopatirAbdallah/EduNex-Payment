using PaymentGateWay.Classes;

namespace PaymentGateWay.Services
{
    public interface ICourseService
    {
        Task<Course> GetCourseById(int courseId);
        Task<IEnumerable<Course>> GetAllCourses();
    }
}
