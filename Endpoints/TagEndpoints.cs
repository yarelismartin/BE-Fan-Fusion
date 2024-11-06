using BE_Fan_Fusion.DTO;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using BE_Fan_Fusion.Services;
using Microsoft.AspNetCore.Builder;

namespace BE_Fan_Fusion.Endpoints
{
    public static class TagEndpoints
    {
        public static void MapTagEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("tags").WithTags(nameof(Tag));

            // get all tags
            group.MapGet("/", async (ITagService tagService) =>
            {
                var tagDtos = await tagService.GetAllTagsAsync();

                if (!tagDtos.Any())
                {
                    return Results.Ok("There are no aviliable tags to display");
                }
                return Results.Ok(tagDtos);
            });

            //Get Single
            group.MapGet("/{tagId}/users/{userId}", async (ITagService tagService, int tagId, int userId) =>
            {
                Tag? tag = await tagService.GetTagByIdAsync(tagId);

                if (tag == null)
                {
                    return Results.NotFound($"No tag was found with the following id: {tagId}");
                }

                User? user = await tagService.GetUserByIdAsync(userId);

                if (user == null)
                {
                    return Results.NotFound($"No tag was found with the following id: {userId}");
                }

                return Results.Ok(new
                {
                    tag.Id,
                    tag.Name,
                    Stories = tag.Stories?.Select(story => new StoryDTO(story, user.FavoritedStories?.Contains(story) ?? false)).OrderByDescending(story => story.DateCreated).ToList(),
                });
            });
        }
    }
}
