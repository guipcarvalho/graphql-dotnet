using GraphQL;
using GraphQL.Playground.Data;
using GraphQL.Playground.Data.Repositories;
using GraphQL.Playground.Data.Repositories.Contracts;
using GraphQL.Playground.GraphQL;
using GraphQL.Playground.GraphQL.Mutations;
using GraphQL.Playground.GraphQL.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<GraphSchema>();
builder.Services.AddScoped<CourseQuery>();
builder.Services.AddScoped<CourseMutation>();
builder.Services.AddScoped<ApplicationContext>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddGraphQL(graphQlBuilder =>
{
    graphQlBuilder
        .AddSystemTextJson()
        .AddGraphTypes(typeof(GraphSchema).Assembly)
        .UseApolloTracing()
        .ConfigureExecutionOptions(opt =>
        {
            opt.EnableMetrics = true;
        });
});

var app = builder.Build();

using var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
await context.Database.MigrateAsync();

app.UseHttpsRedirection();

app.UseGraphQL<GraphSchema>();
app.UseGraphQLPlayground();

app.Run();