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
            group.MapGet("/{tagId}", async (ITagService tagService, int tagId) =>
            {
                Tag? tag = await tagService.GetTagByIdAsync(tagId);

                if (tag == null)
                {
                    return Results.NotFound($"No tag was found with the following id: {tagId}");
                }

                return Results.Ok(new
                {
                    tag.Id,
                    tag.Name,
                    Stories = tag.Stories?.Select(story => new StoryDTO(story)).OrderByDescending(story => story.DateCreated).ToList(),
                });
            });
        }
    }
}
