using GraphQL.Playground.Model.Entities;

namespace GraphQL.Playground.Data.Repositories.Contracts;

public interface ICourseRepository
{
    Task<IEnumerable<Course>> GetCoursesAsync(bool includeReviews = false);
    
    Task<Course?> GetCourseByIdAsync(int id, bool includeReviews = false);
    Task<Course> AddCourseAsync(Course course);
    
    Task<Course> UpdateCourseAsync(Course course);
    
    Task DeleteCourseAsync(int idCourse);
}