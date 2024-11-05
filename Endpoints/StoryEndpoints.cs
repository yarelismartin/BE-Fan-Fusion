using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.DTO;
using BE_Fan_Fusion.Interfaces;
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
            var group = routes.MapGroup("").WithTags(nameof(Story));

            // Injecting StoryService into the endpoint
            group.MapGet("/stories", async (IStoryService storyService) =>
            {
                var allStories = await storyService.GetStoriesAsync();
                var storyDTOs = allStories.Select(story => new StoryDTO(story)).OrderByDescending(story => story.DateCreated).ToList();

                if (!storyDTOs.Any())
                {
                    return Results.Ok("There are no stories");
                }
                return Results.Ok(storyDTOs);
            });

            //GET SINGLE STORY AND IT'S CHAPTERS (SaveAsDraft: false)
            group.MapGet("/stories/{storyId}", async (IStoryService storyService, int storyId) =>
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
            group.MapPost("/stories", async (IStoryService storyService, Story newStory) =>
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
            group.MapDelete("/stories/{storyId}", async (IStoryService storyService, int storyId) =>
            {
                var storyToDelete = await storyService.DeleteStoryAsync(storyId);
                if (storyToDelete == null)
                {
                    return Results.NotFound($"There is no story with a matching id of: {storyId}");
                }
                return Results.Ok(storyToDelete);

            });

            // EDIT STORY BY ID
            group.MapPut("/stories/{storyId}", async (IStoryService storyService, int storyId, Story story) =>
            {
                try
                {
                    // Call the service to update the story
                    var updatedStory = await storyService.UpdateStoryAsync(story, storyId);

                    // Check if the update was successful
                    return Results.Ok(updatedStory);
                }
                catch (ArgumentException ex)
                {
                    // Handle not found and other argument exceptions
                    return Results.NotFound(ex.Message);
                }
            });



            //Search Stories by Title
           /* group.MapGet("/stories/search", async (IStoryService storyService, string searchValue) =>
            {
                // Validate the search value first
                if (string.IsNullOrWhiteSpace(searchValue))
                {
                    return Results.BadRequest("Search value cannot be empty.");
                }

                // Perform the search
                var searchResults = await storyService.SearchStoriesAsync(searchValue);

                // Check if any results were found
                if (!searchResults.Any())
                {
                    return Results.Ok("No stories found for this search.");
                }

                // Return the list of found stories
                return Results.Ok(searchResults);
            });*/

            //GET STORIES BY CATEGORY MINIMAL API
           /* app.MapGet("/stories/categories/{categoryId}", (FanFusionDbContext db, int categoryId) =>
            {
                var category = db.Categories.FirstOrDefault(c => c.Id == categoryId);

                // Check if the category exists
                if (category == null)
                {
                    return Results.NotFound($"Category with ID {categoryId} not found.");
                }

                var stories = db.Stories
                    .Where(c => c.CategoryId == categoryId)
                    .ToList();

                var storyDTOs = stories
                   .Select(story => new StoryDTO(story))
                   .OrderByDescending(dto => dto.DateCreated)
                   .ToList();

                if (!stories.Any())
                {
                    return Results.NotFound("No stories found for this category.");
                }

                return Results.Ok(storyDTOs);
            });*/
        }
    }
}
