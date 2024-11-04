using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_Fan_Fusion.Repositories
{
    public class ChapterRepository : IChapterRepository
    {
        private readonly FanFusionDbContext dbContext;

        public ChapterRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }

        public async Task<Chapter?> GetChapterByIdAsync(int chapterId)
        {
            return await dbContext.Chapters
             .Include(ch => ch.Story)
             .Include(ch => ch.User)
             .Include(ch => ch.Comments)
             .ThenInclude(comment => comment.User)
             .SingleOrDefaultAsync(ch => ch.Id == chapterId);
        }

        public async Task<Chapter> CreateAndUpdateChapterAsync(Chapter chapter)
        {
            throw new NotImplementedException();
        }

        public async Task<Chapter> DeleteChapterAsync(int chapterId)
        {
            throw new NotImplementedException();
        }

    }
}

