using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using Microsoft.AspNetCore.Builder;

namespace BE_Fan_Fusion.Endpoints
{
    public static class CommentEndpoints
    {
        public static void MapCommentEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("comments").WithTags(nameof(Comment));

            group.MapPost("/", async (ICommentService commentService, Comment newComment) =>
            {
                try
                {
                    var createdComment = await commentService.CreateCommentAsync(newComment);
                    return Results.Ok(createdComment);
                }
                catch (ArgumentException ex)
                {
                    return Results.NotFound(ex.Message);
                }
            });

            group.MapDelete("/{commentId}", async (ICommentService commentService, int commentId) =>
            {
                var commentToDelete = await commentService.DeleteCommentAsync(commentId);
                if (commentToDelete == null)
                {
                    return Results.NotFound($"There is no comment with a matching id of: {commentId}");
                }
                return Results.Ok(commentToDelete);

            });
        }
    }
}
