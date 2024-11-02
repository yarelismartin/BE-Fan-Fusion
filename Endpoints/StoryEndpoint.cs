using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Endpoints
{
    public static class StoryEndpoint
    {
        public static void MapStoryEndpoint(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("").WithTags(nameof(Story));
        }
    }
}
