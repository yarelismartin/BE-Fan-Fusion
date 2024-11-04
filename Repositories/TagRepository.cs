using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;
using Microsoft.EntityFrameworkCore;

namespace BE_Fan_Fusion.Repositories
{
    public class TagRepository : ITagRepository
    {
         
        private readonly FanFusionDbContext dbContext;

        public TagRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }
        public async Task<List<Tag>> GetAllTagsAsync()
        {
            return await dbContext.Tags.ToListAsync();
        }
        public async Task<Tag?> GetTagByIdAsync(int tagId)
        {
            return await dbContext.Tags
                .Include(t => t.Stories)
                .SingleOrDefaultAsync(t => t.Id == tagId);
        }
    }
}

