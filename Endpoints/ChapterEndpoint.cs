using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Endpoints
{
    public static class ChapterEndpoint
    {
        public static void MapChapterEndpoint(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("").WithTags(nameof(Chapter));
        }
    }
}
