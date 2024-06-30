using GraphQL.Playground.Model.Entities;

namespace GraphQL.Playground.Data.Repositories.Contracts;

public interface ICourseRepository
{
    Task<IEnumerable<Course>> GetCoursesAsync();
    
    Task<Course?> GetCourseByIdAsync(int id);
    Task<Course> AddCourseAsync(Course course);
}