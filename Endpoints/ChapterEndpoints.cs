using BE_Fan_Fusion.DTO;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using BE_Fan_Fusion.Services;

namespace BE_Fan_Fusion.Endpoints
{
    public static class ChapterEndpoints
    {
        public static void MapChapterEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("chapters").WithTags(nameof(Chapter));

            group.MapGet("/{chapterId}", async (IChapterService chapterService, int chapterId) =>
            {
                var chapter = await chapterService.GetChapterByIdAsync(chapterId);

                if (chapter == null)
                {
                    return Results.NotFound($"No chapter was found with the following id: {chapterId}");
                }

                return Results.Ok(new
                {
                    chapter.Id,
                    chapter.Title,
                    chapter.Content,
                    chapter.DateCreated,
                    chapter.SaveAsDraft,
                    Story = new
                    {
                        chapter.Story.Id,
                        chapter.Story.Title,
                    },
                    User = new UserDto(chapter.User),
                    Comments = chapter.Comments?
                       .OrderBy(c => c.CreatedOn)
                       .Select(comment => new
                       {
                           comment.Id,
                           comment.Content,
                           comment.CreatedOn,
                           User = new UserDto(comment.User),
                       })
                });
            });

            group.MapPost("/", async (IChapterService chapterService, Chapter newcChapter) =>
            {

               try
                {
                    // Find the existing chapter if it exists
                    var chapter = await chapterService.CreateOrUpdateChapterAsync(newcChapter);

                    if (chapter.Id == newcChapter.Id)
                    {
                        return Results.Ok(chapter);
                    }
                    else
                    {
                        return Results.Created($"/chapters/{chapter.Id}", chapter);
                    }
                }
                catch (ArgumentException ex)
                {
                    return Results.NotFound(ex.Message);
                }
            });

            group.MapDelete("/{chapterId}", async (IChapterService chapterService, int chapterId) =>
            {
                var chaptertToDelete = await chapterService.DeleteChapterAsync(chapterId);
                if (chaptertToDelete == null)
                {
                    return Results.NotFound($"There is no comment with a matching id of: {chapterId}");
                }
                return Results.Ok(chaptertToDelete);

            });

        }
    }
}
