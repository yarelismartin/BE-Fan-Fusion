using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;

namespace BE_Fan_Fusion.Repositories
{
    public class TagRepository : ITagRepository
    {
         {
        private readonly FanFusionDbContext dbContext;

        public TagRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }
    }
}
}
