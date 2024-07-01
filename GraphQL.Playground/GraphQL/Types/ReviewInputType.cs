using GraphQL.Playground.Model.Entities;
using GraphQL.Types;

namespace GraphQL.Playground.GraphQL.Types;

public sealed class ReviewInputType : InputObjectGraphType<Review>
{
    public ReviewInputType()
    {
        Name = "ReviewInput";
        
        Field(x => x.Rating, type: typeof(IntGraphType))
            .Description("The rating for the course.");
        
        Field(x => x.Comment, type: typeof(StringGraphType))
            .Description("The comment for the course.");
    }
}