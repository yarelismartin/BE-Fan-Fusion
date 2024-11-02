using BE_Fan_Fusion.Data;
using BE_Fan_Fusion.Interfaces;
using BE_Fan_Fusion.Models;

namespace BE_Fan_Fusion.Repositories
{
    public class StoryRepository : IStoryRepository
    {
         
        private readonly FanFusionDbContext dbContext;

        public StoryRepository(FanFusionDbContext context)
        {
            dbContext = context;
        }
        public async Task<List<Story>> GetStoriesAsync()
        {
            throw new NotImplementedException();
        }
        public async Task<Story> GetStoryByIdAsync(int storyId)
        {
            throw new NotImplementedException();
        }
        public async Task<Story> CreateStoryAsync(Story story)
        {
            throw new NotImplementedException();
        }
        public async Task<Story> UpdateStoryAsync(Story story, int storyId)
        {
            throw new NotImplementedException();
        }
        public async Task<Story> DeleteStoryAsync(int storyId)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Story>> SearchStoriesAsync(string searchValue)
        {
            throw new NotImplementedException();
        }
        public async Task<List<Story>> GetStoriesByCategoryIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}

