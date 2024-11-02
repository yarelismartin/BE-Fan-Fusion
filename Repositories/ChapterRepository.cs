using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Repositories
{
    public class ChapterRepository : IChapterRepository
    {
        private readonly FanFusionDbContext dbContext;

        public ChapterRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }

        public Task<Chapter> GetChapterByIdAsync(int chapterId)
        {
            throw new NotImplementedException();
        }

        public Task<Chapter> CreateAndUpdateChapterAsync(Chapter chapter)
        {
            throw new NotImplementedException();
        }

        public Task<Chapter> DeleteChapterAsync(int chapterId)
        {
            throw new NotImplementedException();
        }

    }
}

