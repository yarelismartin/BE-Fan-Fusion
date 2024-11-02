using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Endpoints
{
    public static class CommentEndpoint
    {
        public static void MapCommentEndpoint(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("").WithTags(nameof(Comment));
        }
    }
}
