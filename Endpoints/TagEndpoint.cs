using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Endpoints
{
    public static class TagEndpoint
    {
        public static void MapTagEndpoint(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("").WithTags(nameof(Tag));
        }
    }
}
