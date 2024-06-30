using GraphQL.Playground.Data.Repositories.Contracts;
using GraphQL.Playground.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Playground.Data.Repositories;

public class CourseRepository(ApplicationContext context) : ICourseRepository
{
    public async Task<IEnumerable<Course>> GetCoursesAsync()
    {
        return await context.Courses.ToListAsync();
    }
    
    public async Task<Course?> GetCourseByIdAsync(int id)
    {
        return await context.Courses.FirstOrDefaultAsync(c => c.Id == id);
    }
    
    public async Task<Course> AddCourseAsync(Course course)
    {
        course.DateAdded = DateTime.Now;
        await context.Courses.AddAsync(course);
        await context.SaveChangesAsync();
        
        return course;
    }
}