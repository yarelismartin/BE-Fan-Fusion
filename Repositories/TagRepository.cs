using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;

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
            throw new NotImplementedException();
        }
        public async Task<Tag> GetTagByIdAsync(int tagId)
        {
            throw new NotImplementedException();
        }
    }
}

