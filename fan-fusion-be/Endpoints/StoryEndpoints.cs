using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.DTO;
using BE_Fan_Fusion.Models;
using BE_Fan_Fusion.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Services;

namespace BE_Fan_Fusion.Endpoints
{
    public static class StoryEndpoints
    {
        public static void MapStoryEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("stories").WithTags(nameof(Story));

            //toggle favorites button
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


            group.MapGet("/users/{userId}", async (IStoryService storyService, int userId) =>
            {
                try
                {
                    var storyDtos = await storyService.GetStoriesAsync(userId);
                    if (!storyDtos.Any())
                    {
                        return Results.Ok(new List<StoryDTO>());
                    }
                    return Results.Ok(storyDtos);
                }
                catch (ArgumentException ex)
                {
                    return Results.NotFound(ex.Message);
                }
            });

            group.MapGet("/{storyId}", async (IStoryService storyService, int storyId) =>
            {
                var story = await storyService.GetStoryByIdAsync(storyId);

                    if (story == null)
                {
                    return Results.NotFound($"The story with the following id was not found: {storyId}");
                }

                return Results.Ok(new
                {
                    story.Id,
                    story.Title,
                    story.Description,
                    story.Image,
                    story.DateCreated,
                    story.TargetAudience,
                    story.UserId,
                    story.CategoryId,
                    Chapters = story.Chapters.Select(story => new
                    {
                        story.Id,
                        story.Title,
                        story.DateCreated,
                    }),
                    Tags = story.Tags?.Select(tag => new TagDto(tag)).ToList(),
                    User = new UserDto(story.User),
                });
            });

            // CREATE NEW STORY
            group.MapPost("/", async (IStoryService storyService, Story newStory) =>
            {
                try
                {
                    var createdStory = await storyService.CreateStoryAsync(newStory);
                    return Results.Ok(createdStory);
                }
                catch (ArgumentException ex)
                {
                    return Results.NotFound(ex.Message);
                }
            });


            //DELETE STORY
            group.MapDelete("/{storyId}", async (IStoryService storyService, int storyId) =>
            {
                var storyToDelete = await storyService.DeleteStoryAsync(storyId);
                if (storyToDelete == null)
                {
                    return Results.NotFound($"There is no story with a matching id of: {storyId}");
                }
                return Results.Ok(storyToDelete);

            });

            // EDIT STORY BY ID
            group.MapPut("/{storyId}", async (IStoryService storyService, int storyId, Story story) =>
            {
                try
                {
                    var updatedStory = await storyService.UpdateStoryAsync(story, storyId);

                    return Results.Ok(updatedStory);
                }
                catch (ArgumentException ex)
                {
                    return Results.NotFound(ex.Message);
                }
            });

            //GET STORIES BY CATEGORY MINIMAL API
            group.MapGet("/users/{userId}/categories/{categoryId}", async (IStoryService storyService, int categoryId, int userId) =>
            {
                try
                {
                    var storyDTOs = await storyService.GetStoriesByCategoryIdAsync(categoryId, userId);
                    if (!storyDTOs.Any())
                    {
                        return Results.Ok(new List<StoryDTO>());
                    }
                    return Results.Ok(storyDTOs);
                }
                catch (ArgumentException ex)
                {
                    return Results.NotFound(ex.Message);
                }

            });
        }
    }
}
