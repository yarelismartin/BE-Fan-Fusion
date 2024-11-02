using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;

namespace BE_Fan_Fusion.Repositories
{
    public class StoryRepository : IStoryRepository
    {
         {
        private readonly FanFusionDbContext dbContext;

        public StoryRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }
    }
}
}
