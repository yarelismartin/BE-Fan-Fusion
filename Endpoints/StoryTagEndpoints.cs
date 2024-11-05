using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;


namespace BE_Fan_Fusion.Endpoints
{
    public static class StoryTagEndpoints
    {
        public static void MapStoryTagEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("stories").WithTags("StoryTag");

            group.MapPost("/{storyId}/add-tag/{tagId}", async (IStoryTagService storyTagService, int tagId, int storyId) =>
            {
                var (success, message) = await storyTagService.AddTagToStoryAsync(tagId, storyId);
                if (success)
                {
                    return Results.Ok(message);
                }
                else if(message.Contains("with following id"))
                {
                    return Results.NotFound(message);
                }
                else
                {
                    return Results.Conflict(message);
                }
            });

            group.MapDelete("/{storyId}/remove-tag/{tagId}", async (IStoryTagService storyTagService, int tagId, int storyId) =>
            {
                var (success, message) = await storyTagService.RemoveTagFromStoryAsync(tagId, storyId);
                if (success)
                {
                    return Results.Ok(message);
                }
                else if (message.Contains("with following id"))
                {
                    return Results.NotFound(message);
                }
                else
                {
                    return Results.Conflict(message);
                }
            });

        }
    }
}