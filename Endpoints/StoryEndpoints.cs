using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using BE_Fan_Fusion.Services;

namespace BE_Fan_Fusion.Endpoints
{
    public static class StoryEndpoints
    {
        public static void MapStoryEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("stories").WithTags(nameof(Story));

            group.MapGet("/{storyId}/users/{userId}/favorites", async (IStoryService storyService, int storyId, int userId) =>
            {
                var (success, message) = await storyService.ToggleFavoriteStoriesAsync(storyId, userId);

                if (success)
                {
                    return Results.Ok(message);
                }
                else
                {
                    return Results.NotFound(message);
                }
              
            });
        }
    }
}
