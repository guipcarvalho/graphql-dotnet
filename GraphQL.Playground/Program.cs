using GraphQL;
using GraphQL.Playground.Data;
using GraphQL.Playground.GraphQL;
using GraphQL.Playground.GraphQL.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<AppSchema>();
builder.Services.AddScoped<CourseQuery>();

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddGraphQL(opt =>
{
    opt.AddSystemTextJson();
});

var app = builder.Build();

using var scope = app.Services.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
await context.Database.MigrateAsync();

app.UseHttpsRedirection();

app.UseGraphQL<AppSchema>();
app.UseGraphQLPlayground();

app.Run();