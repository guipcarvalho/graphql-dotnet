using GraphQL.Playground.Data.Repositories.Contracts;
using GraphQL.Playground.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Playground.Data.Repositories;

public class CourseRepository(ApplicationContext context) : ICourseRepository
{
    public async Task<IEnumerable<Course>> GetCoursesAsync()
    {
        return await context.Courses.Include(c => c.Reviews).ToListAsync();
    }
    
    public async Task<Course?> GetCourseByIdAsync(int id)
    {
        return await context.Courses.Include(c => c.Reviews).FirstOrDefaultAsync(c => c.Id == id);
    }
    
    public async Task<Course> AddCourseAsync(Course course)
    {
        course.DateAdded = DateTime.Now;
        await context.Courses.AddAsync(course);
        if(course.Reviews is { Count: > 0 })
        {
            foreach(var review in course.Reviews)
            {
                review.CourseId = course.Id;
                review.Course = course;
                context.Reviews.Add(review);
            }
        }
        await context.SaveChangesAsync();
        
        return course;
    }
    
    public async Task<Course> UpdateCourseAsync(Course course)
    {
        course.DateUpdated = DateTime.Now;
        context.Courses.Update(course);
        await context.SaveChangesAsync();
        
        return course;
    }
    
    public async Task DeleteCourseAsync(int idCourse)
    {
        var course = await context.Courses.FirstOrDefaultAsync(c => c.Id == idCourse);
        
        if (course is null)
        {
            throw new ArgumentException("Course not found.");
        }
        
        context.Courses.Remove(course);
        await context.SaveChangesAsync();
    }
}