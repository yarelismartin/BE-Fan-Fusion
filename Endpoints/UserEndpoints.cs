using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.DTO;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Endpoints
{
    public static class UserEndpoints
    {
        //This is an interface provided by ASP.NET Core that helps you define and configure your API endpoints.
        public static void MapUserEndpoints(this IEndpointRouteBuilder routes)
        {
            // MapGroup(""): This method is used to group related endpoints under a common prefix or path.
            // Tags help organize your API documentation, making it easier for developers (and users) to understand and navigate the available endpoints.
            var group = routes.MapGroup("").WithTags(nameof(User));

            group.MapGet("/checkUser/{uid}", async (IUserService userService, string uid) =>
            {
                User? userCheck = await userService.CheckUserAsync(uid);

                if (userCheck == null)
                {
                    return Results.NotFound("User is not registered");
                }
                return Results.Ok(new
                {
                    userCheck.Id,
                    userCheck.FirstName,
                    userCheck.LastName,
                    userCheck.Email,
                    userCheck.Image,
                    userCheck.Uid
                });
            });

            group.MapGet("/users/{userId}", async (IUserService userService, int userId) =>
            {
                User? user = await userService.GetUserByIdAsync(userId);

                if (user == null)
                {
                    return Results.NotFound($"There is no user with the following id: {userId}");
                }

                return Results.Ok(new
                {
                    user.Id,
                    user.FirstName,
                    user.LastName,
                    user.Image,
                    user.Username,
                    user.Email,
                    user.Uid,
                    Stories = user.Stories?.Select(story => new StoryDTO(story, user.FavoritedStories?.Contains(story) ?? false)).ToList(),
                    FavoritedStories = user.FavoritedStories?.Select(story => new StoryDTO(story, user.FavoritedStories?.Contains(story) ?? false)).ToList(),
                    Chapters = user.Chapters?.Select(chapter => new ChapterDto(chapter))
                        .Where(chapter => chapter.SaveAsDraft == true)
                        .OrderByDescending(chapter => chapter.DateCreated),
                });
            });
        }


    }
}
