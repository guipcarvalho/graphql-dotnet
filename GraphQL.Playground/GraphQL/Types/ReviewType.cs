using GraphQL.Playground.Model.Entities;
using GraphQL.Types;

namespace GraphQL.Playground.GraphQL.Types;

public sealed class ReviewType : ObjectGraphType<Review>
{
    public ReviewType()
    {
        Field(x => x.Id, type: typeof(IdGraphType))
            .Description("The id of the course.");
        
        Field(x => x.Rating, type: typeof(IntGraphType))
            .Description("The rating of the course.");
        
        Field(x => x.Comment, type: typeof(StringGraphType))
            .Description("The comment for the course.");
    }
}