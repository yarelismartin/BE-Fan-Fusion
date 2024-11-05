using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Repositories
{
    public class StoryTagRepository : IStoryTagRepository
    {
         
        private readonly FanFusionDbContext dbContext;

        public StoryTagRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }

        public async Task<string> AddTagToStory(int tagId, int storyId)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RemoveTagFromStory(int tagId, int storyId)
        {
            throw new NotImplementedException();
        }
    }
}