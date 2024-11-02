using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;

namespace BE_Fan_Fusion.Repositories
{
    public class ChapterRepository : IChapterRepository
    {
         {
        private readonly FanFusionDbContext dbContext;

        public ChapterRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }
    }
}
}
