using GraphQL.Playground.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Playground.Data;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    public DbSet<Course> Courses { get; set; }
}